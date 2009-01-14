namespace LenHandler.forms
{
    partial class LogForm
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
            this.log_lst = new System.Windows.Forms.ListBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_lst
            // 
            this.log_lst.FormattingEnabled = true;
            this.log_lst.Location = new System.Drawing.Point(12, 12);
            this.log_lst.Name = "log_lst";
            this.log_lst.Size = new System.Drawing.Size(559, 459);
            this.log_lst.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.close_btn.Location = new System.Drawing.Point(479, 485);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(92, 23);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "&Fermer";
            this.close_btn.UseVisualStyleBackColor = true;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 520);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.log_lst);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(588, 522);
            this.Name = "LogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox log_lst;
        private System.Windows.Forms.Button close_btn;
    }
}