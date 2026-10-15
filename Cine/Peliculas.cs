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
        private bool Editar = false;
        private String conexion = "";
        private SqlConnection sqlConnection = null;
        public Peliculas()
        {
            InitializeComponent();
            ObtenerConexion();
        }


        public static SqlConnection ObtenerConexion()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CineDB"].ConnectionString;
                return new SqlConnection(connectionString);
            }
            catch (Exception ex) { 
            Console.WriteLine("Error");
            }
        }
    }
}
