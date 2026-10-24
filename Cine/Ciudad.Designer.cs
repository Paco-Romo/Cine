namespace Cine
{
    partial class Ciudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciudad));
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            obtenerButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            dgvCiudad = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            estadoBox = new ComboBox();
            ciudadBox = new TextBox();
            siglaBox = new TextBox();
            claveBox = new TextBox();
            nombreBox = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudad).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, editarButton, eliminarButton, guardarButton, cancelarButton, obtenerButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
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
            // editarButton
            // 
            editarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editarButton.Image = (Image)resources.GetObject("editarButton.Image");
            editarButton.ImageTransparentColor = Color.Magenta;
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(52, 24);
            editarButton.Text = "Editar";
            editarButton.Click += editarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            eliminarButton.Image = (Image)resources.GetObject("eliminarButton.Image");
            eliminarButton.ImageTransparentColor = Color.Magenta;
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(67, 24);
            eliminarButton.Text = "Eliminar";
            eliminarButton.Click += eliminarButton_Click;
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
            cancelarButton.Click += cancelarButton_Click;
            // 
            // obtenerButton
            // 
            obtenerButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            obtenerButton.Image = (Image)resources.GetObject("obtenerButton.Image");
            obtenerButton.ImageTransparentColor = Color.Magenta;
            obtenerButton.Name = "obtenerButton";
            obtenerButton.Size = new Size(67, 24);
            obtenerButton.Text = "Obtener";
            obtenerButton.Click += obtenerButton_Click;
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
            salirButton.Click += salirButton_Click;
            // 
            // dgvCiudad
            // 
            dgvCiudad.AllowUserToAddRows = false;
            dgvCiudad.AllowUserToDeleteRows = false;
            dgvCiudad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudad.Location = new Point(12, 41);
            dgvCiudad.Name = "dgvCiudad";
            dgvCiudad.ReadOnly = true;
            dgvCiudad.RowHeadersWidth = 51;
            dgvCiudad.Size = new Size(776, 236);
            dgvCiudad.TabIndex = 3;
            dgvCiudad.SelectionChanged += dgvCiudad_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 313);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "IDCiudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 397);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 313);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "Sigla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 360);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Clave";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 402);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // estadoBox
            // 
            estadoBox.Enabled = false;
            estadoBox.FormattingEnabled = true;
            estadoBox.Location = new Point(111, 394);
            estadoBox.Name = "estadoBox";
            estadoBox.Size = new Size(151, 28);
            estadoBox.TabIndex = 9;
            // 
            // ciudadBox
            // 
            ciudadBox.Enabled = false;
            ciudadBox.Location = new Point(111, 310);
            ciudadBox.Name = "ciudadBox";
            ciudadBox.Size = new Size(151, 27);
            ciudadBox.TabIndex = 10;
            // 
            // siglaBox
            // 
            siglaBox.Enabled = false;
            siglaBox.Location = new Point(398, 310);
            siglaBox.Name = "siglaBox";
            siglaBox.Size = new Size(151, 27);
            siglaBox.TabIndex = 11;
            // 
            // claveBox
            // 
            claveBox.Enabled = false;
            claveBox.Location = new Point(398, 357);
            claveBox.Name = "claveBox";
            claveBox.Size = new Size(151, 27);
            claveBox.TabIndex = 12;
            // 
            // nombreBox
            // 
            nombreBox.Enabled = false;
            nombreBox.Location = new Point(398, 399);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(151, 27);
            nombreBox.TabIndex = 13;
            // 
            // Ciudad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nombreBox);
            Controls.Add(claveBox);
            Controls.Add(siglaBox);
            Controls.Add(ciudadBox);
            Controls.Add(estadoBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCiudad);
            Controls.Add(toolStrip1);
            Name = "Ciudad";
            Text = "Ciudad";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton nuevoButton;
        private ToolStripButton editarButton;
        private ToolStripButton eliminarButton;
        private ToolStripButton guardarButton;
        private ToolStripButton cancelarButton;
        private ToolStripButton obtenerButton;
        private ToolStripButton salirButton;
        private DataGridView dgvCiudad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox estadoBox;
        private TextBox ciudadBox;
        private TextBox siglaBox;
        private TextBox claveBox;
        private TextBox nombreBox;
    }
}