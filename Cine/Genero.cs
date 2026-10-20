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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void datosButton_Click(object sender, EventArgs e)
        {

        }
    }
}
