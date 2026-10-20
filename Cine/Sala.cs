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
    public partial class Sala : Form
    {
        bool Editar = false;
        public Sala()
        {
            InitializeComponent();
            ObtenerDatosBD();
            llenaComboSucursal();

            txtIDSala.Text = "0";
            txtIDSala.Enabled = false;
            txtNumSala.Enabled = false;
            txtAsientos.Enabled = false;
            cbIDSucursal.Enabled = false;
            cbTipoSala.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
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
        private void llenaComboSucursal()
        {
            try
            {
                cbIDSucursal.DataSource = null;

                using (SqlConnection sqlConn = ObtenerConexion())
                {
                    sqlConn.Open();

                    string consulta =
                        "SELECT IDSucursal, Nombre FROM dbo.Sucursal";

                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);

                    DataTable datos = new DataTable();
                    adapter.Fill(datos);

                    cbIDSucursal.DataSource = datos;
                    cbIDSucursal.ValueMember = "IDSucursal";
                    cbIDSucursal.DisplayMember = "Nombre";
                    cbIDSucursal.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }

        private void ObtenerDatosBD()
        {
            try
            {
                using (SqlConnection sqlConn = ObtenerConexion())
                {
                    sqlConn.Open();

                    string consulta =
                        "SELECT S.IDSala, S.IDSucursal, SU.Nombre AS Sucursal, " +
                        "S.NumeroSala, S.TipoSala, S.CantidadAsientos " +
                        "FROM dbo.Sala S " +
                        "INNER JOIN dbo.Sucursal SU " +
                        "ON SU.IDSucursal = S.IDSucursal";

                    SqlCommand comando = new SqlCommand(consulta, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);

                    DataTable datos = new DataTable();
                    adapter.Fill(datos);

                    dgvSala.DataSource = datos;

                    dgvSala.Columns["IDSucursal"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }
        }


        private void dgvClasificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datosButton_Click(object sender, EventArgs e)
        {
            ObtenerDatosBD();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            Editar = false;

            txtIDSala.Text = "0";
            txtNumSala.Text = "";
            txtAsientos.Text = "";

            cbIDSucursal.SelectedIndex = -1;
            cbTipoSala.SelectedIndex = -1;

            txtNumSala.Enabled = true;
            txtAsientos.Enabled = true;
            cbIDSucursal.Enabled = true;
            cbTipoSala.Enabled = true;

            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
            nuevoButton.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            datosButton.Enabled = false;
            salirButton.Enabled = false;
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (cbIDSucursal.SelectedValue == null ||
                cbIDSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una sucursal.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumSala.Text) ||
                string.IsNullOrWhiteSpace(txtAsientos.Text))
            {
                MessageBox.Show("Completa el número de sala y los asientos.");
                return;
            }

            int numeroSala;
            int cantidadAsientos;

            if (!int.TryParse(txtNumSala.Text, out numeroSala) ||
                !int.TryParse(txtAsientos.Text, out cantidadAsientos))
            {
                MessageBox.Show("El número de sala y los asientos deben ser enteros.");
                return;
            }

            if (numeroSala <= 0 || cantidadAsientos <= 0)
            {
                MessageBox.Show("El número de sala y los asientos deben ser mayores que cero.");
                return;
            }

            try
            {
                using (SqlConnection s = ObtenerConexion())
                {
                    s.Open();

                    if (Editar == false)
                    {
                        // INSERT: crear una sala nueva
                        string nuevo =
                            "INSERT INTO dbo.Sala " +
                            "(IDSucursal, NumeroSala, TipoSala, CantidadAsientos) " +
                            "VALUES (@IDSucursal, @NumeroSala, @TipoSala, @CantidadAsientos)";

                        SqlCommand comando = new SqlCommand(nuevo, s);

                        comando.Parameters.AddWithValue(
                            "@IDSucursal", Convert.ToInt32(cbIDSucursal.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@NumeroSala", numeroSala);

                        comando.Parameters.AddWithValue(
                            "@TipoSala",
                            cbTipoSala.SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cbTipoSala.SelectedItem.ToString());

                        comando.Parameters.AddWithValue(
                            "@CantidadAsientos", cantidadAsientos);

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al guardar el registro");
                        }
                    }
                    else
                    {
                        // UPDATE: editar una sala existente
                        string actualizar =
                            "UPDATE dbo.Sala SET " +
                            "IDSucursal = @IDSucursal, " +
                            "NumeroSala = @NumeroSala, " +
                            "TipoSala = @TipoSala, " +
                            "CantidadAsientos = @CantidadAsientos " +
                            "WHERE IDSala = @IDSala";

                        SqlCommand comando = new SqlCommand(actualizar, s);

                        comando.Parameters.AddWithValue(
                            "@IDSucursal", Convert.ToInt32(cbIDSucursal.SelectedValue));

                        comando.Parameters.AddWithValue(
                            "@NumeroSala", numeroSala);

                        comando.Parameters.AddWithValue(
                            "@TipoSala",
                            cbTipoSala.SelectedIndex == -1
                                ? (object)DBNull.Value
                                : cbTipoSala.SelectedItem.ToString());

                        comando.Parameters.AddWithValue(
                            "@CantidadAsientos", cantidadAsientos);

                        comando.Parameters.AddWithValue(
                            "@IDSala", Convert.ToInt32(txtIDSala.Text));

                        int renglonesAfectados = comando.ExecuteNonQuery();

                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Éxito al editar el registro");
                        }
                    }
                }

                ObtenerDatosBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }

            // Restaurar los controles
            txtNumSala.Enabled = false;
            txtAsientos.Enabled = false;
            cbIDSucursal.Enabled = false;
            cbTipoSala.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
            nuevoButton.Enabled = true;
            editarButton.Enabled = true;
            eliminarButton.Enabled = true;
            datosButton.Enabled = true;
            salirButton.Enabled = true;

            Editar = false;
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            Editar = true;

            txtNumSala.Enabled = true;
            txtAsientos.Enabled = true;
            cbIDSucursal.Enabled = true;
            cbTipoSala.Enabled = true;

            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;
            nuevoButton.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            datosButton.Enabled = false;
            salirButton.Enabled = false;

        }

        private void dgvSala_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSala.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dgvSala.SelectedRows[0];

                if (r.Cells["IDSala"].Value != null)
                {
                    txtIDSala.Text =
                        r.Cells["IDSala"].Value.ToString();

                    txtNumSala.Text =
                        r.Cells["NumeroSala"].Value.ToString();

                    txtAsientos.Text =
                        r.Cells["CantidadAsientos"].Value.ToString();

                    cbIDSucursal.SelectedValue =
                        Convert.ToInt32(r.Cells["IDSucursal"].Value);

                    if (r.Cells["TipoSala"].Value == DBNull.Value)
                    {
                        cbTipoSala.SelectedIndex = -1;
                    }
                    else
                    {
                        cbTipoSala.SelectedItem =
                            r.Cells["TipoSala"].Value.ToString();
                    }
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            txtNumSala.Enabled = false;
            txtAsientos.Enabled = false;
            cbIDSucursal.Enabled = false;
            cbTipoSala.Enabled = false;

            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;
            nuevoButton.Enabled = true;
            editarButton.Enabled = true;
            eliminarButton.Enabled = true;
            datosButton.Enabled = true;
            salirButton.Enabled = true;

            Editar = false;

            ObtenerDatosBD();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dgvSala.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar esta sala?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection s = ObtenerConexion())
                        {
                            s.Open();

                            string eliminar =
                                "DELETE FROM dbo.Sala WHERE IDSala = @IDSala";

                            SqlCommand comando = new SqlCommand(eliminar, s);

                            comando.Parameters.AddWithValue(
                                "@IDSala", Convert.ToInt32(txtIDSala.Text));

                            int renglonesAfectados = comando.ExecuteNonQuery();

                            if (renglonesAfectados > 0)
                            {
                                MessageBox.Show("Éxito al eliminar el registro");
                            }
                        }

                        ObtenerDatosBD();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Excepción: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar");
            }
        }
    }
    
}
