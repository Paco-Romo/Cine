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
    public partial class TipoBoleto : Form
    {
        bool editar = false;
        public TipoBoleto()
        {
            InitializeComponent();
            CargarDatos();

            txtIDTipoBoleto.Text = "0";
            txtIDTipoBoleto.Enabled = false;
            txtClave.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TipoBoleto", cargar);
                DataTable peliculas = new DataTable();
                adapter.Fill(peliculas);
                dgvSala.DataSource = peliculas;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    cargar.Open();

                    string nuevo =
                        "INSERT INTO dbo.TipoBoleto(Clave, Descripcion, Precio) " +
                        "VALUES (@Clave, @Descripcion, @Precio)";

                    SqlCommand comando = new SqlCommand(nuevo, cargar);

                    comando.Parameters.AddWithValue("@Clave", txtClave.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
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
                        "SET Clave = @Clave, Descripcion = @Descripcion, Precio=@Precio " +
                        "WHERE IDTipoBoleto = @IDTipoBoleto";

                    SqlCommand comando = new SqlCommand(nuevo, cargar);

                    comando.Parameters.AddWithValue("@Clave", txtClave.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@Precio", Double.Parse(txtPrecio.Text));
                    comando.Parameters.AddWithValue("@IDTipoBoleto", txtIDTipoBoleto.Text);

                    int renglonesAfectados = comando.ExecuteNonQuery();

                    if (renglonesAfectados > 0)
                    {
                        MessageBox.Show("Éxito al editar el registro");
                    }
                }
            }

            CargarDatos();

            txtIDTipoBoleto.Enabled = false;
            txtClave.Enabled = false;
            txtDescripcion.Enabled = false;
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

        private void dgvSala_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSala.SelectedRows.Count == 1)
            {
                txtIDTipoBoleto.Text = dgvSala.SelectedRows[0].Cells["IDTipoBoleto"].Value.ToString();
                txtClave.Text = dgvSala.SelectedRows[0].Cells["Clave"].Value.ToString();
                txtDescripcion.Text = dgvSala.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgvSala.SelectedRows[0].Cells["Precio"].Value.ToString();
            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            editar = false;

            txtIDTipoBoleto.Text = "0";
            txtIDTipoBoleto.Enabled = true;
            txtClave.Enabled = true;
            txtDescripcion.Enabled = true;
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
            if (dgvSala.SelectedRows.Count == 1)
            {
                editar = true;

                txtIDTipoBoleto.Enabled = true;
                txtClave.Enabled = true;
                txtDescripcion.Enabled = true;
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
            if (dgvSala.SelectedRows.Count == 1)
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
                            "DELETE FROM dbo.TipoBoleto " +
                            "WHERE IDTipoBoleto = @IDTipoBoleto";

                        SqlCommand comando = new SqlCommand(eliminar, cargar);

                        comando.Parameters.AddWithValue(
                            "@IDTipoBoleto", txtIDTipoBoleto.Text);

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
            txtIDTipoBoleto.Enabled = false;
            txtClave.Enabled = false;
            txtDescripcion.Enabled = false;
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
