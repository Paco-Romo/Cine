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
    }
}
