using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LenHandler.objects
{

    public class TabPage : System.Windows.Forms.TabPage
    {

        #region ContentElements

        private System.Windows.Forms.TabControl connection_tc;
        private System.Windows.Forms.TabPage general_tp;
        private System.Windows.Forms.TabPage log_tp;
        private System.Windows.Forms.Label kills_lbl;
        private System.Windows.Forms.Label kills_val;
        private System.Windows.Forms.GroupBox kld_gb;
        private System.Windows.Forms.Label lvlup_lbl;
        private System.Windows.Forms.Label lvlup_val;
        private System.Windows.Forms.Label xph_lbl;
        private System.Windows.Forms.Label xph_val;
        private System.Windows.Forms.Label death_lbl;
        private System.Windows.Forms.Label death_val;
        private System.Windows.Forms.Label loots_lbl;
        private System.Windows.Forms.Label loots_val;
        private System.Windows.Forms.GroupBox xp_gb;
        private System.Windows.Forms.Label xp_lbl;
        private System.Windows.Forms.Label xp_val;
        private System.Windows.Forms.TableLayoutPanel xp_typnl;
        private System.Windows.Forms.TableLayoutPanel kld_typnl;
        private System.Windows.Forms.GroupBox loots_gb;
        private System.Windows.Forms.TableLayoutPanel loots_typnl;
        private System.Windows.Forms.TableLayoutPanel kldxp_typnl;
        private System.Windows.Forms.Panel loots_pnl;
        private System.Windows.Forms.TableLayoutPanel money_typnl;
        private System.Windows.Forms.Label money_pc_val;
        private System.Windows.Forms.Label money_ps_val;
        private System.Windows.Forms.Label money_po_val;
        private System.Windows.Forms.Label money_lbl;
        private System.Windows.Forms.Label lastloot_lbl;
        private System.Windows.Forms.Panel lootgrey_pnl;
        private System.Windows.Forms.Panel lootwhite_pnl;
        private System.Windows.Forms.Panel lootpurple_pnl;
        private System.Windows.Forms.Panel lootblue_pnl;
        private System.Windows.Forms.Panel lootgreen_pnl;
        private System.Windows.Forms.Label lastloot_val;
        private System.Windows.Forms.Label lootgrey_val;
        private System.Windows.Forms.Label lootwhite_val;
        private System.Windows.Forms.Label lootpurple_val;
        private System.Windows.Forms.Label lootblue_val;
        private System.Windows.Forms.Label lootgreen_val;
        private System.Windows.Forms.Panel player_pnl;
        private System.Windows.Forms.GroupBox player_gb;
        private System.Windows.Forms.TableLayoutPanel player_typnl;
        private System.Windows.Forms.Label name_val;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label class_lbl;
        private System.Windows.Forms.Label level_lbl;
        private System.Windows.Forms.Label class_val;
        private System.Windows.Forms.Label level_val;
        private System.Windows.Forms.TabPage chat_tp;
        private System.Windows.Forms.ListBox log_lst;
        private System.Windows.Forms.TableLayoutPanel chat_typnl;
        private System.Windows.Forms.TableLayoutPanel currentchat_typnl;
        private System.Windows.Forms.ListBox currentchat_lst;
        private System.Windows.Forms.TextBox chatmsg_txt;
        private System.Windows.Forms.ListBox chat_lst;
        private System.Windows.Forms.Label session_lbl;
        private System.Windows.Forms.Label session_val;

        #endregion


        #region Variables de classes

        private Connection _connection;
        private Timer _logTimer;
        private Timer _updateTimer;
        private List<string> _updatedDatas;

        #endregion


        #region Constructeurs

        public TabPage(Connection connection) : base()
        {
            InitializeComponent();
            _connection = connection;
            this.Text = " " + _connection.Name + " ";
            _logTimer = new Timer();
            _logTimer.Interval = 500;
            _logTimer.Tick += new System.EventHandler(this.logTimer_Tick);

            _updateTimer = new Timer();
            _updateTimer.Interval = 1000;
            _updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            _updateTimer.Enabled = true;

            _updatedDatas = new List<string>();
        }

        public void InitializeComponent()
        {
            this.connection_tc = new System.Windows.Forms.TabControl();

            this.general_tp = new System.Windows.Forms.TabPage();

            this.loots_pnl = new System.Windows.Forms.Panel();
            this.loots_gb = new System.Windows.Forms.GroupBox();
            this.loots_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.lastloot_val = new System.Windows.Forms.Label();
            this.money_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.money_pc_val = new System.Windows.Forms.Label();
            this.money_ps_val = new System.Windows.Forms.Label();
            this.money_po_val = new System.Windows.Forms.Label();
            this.money_lbl = new System.Windows.Forms.Label();
            this.lastloot_lbl = new System.Windows.Forms.Label();
            this.lootgrey_pnl = new System.Windows.Forms.Panel();
            this.lootgrey_val = new System.Windows.Forms.Label();
            this.lootwhite_pnl = new System.Windows.Forms.Panel();
            this.lootwhite_val = new System.Windows.Forms.Label();
            this.lootpurple_pnl = new System.Windows.Forms.Panel();
            this.lootpurple_val = new System.Windows.Forms.Label();
            this.lootblue_pnl = new System.Windows.Forms.Panel();
            this.lootblue_val = new System.Windows.Forms.Label();
            this.lootgreen_pnl = new System.Windows.Forms.Panel();
            this.lootgreen_val = new System.Windows.Forms.Label();
            this.kldxp_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.kld_gb = new System.Windows.Forms.GroupBox();
            this.kld_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.death_val = new System.Windows.Forms.Label();
            this.death_lbl = new System.Windows.Forms.Label();
            this.loots_val = new System.Windows.Forms.Label();
            this.kills_lbl = new System.Windows.Forms.Label();
            this.kills_val = new System.Windows.Forms.Label();
            this.loots_lbl = new System.Windows.Forms.Label();
            this.xp_gb = new System.Windows.Forms.GroupBox();
            this.xp_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.xph_lbl = new System.Windows.Forms.Label();
            this.xp_val = new System.Windows.Forms.Label();
            this.xp_lbl = new System.Windows.Forms.Label();
            this.xph_val = new System.Windows.Forms.Label();
            this.lvlup_lbl = new System.Windows.Forms.Label();
            this.lvlup_val = new System.Windows.Forms.Label();
            this.player_pnl = new System.Windows.Forms.Panel();
            this.player_gb = new System.Windows.Forms.GroupBox();
            this.player_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.class_val = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.class_lbl = new System.Windows.Forms.Label();
            this.level_val = new System.Windows.Forms.Label();
            this.level_lbl = new System.Windows.Forms.Label();
            this.name_val = new System.Windows.Forms.Label();
            this.session_lbl = new System.Windows.Forms.Label();
            this.session_val = new System.Windows.Forms.Label();

            this.log_tp = new System.Windows.Forms.TabPage();
            this.log_lst = new System.Windows.Forms.ListBox();

            this.chat_tp = new System.Windows.Forms.TabPage();
            this.chat_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.currentchat_typnl = new System.Windows.Forms.TableLayoutPanel();
            this.chatmsg_txt = new System.Windows.Forms.TextBox();
            this.currentchat_lst = new System.Windows.Forms.ListBox();
            this.chat_lst = new System.Windows.Forms.ListBox();

            // 
            // connection_tc
            // 
            this.connection_tc.Controls.Add(this.general_tp);
            this.connection_tc.Controls.Add(this.chat_tp);
            this.connection_tc.Controls.Add(this.log_tp);
            this.connection_tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connection_tc.Location = new System.Drawing.Point(3, 3);
            this.connection_tc.Name = "connection_tc";
            this.connection_tc.SelectedIndex = 0;
            this.connection_tc.Size = new System.Drawing.Size(513, 299);
            this.connection_tc.TabIndex = 0;
            this.connection_tc.SelectedIndexChanged += new System.EventHandler(this.connection_tc_SelectedIndexChanged);

            // 
            // general_tp
            // 
            this.general_tp.Controls.Add(this.loots_pnl);
            this.general_tp.Controls.Add(this.kldxp_typnl);
            this.general_tp.Controls.Add(this.player_pnl);
            this.general_tp.Location = new System.Drawing.Point(4, 22);
            this.general_tp.Name = "general_tp";
            this.general_tp.Padding = new System.Windows.Forms.Padding(3);
            this.general_tp.Size = new System.Drawing.Size(505, 273);
            this.general_tp.TabIndex = 0;
            this.general_tp.Text = "Général";
            this.general_tp.UseVisualStyleBackColor = true;
            // 
            // loots_pnl
            // 
            this.loots_pnl.Controls.Add(this.loots_gb);
            this.loots_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.loots_pnl.Location = new System.Drawing.Point(3, 145);
            this.loots_pnl.Name = "loots_pnl";
            this.loots_pnl.Size = new System.Drawing.Size(499, 122);
            this.loots_pnl.TabIndex = 15;
            // 
            // loots_gb
            // 
            this.loots_gb.Controls.Add(this.loots_typnl);
            this.loots_gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loots_gb.Location = new System.Drawing.Point(0, 0);
            this.loots_gb.Name = "loots_gb";
            this.loots_gb.Size = new System.Drawing.Size(499, 122);
            this.loots_gb.TabIndex = 13;
            this.loots_gb.TabStop = false;
            this.loots_gb.Text = "Loots";
            // 
            // loots_typnl
            // 
            this.loots_typnl.ColumnCount = 3;
            this.loots_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.loots_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loots_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.loots_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.loots_typnl.Controls.Add(this.lastloot_val, 1, 1);
            this.loots_typnl.Controls.Add(this.money_typnl, 1, 0);
            this.loots_typnl.Controls.Add(this.money_lbl, 0, 0);
            this.loots_typnl.Controls.Add(this.lastloot_lbl, 0, 1);
            this.loots_typnl.Controls.Add(this.lootgrey_pnl, 2, 0);
            this.loots_typnl.Controls.Add(this.lootwhite_pnl, 2, 1);
            this.loots_typnl.Controls.Add(this.lootpurple_pnl, 2, 4);
            this.loots_typnl.Controls.Add(this.lootblue_pnl, 2, 3);
            this.loots_typnl.Controls.Add(this.lootgreen_pnl, 2, 2);
            this.loots_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loots_typnl.Location = new System.Drawing.Point(3, 16);
            this.loots_typnl.Name = "loots_typnl";
            this.loots_typnl.RowCount = 5;
            this.loots_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loots_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loots_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loots_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loots_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loots_typnl.Size = new System.Drawing.Size(493, 103);
            this.loots_typnl.TabIndex = 0;
            // 
            // lastloot_val
            // 
            this.lastloot_val.AutoSize = true;
            this.lastloot_val.Location = new System.Drawing.Point(93, 20);
            this.lastloot_val.Name = "lastloot_val";
            this.lastloot_val.Size = new System.Drawing.Size(37, 13);
            this.lastloot_val.TabIndex = 16;
            this.lastloot_val.Text = "aucun";
            // 
            // money_typnl
            // 
            this.money_typnl.ColumnCount = 3;
            this.money_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.money_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.money_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.money_typnl.Controls.Add(this.money_pc_val, 2, 0);
            this.money_typnl.Controls.Add(this.money_ps_val, 1, 0);
            this.money_typnl.Controls.Add(this.money_po_val, 0, 0);
            this.money_typnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.money_typnl.Location = new System.Drawing.Point(90, 0);
            this.money_typnl.Margin = new System.Windows.Forms.Padding(0);
            this.money_typnl.Name = "money_typnl";
            this.money_typnl.RowCount = 1;
            this.money_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.money_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.money_typnl.Size = new System.Drawing.Size(161, 20);
            this.money_typnl.TabIndex = 16;
            // 
            // money_pc_val
            // 
            this.money_pc_val.AutoSize = true;
            this.money_pc_val.Location = new System.Drawing.Point(109, 0);
            this.money_pc_val.Name = "money_pc_val";
            this.money_pc_val.Size = new System.Drawing.Size(13, 13);
            this.money_pc_val.TabIndex = 5;
            this.money_pc_val.Text = "0";
            // 
            // money_ps_val
            // 
            this.money_ps_val.AutoSize = true;
            this.money_ps_val.Location = new System.Drawing.Point(56, 0);
            this.money_ps_val.Name = "money_ps_val";
            this.money_ps_val.Size = new System.Drawing.Size(13, 13);
            this.money_ps_val.TabIndex = 4;
            this.money_ps_val.Text = "0";
            // 
            // money_po_val
            // 
            this.money_po_val.AutoSize = true;
            this.money_po_val.Location = new System.Drawing.Point(3, 0);
            this.money_po_val.Name = "money_po_val";
            this.money_po_val.Size = new System.Drawing.Size(13, 13);
            this.money_po_val.TabIndex = 3;
            this.money_po_val.Text = "0";
            // 
            // money_lbl
            // 
            this.money_lbl.AutoSize = true;
            this.money_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.money_lbl.Location = new System.Drawing.Point(43, 0);
            this.money_lbl.Name = "money_lbl";
            this.money_lbl.Size = new System.Drawing.Size(44, 20);
            this.money_lbl.TabIndex = 1;
            this.money_lbl.Text = "Argent :";
            // 
            // lastloot_lbl
            // 
            this.lastloot_lbl.AutoSize = true;
            this.lastloot_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastloot_lbl.Location = new System.Drawing.Point(20, 20);
            this.lastloot_lbl.Name = "lastloot_lbl";
            this.lastloot_lbl.Size = new System.Drawing.Size(67, 20);
            this.lastloot_lbl.TabIndex = 17;
            this.lastloot_lbl.Text = "Dernier loot :";
            // 
            // lootgrey_pnl
            // 
            this.lootgrey_pnl.BackColor = System.Drawing.Color.Gray;
            this.lootgrey_pnl.Controls.Add(this.lootgrey_val);
            this.lootgrey_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lootgrey_pnl.Location = new System.Drawing.Point(403, 0);
            this.lootgrey_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.lootgrey_pnl.Name = "lootgrey_pnl";
            this.lootgrey_pnl.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.lootgrey_pnl.Size = new System.Drawing.Size(90, 20);
            this.lootgrey_pnl.TabIndex = 16;
            // 
            // lootgrey_val
            // 
            this.lootgrey_val.AutoSize = true;
            this.lootgrey_val.Dock = System.Windows.Forms.DockStyle.Right;
            this.lootgrey_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lootgrey_val.Location = new System.Drawing.Point(71, 3);
            this.lootgrey_val.Name = "lootgrey_val";
            this.lootgrey_val.Size = new System.Drawing.Size(14, 13);
            this.lootgrey_val.TabIndex = 17;
            this.lootgrey_val.Text = "0";
            this.lootgrey_val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lootwhite_pnl
            // 
            this.lootwhite_pnl.BackColor = System.Drawing.Color.White;
            this.lootwhite_pnl.Controls.Add(this.lootwhite_val);
            this.lootwhite_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lootwhite_pnl.Location = new System.Drawing.Point(403, 20);
            this.lootwhite_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.lootwhite_pnl.Name = "lootwhite_pnl";
            this.lootwhite_pnl.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.lootwhite_pnl.Size = new System.Drawing.Size(90, 20);
            this.lootwhite_pnl.TabIndex = 17;
            // 
            // lootwhite_val
            // 
            this.lootwhite_val.AutoSize = true;
            this.lootwhite_val.Dock = System.Windows.Forms.DockStyle.Right;
            this.lootwhite_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lootwhite_val.Location = new System.Drawing.Point(71, 3);
            this.lootwhite_val.Name = "lootwhite_val";
            this.lootwhite_val.Size = new System.Drawing.Size(14, 13);
            this.lootwhite_val.TabIndex = 18;
            this.lootwhite_val.Text = "0";
            this.lootwhite_val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lootpurple_pnl
            // 
            this.lootpurple_pnl.BackColor = System.Drawing.Color.Purple;
            this.lootpurple_pnl.Controls.Add(this.lootpurple_val);
            this.lootpurple_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lootpurple_pnl.Location = new System.Drawing.Point(403, 80);
            this.lootpurple_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.lootpurple_pnl.Name = "lootpurple_pnl";
            this.lootpurple_pnl.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.lootpurple_pnl.Size = new System.Drawing.Size(90, 23);
            this.lootpurple_pnl.TabIndex = 20;
            // 
            // lootpurple_val
            // 
            this.lootpurple_val.AutoSize = true;
            this.lootpurple_val.Dock = System.Windows.Forms.DockStyle.Right;
            this.lootpurple_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lootpurple_val.Location = new System.Drawing.Point(71, 3);
            this.lootpurple_val.Name = "lootpurple_val";
            this.lootpurple_val.Size = new System.Drawing.Size(14, 13);
            this.lootpurple_val.TabIndex = 21;
            this.lootpurple_val.Text = "0";
            this.lootpurple_val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lootblue_pnl
            // 
            this.lootblue_pnl.BackColor = System.Drawing.Color.Blue;
            this.lootblue_pnl.Controls.Add(this.lootblue_val);
            this.lootblue_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lootblue_pnl.Location = new System.Drawing.Point(403, 60);
            this.lootblue_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.lootblue_pnl.Name = "lootblue_pnl";
            this.lootblue_pnl.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.lootblue_pnl.Size = new System.Drawing.Size(90, 20);
            this.lootblue_pnl.TabIndex = 19;
            // 
            // lootblue_val
            // 
            this.lootblue_val.AutoSize = true;
            this.lootblue_val.Dock = System.Windows.Forms.DockStyle.Right;
            this.lootblue_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lootblue_val.Location = new System.Drawing.Point(71, 3);
            this.lootblue_val.Name = "lootblue_val";
            this.lootblue_val.Size = new System.Drawing.Size(14, 13);
            this.lootblue_val.TabIndex = 20;
            this.lootblue_val.Text = "0";
            this.lootblue_val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lootgreen_pnl
            // 
            this.lootgreen_pnl.BackColor = System.Drawing.Color.Green;
            this.lootgreen_pnl.Controls.Add(this.lootgreen_val);
            this.lootgreen_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lootgreen_pnl.Location = new System.Drawing.Point(403, 40);
            this.lootgreen_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.lootgreen_pnl.Name = "lootgreen_pnl";
            this.lootgreen_pnl.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.lootgreen_pnl.Size = new System.Drawing.Size(90, 20);
            this.lootgreen_pnl.TabIndex = 18;
            // 
            // lootgreen_val
            // 
            this.lootgreen_val.AutoSize = true;
            this.lootgreen_val.Dock = System.Windows.Forms.DockStyle.Right;
            this.lootgreen_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lootgreen_val.Location = new System.Drawing.Point(71, 3);
            this.lootgreen_val.Name = "lootgreen_val";
            this.lootgreen_val.Size = new System.Drawing.Size(14, 13);
            this.lootgreen_val.TabIndex = 19;
            this.lootgreen_val.Text = "0";
            this.lootgreen_val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kldxp_typnl
            // 
            this.kldxp_typnl.ColumnCount = 2;
            this.kldxp_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kldxp_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kldxp_typnl.Controls.Add(this.kld_gb, 0, 0);
            this.kldxp_typnl.Controls.Add(this.xp_gb, 1, 0);
            this.kldxp_typnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.kldxp_typnl.Location = new System.Drawing.Point(3, 45);
            this.kldxp_typnl.Name = "kldxp_typnl";
            this.kldxp_typnl.RowCount = 1;
            this.kldxp_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kldxp_typnl.Size = new System.Drawing.Size(499, 100);
            this.kldxp_typnl.TabIndex = 14;
            // 
            // kld_gb
            // 
            this.kld_gb.Controls.Add(this.kld_typnl);
            this.kld_gb.Location = new System.Drawing.Point(3, 3);
            this.kld_gb.Name = "kld_gb";
            this.kld_gb.Size = new System.Drawing.Size(240, 90);
            this.kld_gb.TabIndex = 2;
            this.kld_gb.TabStop = false;
            this.kld_gb.Text = "KLD";
            // 
            // kld_typnl
            // 
            this.kld_typnl.ColumnCount = 2;
            this.kld_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.kld_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.kld_typnl.Controls.Add(this.death_val, 1, 2);
            this.kld_typnl.Controls.Add(this.death_lbl, 0, 2);
            this.kld_typnl.Controls.Add(this.loots_val, 1, 1);
            this.kld_typnl.Controls.Add(this.kills_lbl, 0, 0);
            this.kld_typnl.Controls.Add(this.kills_val, 1, 0);
            this.kld_typnl.Controls.Add(this.loots_lbl, 0, 1);
            this.kld_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kld_typnl.Location = new System.Drawing.Point(3, 16);
            this.kld_typnl.Name = "kld_typnl";
            this.kld_typnl.RowCount = 3;
            this.kld_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kld_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kld_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kld_typnl.Size = new System.Drawing.Size(234, 71);
            this.kld_typnl.TabIndex = 13;
            // 
            // death_val
            // 
            this.death_val.AutoSize = true;
            this.death_val.Location = new System.Drawing.Point(93, 40);
            this.death_val.Name = "death_val";
            this.death_val.Size = new System.Drawing.Size(13, 13);
            this.death_val.TabIndex = 5;
            this.death_val.Text = "0";
            // 
            // death_lbl
            // 
            this.death_lbl.AutoSize = true;
            this.death_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.death_lbl.Location = new System.Drawing.Point(48, 40);
            this.death_lbl.Name = "death_lbl";
            this.death_lbl.Size = new System.Drawing.Size(39, 31);
            this.death_lbl.TabIndex = 4;
            this.death_lbl.Text = "Morts :";
            // 
            // loots_val
            // 
            this.loots_val.AutoSize = true;
            this.loots_val.Location = new System.Drawing.Point(93, 20);
            this.loots_val.Name = "loots_val";
            this.loots_val.Size = new System.Drawing.Size(13, 13);
            this.loots_val.TabIndex = 3;
            this.loots_val.Text = "0";
            // 
            // kills_lbl
            // 
            this.kills_lbl.AutoSize = true;
            this.kills_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.kills_lbl.Location = new System.Drawing.Point(56, 0);
            this.kills_lbl.Name = "kills_lbl";
            this.kills_lbl.Size = new System.Drawing.Size(31, 20);
            this.kills_lbl.TabIndex = 0;
            this.kills_lbl.Text = "Kills :";
            // 
            // kills_val
            // 
            this.kills_val.AutoSize = true;
            this.kills_val.Location = new System.Drawing.Point(93, 0);
            this.kills_val.Name = "kills_val";
            this.kills_val.Size = new System.Drawing.Size(13, 13);
            this.kills_val.TabIndex = 1;
            this.kills_val.Text = "0";
            // 
            // loots_lbl
            // 
            this.loots_lbl.AutoSize = true;
            this.loots_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.loots_lbl.Location = new System.Drawing.Point(48, 20);
            this.loots_lbl.Name = "loots_lbl";
            this.loots_lbl.Size = new System.Drawing.Size(39, 20);
            this.loots_lbl.TabIndex = 2;
            this.loots_lbl.Text = "Loots :";
            // 
            // xp_gb
            // 
            this.xp_gb.Controls.Add(this.xp_typnl);
            this.xp_gb.Location = new System.Drawing.Point(252, 3);
            this.xp_gb.Name = "xp_gb";
            this.xp_gb.Size = new System.Drawing.Size(240, 90);
            this.xp_gb.TabIndex = 12;
            this.xp_gb.TabStop = false;
            this.xp_gb.Text = "XP";
            // 
            // xp_typnl
            // 
            this.xp_typnl.ColumnCount = 2;
            this.xp_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.xp_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.xp_typnl.Controls.Add(this.xph_lbl, 0, 0);
            this.xp_typnl.Controls.Add(this.xp_val, 1, 2);
            this.xp_typnl.Controls.Add(this.xp_lbl, 0, 2);
            this.xp_typnl.Controls.Add(this.xph_val, 1, 0);
            this.xp_typnl.Controls.Add(this.lvlup_lbl, 0, 1);
            this.xp_typnl.Controls.Add(this.lvlup_val, 1, 1);
            this.xp_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xp_typnl.Location = new System.Drawing.Point(3, 16);
            this.xp_typnl.Name = "xp_typnl";
            this.xp_typnl.RowCount = 3;
            this.xp_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.xp_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.xp_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.xp_typnl.Size = new System.Drawing.Size(234, 71);
            this.xp_typnl.TabIndex = 13;
            // 
            // xph_lbl
            // 
            this.xph_lbl.AutoSize = true;
            this.xph_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.xph_lbl.Location = new System.Drawing.Point(26, 0);
            this.xph_lbl.Name = "xph_lbl";
            this.xph_lbl.Size = new System.Drawing.Size(61, 20);
            this.xph_lbl.TabIndex = 6;
            this.xph_lbl.Text = "XP/Heure :";
            // 
            // xp_val
            // 
            this.xp_val.AutoSize = true;
            this.xp_val.Location = new System.Drawing.Point(93, 40);
            this.xp_val.Name = "xp_val";
            this.xp_val.Size = new System.Drawing.Size(47, 13);
            this.xp_val.TabIndex = 11;
            this.xp_val.Text = "0/0 (0%)";
            // 
            // xp_lbl
            // 
            this.xp_lbl.AutoSize = true;
            this.xp_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.xp_lbl.Location = new System.Drawing.Point(21, 40);
            this.xp_lbl.Name = "xp_lbl";
            this.xp_lbl.Size = new System.Drawing.Size(66, 31);
            this.xp_lbl.TabIndex = 10;
            this.xp_lbl.Text = "Expérience :";
            // 
            // xph_val
            // 
            this.xph_val.AutoSize = true;
            this.xph_val.Location = new System.Drawing.Point(93, 0);
            this.xph_val.Name = "xph_val";
            this.xph_val.Size = new System.Drawing.Size(13, 13);
            this.xph_val.TabIndex = 7;
            this.xph_val.Text = "0";
            // 
            // lvlup_lbl
            // 
            this.lvlup_lbl.AutoSize = true;
            this.lvlup_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvlup_lbl.Location = new System.Drawing.Point(15, 20);
            this.lvlup_lbl.Name = "lvlup_lbl";
            this.lvlup_lbl.Size = new System.Drawing.Size(72, 20);
            this.lvlup_lbl.TabIndex = 8;
            this.lvlup_lbl.Text = "Level proch. :";
            // 
            // lvlup_val
            // 
            this.lvlup_val.AutoSize = true;
            this.lvlup_val.Location = new System.Drawing.Point(93, 20);
            this.lvlup_val.Name = "lvlup_val";
            this.lvlup_val.Size = new System.Drawing.Size(13, 13);
            this.lvlup_val.TabIndex = 9;
            this.lvlup_val.Text = "0";
            // 
            // player_pnl
            // 
            this.player_pnl.Controls.Add(this.player_gb);
            this.player_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.player_pnl.Location = new System.Drawing.Point(3, 3);
            this.player_pnl.Name = "player_pnl";
            this.player_pnl.Size = new System.Drawing.Size(499, 42);
            this.player_pnl.TabIndex = 17;
            // 
            // player_gb
            // 
            this.player_gb.Controls.Add(this.player_typnl);
            this.player_gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_gb.Location = new System.Drawing.Point(0, 0);
            this.player_gb.Name = "player_gb";
            this.player_gb.Size = new System.Drawing.Size(499, 42);
            this.player_gb.TabIndex = 16;
            this.player_gb.TabStop = false;
            this.player_gb.Text = "Personnage";
            // 
            // player_typnl
            // 
            this.player_typnl.ColumnCount = 8;
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.player_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.player_typnl.Controls.Add(this.class_val, 5, 0);
            this.player_typnl.Controls.Add(this.name_lbl, 0, 0);
            this.player_typnl.Controls.Add(this.class_lbl, 4, 0);
            this.player_typnl.Controls.Add(this.level_val, 2, 0);
            this.player_typnl.Controls.Add(this.level_lbl, 2, 0);
            this.player_typnl.Controls.Add(this.name_val, 1, 0);
            this.player_typnl.Controls.Add(this.session_lbl, 6, 0);
            this.player_typnl.Controls.Add(this.session_val, 7, 0);
            this.player_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_typnl.Location = new System.Drawing.Point(3, 16);
            this.player_typnl.Name = "player_typnl";
            this.player_typnl.RowCount = 1;
            this.player_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.player_typnl.Size = new System.Drawing.Size(927, 23);
            this.player_typnl.TabIndex = 0;
            // 
            // class_val
            // 
            this.class_val.AutoSize = true;
            this.class_val.Location = new System.Drawing.Point(391, 0);
            this.class_val.Name = "class_val";
            this.class_val.Size = new System.Drawing.Size(43, 13);
            this.class_val.TabIndex = 18;
            this.class_val.Text = "aucune";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.name_lbl.Location = new System.Drawing.Point(22, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 23);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Nom :";
            // 
            // class_lbl
            // 
            this.class_lbl.AutoSize = true;
            this.class_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.class_lbl.Location = new System.Drawing.Point(341, 0);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(44, 23);
            this.class_lbl.TabIndex = 2;
            this.class_lbl.Text = "Classe :";
            // 
            // level_val
            // 
            this.level_val.AutoSize = true;
            this.level_val.Dock = System.Windows.Forms.DockStyle.Right;
            this.level_val.Location = new System.Drawing.Point(174, 0);
            this.level_val.Name = "level_val";
            this.level_val.Size = new System.Drawing.Size(47, 23);
            this.level_val.TabIndex = 4;
            this.level_val.Text = "Niveau :";
            // 
            // level_lbl
            // 
            this.level_lbl.AutoSize = true;
            this.level_lbl.Location = new System.Drawing.Point(227, 0);
            this.level_lbl.Name = "level_lbl";
            this.level_lbl.Size = new System.Drawing.Size(13, 13);
            this.level_lbl.TabIndex = 1;
            this.level_lbl.Text = "1";
            // 
            // name_val
            // 
            this.name_val.AutoSize = true;
            this.name_val.Location = new System.Drawing.Point(63, 0);
            this.name_val.Name = "name_val";
            this.name_val.Size = new System.Drawing.Size(37, 13);
            this.name_val.TabIndex = 3;
            this.name_val.Text = "aucun";
            // 
            // chat_tp
            // 
            this.chat_tp.Controls.Add(this.chat_typnl);
            this.chat_tp.Location = new System.Drawing.Point(4, 22);
            this.chat_tp.Name = "chat_tp";
            this.chat_tp.Padding = new System.Windows.Forms.Padding(3);
            this.chat_tp.Size = new System.Drawing.Size(505, 273);
            this.chat_tp.TabIndex = 2;
            this.chat_tp.Text = "Chat";
            this.chat_tp.UseVisualStyleBackColor = true;
            // 
            // chat_typnl
            // 
            this.chat_typnl.ColumnCount = 2;
            this.chat_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.chat_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chat_typnl.Controls.Add(this.currentchat_typnl, 1, 0);
            this.chat_typnl.Controls.Add(this.chat_lst, 0, 0);
            this.chat_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat_typnl.Location = new System.Drawing.Point(3, 3);
            this.chat_typnl.Name = "chat_typnl";
            this.chat_typnl.RowCount = 1;
            this.chat_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chat_typnl.Size = new System.Drawing.Size(499, 267);
            this.chat_typnl.TabIndex = 0;
            // 
            // currentchat_typnl
            // 
            this.currentchat_typnl.ColumnCount = 1;
            this.currentchat_typnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.currentchat_typnl.Controls.Add(this.chatmsg_txt, 0, 1);
            this.currentchat_typnl.Controls.Add(this.currentchat_lst, 0, 0);
            this.currentchat_typnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentchat_typnl.Location = new System.Drawing.Point(100, 0);
            this.currentchat_typnl.Margin = new System.Windows.Forms.Padding(0);
            this.currentchat_typnl.Name = "currentchat_typnl";
            this.currentchat_typnl.RowCount = 2;
            this.currentchat_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.currentchat_typnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.currentchat_typnl.Size = new System.Drawing.Size(399, 267);
            this.currentchat_typnl.TabIndex = 9;
            // 
            // chatmsg_txt
            // 
            this.chatmsg_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatmsg_txt.Location = new System.Drawing.Point(3, 240);
            this.chatmsg_txt.Name = "chatmsg_txt";
            this.chatmsg_txt.Size = new System.Drawing.Size(393, 20);
            this.chatmsg_txt.TabIndex = 0;
            // 
            // currentchat_lst
            // 
            this.currentchat_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentchat_lst.FormattingEnabled = true;
            this.currentchat_lst.Location = new System.Drawing.Point(3, 3);
            this.currentchat_lst.Name = "currentchat_lst";
            this.currentchat_lst.Size = new System.Drawing.Size(393, 225);
            this.currentchat_lst.TabIndex = 1;
            // 
            // chat_lst
            // 
            this.chat_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat_lst.FormattingEnabled = true;
            this.chat_lst.Location = new System.Drawing.Point(3, 3);
            this.chat_lst.Name = "chat_lst";
            this.chat_lst.Size = new System.Drawing.Size(94, 251);
            this.chat_lst.TabIndex = 0;
            // 
            // log_tp
            // 
            this.log_tp.Controls.Add(this.log_lst);
            this.log_tp.Location = new System.Drawing.Point(4, 22);
            this.log_tp.Name = "log_tp";
            this.log_tp.Padding = new System.Windows.Forms.Padding(3);
            this.log_tp.Size = new System.Drawing.Size(505, 273);
            this.log_tp.TabIndex = 1;
            this.log_tp.Text = "Log";
            this.log_tp.UseVisualStyleBackColor = true;
            // 
            // log_lst
            // 
            this.log_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_lst.FormattingEnabled = true;
            this.log_lst.Location = new System.Drawing.Point(3, 3);
            this.log_lst.Name = "log_lst";
            this.log_lst.Size = new System.Drawing.Size(499, 264);
            this.log_lst.TabIndex = 0;
            // 
            // session_lbl
            // 
            this.session_lbl.AutoSize = true;
            this.session_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.session_lbl.Location = new System.Drawing.Point(700, 0);
            this.session_lbl.Name = "session_lbl";
            this.session_lbl.Size = new System.Drawing.Size(50, 23);
            this.session_lbl.TabIndex = 19;
            this.session_lbl.Text = "Session :";
            // 
            // session_val
            // 
            this.session_val.AutoSize = true;
            this.session_val.Location = new System.Drawing.Point(756, 0);
            this.session_val.Name = "session_val";
            this.session_val.Size = new System.Drawing.Size(75, 13);
            this.session_val.TabIndex = 20;
            this.session_val.Text = "Non connecté";

            this.Controls.Add(this.connection_tc);
        }

        #endregion


        #region Events

        private void connection_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            _logTimer.Enabled = false;
            if (this.connection_tc.SelectedTab.Name == "log_tp")
            {
                UpdateLog();
                _logTimer.Enabled = true;
            }
        }

        private void logTimer_Tick(object sender, EventArgs e)
        {
            UpdateLog();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateDatas();
        }

        #endregion


        #region Functions

        public void Close()
        {
            if (_connection.Status)
            {
                _connection.Disconnect();
            }
            Parent.Dispose();
        }

        public Connection Connection
        {
            get { return _connection; }
        }

        private void UpdateLog()
        {
            if (_connection.Status)
            {
                List<string> _currentLog = _connection.Log;
                if (_currentLog.Count > 0 && _currentLog.Count > this.log_lst.Items.Count)
                {
                    for (int i = this.log_lst.Items.Count; i < _currentLog.Count; i++)
                    {
                        this.log_lst.Items.Add(_currentLog[i]);
                    }
                    this.log_lst.SelectedIndex = this.log_lst.Items.Count - 1;
                }
            }
        }

        private void UpdateDatas()
        {
            if (_connection.Status)
            {
                List<string> _currentLog = _connection.Log;
                if (_currentLog.Count > _updatedDatas.Count)
                {
                    for (int i = _updatedDatas.Count; i < _currentLog.Count; i++)
                    {
                        _updatedDatas.Add(_currentLog[i]);
                    }
                }
            }
        }

        #endregion
    }
}
