namespace Cine
{
    partial class TipoBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoBoleto));
            txtClave = new TextBox();
            txtIDTipoBoleto = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dgvSala = new DataGridView();
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            datosButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSala).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtClave
            // 
            txtClave.Location = new Point(651, 410);
            txtClave.Margin = new Padding(4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(193, 31);
            txtClave.TabIndex = 54;
            // 
            // txtIDTipoBoleto
            // 
            txtIDTipoBoleto.Enabled = false;
            txtIDTipoBoleto.Location = new Point(148, 410);
            txtIDTipoBoleto.Margin = new Padding(4);
            txtIDTipoBoleto.Name = "txtIDTipoBoleto";
            txtIDTipoBoleto.ReadOnly = true;
            txtIDTipoBoleto.Size = new Size(193, 31);
            txtIDTipoBoleto.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 413);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 52;
            label3.Text = "Clave";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 410);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 50;
            label1.Text = "IDTipoBoleto";
            label1.Click += label1_Click;
            // 
            // dgvSala
            // 
            dgvSala.AllowUserToAddRows = false;
            dgvSala.AllowUserToDeleteRows = false;
            dgvSala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSala.Location = new Point(26, 52);
            dgvSala.Margin = new Padding(4);
            dgvSala.Name = "dgvSala";
            dgvSala.ReadOnly = true;
            dgvSala.RowHeadersWidth = 51;
            dgvSala.Size = new Size(970, 315);
            dgvSala.TabIndex = 49;
            dgvSala.SelectionChanged += dgvSala_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, eliminarButton, editarButton, guardarButton, cancelarButton, datosButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1049, 34);
            toolStrip1.TabIndex = 48;
            toolStrip1.Text = "toolStripPeliculas";
            // 
            // nuevoButton
            // 
            nuevoButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            nuevoButton.Image = (Image)resources.GetObject("nuevoButton.Image");
            nuevoButton.ImageTransparentColor = Color.Magenta;
            nuevoButton.Name = "nuevoButton";
            nuevoButton.Size = new Size(68, 29);
            nuevoButton.Text = "Nuevo";
            nuevoButton.Click += nuevoButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            eliminarButton.Image = (Image)resources.GetObject("eliminarButton.Image");
            eliminarButton.ImageTransparentColor = Color.Magenta;
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(78, 29);
            eliminarButton.Text = "Eliminar";
            eliminarButton.Click += eliminarButton_Click;
            // 
            // editarButton
            // 
            editarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editarButton.Image = (Image)resources.GetObject("editarButton.Image");
            editarButton.ImageTransparentColor = Color.Magenta;
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(61, 29);
            editarButton.Text = "Editar";
            editarButton.Click += editarButton_Click;
            // 
            // guardarButton
            // 
            guardarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            guardarButton.Image = (Image)resources.GetObject("guardarButton.Image");
            guardarButton.ImageTransparentColor = Color.Magenta;
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(79, 29);
            guardarButton.Text = "Guardar";
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelarButton.Image = (Image)resources.GetObject("cancelarButton.Image");
            cancelarButton.ImageTransparentColor = Color.Magenta;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(82, 29);
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click;
            // 
            // datosButton
            // 
            datosButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            datosButton.Image = (Image)resources.GetObject("datosButton.Image");
            datosButton.ImageTransparentColor = Color.Magenta;
            datosButton.Name = "datosButton";
            datosButton.Size = new Size(133, 29);
            datosButton.Text = "Obtener Datos";
            // 
            // salirButton
            // 
            salirButton.Alignment = ToolStripItemAlignment.Right;
            salirButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            salirButton.Image = (Image)resources.GetObject("salirButton.Image");
            salirButton.ImageTransparentColor = Color.Magenta;
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(49, 29);
            salirButton.Text = "Salir";
            salirButton.TextAlign = ContentAlignment.TopCenter;
            salirButton.Click += salirButton_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(148, 511);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(193, 31);
            txtDescripcion.TabIndex = 61;
            txtDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 514);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 60;
            label2.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(651, 505);
            txtPrecio.Margin = new Padding(4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(193, 31);
            txtPrecio.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 508);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 62;
            label4.Text = "Precio";
            // 
            // TipoBoleto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 587);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(txtIDTipoBoleto);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvSala);
            Controls.Add(toolStrip1);
            Name = "TipoBoleto";
            Text = "TiopoBoleto";
            ((System.ComponentModel.ISupportInitialize)dgvSala).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtClave;
        private TextBox txtIDTipoBoleto;
        private Label label3;
        private Label label1;
        private DataGridView dgvSala;
        private ToolStrip toolStrip1;
        private ToolStripButton nuevoButton;
        private ToolStripButton eliminarButton;
        private ToolStripButton editarButton;
        private ToolStripButton guardarButton;
        private ToolStripButton cancelarButton;
        private ToolStripButton datosButton;
        private ToolStripButton salirButton;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtPrecio;
        private Label label4;
    }
}