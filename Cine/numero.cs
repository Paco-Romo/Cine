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
        public numero()
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
                DataTable numero = new DataTable();
                adapter.Fill(numero);
                MessageBox.Show($"Filas cargadas: {numero.Rows.Count}");
                dgvPeliculas.DataSource = numero;

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datosButton_Click(object sender, EventArgs e)
        {

        }
    }
}
