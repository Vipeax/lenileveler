using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LenHandler.forms
{
    public partial class LogForm : Form
    {
        public LogForm(ListView log)
        {
            InitializeComponent();
            if (log != null)
            {
                for (int i = 0; i < log.Items.Count; i++)
                {
                    log_lst.Items.Add(log.Items[i]);
                }
            }
        }
        public LogForm(List<string> log)
        {
            InitializeComponent();
            if (log != null)
            {
                for (int i = 0; i < log.Count; i++)
                {
                    log_lst.Items.Add(log[i]);
                }
            }
        }
    }
}