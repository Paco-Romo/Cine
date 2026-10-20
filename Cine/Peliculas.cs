using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace Cine
{
    public partial class Peliculas : Form
    {
        //rivate bool Editar = false;
        public Peliculas()
        {
            InitializeComponent();
            CargarPeliculas();

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
        public void CargarPeliculas()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pelicula", cargar);
                DataTable peliculas = new DataTable();
                adapter.Fill(peliculas);
                MessageBox.Show($"Filas cargadas: {peliculas.Rows.Count}");
                dgvPeliculas.DataSource = peliculas;

            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
