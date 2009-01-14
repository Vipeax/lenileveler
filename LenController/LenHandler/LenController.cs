using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LenHandler.objects;
using LenHandler.views;
using LenHandler.forms;

namespace LenHandler
{
    public partial class LenController : Form
    {
        #region Variables de classe

        private static ListView _log = new ListView();

        #endregion

        #region Constructeurs

        public LenController()
        {
            InitializeComponent();
        }

        #endregion


        #region Functions

        private void CheckButton()
        {
            bool _status = false;
            connect_btn.Enabled = false;
            if (connections_tc.Controls.Count > 0)
            {
                _status = ((objects.TabPage)connections_tc.SelectedTab).Connection.Status;
                connect_btn.Enabled = !_status;
            }
            disconnect_btn.Enabled = _status;
            view_btn.Enabled = _status;
            cmd_btn.Enabled = _status;
        }

        private static void Log(string msg)
        {
            _log.Items.Add(msg);
        }

        private Connection getSelectedConnection()
        {
            Connection _conn = null;
            if (connections_tc.Controls.Count > 0)
            {
                _conn = ((objects.TabPage)connections_tc.SelectedTab).Connection;
            }
            return _conn;
        }

        #endregion


        #region Events


        private void connect_btn_Click(object sender, EventArgs e)
        {
            Connection _conn = getSelectedConnection();
            if (_conn != null && !_conn.Status)
            {
                _conn.Connect();
            }
            CheckButton();
        }

        private void LenHandler_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < connections_tc.Controls.Count; i++)
            {
                ((objects.TabPage)connections_tc.Controls[i]).Close();
            }
        }
        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            Connection _conn = getSelectedConnection();
            if (_conn != null && _conn.Status)
            {
                _conn.Disconnect();
            }
            CheckButton();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            Connection _conn = getSelectedConnection();
            if (_conn != null)
            {
                new LogForm(_conn.Log).ShowDialog();
            }
        }

        private void cmd_btn_Click(object sender, EventArgs e)
        {
            Connection _conn = getSelectedConnection();
            if (_conn != null)
            {
                new CommandForm(_conn).ShowDialog();
            }
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection _conn;
            new CreateForm(out _conn).ShowDialog();
            if (_conn.Created)
            {
                _conn.MessageReceived += new Connection.Event_MessageReceived(Log);
                connections_tc.Controls.Add(new objects.TabPage(_conn));
            }
            CheckButton();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connections_tc.Controls.Count > 0)
            {
                ((objects.TabPage)connections_tc.SelectedTab).Close();
            }
            CheckButton();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}