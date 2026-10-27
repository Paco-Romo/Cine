using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Cine
{
    public partial class Venta : Form
    {
        bool editar;
        public Venta()
        {
            InitializeComponent();
            CargarDatos();

            llenaComboCliente();
            llenaComboFuncion();
            llenaComboTipoBoleto();
        }

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CineDB"].ConnectionString;
                return new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void CargarDatos()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                String consulta = "SELECT V.IDVenta, C.IDCliente AS Cliente," +
                    "\r\n\tP.NombrePelicula As Función, TBO.Clave AS Boleto, V.Precio\r\nFROM Venta AS V\r\nINNER JOIN Funcion AS F\r\n\tON V.IDFuncion=F.IDFuncion\r\nINNER JOIN Pelicula AS P\r\n\tON F.IDPelicula=P.IDPelicula\r\nINNER JOIN Cliente AS C\r\n\tON V.IDCliente=C.IDCliente\r\nINNER JOIN TipoBoleto AS TBO\r\n\tON V.IDTipoBoleto=TBO.IDTipoBoleto";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, cargar);
                DataTable peliculas = new DataTable();
                adapter.Fill(peliculas);
                dgvVenta.DataSource = peliculas;

            }
        }

        private void llenaComboFuncion()
        {
            try
            {
                cbFuncion.DataSource = null;

                using (SqlConnection sqlConn = ObtenerConexion())
                {
                    sqlConn.Open();

                    string consulta =
                        "SELECT Distinct F.IDFuncion, P.NombrePelicula As Función " +
                        "FROM Funcion AS F " + "INNER JOIN Pelicula AS P " +
                        "ON F.IDPelicula=P.IDPelicula";

                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);

                    DataTable datos = new DataTable();
                    adapter.Fill(datos);

                    cbFuncion.DataSource = datos;
                    cbFuncion.ValueMember = "Función";
                    cbFuncion.DisplayMember = "Función";
                    cbFuncion.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }
        private void llenaComboTipoBoleto()
        {
            try
            {
                cbTipoBoleto.DataSource = null;

                using (SqlConnection sqlConn = ObtenerConexion())
                {
                    sqlConn.Open();

                    string consulta =
                        "SELECT IDTipoBoleto, Clave FROM TipoBoleto";

                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);

                    DataTable datos = new DataTable();
                    adapter.Fill(datos);

                    cbTipoBoleto.DataSource = datos;
                    cbTipoBoleto.ValueMember = "Clave";
                    cbTipoBoleto.DisplayMember = "Clave";
                    cbTipoBoleto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void llenaComboCliente()
        {
            try
            {
                cbCliente.DataSource = null;

                using (SqlConnection sqlConn = ObtenerConexion())
                {
                    sqlConn.Open();

                    string consulta =
                        "SELECT IDCliente, Nombre FROM Cliente";

                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);

                    DataTable datos = new DataTable();
                    adapter.Fill(datos);

                    cbCliente.DataSource = datos;
                    cbCliente.ValueMember = "IDCliente";
                    cbCliente.DisplayMember = "Nombre";
                    cbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    cargar.Open();

                    string nuevo =
                        "INSERT INTO dbo.Venta(IDCliente, IDFuncion, IDTipoBoleto, Precio) " +
                        "VALUES (@IDCliente, @IDFuncion, @IDTipoBoleto, @Precio)";

                    SqlCommand comando = new SqlCommand(nuevo, cargar);

                    comando.Parameters.AddWithValue("@IDCliente", cbCliente.SelectedValue);
                    comando.Parameters.AddWithValue("@IDFuncion", cbFuncion.SelectedValue);
                    comando.Parameters.AddWithValue("@IDTipoBoleto", cbTipoBoleto.SelectedValue);
                    comando.Parameters.AddWithValue("@Precio", Double.Parse(txtPrecio.Text));

                    int renglonesAfectados = comando.ExecuteNonQuery();

                    if (renglonesAfectados > 0)
                    {
                        MessageBox.Show("Éxito al guardar el registro");
                    }
                }
            }
            else
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    cargar.Open();

                    string nuevo =
                        "UPDATE dbo.TipoBoleto " +
                        "SET IDCliente = @IDCliente, IDFuncion = @IDFuncion, IDTipoBoleto = @IDTipoBoleto, Precio=@Precio " +
                        "WHERE IDVenta = @IDVenta";

                    SqlCommand comando = new SqlCommand(nuevo, cargar);

                    comando.Parameters.AddWithValue("@IDCliente", cbCliente.SelectedValue);
                    comando.Parameters.AddWithValue("@IDFuncion", cbFuncion.SelectedValue);
                    comando.Parameters.AddWithValue("@IDTipoBoleto", cbTipoBoleto.SelectedValue);
                    comando.Parameters.AddWithValue("@Precio", Double.Parse(txtPrecio.Text));
                    comando.Parameters.AddWithValue("@IDVenta", txtIDVenta);

                    int renglonesAfectados = comando.ExecuteNonQuery();

                    if (renglonesAfectados > 0)
                    {
                        MessageBox.Show("Éxito al editar el registro");
                    }
                }
            }

            CargarDatos();

            cbCliente.Enabled = false;
            cbFuncion.Enabled = false;
            cbTipoBoleto.Enabled = false;
            txtPrecio.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
            nuevoButton.Enabled = true;
            editarButton.Enabled = true;
            eliminarButton.Enabled = true;
            datosButton.Enabled = true;
            salirButton.Enabled = true;

            editar = false;
        }

        private void dgvVenta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count == 1)
            {
                txtIDVenta.Text = dgvVenta.SelectedRows[0].Cells["IDVenta"].Value.ToString();
                cbCliente.SelectedValue = dgvVenta.SelectedRows[0].Cells["Cliente"].Value;
                cbFuncion.SelectedValue = dgvVenta.SelectedRows[0].Cells[2].Value;
                cbTipoBoleto.SelectedValue = dgvVenta.SelectedRows[0].Cells["Boleto"].Value;
                txtPrecio.Text = dgvVenta.SelectedRows[0].Cells["Precio"].Value.ToString();
            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            editar = false;

            txtIDVenta.Text = "0";
            cbCliente.Enabled = true;
            cbFuncion.Enabled = true;
            cbTipoBoleto.Enabled = true;
            txtPrecio.Enabled = true;

            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
            nuevoButton.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            datosButton.Enabled = false;
            salirButton.Enabled = false;
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count == 1)
            {
                editar = true;

                cbFuncion.Enabled = true;
                cbCliente.Enabled = true;
                cbTipoBoleto.Enabled = true;
                txtPrecio.Enabled = true;


                guardarButton.Enabled = true;
                cancelarButton.Enabled = true;
                nuevoButton.Enabled = false;
                editarButton.Enabled = false;
                eliminarButton.Enabled = false;
                datosButton.Enabled = false;
                salirButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecciona un registro para editar");
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar esta clasificación?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection cargar = ObtenerConexion())
                    {
                        cargar.Open();

                        string eliminar =
                            "DELETE FROM dbo.Venta " +
                            "WHERE IDVenta = @IDVenta";

                        SqlCommand comando = new SqlCommand(eliminar, cargar);

                        comando.Parameters.AddWithValue(
                            "@IDVenta", txtIDVenta.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al eliminar el registro");
                        }
                    }

                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar");
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            cbTipoBoleto.Enabled = false;
            cbCliente.Enabled = false;
            cbFuncion.Enabled = false;
            txtPrecio.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
            nuevoButton.Enabled = true;
            editarButton.Enabled = true;
            eliminarButton.Enabled = true;
            datosButton.Enabled = true;
            salirButton.Enabled = true;

            editar = false;
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
