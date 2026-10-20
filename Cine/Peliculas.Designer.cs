namespace Cine
{
    partial class Peliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            datosButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            dgvPeliculas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            idBox = new TextBox();
            nombreBox = new TextBox();
            duracionBox = new TextBox();
            generoBox = new ComboBox();
            clasificacionBox = new ComboBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, eliminarButton, editarButton, guardarButton, cancelarButton, datosButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStripPeliculas";
            // 
            // nuevoButton
            // 
            nuevoButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            nuevoButton.Image = (Image)resources.GetObject("nuevoButton.Image");
            nuevoButton.ImageTransparentColor = Color.Magenta;
            nuevoButton.Name = "nuevoButton";
            nuevoButton.Size = new Size(56, 24);
            nuevoButton.Text = "Nuevo";
            nuevoButton.Click += nuevoButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            eliminarButton.Image = (Image)resources.GetObject("eliminarButton.Image");
            eliminarButton.ImageTransparentColor = Color.Magenta;
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(67, 24);
            eliminarButton.Text = "Eliminar";
            // 
            // editarButton
            // 
            editarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editarButton.Image = (Image)resources.GetObject("editarButton.Image");
            editarButton.ImageTransparentColor = Color.Magenta;
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(52, 24);
            editarButton.Text = "Editar";
            // 
            // guardarButton
            // 
            guardarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            guardarButton.Image = (Image)resources.GetObject("guardarButton.Image");
            guardarButton.ImageTransparentColor = Color.Magenta;
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(66, 24);
            guardarButton.Text = "Guardar";
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelarButton.Image = (Image)resources.GetObject("cancelarButton.Image");
            cancelarButton.ImageTransparentColor = Color.Magenta;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(70, 24);
            cancelarButton.Text = "Cancelar";
            // 
            // datosButton
            // 
            datosButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            datosButton.Image = (Image)resources.GetObject("datosButton.Image");
            datosButton.ImageTransparentColor = Color.Magenta;
            datosButton.Name = "datosButton";
            datosButton.Size = new Size(110, 24);
            datosButton.Text = "Obtener Datos";
            datosButton.Click += datosButton_Click;
            // 
            // salirButton
            // 
            salirButton.Alignment = ToolStripItemAlignment.Right;
            salirButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            salirButton.Image = (Image)resources.GetObject("salirButton.Image");
            salirButton.ImageTransparentColor = Color.Magenta;
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(42, 24);
            salirButton.Text = "Salir";
            salirButton.TextAlign = ContentAlignment.TopCenter;
            salirButton.Click += salirButton_Click;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(12, 39);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.Size = new Size(776, 255);
            dgvPeliculas.TabIndex = 1;
            dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 313);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "IDPelicula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 391);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 313);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Duracion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 395);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 354);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 6;
            label5.Text = "Clasificacion";
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(101, 310);
            idBox.Name = "idBox";
            idBox.Size = new Size(155, 27);
            idBox.TabIndex = 7;
            // 
            // nombreBox
            // 
            nombreBox.Enabled = false;
            nombreBox.Location = new Point(101, 388);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(155, 27);
            nombreBox.TabIndex = 8;
            // 
            // duracionBox
            // 
            duracionBox.Enabled = false;
            duracionBox.Location = new Point(349, 310);
            duracionBox.Name = "duracionBox";
            duracionBox.Size = new Size(155, 27);
            duracionBox.TabIndex = 9;
            // 
            // generoBox
            // 
            generoBox.FormattingEnabled = true;
            generoBox.Location = new Point(349, 391);
            generoBox.Name = "generoBox";
            generoBox.Size = new Size(151, 28);
            generoBox.TabIndex = 12;
            // 
            // clasificacionBox
            // 
            clasificacionBox.FormattingEnabled = true;
            clasificacionBox.Location = new Point(623, 351);
            clasificacionBox.Name = "clasificacionBox";
            clasificacionBox.Size = new Size(151, 28);
            clasificacionBox.TabIndex = 13;
            // 
            // Peliculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clasificacionBox);
            Controls.Add(generoBox);
            Controls.Add(duracionBox);
            Controls.Add(nombreBox);
            Controls.Add(idBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPeliculas);
            Controls.Add(toolStrip1);
            Name = "Peliculas";
            Text = "Peliculas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton nuevoButton;
        private ToolStripButton eliminarButton;
        private ToolStripButton editarButton;
        private ToolStripButton guardarButton;
        private ToolStripButton cancelarButton;
        private ToolStripButton datosButton;
        private ToolStripButton salirButton;
        private DataGridView dgvPeliculas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idBox;
        private TextBox nombreBox;
        private TextBox duracionBox;
        private ComboBox generoBox;
        private ComboBox clasificacionBox;
    }
}