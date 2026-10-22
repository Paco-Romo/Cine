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
    public partial class numero : Form
    {
        bool Editar = false;
        public numero()
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
            numBox.Clear();
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
        public void CargarDatos()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Numero", cargar);
                DataTable numero = new DataTable();
                adapter.Fill(numero);
                MessageBox.Show($"Filas cargadas: {numero.Rows.Count}");
                dgvPeliculas.DataSource = numero;

            }
        }
        private void datosButton_Click(object sender, EventArgs e)
        {
            CargarDatos();
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
                    string query = "DELETE FROM Numero WHERE numbox = @numero";
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@numero", numBox.Text);
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

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }
            else
            {
                string conexion = "Server=./localhost; Database=cineBD; Trusted_Connection=true;";
                string query = "INSERT INTO Numero (num) VALUES (@num)";

                try
                {
                    using (SqlConnection s = ObtenerConexion())
                    {
                        s.Open();

                        if (Editar == false)
                        {
                            string nuevo =
                                "INSERT INTO dbo.Numero " +
                                "(num) " +
                                "VALUES (@num)";

                            SqlCommand comando = new SqlCommand(nuevo, s);

                            comando.Parameters.AddWithValue(
                                "@num", numBox.Text.Trim());

                            int renglonesAfectados = comando.ExecuteNonQuery();

                            if (renglonesAfectados > 0)
                            {
                                MessageBox.Show("Éxito al guardar el registro");
                            }
                        }
                        else
                        {
                            string actualizar =
                                "UPDATE dbo.Numero SET " +
                                "num = @num, ";

                            SqlCommand comando = new SqlCommand(actualizar, s);

                            comando.Parameters.AddWithValue(
                                "@num", numBox.Text.Trim());

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
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
