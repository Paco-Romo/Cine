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
            generoBox = new TextBox();
            clasificacionBox = new TextBox();
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
            toolStrip1.Size = new Size(700, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStripPeliculas";
            // 
            // nuevoButton
            // 
            nuevoButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            nuevoButton.Image = (Image)resources.GetObject("nuevoButton.Image");
            nuevoButton.ImageTransparentColor = Color.Magenta;
            nuevoButton.Name = "nuevoButton";
            nuevoButton.Size = new Size(46, 22);
            nuevoButton.Text = "Nuevo";
            nuevoButton.Click += nuevoButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            eliminarButton.Image = (Image)resources.GetObject("eliminarButton.Image");
            eliminarButton.ImageTransparentColor = Color.Magenta;
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(54, 22);
            eliminarButton.Text = "Eliminar";
            // 
            // editarButton
            // 
            editarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editarButton.Image = (Image)resources.GetObject("editarButton.Image");
            editarButton.ImageTransparentColor = Color.Magenta;
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(41, 22);
            editarButton.Text = "Editar";
            // 
            // guardarButton
            // 
            guardarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            guardarButton.Image = (Image)resources.GetObject("guardarButton.Image");
            guardarButton.ImageTransparentColor = Color.Magenta;
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(53, 22);
            guardarButton.Text = "Guardar";
            // 
            // cancelarButton
            // 
            cancelarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelarButton.Image = (Image)resources.GetObject("cancelarButton.Image");
            cancelarButton.ImageTransparentColor = Color.Magenta;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(57, 22);
            cancelarButton.Text = "Cancelar";
            // 
            // datosButton
            // 
            datosButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            datosButton.Image = (Image)resources.GetObject("datosButton.Image");
            datosButton.ImageTransparentColor = Color.Magenta;
            datosButton.Name = "datosButton";
            datosButton.Size = new Size(87, 22);
            datosButton.Text = "Obtener Datos";
            // 
            // salirButton
            // 
            salirButton.Alignment = ToolStripItemAlignment.Right;
            salirButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            salirButton.Image = (Image)resources.GetObject("salirButton.Image");
            salirButton.ImageTransparentColor = Color.Magenta;
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(33, 22);
            salirButton.Text = "Salir";
            salirButton.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(10, 29);
            dgvPeliculas.Margin = new Padding(3, 2, 3, 2);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.Size = new Size(679, 191);
            dgvPeliculas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 235);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "IDPelicula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 293);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 235);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Duracion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 296);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "IDGenero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 266);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 6;
            label5.Text = "idClasificacion";
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(88, 232);
            idBox.Margin = new Padding(3, 2, 3, 2);
            idBox.Name = "idBox";
            idBox.Size = new Size(136, 23);
            idBox.TabIndex = 7;
            // 
            // nombreBox
            // 
            nombreBox.Location = new Point(88, 291);
            nombreBox.Margin = new Padding(3, 2, 3, 2);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(136, 23);
            nombreBox.TabIndex = 8;
            // 
            // duracionBox
            // 
            duracionBox.Location = new Point(305, 232);
            duracionBox.Margin = new Padding(3, 2, 3, 2);
            duracionBox.Name = "duracionBox";
            duracionBox.Size = new Size(136, 23);
            duracionBox.TabIndex = 9;
            // 
            // generoBox
            // 
            generoBox.Enabled = false;
            generoBox.Location = new Point(305, 291);
            generoBox.Margin = new Padding(3, 2, 3, 2);
            generoBox.Name = "generoBox";
            generoBox.Size = new Size(136, 23);
            generoBox.TabIndex = 10;
            // 
            // clasificacionBox
            // 
            clasificacionBox.Location = new Point(554, 263);
            clasificacionBox.Margin = new Padding(3, 2, 3, 2);
            clasificacionBox.Name = "clasificacionBox";
            clasificacionBox.Size = new Size(136, 23);
            clasificacionBox.TabIndex = 11;
            // 
            // Peliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox generoBox;
        private TextBox clasificacionBox;
    }
}