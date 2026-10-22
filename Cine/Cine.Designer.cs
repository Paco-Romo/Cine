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
            películaToolStripMenuItem = new ToolStripMenuItem();
            clasificaciónToolStripMenuItem = new ToolStripMenuItem();
            generoToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1086, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { películaToolStripMenuItem, clasificaciónToolStripMenuItem, generoToolStripMenuItem, salaToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(76, 29);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // películaToolStripMenuItem
            // 
            películaToolStripMenuItem.Name = "películaToolStripMenuItem";
            películaToolStripMenuItem.Size = new Size(270, 34);
            películaToolStripMenuItem.Text = "Película";
            películaToolStripMenuItem.Click += películaToolStripMenuItem_Click;
            // 
            // clasificaciónToolStripMenuItem
            // 
            clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            clasificaciónToolStripMenuItem.Size = new Size(270, 34);
            clasificaciónToolStripMenuItem.Text = "Clasificación";
            clasificaciónToolStripMenuItem.Click += clasificaciónToolStripMenuItem_Click;
            // 
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(270, 34);
            generoToolStripMenuItem.Text = "Genero";
            generoToolStripMenuItem.Click += generoToolStripMenuItem_Click;
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(270, 34);
            salaToolStripMenuItem.Text = "Sala";
            salaToolStripMenuItem.Click += salaToolStripMenuItem_Click;
            // 
            // Cine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 532);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Cine";
            Text = "Cine";
            Load += Cine_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem películaToolStripMenuItem;
        private ToolStripMenuItem clasificaciónToolStripMenuItem;
        private ToolStripMenuItem generoToolStripMenuItem;
        private ToolStripMenuItem salaToolStripMenuItem;
    }
}
