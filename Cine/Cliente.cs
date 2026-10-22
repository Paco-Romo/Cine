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
    public partial class Cliente : Form
    {
        bool Editar = false;
        public Cliente()
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
            IDCliBox.Clear();
            IDCiuBox.Clear();
            nombreBox.Clear();
            celularBox.Clear();
            correoBox.Clear();
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Cliente", cargar);
                DataTable cliente = new DataTable();
                adapter.Fill(cliente);
                MessageBox.Show($"Filas cargadas: {cliente.Rows.Count}");
                dgvCliente.DataSource = cliente;
            }
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dgvCliente.SelectedRows[0];

                if (r.Cells["IDCliente"].Value != null)
                {
                    IDCliBox.Text =
                        r.Cells["IDCliente"].Value.ToString();

                    IDCiuBox.Text =
                        r.Cells["IDCiudad"].Value.ToString();

                    nombreBox.Text =
                        r.Cells["Nombre"].Value.ToString();

                    celularBox.Text =
                        r.Cells["Celular"].Value.ToString();

                    correoBox.Text =
                        r.Cells["Correo"].Value.ToString();
                }
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
                    string query = "DELETE FROM Cliente WHERE IDCliente = @IDCliente";
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IDCliente", IDCliBox.Text);
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
            if (string.IsNullOrWhiteSpace(nombreBox.Text) || string.IsNullOrWhiteSpace(celularBox.Text)
                || string.IsNullOrWhiteSpace(correoBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }
            else
            {
                string conexion = "Server=./localhost; Database=cineBD; Trusted_Connection=true;";
                string query = "INSERT INTO Cliente (Nombre, Celular, Correo) VALUES (@nombre, @celular, @correo)";

                try
                {
                    using (SqlConnection s = ObtenerConexion())
                    {
                        s.Open();

                        if (Editar == false)
                        {
                            string nuevo =
                                "INSERT INTO dbo.Cliente " +
                                "(Nombre, Celular, Correo) " +
                                "VALUES (@Nombre, @Celular, @Correo)";

                            SqlCommand comando = new SqlCommand(nuevo, s);

                            comando.Parameters.AddWithValue(
                                "@Nombre", nombreBox.Text.Trim());

                            comando.Parameters.AddWithValue(
                                "@Celular", celularBox.Text.Trim());

                            comando.Parameters.AddWithValue(
                                "@Correo", correoBox.Text.Trim());

                            int renglonesAfectados = comando.ExecuteNonQuery();

                            if (renglonesAfectados > 0)
                            {
                                MessageBox.Show("Éxito al guardar el registro");
                            }
                        }
                        else
                        {
                            string actualizar =
                                "UPDATE dbo.Cliente SET " +
                                "Nombre = @Nombre, " +
                                "Celular = @Celular, " +
                                "Correo = @Correo " +
                                "WHERE IDCliente = @IDCliente";

                            SqlCommand comando = new SqlCommand(actualizar, s);

                            comando.Parameters.AddWithValue(
                                "@Nombre", nombreBox.Text.Trim());

                            comando.Parameters.AddWithValue(
                                "@Celular", celularBox.Text.Trim());

                            comando.Parameters.AddWithValue(
                                "@Correo", correoBox.Text.Trim());

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

        private void datosButton_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
