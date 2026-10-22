namespace Cine
{
    partial class Estado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estado));
            dgvEstado = new DataGridView();
            toolStrip1 = new ToolStrip();
            nuevoButton = new ToolStripButton();
            editarButton = new ToolStripButton();
            eliminarButton = new ToolStripButton();
            guardarButton = new ToolStripButton();
            cancelarButton = new ToolStripButton();
            obtenerButton = new ToolStripButton();
            salirButton = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idBox = new TextBox();
            siglaBox = new TextBox();
            claveBox = new TextBox();
            nombreBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstado).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEstado
            // 
            dgvEstado.AllowUserToAddRows = false;
            dgvEstado.AllowUserToDeleteRows = false;
            dgvEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstado.Location = new Point(12, 64);
            dgvEstado.Name = "dgvEstado";
            dgvEstado.ReadOnly = true;
            dgvEstado.RowHeadersWidth = 51;
            dgvEstado.Size = new Size(776, 236);
            dgvEstado.TabIndex = 0;
            dgvEstado.SelectionChanged += dgvEstado_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoButton, editarButton, eliminarButton, guardarButton, cancelarButton, obtenerButton, salirButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 342);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "IDEstado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 421);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Sigla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 342);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 4;
            label3.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 421);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 5;
            label4.Text = "Nombre";
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(136, 339);
            idBox.Name = "idBox";
            idBox.Size = new Size(235, 27);
            idBox.TabIndex = 6;
            // 
            // siglaBox
            // 
            siglaBox.Enabled = false;
            siglaBox.Location = new Point(136, 418);
            siglaBox.Name = "siglaBox";
            siglaBox.Size = new Size(235, 27);
            siglaBox.TabIndex = 7;
            // 
            // claveBox
            // 
            claveBox.Enabled = false;
            claveBox.Location = new Point(428, 339);
            claveBox.Name = "claveBox";
            claveBox.Size = new Size(235, 27);
            claveBox.TabIndex = 8;
            // 
            // nombreBox
            // 
            nombreBox.Enabled = false;
            nombreBox.Location = new Point(447, 414);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(235, 27);
            nombreBox.TabIndex = 9;
            // 
            // Estado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nombreBox);
            Controls.Add(claveBox);
            Controls.Add(siglaBox);
            Controls.Add(idBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(dgvEstado);
            Name = "Estado";
            Text = "Estado";
            ((System.ComponentModel.ISupportInitialize)dgvEstado).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstado;
        private ToolStrip toolStrip1;
        private ToolStripButton nuevoButton;
        private ToolStripButton editarButton;
        private ToolStripButton eliminarButton;
        private ToolStripButton guardarButton;
        private ToolStripButton cancelarButton;
        private ToolStripButton obtenerButton;
        private ToolStripButton salirButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idBox;
        private TextBox siglaBox;
        private TextBox claveBox;
        private TextBox nombreBox;
    }
}