using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Windows.Forms;
using LenHandler.objects;

namespace LenHandler.views
{
    public partial class CreateForm : Form
    {

        #region Variables de classe

        Connection _connection;

        #endregion


        #region Constructeurs

        public CreateForm(out Connection connection)
        {
            InitializeComponent();
            connection = new Connection();
            _connection = connection;
            name_txt.Focus();
        }

        #endregion


        #region Events

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (Create())
            {
                this.Close();
            }
        }

        private void name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            CreateOnReturn(e);
        }

        private void ip_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            CreateOnReturn(e);
        }

        private void port_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            CreateOnReturn(e);
        }

        private void passwd_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            CreateOnReturn(e);
        }

        #endregion


        #region Functions

        private void CreateOnReturn(KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                if (Create())
                {
                    this.Close();
                }
            }
        }

        private bool Create()
        {
            IPAddress _ip;
            Int16 _port = 0;
            IPAddress[] addresslist = null;
            try
            {
                addresslist = Dns.GetHostAddresses(ip_txt.Text);
            }
            catch (Exception)
            {
            }
            if (IPAddress.TryParse(ip_txt.Text, out _ip) || (addresslist != null && addresslist.Length > 0))
            {
                if (_ip == null)
                {
                    _ip = addresslist[0];
                }
                _connection.IP = _ip;
                if (Int16.TryParse(port_txt.Text, out _port))
                {
                    _connection.Port = _port;
                    _connection.Name = name_txt.Text;
                    _connection.Password = passwd_txt.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("Port invalide!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port_txt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Adresse ip/Nom de domaine invalide!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ip_txt.Focus();
            }
            return false;
        }

        #endregion

    }
}