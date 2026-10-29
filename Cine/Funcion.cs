using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cine
{
    public partial class Funcion : Form
    {
        bool Editar = false;
        public Funcion()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void adbuttons()
        {
            Editar = false;
            nuevoButton.Enabled = true;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
        }
        public void LimpiarCampos()
        {
            IDFunBox.Clear();
            IDPeliBox.Clear();
            IDSalaBox.Clear();
        }

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CineDB"].ConnectionString;
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Funcion", cargar);
                DataTable genero = new DataTable();
                adapter.Fill(genero);
                MessageBox.Show($"Filas cargadas: {genero.Rows.Count}");
                dgvFuncion.DataSource = genero;
            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            nuevoButton.Enabled = false;
            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM Funcion WHERE IDFuncion = @IDFuncion";
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IDFuncion", IDFunBox.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para eliminar.");
                    }
                }
                LimpiarCampos();
                adbuttons();
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            Editar = true;

            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
            nuevoButton.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            datosButton.Enabled = false;
        }

        /*private void guardarButton_Click(object sender, EventArgs e)
        {
            string conexion = "Server=./localhost; Database=cineBD; Trusted_Connection=true;";
            string query = "INSERT INTO Funcion () VALUES ()";

            try
            {
                using (SqlConnection s = ObtenerConexion())
                {
                    s.Open();

                    if (Editar == false)
                    {
                        string nuevo =
                            "INSERT INTO dbo.Funcion " +
                            "() " +
                            "VALUES ()";

                        SqlCommand comando = new SqlCommand(nuevo, s);
                        //FECHA Y HORA DE LA FUNCION
                        comando.Parameters.AddWithValue( 
                        "@NombreGenero", nombreBox.Text.Trim());

                        comando.Parameters.AddWithValue(
                        "@DescripcionGenero", descripcionBox.Text.Trim());

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al guardar el registro");
                        }
                    }
                    else
                    {
                        string actualizar =
                            //FECHA Y HORA DE LA FUNCION
                            "UPDATE dbo.Genero SET " +
                            "NombreGenero = @NombreGenero, " +
                            "DescripcionGenero = @DescripcionGenero " +
                            "WHERE IDGenero = @IDGenero";

                        SqlCommand comando = new SqlCommand(actualizar, s);

                         comando.Parameters.AddWithValue(
                        "@NombreGenero", nombreBox.Text.Trim());

                         comando.Parameters.AddWithValue(
                        "@DescripcionGenero", descripcionBox.Text.Trim());

                        comando.Parameters.AddWithValue(
                        "@IDGenero", Convert.ToInt32(idBox.Text));

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                          MessageBox.Show("Éxito al editar el registro");
                        }
                    }
                }
                LimpiarCampos();
                adbuttons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }

            LimpiarCampos();
        }
        */

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosButton_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void dgvFuncion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFuncion.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dgvFuncion.SelectedRows[0];

                if (r.Cells["IDFuncion"].Value != null)
                {
                    IDFunBox.Text =
                        r.Cells["IDFuncion"].Value.ToString();

                    IDPeliBox.Text =
                        r.Cells["IDPelicula"].Value.ToString();

                    IDSalaBox.Text =
                        r.Cells["IDSala"].Value.ToString();
                }
            }
        }
    }
}
