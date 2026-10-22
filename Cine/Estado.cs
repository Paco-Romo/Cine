using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace Cine
{
    public partial class Estado : Form
    {
        private bool editar = false;
        public Estado()
        {
            InitializeComponent();
            CargarEstados();
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
        public void CargarEstados()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Estado", cargar);
                DataTable estado = new DataTable();
                adapter.Fill(estado);
                dgvEstado.DataSource = estado;
                cargar.Close();

            }
        }
        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvEstado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstado.SelectedRows.Count > 0)
            {
                idBox.Text = dgvEstado.SelectedRows[0].Cells[0].Value.ToString();
                siglaBox.Text = dgvEstado.SelectedRows[0].Cells[1].Value.ToString();
                claveBox.Text = dgvEstado.SelectedRows[0].Cells[2].Value.ToString();
                nombreBox.Text = dgvEstado.SelectedRows[0].Cells[3].Value.ToString();

            }
        }
        private void datosButton_Click(object sender, EventArgs e)
        {
            CargarEstados();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            editar = false;
            nombreBox.Enabled = true;
            siglaBox.Enabled = true;
            claveBox.Enabled = true;

            //Botones
            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
            nuevoButton.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            obtenerButton.Enabled = false;
            salirButton.Enabled = false;

            dgvEstado.Enabled = false;

            nombreBox.Text = "";
            siglaBox.Text = "";
            idBox.Text = "";
            claveBox.Text = "";

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
                            "INSERT INTO dbo.Estado (SiglaEstado,ClaveEstado, NombreEstado)\r\n"
                        + "VALUES (@SiglaEstado, @ClaveEstado, @NombreEstado)";
                        SqlCommand comando = new SqlCommand(agrega, cargar);

                        comando.Parameters.AddWithValue("@SiglaEstado", siglaBox.Text);
                        comando.Parameters.AddWithValue("@ClaveEstado", claveBox.Text);
                        comando.Parameters.AddWithValue("@NombreEstado", nombreBox.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Éxito al registar Estado");
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
                    CargarEstados();
                }



                idBox.Enabled = false;
                nombreBox.Enabled = false;
                siglaBox.Enabled = false;
                claveBox.Enabled = false;

                guardarButton.Enabled = false;
                cancelarButton.Enabled = false;
                nuevoButton.Enabled = true;
                editarButton.Enabled = true;
                eliminarButton.Enabled = true;
                obtenerButton.Enabled = true;
                salirButton.Enabled = true;

                dgvEstado.Enabled = true;
            }
            else
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    cargar.Open();

                    string editar =
                        "UPDATE dbo.Estado " +
                        "SET SiglaEstado = @SiglaEstado, ClaveEstado = @ClaveEstado, NombreEstado = @NombreEstado " +
                        "WHERE IDEstado = @IDEstado";

                    SqlCommand comando = new SqlCommand(editar, cargar);

                    comando.Parameters.AddWithValue("@IDEstado", int.Parse(idBox.Text));
                    comando.Parameters.AddWithValue("@SiglaEstado", siglaBox.Text);
                    comando.Parameters.AddWithValue("@ClaveEstado", claveBox.Text);
                    comando.Parameters.AddWithValue("@NombreEstado", nombreBox.Text);

                    int renglonesAfectados = comando.ExecuteNonQuery();

                    if (renglonesAfectados > 0)
                    {
                        MessageBox.Show("Éxito al editar el registro");
                    }
                }
            }

            CargarEstados();
        }

        private void obtenerButton_Click(object sender, EventArgs e)
        {
            CargarEstados();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dgvEstado.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar este estado?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection cargar = ObtenerConexion())
                    {
                        cargar.Open();

                        string eliminar =
                            "DELETE FROM dbo.Estado " +
                            "WHERE IDEstado = @IDEstado";

                        SqlCommand comando = new SqlCommand(eliminar, cargar);

                        comando.Parameters.AddWithValue(
                            "@IDEstado", idBox.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al eliminar el registro");
                        }
                    }

                    CargarEstados();

                }
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (dgvEstado.SelectedRows.Count == 1)
            {
                editar = true;

                siglaBox.Enabled = true;
                claveBox.Enabled = true;
                nombreBox.Enabled = true;

                guardarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecciona un registro para editar");
            }
        }
    }
}
