namespace Cine
{
    partial class Funcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcion));
            label7 = new Label();
            IDPeliBox = new TextBox();
            label6 = new Label();
            IDFunBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvFuncion = new DataGridView();
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            datosButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            label8 = new Label();
            IDSalaBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFuncion).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 386);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 48;
            label7.Text = "Hora";
            // 
            // IDPeliBox
            // 
            IDPeliBox.Enabled = false;
            IDPeliBox.Location = new Point(116, 383);
            IDPeliBox.Margin = new Padding(3, 2, 3, 2);
            IDPeliBox.Name = "IDPeliBox";
            IDPeliBox.ReadOnly = true;
            IDPeliBox.Size = new Size(136, 23);
            IDPeliBox.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 386);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 46;
            label6.Text = "IDPelicula";
            // 
            // IDFunBox
            // 
            IDFunBox.Enabled = false;
            IDFunBox.Location = new Point(116, 339);
            IDFunBox.Margin = new Padding(3, 2, 3, 2);
            IDFunBox.Name = "IDFunBox";
            IDFunBox.ReadOnly = true;
            IDFunBox.Size = new Size(136, 23);
            IDFunBox.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 373);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 406);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 347);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 41;
            label3.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 347);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 39;
            label1.Text = "IDFuncion";
            // 
            // dgvFuncion
            // 
            dgvFuncion.AllowUserToAddRows = false;
            dgvFuncion.AllowUserToDeleteRows = false;
            dgvFuncion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncion.Location = new Point(10, 136);
            dgvFuncion.Margin = new Padding(3, 2, 3, 2);
            dgvFuncion.Name = "dgvFuncion";
            dgvFuncion.ReadOnly = true;
            dgvFuncion.RowHeadersWidth = 51;
            dgvFuncion.Size = new Size(679, 191);
            dgvFuncion.TabIndex = 38;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, eliminarButton, editarButton, guardarButton, cancelarButton, datosButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 37;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 425);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 51;
            label8.Text = "IDSala";
            // 
            // IDSalaBox
            // 
            IDSalaBox.Enabled = false;
            IDSalaBox.Location = new Point(116, 422);
            IDSalaBox.Margin = new Padding(3, 2, 3, 2);
            IDSalaBox.Name = "IDSalaBox";
            IDSalaBox.ReadOnly = true;
            IDSalaBox.Size = new Size(136, 23);
            IDSalaBox.TabIndex = 52;
            // 
            // Funcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IDSalaBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(IDPeliBox);
            Controls.Add(label6);
            Controls.Add(IDFunBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvFuncion);
            Controls.Add(toolStrip1);
            Name = "Funcion";
            Text = "Funcion";
            ((System.ComponentModel.ISupportInitialize)dgvFuncion).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox IDPeliBox;
        private Label label6;
        private TextBox nombreBox;
        private TextBox IDFunBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvFuncion;
        private ToolStrip toolStrip1;
        private ToolStripButton nuevoButton;
        private ToolStripButton eliminarButton;
        private ToolStripButton editarButton;
        private ToolStripButton guardarButton;
        private ToolStripButton cancelarButton;
        private ToolStripButton datosButton;
        private ToolStripButton salirButton;
        private Label label8;
        private TextBox IDSalaBox;
    }
}