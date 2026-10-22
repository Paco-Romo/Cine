namespace Cine
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            nombreBox = new TextBox();
            IDCliBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvCliente = new DataGridView();
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            datosButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            IDCiuBox = new TextBox();
            label6 = new Label();
            correoBox = new TextBox();
            label7 = new Label();
            celularBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nombreBox
            // 
            nombreBox.Location = new Point(116, 417);
            nombreBox.Margin = new Padding(3, 2, 3, 2);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(136, 23);
            nombreBox.TabIndex = 30;
            // 
            // IDCliBox
            // 
            IDCliBox.Enabled = false;
            IDCliBox.Location = new Point(116, 334);
            IDCliBox.Margin = new Padding(3, 2, 3, 2);
            IDCliBox.Name = "IDCliBox";
            IDCliBox.ReadOnly = true;
            IDCliBox.Size = new Size(136, 23);
            IDCliBox.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 368);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 401);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 342);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 26;
            label3.Text = "Celular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 420);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 25;
            label2.Text = "Nombre ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 342);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 24;
            label1.Text = "IDGenero";
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(10, 131);
            dgvCliente.Margin = new Padding(3, 2, 3, 2);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(679, 191);
            dgvCliente.TabIndex = 23;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, eliminarButton, editarButton, guardarButton, cancelarButton, datosButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 22;
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
            eliminarButton.Click += eliminarButton_Click;
            // 
            // editarButton
            // 
            editarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editarButton.Image = (Image)resources.GetObject("editarButton.Image");
            editarButton.ImageTransparentColor = Color.Magenta;
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(41, 22);
            editarButton.Text = "Editar";
            editarButton.Click += editarButton_Click;
            // 
            // guardarButton
            // 
            guardarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            guardarButton.Image = (Image)resources.GetObject("guardarButton.Image");
            guardarButton.ImageTransparentColor = Color.Magenta;
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(53, 22);
            guardarButton.Text = "Guardar";
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelarButton.Image = (Image)resources.GetObject("cancelarButton.Image");
            cancelarButton.ImageTransparentColor = Color.Magenta;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(57, 22);
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click;
            // 
            // datosButton
            // 
            datosButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            datosButton.Image = (Image)resources.GetObject("datosButton.Image");
            datosButton.ImageTransparentColor = Color.Magenta;
            datosButton.Name = "datosButton";
            datosButton.Size = new Size(87, 22);
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
            salirButton.Size = new Size(33, 22);
            salirButton.Text = "Salir";
            salirButton.TextAlign = ContentAlignment.TopCenter;
            salirButton.Click += salirButton_Click;
            // 
            // IDCiuBox
            // 
            IDCiuBox.Enabled = false;
            IDCiuBox.Location = new Point(116, 378);
            IDCiuBox.Margin = new Padding(3, 2, 3, 2);
            IDCiuBox.Name = "IDCiuBox";
            IDCiuBox.ReadOnly = true;
            IDCiuBox.Size = new Size(136, 23);
            IDCiuBox.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 381);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 32;
            label6.Text = "IDCiudad";
            // 
            // correoBox
            // 
            correoBox.Location = new Point(421, 378);
            correoBox.Margin = new Padding(3, 2, 3, 2);
            correoBox.Name = "correoBox";
            correoBox.Size = new Size(136, 23);
            correoBox.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 381);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 34;
            label7.Text = "Correo";
            // 
            // celularBox
            // 
            celularBox.Location = new Point(421, 334);
            celularBox.Name = "celularBox";
            celularBox.Size = new Size(136, 23);
            celularBox.TabIndex = 36;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(celularBox);
            Controls.Add(correoBox);
            Controls.Add(label7);
            Controls.Add(IDCiuBox);
            Controls.Add(label6);
            Controls.Add(nombreBox);
            Controls.Add(IDCliBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCliente);
            Controls.Add(toolStrip1);
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionBox;
        private TextBox nombreBox;
        private TextBox IDCliBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvCliente;
        private ToolStrip toolStrip1;
        private ToolStripButton nuevoButton;
        private ToolStripButton eliminarButton;
        private ToolStripButton editarButton;
        private ToolStripButton guardarButton;
        private ToolStripButton cancelarButton;
        private ToolStripButton datosButton;
        private ToolStripButton salirButton;
        private TextBox IDCiuBox;
        private Label label6;
        private TextBox correoBox;
        private Label label7;
        private TextBox celularBox;
    }
}