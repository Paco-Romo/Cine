using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Drawing.Text;


namespace Cine
{
    public partial class Peliculas : Form
    {
        private bool editar = false;
        public Peliculas()
        {
            InitializeComponent();
            CargarPeliculas();
            llenarGenero();
            LlenarClasificacion();
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
        public void CargarPeliculas()
        {
            using (SqlConnection cargar = ObtenerConexion())
            {
                cargar.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pelicula", cargar);
                DataTable peliculas = new DataTable();
                adapter.Fill(peliculas);
                dgvPeliculas.DataSource = peliculas;
                cargar.Close();

            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {

            editar = false;
            nombreBox.Enabled = true;
            duracionBox.Enabled = true;
            generoBox.Enabled = true;
            clasificacionBox.Enabled = true;

            //Botones
            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
            nuevoButton.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            datosButton.Enabled = false;
            salirButton.Enabled = false;

            dgvPeliculas.Enabled = false;

            nombreBox.Text = "";
            duracionBox.Text = "";
            generoBox.Text = "";
            clasificacionBox.Text = "";

        }

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeliculas.SelectedRows.Count > 0)
            {
                idBox.Text = dgvPeliculas.SelectedRows[0].Cells[0].Value.ToString();
                nombreBox.Text = dgvPeliculas.SelectedRows[0].Cells[1].Value.ToString();
                duracionBox.Text = dgvPeliculas.SelectedRows[0].Cells[2].Value.ToString();
                generoBox.SelectedValue = dgvPeliculas.SelectedRows[0].Cells[3].Value;
                clasificacionBox.SelectedValue = dgvPeliculas.SelectedRows[0].Cells[4].Value;
            }
        }

        private void datosButton_Click(object sender, EventArgs e)
        {
            CargarPeliculas();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarGenero()
        {
            try
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    String consulta = "SELECT IDGenero, NombreGenero FROM dbo.genero ";
                    SqlCommand comando = new SqlCommand(consulta, cargar);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datos = new DataTable();
                    adapter.Fill(datos);
                    generoBox.DataSource = datos;
                    generoBox.ValueMember = "IDGenero";
                    generoBox.DisplayMember = "NombreGenero";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }
        public void LlenarClasificacion()
        {
            try
            {
                using (SqlConnection cargar = ObtenerConexion())
                {
                    String consulta = "SELECT IDClasificacion, Clave FROM dbo.Clasificacion ";
                    SqlCommand comando = new SqlCommand(consulta, cargar);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable datos = new DataTable();
                    adapter.Fill(datos);
                    clasificacionBox.DataSource = datos;
                    clasificacionBox.ValueMember = "IDClasificacion";
                    clasificacionBox.DisplayMember = "Clave";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
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
                        String agrega = "INSERT INTO dbo.Pelicula (NombrePelicula,duracion,IDgenero,IDclasificacion)\r\n"
                        + "VALUES ('" + nombreBox.Text + "', '" + duracionBox.Text + "', '" + generoBox.SelectedValue + "', '" + clasificacionBox.SelectedValue + "')";
                        SqlCommand comando = new SqlCommand(agrega, cargar);
                        SqlDataAdapter adapter = new SqlDataAdapter(comando);
                        DataTable datos = new DataTable();
                        adapter.Fill(datos);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados == 1)
                        {
                            MessageBox.Show("Éxito al registar Pelicula");
                            // botObtener.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("ERROR: No se registro");
                        }
                        cargar.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción: " + ex.Message);
                }
                finally
                {
                    CargarPeliculas();
                }



                idBox.Enabled = false;
                nombreBox.Enabled = false;
                duracionBox.Enabled = false;
                generoBox.Enabled = false;
                clasificacionBox.Enabled = false;

                guardarButton.Enabled = false;
                cancelarButton.Enabled = false;
                nuevoButton.Enabled = true;
                editarButton.Enabled = true;
                eliminarButton.Enabled = true;
                datosButton.Enabled = true;
                salirButton.Enabled = true;

                dgvPeliculas.Enabled = true;
            }
        }
    }
}
