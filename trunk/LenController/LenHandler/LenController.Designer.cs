namespace LenHandler
{
    partial class LenController
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.connections_tc = new System.Windows.Forms.TabControl();
            this.cmd_btn = new System.Windows.Forms.Button();
            this.view_btn = new System.Windows.Forms.Button();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.connections_tc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmd_btn);
            this.splitContainer1.Panel2.Controls.Add(this.view_btn);
            this.splitContainer1.Panel2.Controls.Add(this.disconnect_btn);
            this.splitContainer1.Panel2.Controls.Add(this.connect_btn);
            this.splitContainer1.Size = new System.Drawing.Size(527, 427);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // connections_tc
            // 
            this.connections_tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connections_tc.Location = new System.Drawing.Point(0, 0);
            this.connections_tc.Name = "connections_tc";
            this.connections_tc.SelectedIndex = 0;
            this.connections_tc.Size = new System.Drawing.Size(527, 331);
            this.connections_tc.TabIndex = 0;
            // 
            // cmd_btn
            // 
            this.cmd_btn.Enabled = false;
            this.cmd_btn.Location = new System.Drawing.Point(427, 14);
            this.cmd_btn.Name = "cmd_btn";
            this.cmd_btn.Size = new System.Drawing.Size(80, 30);
            this.cmd_btn.TabIndex = 8;
            this.cmd_btn.Text = "Command";
            this.cmd_btn.UseVisualStyleBackColor = true;
            this.cmd_btn.Click += new System.EventHandler(this.cmd_btn_Click);
            // 
            // view_btn
            // 
            this.view_btn.Enabled = false;
            this.view_btn.Location = new System.Drawing.Point(341, 14);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(80, 30);
            this.view_btn.TabIndex = 5;
            this.view_btn.Text = "Visionner";
            this.view_btn.UseVisualStyleBackColor = true;
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Enabled = false;
            this.disconnect_btn.Location = new System.Drawing.Point(12, 50);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(80, 30);
            this.disconnect_btn.TabIndex = 1;
            this.disconnect_btn.Text = "Déconnexion";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Enabled = false;
            this.connect_btn.Location = new System.Drawing.Point(12, 14);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(80, 30);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connexion";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.créerToolStripMenuItem.Text = "&Créer";
            this.créerToolStripMenuItem.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.supprimerToolStripMenuItem.Text = "&Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // LenController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 451);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(535, 485);
            this.Name = "LenController";
            this.ShowIcon = false;
            this.Text = "Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LenHandler_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.Button cmd_btn;
        private System.Windows.Forms.TabControl connections_tc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

