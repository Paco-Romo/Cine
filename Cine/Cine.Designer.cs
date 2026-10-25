namespace Cine
{
    partial class Cine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            ciudadToolStripMenuItem = new ToolStripMenuItem();
            clasificaciónToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            estadoToolStripMenuItem = new ToolStripMenuItem();
            funcionToolStripMenuItem = new ToolStripMenuItem();
            géneroToolStripMenuItem = new ToolStripMenuItem();
            númeroToolStripMenuItem = new ToolStripMenuItem();
            pelíiculaToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            sucursalToolStripMenuItem = new ToolStripMenuItem();
            tipoBoletoToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1076, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ciudadToolStripMenuItem, clasificaciónToolStripMenuItem, clienteToolStripMenuItem, estadoToolStripMenuItem, funcionToolStripMenuItem, géneroToolStripMenuItem, númeroToolStripMenuItem, pelíiculaToolStripMenuItem, salaToolStripMenuItem, sucursalToolStripMenuItem, tipoBoletoToolStripMenuItem, ventaToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(76, 29);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // ciudadToolStripMenuItem
            // 
            ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            ciudadToolStripMenuItem.Size = new Size(270, 34);
            ciudadToolStripMenuItem.Text = "Ciudad";
            ciudadToolStripMenuItem.Click += ciudadToolStripMenuItem_Click_1;
            // 
            // clasificaciónToolStripMenuItem
            // 
            clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            clasificaciónToolStripMenuItem.Size = new Size(270, 34);
            clasificaciónToolStripMenuItem.Text = "Clasificación";
            clasificaciónToolStripMenuItem.Click += clasificaciónToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(270, 34);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // estadoToolStripMenuItem
            // 
            estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            estadoToolStripMenuItem.Size = new Size(270, 34);
            estadoToolStripMenuItem.Text = "Estado";
            estadoToolStripMenuItem.Click += estadoToolStripMenuItem_Click;
            // 
            // funcionToolStripMenuItem
            // 
            funcionToolStripMenuItem.Name = "funcionToolStripMenuItem";
            funcionToolStripMenuItem.Size = new Size(270, 34);
            funcionToolStripMenuItem.Text = "Función";
            funcionToolStripMenuItem.Click += funcionToolStripMenuItem_Click;
            // 
            // géneroToolStripMenuItem
            // 
            géneroToolStripMenuItem.Name = "géneroToolStripMenuItem";
            géneroToolStripMenuItem.Size = new Size(270, 34);
            géneroToolStripMenuItem.Text = "Género";
            géneroToolStripMenuItem.Click += géneroToolStripMenuItem_Click;
            // 
            // númeroToolStripMenuItem
            // 
            númeroToolStripMenuItem.Name = "númeroToolStripMenuItem";
            númeroToolStripMenuItem.Size = new Size(270, 34);
            númeroToolStripMenuItem.Text = "Número";
            númeroToolStripMenuItem.Click += númeroToolStripMenuItem_Click;
            // 
            // pelíiculaToolStripMenuItem
            // 
            pelíiculaToolStripMenuItem.Name = "pelíiculaToolStripMenuItem";
            pelíiculaToolStripMenuItem.Size = new Size(270, 34);
            pelíiculaToolStripMenuItem.Text = "Pelíicula";
            pelíiculaToolStripMenuItem.Click += pelíiculaToolStripMenuItem_Click;
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(270, 34);
            salaToolStripMenuItem.Text = "Sala";
            salaToolStripMenuItem.Click += salaToolStripMenuItem_Click;
            // 
            // sucursalToolStripMenuItem
            // 
            sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            sucursalToolStripMenuItem.Size = new Size(270, 34);
            sucursalToolStripMenuItem.Text = "Sucursal";
            sucursalToolStripMenuItem.Click += sucursalToolStripMenuItem_Click;
            // 
            // tipoBoletoToolStripMenuItem
            // 
            tipoBoletoToolStripMenuItem.Name = "tipoBoletoToolStripMenuItem";
            tipoBoletoToolStripMenuItem.Size = new Size(270, 34);
            tipoBoletoToolStripMenuItem.Text = "Tipo Boleto";
            tipoBoletoToolStripMenuItem.Click += tipoBoletoToolStripMenuItem_Click;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(270, 34);
            ventaToolStripMenuItem.Text = "Venta";
            ventaToolStripMenuItem.Click += ventaToolStripMenuItem_Click;
            // 
            // Cine
            // 
            ClientSize = new Size(1076, 446);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Cine";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


        private MenuStrip menuStrip1;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem ciudadToolStripMenuItem;
        private ToolStripMenuItem clasificaciónToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem estadoToolStripMenuItem;
        private ToolStripMenuItem funcionToolStripMenuItem;
        private ToolStripMenuItem géneroToolStripMenuItem;
        private ToolStripMenuItem númeroToolStripMenuItem;
        private ToolStripMenuItem pelíiculaToolStripMenuItem;
        private ToolStripMenuItem salaToolStripMenuItem;
        private ToolStripMenuItem sucursalToolStripMenuItem;
        private ToolStripMenuItem tipoBoletoToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
    }
}
