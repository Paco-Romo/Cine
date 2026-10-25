namespace Cine
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        private void ciudadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.ShowDialog();
        }

        private void clasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificacion clasificacion = new Clasificacion();
            clasificacion.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();
            estado.ShowDialog();
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcion funcion = new Funcion();
            funcion.ShowDialog();
        }

        private void géneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genero g = new Genero();
            g.ShowDialog();
        }

        private void númeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numero numero = new numero();
            numero.ShowDialog();
        }

        private void pelíiculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peliculas peliculas = new Peliculas();
            peliculas.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala();
            sala.ShowDialog();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.ShowDialog();
        }

        private void tipoBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoBoleto tipo = new TipoBoleto();
            tipo.ShowDialog();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.ShowDialog();
        }
    }
}
