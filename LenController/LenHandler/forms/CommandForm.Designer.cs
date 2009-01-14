namespace LenHandler.forms
{
    partial class CommandForm
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
            this.send_btn = new System.Windows.Forms.Button();
            this.cmd_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send_btn
            // 
            this.send_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.send_btn.Location = new System.Drawing.Point(305, 12);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 0;
            this.send_btn.Text = "&Envoyer";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // cmd_txt
            // 
            this.cmd_txt.AutoCompleteCustomSource.AddRange(new string[] {
            "/exit",
            "/exitglider",
            "/status",
            "/version",
            "/log",
            "/nolog",
            "/say",
            "/queuekeys",
            "/clearsay",
            "/forcekeys",
            "/holdkey",
            "/releasekey",
            "/grabmouse",
            "/setmouse",
            "/getmouse",
            "/clickmouse",
            "/attach",
            "/startglide",
            "/stopglide",
            "/loadprofile",
            "/capture",
            "/capturecache",
            "/capturescale",
            "/capturequality",
            "/queryconfig",
            "/config",
            "/selectgame",
            "/getgamews",
            "/setgamews",
            "/escapehi"});
            this.cmd_txt.Location = new System.Drawing.Point(12, 12);
            this.cmd_txt.Name = "cmd_txt";
            this.cmd_txt.Size = new System.Drawing.Size(287, 20);
            this.cmd_txt.TabIndex = 1;
            this.cmd_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmd_txt_KeyPress);
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 46);
            this.Controls.Add(this.cmd_txt);
            this.Controls.Add(this.send_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 70);
            this.Name = "CommandForm";
            this.Text = "CommandForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox cmd_txt;
    }
}