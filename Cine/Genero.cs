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
    public partial class Genero : Form
    {
        public Genero()
        {
            InitializeComponent();
        }

        public void adbuttons()
        {
            nuevoButton.Enabled = true;
            editarButton.Enabled = true;
            datosButton.Enabled = true;
            eliminarButton.Enabled = true;
            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
        }
        public void LimpiarCampos()
        {
            nombreBox.Clear();
            idBox.Clear();
            descripcionBox.Clear();
        }

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                MessageBox.Show("Conexion Exitosa");
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CineDB"].ConnectionString;
                return new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void CargarPeliculas()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pelicula", cargar);
                DataTable genero = new DataTable();
                adapter.Fill(genero);
                MessageBox.Show($"Filas cargadas: {genero.Rows.Count}");
                dgvPeliculas.DataSource = genero;
            }
        }
        private void nuevoButton_Click(object sender, EventArgs e)
        {
            nuevoButton.Enabled = false;
            LimpiarCampos();
        }

        private void datosButton_Click(object sender, EventArgs e)
        {

        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM Genero WHERE IdGenero = @IdGenero";
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IdGenero", idBox.Text);
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

        private void guardarsButton_Click(object sender, EventArgs e)
        {

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreBox.Text) || string.IsNullOrWhiteSpace(descripcionBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            string conexion = "Server=./localhost; Database=cineBD; Trusted_Connection=true;";
            string query = "INSERT INTO Genero (Nombre, DescripcionGenero) VALUES (@nombre, @descripcion)";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombreBox.Text);
                    command.Parameters.AddWithValue("@descripcion", descripcionBox.Text);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro guardado correctamente.");
                            LimpiarCampos();
                            adbuttons();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el registro.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el registro: {ex.Message}");
                    }
                }
            }
        }

    }
}
