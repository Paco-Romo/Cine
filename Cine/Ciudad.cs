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
    public partial class Ciudad : Form
    {
        private bool editar = false;
        public Ciudad()
        {
            InitializeComponent();
            CargarCiudades();
            LlenarCiudad();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            editar = false;
            nombreBox.Enabled = true;
            estadoBox.Enabled = true;
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

            dgvCiudad.Enabled = false;

            ciudadBox.Text = "";
            siglaBox.Text = "";
            nombreBox.Text = "";
            claveBox.Text = "";
        }

        private void obtenerButton_Click(object sender, EventArgs e)
        {
            CargarCiudades();
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
        public void CargarCiudades()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ciudad", cargar);
                DataTable estado = new DataTable();
                adapter.Fill(estado);
                dgvCiudad.DataSource = estado;
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
                ciudadBox.Text = "0";
                estadoBox.Text = "";
                siglaBox.Text = "";
                claveBox.Text = "";
                nombreBox.Text = "";

                ciudadBox.Enabled = false;
                estadoBox.Enabled = false;
                siglaBox.Enabled = false;
                claveBox.Enabled = false;
                nombreBox.Enabled = false;

                guardarButton.Enabled = false;
                cancelarButton.Enabled = false;
                nuevoButton.Enabled = true;
                editarButton.Enabled = true;
                eliminarButton.Enabled = true;
                obtenerButton.Enabled = true;
                salirButton.Enabled = true;

                dgvCiudad.Enabled = true;
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
                            "INSERT INTO dbo.Ciudad (SiglasCiudad,IDEstado, ClaveCiudad, NombreCiudad)\r\n"
                        + "VALUES (@SiglaCiudad, @IDEstado, @ClaveCiudad, @NombreCiudad)";
                        SqlCommand comando = new SqlCommand(agrega, cargar);

                        comando.Parameters.AddWithValue("@IDCiudad", ciudadBox.Text);
                        comando.Parameters.AddWithValue("@IDEstado", estadoBox.SelectedValue);
                        comando.Parameters.AddWithValue("@SiglaCiudad", siglaBox.Text);
                        comando.Parameters.AddWithValue("@ClaveCiudad", claveBox.Text);
                        comando.Parameters.AddWithValue("@NombreCiudad", nombreBox.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Éxito al registar Ciudad");
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
                    CargarCiudades();
                }



                ciudadBox.Enabled = false;
                nombreBox.Enabled = false;
                estadoBox.Enabled = false;
                siglaBox.Enabled = false;
                claveBox.Enabled = false;

                guardarButton.Enabled = false;
                cancelarButton.Enabled = false;
                nuevoButton.Enabled = true;
                editarButton.Enabled = true;
                eliminarButton.Enabled = true;
                obtenerButton.Enabled = true;
                salirButton.Enabled = true;

                dgvCiudad.Enabled = true;
            }
            else
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    cargar.Open();

                    string editar =
                        "UPDATE dbo.Ciudad " +
                        "SET SiglasCiudad = @SiglaCiudad, IDEstado = @IDEstado, Claveciudad = @ClaveCiudad , NombreCiudad = @NombreCiudad " +
                        "WHERE IDCiudad = @IDCiudad";

                    SqlCommand comando = new SqlCommand(editar, cargar);

                    comando.Parameters.AddWithValue("@IDCiudad", ciudadBox.Text);
                    comando.Parameters.AddWithValue("@IDEstado", estadoBox.SelectedValue);
                    comando.Parameters.AddWithValue("@SiglaCiudad", siglaBox.Text);
                    comando.Parameters.AddWithValue("@ClaveCiudad", claveBox.Text);
                    comando.Parameters.AddWithValue("@NombreCiudad", nombreBox.Text);

                    int renglonesAfectados = comando.ExecuteNonQuery();

                    if (renglonesAfectados > 0)
                    {
                        MessageBox.Show("Éxito al editar el registro");
                    }
                }
            }

            CargarCiudades();

            ciudadBox.Text = "0";
            estadoBox.Text = "";
            siglaBox.Text = "";
            claveBox.Text = "";
            nombreBox.Text = "";

            ciudadBox.Enabled = false;
            estadoBox.Enabled = false;
            siglaBox.Enabled = false;
            claveBox.Enabled = false;
            nombreBox.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
            nuevoButton.Enabled = true;
            editarButton.Enabled = true;
            eliminarButton.Enabled = true;
            obtenerButton.Enabled = true;
            salirButton.Enabled = true;

            dgvCiudad.Enabled = true;
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar esta Ciudad?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection cargar = ObtenerConexion())
                    {
                        cargar.Open();

                        string eliminar =
                            "DELETE FROM dbo.Ciudad " +
                            "WHERE IDCiudad = @IDCiudad";

                        SqlCommand comando = new SqlCommand(eliminar, cargar);

                        comando.Parameters.AddWithValue(
                            "@IDCiudad", ciudadBox.Text);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al eliminar el registro");
                        }
                    }

                    CargarCiudades();

                }
            }
        }
        private void dgvCiudad_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count > 0)
            {
                ciudadBox.Text = dgvCiudad.SelectedRows[0].Cells[0].Value.ToString();
                estadoBox.SelectedValue = dgvCiudad.SelectedRows[0].Cells[1].Value;
                siglaBox.Text = dgvCiudad.SelectedRows[0].Cells[2].Value.ToString();
                claveBox.Text = dgvCiudad.SelectedRows[0].Cells[3].Value.ToString();
                nombreBox.Text = dgvCiudad.SelectedRows[0].Cells[4].Value.ToString();

            }
        }
        public void LlenarCiudad()
        {
            try
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    String consulta = "SELECT IDEstado, NombreEstado FROM dbo.Estado ";
                    SqlCommand comando = new SqlCommand(consulta, cargar);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datos = new DataTable();
                    adapter.Fill(datos);
                    estadoBox.DataSource = datos;
                    estadoBox.ValueMember = "IDEstado";
                    estadoBox.DisplayMember = "NombreEstado";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (dgvCiudad.SelectedRows.Count == 1)
            {
                editar = true;

                siglaBox.Enabled = true;
                estadoBox.Enabled = true;
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
