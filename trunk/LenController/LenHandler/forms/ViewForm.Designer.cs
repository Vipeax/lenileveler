namespace LenHandler.forms
{
    partial class ViewForm
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
            this.screen_pct = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.main_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.img_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.fr_lbl = new System.Windows.Forms.Label();
            this.fr_txt = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.options_gb = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.screen_pct)).BeginInit();
            this.main_typnl.SuspendLayout();
            this.img_typnl.SuspendLayout();
            this.options_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen_pct
            // 
            this.screen_pct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen_pct.Location = new System.Drawing.Point(103, 3);
            this.screen_pct.Name = "screen_pct";
            this.screen_pct.Size = new System.Drawing.Size(723, 566);
            this.screen_pct.TabIndex = 0;
            this.screen_pct.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.Location = new System.Drawing.Point(757, 581);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 27);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "&Fermer";
            this.close_btn.UseVisualStyleBackColor = true;
            // 
            // main_typnl
            // 
            this.main_typnl.ColumnCount = 1;
            this.main_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_typnl.Controls.Add(this.img_typnl, 0, 0);
            this.main_typnl.Controls.Add(this.close_btn, 0, 1);
            this.main_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_typnl.Location = new System.Drawing.Point(0, 0);
            this.main_typnl.Name = "main_typnl";
            this.main_typnl.RowCount = 2;
            this.main_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.main_typnl.Size = new System.Drawing.Size(835, 611);
            this.main_typnl.TabIndex = 2;
            // 
            // img_typnl
            // 
            this.img_typnl.ColumnCount = 2;
            this.img_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.img_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.img_typnl.Controls.Add(this.screen_pct, 1, 0);
            this.img_typnl.Controls.Add(this.options_gb, 0, 0);
            this.img_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_typnl.Location = new System.Drawing.Point(3, 3);
            this.img_typnl.Name = "img_typnl";
            this.img_typnl.RowCount = 1;
            this.img_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.img_typnl.Size = new System.Drawing.Size(829, 572);
            this.img_typnl.TabIndex = 3;
            // 
            // fr_lbl
            // 
            this.fr_lbl.AutoSize = true;
            this.fr_lbl.Location = new System.Drawing.Point(6, 25);
            this.fr_lbl.Name = "fr_lbl";
            this.fr_lbl.Size = new System.Drawing.Size(68, 13);
            this.fr_lbl.TabIndex = 0;
            this.fr_lbl.Text = "Frame Rate :";
            // 
            // fr_txt
            // 
            this.fr_txt.Location = new System.Drawing.Point(9, 41);
            this.fr_txt.Name = "fr_txt";
            this.fr_txt.Size = new System.Drawing.Size(65, 20);
            this.fr_txt.TabIndex = 1;
            this.fr_txt.Text = "25";
            this.fr_txt.TextChanged += new System.EventHandler(this.fr_txt_TextChanged);
            // 
            // start_btn
            // 
            this.start_btn.Enabled = false;
            this.start_btn.Location = new System.Drawing.Point(7, 156);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 32);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Démarrer";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Enabled = false;
            this.stop_btn.Location = new System.Drawing.Point(7, 194);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 32);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Text = "Arrêter";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // options_gb
            // 
            this.options_gb.Controls.Add(this.start_btn);
            this.options_gb.Controls.Add(this.fr_txt);
            this.options_gb.Controls.Add(this.stop_btn);
            this.options_gb.Controls.Add(this.fr_lbl);
            this.options_gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.options_gb.Location = new System.Drawing.Point(3, 3);
            this.options_gb.Name = "options_gb";
            this.options_gb.Size = new System.Drawing.Size(94, 566);
            this.options_gb.TabIndex = 4;
            this.options_gb.TabStop = false;
            this.options_gb.Text = "Options";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 611);
            this.Controls.Add(this.main_typnl);
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Visionnement";
            ((System.ComponentModel.ISupportInitialize)(this.screen_pct)).EndInit();
            this.main_typnl.ResumeLayout(false);
            this.img_typnl.ResumeLayout(false);
            this.options_gb.ResumeLayout(false);
            this.options_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screen_pct;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TableLayoutPanel main_typnl;
        private System.Windows.Forms.TableLayoutPanel img_typnl;
        private System.Windows.Forms.TextBox fr_txt;
        private System.Windows.Forms.Label fr_lbl;
        private System.Windows.Forms.GroupBox options_gb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
    }
}