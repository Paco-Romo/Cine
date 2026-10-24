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
    public partial class Sucursal : Form
    {
        private bool editar = false;
        public Sucursal()
        {
            InitializeComponent();
            ObtenerSucursal();
            LlenarCiudad();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosButton_Click(object sender, EventArgs e)
        {
            ObtenerSucursal();
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
        public void ObtenerSucursal()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sucursal", cargar);
                DataTable sucursal = new DataTable();
                adapter.Fill(sucursal);
                dgvSucursal.DataSource = sucursal;
                cargar.Close();

            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show("¿Deseas cancelar el registro?", "Cancelar?"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                idBox.Text = "0";
                nombreBox.Text = "";
                direccionBox.Text = "";
                ciudadBox.Text = "";

                ciudadBox.Enabled = false;
                nombreBox.Enabled = false;
                direccionBox.Enabled = false;

                guardarButton.Enabled = false;
                cancelarButton.Enabled = false;
                nuevoButton.Enabled = true;
                editarButton.Enabled = true;
                eliminarButton.Enabled = true;
                datosButton.Enabled = true;
                salirButton.Enabled = true;

                dgvSucursal.Enabled = true;
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar esta Sucursal?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection cargar = ObtenerConexion())
                    {
                        cargar.Open();

                        string eliminar =
                            "DELETE FROM dbo.Sucursal " +
                            "WHERE IDSucursal = @IDSucursal";

                        SqlCommand comando = new SqlCommand(eliminar, cargar);

                        comando.Parameters.AddWithValue(
                            "@IDSucursal", idBox.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al eliminar el registro");
                        }
                    }

                    ObtenerSucursal();

                }
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count == 1)
            {
                editar = true;

                ciudadBox.Enabled = true;
                nombreBox.Enabled = true;
                direccionBox.Enabled = true;

                guardarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecciona un registro para editar");
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    using (SqlConnection cargar = ObtenerConexion())
                    {
                        cargar.Open();
                        String agrega =
                            "INSERT INTO dbo.Ciudad (IDCiudad,Direccion,Nombre)\r\n"
                        + "VALUES (@IDCiudad, @Direccion, @Nombre)";
                        SqlCommand comando = new SqlCommand(agrega, cargar);


                        comando.Parameters.AddWithValue("@IDSucursal", idBox.Text);
                        comando.Parameters.AddWithValue("@IDCiudad", ciudadBox.SelectedValue);
                        comando.Parameters.AddWithValue("@Direccion", direccionBox.Text);
                        comando.Parameters.AddWithValue("@Nombre", nombreBox.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Éxito al registar Sucursal");
                            // botObtener.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("ERROR: No se registro");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción: " + ex.Message);
                }
                finally
                {
                    ObtenerSucursal();
                }


                idBox.Enabled = false;
                nombreBox.Enabled = false;
                direccionBox.Enabled = false;
                ciudadBox.Enabled = false;
                nombreBox.Enabled = false;

                guardarButton.Enabled = false;
                cancelarButton.Enabled = false;
                nuevoButton.Enabled = true;
                editarButton.Enabled = true;
                eliminarButton.Enabled = true;
                datosButton.Enabled = true;
                salirButton.Enabled = true;

                dgvSucursal.Enabled = true;
            }
            else
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    cargar.Open();

                    string editar =
                        "UPDATE dbo.Sucursal " +
                        "SET Direccion = @Direccion, IDCiudad = @IDCiudad , Nombre = @Nombre " +
                        "WHERE IDSucursal = @IDSucursal";

                    SqlCommand comando = new SqlCommand(editar, cargar);

                    comando.Parameters.AddWithValue("@IDSucursal", idBox.Text);
                    comando.Parameters.AddWithValue("@IDCiudad", ciudadBox.SelectedValue);
                    comando.Parameters.AddWithValue("@Direccion", direccionBox.Text);
                    comando.Parameters.AddWithValue("@Nombre", nombreBox.Text);

                    int renglonesAfectados = comando.ExecuteNonQuery();

                    if (renglonesAfectados > 0)
                    {
                        MessageBox.Show("Éxito al editar el registro");
                    }
                }
            }

            ObtenerSucursal();

            idBox.Text = "0";
            nombreBox.Text = "";
            direccionBox.Text = "";
            ciudadBox.Text = "";
            nombreBox.Text = "";

            idBox.Enabled = false;
            nombreBox.Enabled = false;
            direccionBox.Enabled = false;
            ciudadBox.Enabled = false;
            nombreBox.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
            nuevoButton.Enabled = true;
            editarButton.Enabled = true;
            eliminarButton.Enabled = true;
            datosButton.Enabled = true;
            salirButton.Enabled = true;

            dgvSucursal.Enabled = true;
        }

        public void LlenarCiudad()
        {
            try
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    String consulta = "SELECT IDCiudad, NombreCiudad FROM dbo.Ciudad ";
                    SqlCommand comando = new SqlCommand(consulta, cargar);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datos = new DataTable();
                    adapter.Fill(datos);
                    ciudadBox.DataSource = datos;
                    ciudadBox.ValueMember = "IDCiudad";
                    ciudadBox.DisplayMember = "NombreCiudad";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            editar = false;
            nombreBox.Enabled = true;
            direccionBox.Enabled = true;
            ciudadBox.Enabled = true;

            //Botones
            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
            nuevoButton.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            datosButton.Enabled = false;
            salirButton.Enabled = false;

            dgvSucursal.Enabled = false;

            ciudadBox.Text = "";
            idBox.Text = "";
            nombreBox.Text = "";
            direccionBox.Text = "";
        }

        private void dgvSucursal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count > 0)
            {
                idBox.Text = dgvSucursal.SelectedRows[0].Cells[0].Value.ToString();
                nombreBox.Text = dgvSucursal.SelectedRows[0].Cells[1].Value.ToString();
                direccionBox.Text = dgvSucursal.SelectedRows[0].Cells[2].Value.ToString();
                ciudadBox.SelectedValue = dgvSucursal.SelectedRows[0].Cells[3].Value;
            }
        }
    }
}
