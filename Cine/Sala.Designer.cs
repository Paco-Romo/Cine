namespace Cine
{
    partial class Sala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sala));
            label4 = new Label();
            txtNumSala = new TextBox();
            txtIDSala = new TextBox();
            label3 = new Label();
            label2 = new Label();
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
            cbIDSucursal = new ComboBox();
            cbTipoSala = new ComboBox();
            label5 = new Label();
            txtAsientos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSala).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 515);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 42;
            label4.Text = "Tipo de Sala";
            // 
            // txtNumSala
            // 
            txtNumSala.Location = new Point(547, 432);
            txtNumSala.Margin = new Padding(4);
            txtNumSala.Name = "txtNumSala";
            txtNumSala.Size = new Size(193, 31);
            txtNumSala.TabIndex = 41;
            // 
            // txtIDSala
            // 
            txtIDSala.Enabled = false;
            txtIDSala.Location = new Point(134, 429);
            txtIDSala.Margin = new Padding(4);
            txtIDSala.Name = "txtIDSala";
            txtIDSala.ReadOnly = true;
            txtIDSala.Size = new Size(193, 31);
            txtIDSala.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 438);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 38;
            label3.Text = "Numero de sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 515);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 37;
            label2.Text = "IDSucursal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 426);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 36;
            label1.Text = "IDSala";
            // 
            // dgvSala
            // 
            dgvSala.AllowUserToAddRows = false;
            dgvSala.AllowUserToDeleteRows = false;
            dgvSala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSala.Location = new Point(26, 68);
            dgvSala.Margin = new Padding(4);
            dgvSala.Name = "dgvSala";
            dgvSala.ReadOnly = true;
            dgvSala.RowHeadersWidth = 51;
            dgvSala.Size = new Size(970, 315);
            dgvSala.TabIndex = 35;
            dgvSala.CellContentClick += dgvClasificacion_CellContentClick;
            dgvSala.SelectionChanged += dgvSala_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, eliminarButton, editarButton, guardarButton, cancelarButton, datosButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1088, 34);
            toolStrip1.TabIndex = 34;
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
            datosButton.Click += datosButton_Click;
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
            // cbIDSucursal
            // 
            cbIDSucursal.FormattingEnabled = true;
            cbIDSucursal.Location = new Point(134, 515);
            cbIDSucursal.Name = "cbIDSucursal";
            cbIDSucursal.Size = new Size(182, 33);
            cbIDSucursal.TabIndex = 43;
            // 
            // cbTipoSala
            // 
            cbTipoSala.FormattingEnabled = true;
            cbTipoSala.Items.AddRange(new object[] { "Normal", "VIP", "3D" });
            cbTipoSala.Location = new Point(547, 512);
            cbTipoSala.Name = "cbTipoSala";
            cbTipoSala.Size = new Size(182, 33);
            cbTipoSala.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(818, 455);
            label5.Name = "label5";
            label5.Size = new Size(178, 25);
            label5.TabIndex = 46;
            label5.Text = "Cantidad de asientos";
            // 
            // txtAsientos
            // 
            txtAsientos.Location = new Point(832, 492);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(150, 31);
            txtAsientos.TabIndex = 47;
            // 
            // Sala
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 568);
            Controls.Add(txtAsientos);
            Controls.Add(label5);
            Controls.Add(cbTipoSala);
            Controls.Add(cbIDSucursal);
            Controls.Add(label4);
            Controls.Add(txtNumSala);
            Controls.Add(txtIDSala);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSala);
            Controls.Add(toolStrip1);
            Name = "Sala";
            Text = "Sala";
            ((System.ComponentModel.ISupportInitialize)dgvSala).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox txtNumSala;
        private TextBox txtIDSala;
        private Label label3;
        private Label label2;
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
        private ComboBox cbIDSucursal;
        private ComboBox cbTipoSala;
        private Label label5;
        private TextBox txtAsientos;
    }
}