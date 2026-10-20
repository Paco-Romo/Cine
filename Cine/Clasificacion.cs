using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;

namespace Cine
{
    public partial class Clasificacion : Form
    {
        bool editar = false;
        public Clasificacion()
        {
            InitializeComponent();
            CargarDatos();
        }

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                MessageBox.Show("Conexion Exitosa");
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clasificacion", cargar);
                DataTable peliculas = new DataTable();
                adapter.Fill(peliculas);
                dgvClasificacion.DataSource = peliculas;

            }
        }

        private void Clasificacion_Load(object sender, EventArgs e)
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
                        "INSERT INTO dbo.Clasificacion(Clave, Descripcion, FecharHoraCreacion) " +
                        "VALUES (@Clave, @Descripcion, @FecharHoraCreacion)";

                    SqlCommand comando = new SqlCommand(nuevo, cargar);

                    comando.Parameters.AddWithValue("@Clave", txtClave.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@FecharHoraCreacion", dtFecha.Value);

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
                        "UPDATE dbo.Clasificacion " +
                        "SET Clave = @Clave, Descripcion = @Descripcion " +
                        "WHERE IDClasificacion = @IDClasificacion";

                    SqlCommand comando = new SqlCommand(nuevo, cargar);

                    comando.Parameters.AddWithValue("@Clave", txtClave.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue(
                        "@IDClasificacion", txtIdClasificacion.Text);

                    int renglonesAfectados = comando.ExecuteNonQuery();

                    if (renglonesAfectados > 0)
                    {
                        MessageBox.Show("Éxito al editar el registro");
                    }
                }
            }

            CargarDatos();
        }

        private void dgvClasificacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count == 1)
            {
                txtIdClasificacion.Text = dgvClasificacion.SelectedRows[0].Cells["IDClasificacion"].Value.ToString();
                txtClave.Text = dgvClasificacion.SelectedRows[0].Cells["Clave"].Value.ToString();
                txtDescripcion.Text = dgvClasificacion.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            editar = false;

            txtIdClasificacion.Text = "0";
            txtClave.Text = "";
            txtDescripcion.Text = "";
            dtFecha.Value = DateTime.Now;

            txtClave.Enabled = true;
            txtDescripcion.Enabled = true;
            dtFecha.Enabled = true;

            guardarButton.Enabled = true;
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count == 1)
            {
                editar = true;

                txtClave.Enabled = true;
                txtDescripcion.Enabled = true;

                guardarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecciona un registro para editar");
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count == 1)
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
                            "DELETE FROM dbo.Clasificacion " +
                            "WHERE IDClasificacion = @IDClasificacion";

                        SqlCommand comando = new SqlCommand(eliminar, cargar);

                        comando.Parameters.AddWithValue(
                            "@IDClasificacion", txtIdClasificacion.Text);

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

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
