namespace Cine
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        private void películaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peliculas peliculas = new Peliculas();
            peliculas.ShowDialog();
        }

        private void clasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificacion clasificacion = new Clasificacion();
            clasificacion.ShowDialog();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.ShowDialog();
        }
        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();
            estado.ShowDialog();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.ShowDialog();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.ShowDialog();

        private void Cine_Load(object sender, EventArgs e)
        {

        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala();
            sala.ShowDialog();
        }
    }
}
