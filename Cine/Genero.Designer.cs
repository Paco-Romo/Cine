namespace Cine
{
    partial class Genero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genero));
            descripcionBox = new TextBox();
            nombreBox = new TextBox();
            idBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvGenero = new DataGridView();
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            datosButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvGenero).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // descripcionBox
            // 
            descripcionBox.Location = new Point(421, 300);
            descripcionBox.Margin = new Padding(3, 2, 3, 2);
            descripcionBox.Name = "descripcionBox";
            descripcionBox.Size = new Size(136, 23);
            descripcionBox.TabIndex = 21;
            // 
            // nombreBox
            // 
            nombreBox.Location = new Point(116, 358);
            nombreBox.Margin = new Padding(3, 2, 3, 2);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(136, 23);
            nombreBox.TabIndex = 20;
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(116, 300);
            idBox.Margin = new Padding(3, 2, 3, 2);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(136, 23);
            idBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 334);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 367);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 303);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 16;
            label3.Text = "Descripcion Genero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 361);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre Genero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 308);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 14;
            label1.Text = "IDGenero";
            // 
            // dgvGenero
            // 
            dgvGenero.AllowUserToAddRows = false;
            dgvGenero.AllowUserToDeleteRows = false;
            dgvGenero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenero.Location = new Point(10, 97);
            dgvGenero.Margin = new Padding(3, 2, 3, 2);
            dgvGenero.Name = "dgvGenero";
            dgvGenero.ReadOnly = true;
            dgvGenero.RowHeadersWidth = 51;
            dgvGenero.Size = new Size(679, 191);
            dgvGenero.TabIndex = 13;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, eliminarButton, editarButton, guardarButton, cancelarButton, datosButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 12;
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
            // Genero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(descripcionBox);
            Controls.Add(nombreBox);
            Controls.Add(idBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvGenero);
            Controls.Add(toolStrip1);
            Name = "Genero";
            Text = "Genero";
            ((System.ComponentModel.ISupportInitialize)dgvGenero).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox descripcionBox;
        private TextBox nombreBox;
        private TextBox idBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvGenero;
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