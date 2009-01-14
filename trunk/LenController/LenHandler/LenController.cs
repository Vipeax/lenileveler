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
using System.IO;
using System.Threading;

namespace LenHandler
{
    public partial class LenController : Form
    {
        #region Variables de classe

        private static ListView _log = new ListView();
        private List<Thread> _openThread;

        #endregion

        #region Constructeurs

        public LenController()
        {
            InitializeComponent();
            _openThread = new List<Thread>();
        }

        #endregion


        #region Functions

        private void CheckButton()
        {
            bool _status = false;
            connect_btn.Enabled = false;
            GliderConnection _conn = getSelectedConnection();
            if (_conn != null)
            {
                _status = _conn.Status;
                if (!_conn.Connecting)
                {
                    connect_btn.Image = null;
                }
                else
                {
                    connect_btn.Image = LenHandler.Properties.Resources.loader;
                }
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

        private GliderConnection getSelectedConnection()
        {
            GliderConnection _conn = null;
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
            GliderConnection _conn = getSelectedConnection();
            if (!_conn.Connecting)
            {
                connect_btn.Image = LenHandler.Properties.Resources.loader;
                Thread thread = new Thread(new ThreadStart(_conn.Connect));
                thread.IsBackground = false;
                thread.Start();
                _openThread.Add(thread);
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 500;
                timer.Tick += new System.EventHandler(this.connectTimer_Tick);
                timer.Enabled = true;
            }
        }

        private void LenHandler_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < connections_tc.Controls.Count; i++)
            {
                ((objects.TabPage)connections_tc.Controls[i]).Close();
            }
            for (int i = 0; i < _openThread.Count; i++)
            {
                if (_openThread[i].ThreadState == ThreadState.Running)
                {
                    _openThread[i].Abort();
                }
            }
        }
        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            GliderConnection _conn = getSelectedConnection();
            if (_conn != null && _conn.Status)
            {
                _conn.Disconnect();
            }
            CheckButton();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            GliderConnection _conn = getSelectedConnection();
            if (_conn != null)
            {
                new LogForm(_conn.Log).ShowDialog();
            }
        }

        private void cmd_btn_Click(object sender, EventArgs e)
        {
            GliderConnection _conn = getSelectedConnection();
            if (_conn != null)
            {
                new CommandForm(_conn).ShowDialog();
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            GliderConnection _conn = getSelectedConnection();
            if (_conn != null)
            {
                new ViewForm(_conn).ShowDialog();
            }
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GliderConnection _conn;
            new CreateForm(out _conn).ShowDialog();
            if (_conn.Created)
            {
                _conn.MessageReceived += new GliderConnection.Event_MessageReceived(Log);
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

        private void connectTimer_Tick(object sender, EventArgs e)
        {

            GliderConnection _conn = getSelectedConnection();
            if (_conn != null && !_conn.Connecting)
            {
                System.Windows.Forms.Timer timer = ((System.Windows.Forms.Timer)sender);
                timer.Enabled = false;
                timer.Dispose();
            }
            CheckButton();
        }

        private void connections_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        #endregion

    }
}