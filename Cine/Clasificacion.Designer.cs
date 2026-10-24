namespace Cine
{
    partial class Clasificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clasificacion));
            dtFecha = new DateTimePicker();
            label4 = new Label();
            txtDescripcion = new TextBox();
            txtClave = new TextBox();
            txtIdClasificacion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvClasificacion = new DataGridView();
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            datosButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtFecha
            // 
            dtFecha.Enabled = false;
            dtFecha.Location = new Point(605, 504);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(300, 31);
            dtFecha.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 509);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 32;
            label4.Text = "Fecha";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(617, 409);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(193, 31);
            txtDescripcion.TabIndex = 31;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(159, 509);
            txtClave.Margin = new Padding(4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(193, 31);
            txtClave.TabIndex = 30;
            // 
            // txtIdClasificacion
            // 
            txtIdClasificacion.Enabled = false;
            txtIdClasificacion.Location = new Point(159, 412);
            txtIdClasificacion.Margin = new Padding(4);
            txtIdClasificacion.Name = "txtIdClasificacion";
            txtIdClasificacion.ReadOnly = true;
            txtIdClasificacion.Size = new Size(193, 31);
            txtIdClasificacion.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 415);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 28;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 512);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 27;
            label2.Text = "Clave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 412);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 26;
            label1.Text = "IDClasificación";
            // 
            // dgvClasificacion
            // 
            dgvClasificacion.AllowUserToAddRows = false;
            dgvClasificacion.AllowUserToDeleteRows = false;
            dgvClasificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasificacion.Location = new Point(26, 54);
            dgvClasificacion.Margin = new Padding(4);
            dgvClasificacion.Name = "dgvClasificacion";
            dgvClasificacion.ReadOnly = true;
            dgvClasificacion.RowHeadersWidth = 51;
            dgvClasificacion.Size = new Size(970, 315);
            dgvClasificacion.TabIndex = 25;
            dgvClasificacion.SelectionChanged += dgvClasificacion_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, eliminarButton, editarButton, guardarButton, cancelarButton, datosButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1096, 34);
            toolStrip1.TabIndex = 24;
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
            // Clasificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 554);
            Controls.Add(dtFecha);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(txtClave);
            Controls.Add(txtIdClasificacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClasificacion);
            Controls.Add(toolStrip1);
            Name = "Clasificacion";
            Text = "Clasificación";
            Load += Clasificacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtFecha;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox txtClave;
        private TextBox txtIdClasificacion;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvClasificacion;
        private ToolStrip toolStrip1;
        private ToolStripButton nuevoButton;
        private ToolStripButton eliminarButton;
        private ToolStripButton editarButton;
        private ToolStripButton guardarButton;
        private ToolStripButton cancelarButton;
        private ToolStripButton datosButton;
        private ToolStripButton salirButton;
    }
}