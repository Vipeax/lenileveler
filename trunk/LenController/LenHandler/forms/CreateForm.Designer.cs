namespace LenHandler.views
{
    partial class CreateForm
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
            this.server_gb = new System.Windows.Forms.GroupBox();
            this.passwd_txt = new System.Windows.Forms.TextBox();
            this.passwd_lbl = new System.Windows.Forms.Label();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.port_lbl = new System.Windows.Forms.Label();
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.ip_lbl = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.global_gb = new System.Windows.Forms.GroupBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.server_gb.SuspendLayout();
            this.global_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // server_gb
            // 
            this.server_gb.Controls.Add(this.passwd_txt);
            this.server_gb.Controls.Add(this.passwd_lbl);
            this.server_gb.Controls.Add(this.port_txt);
            this.server_gb.Controls.Add(this.port_lbl);
            this.server_gb.Controls.Add(this.ip_txt);
            this.server_gb.Controls.Add(this.ip_lbl);
            this.server_gb.Location = new System.Drawing.Point(12, 78);
            this.server_gb.Name = "server_gb";
            this.server_gb.Size = new System.Drawing.Size(251, 129);
            this.server_gb.TabIndex = 0;
            this.server_gb.TabStop = false;
            this.server_gb.Text = "Serveur";
            // 
            // passwd_txt
            // 
            this.passwd_txt.Location = new System.Drawing.Point(89, 94);
            this.passwd_txt.Name = "passwd_txt";
            this.passwd_txt.Size = new System.Drawing.Size(147, 20);
            this.passwd_txt.TabIndex = 4;
            this.passwd_txt.Text = "glipass";
            this.passwd_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwd_txt_KeyPress);
            // 
            // passwd_lbl
            // 
            this.passwd_lbl.AutoSize = true;
            this.passwd_lbl.Location = new System.Drawing.Point(6, 97);
            this.passwd_lbl.Name = "passwd_lbl";
            this.passwd_lbl.Size = new System.Drawing.Size(77, 13);
            this.passwd_lbl.TabIndex = 9;
            this.passwd_lbl.Text = "Mot de passe :";
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(89, 49);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(147, 20);
            this.port_txt.TabIndex = 3;
            this.port_txt.Text = "1301";
            this.port_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.port_txt_KeyPress);
            // 
            // port_lbl
            // 
            this.port_lbl.AutoSize = true;
            this.port_lbl.Location = new System.Drawing.Point(51, 52);
            this.port_lbl.Name = "port_lbl";
            this.port_lbl.Size = new System.Drawing.Size(32, 13);
            this.port_lbl.TabIndex = 5;
            this.port_lbl.Text = "Port :";
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(89, 23);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(147, 20);
            this.ip_txt.TabIndex = 2;
            this.ip_txt.Text = "192.168.125.15";
            this.ip_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ip_txt_KeyPress);
            // 
            // ip_lbl
            // 
            this.ip_lbl.AutoSize = true;
            this.ip_lbl.Location = new System.Drawing.Point(60, 26);
            this.ip_lbl.Name = "ip_lbl";
            this.ip_lbl.Size = new System.Drawing.Size(23, 13);
            this.ip_lbl.TabIndex = 3;
            this.ip_lbl.Text = "IP :";
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(188, 213);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "&Annuler";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(107, 213);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "&Créer";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // global_gb
            // 
            this.global_gb.Controls.Add(this.name_txt);
            this.global_gb.Controls.Add(this.name_lbl);
            this.global_gb.Location = new System.Drawing.Point(12, 12);
            this.global_gb.Name = "global_gb";
            this.global_gb.Size = new System.Drawing.Size(251, 60);
            this.global_gb.TabIndex = 3;
            this.global_gb.TabStop = false;
            this.global_gb.Text = "Général";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(89, 24);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(147, 20);
            this.name_txt.TabIndex = 1;
            this.name_txt.Text = "Gamaya";
            this.name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_txt_KeyPress);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(48, 27);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 5;
            this.name_lbl.Text = "Nom :";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 244);
            this.Controls.Add(this.global_gb);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.server_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateForm";
            this.ShowIcon = false;
            this.Text = "Création";
            this.server_gb.ResumeLayout(false);
            this.server_gb.PerformLayout();
            this.global_gb.ResumeLayout(false);
            this.global_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox server_gb;
        private System.Windows.Forms.TextBox passwd_txt;
        private System.Windows.Forms.Label passwd_lbl;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Label port_lbl;
        private System.Windows.Forms.TextBox ip_txt;
        private System.Windows.Forms.Label ip_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.GroupBox global_gb;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label name_lbl;
    }
}