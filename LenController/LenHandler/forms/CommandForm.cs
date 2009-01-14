using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LenHandler.objects;

namespace LenHandler.forms
{
    public partial class CommandForm : Form
    {
        #region Variable de classe

        private Connection _connection;

        #endregion


        #region Constructeurs

        public CommandForm(Connection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        #endregion


        #region Events

        private void send_btn_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void cmd_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                Send();
                this.Close();
            }
        }

        #endregion


        #region Functions

        private void Send()
        {
            if (cmd_txt.Text.Length > 0)
            {
                _connection.Send(cmd_txt.Text);
            }
        }

        #endregion
    }
}