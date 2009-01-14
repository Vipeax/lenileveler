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
    public partial class ViewForm : Form
    {
        #region Variables de classes

        private GliderConnection _connection;
        private Timer _timer;
        private Image _last;
        private bool _eventAdded;

        #endregion


        #region Constructeurs

        public ViewForm(GliderConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _timer = new Timer();
            _timer.Interval = 40;
            _timer.Tick += new System.EventHandler(this.timer_Tick);
            _last = null;
            _eventAdded = false;
        }

        #endregion


        #region Functions

        private void Stop()
        {
            _timer.Enabled = false;
            CheckButtons();
        }

        private void Start()
        {
            if(_connection.Status){
                _timer.Enabled = true;
                if(!_eventAdded){
                    _connection.Parser.ImageParsed += new GliderParser.Event_ImageParsed(Parser_ImageParsed);
                }
            }
            CheckButtons();
        }

        private void CheckButtons()
        {
            if (_connection.Status)
            {
                start_btn.Enabled = !_timer.Enabled;
                stop_btn.Enabled = _timer.Enabled;
            }
            else
            {
                start_btn.Enabled = false;
                stop_btn.Enabled = false;
            }
        }

        #endregion


        #region Events

        private void fr_txt_TextChanged(object sender, EventArgs e)
        {
            Stop();
            int interval = _timer.Interval;
            Int16 rate = (Int16)(1000 / interval);
            if(Int16.TryParse(fr_txt.Text, out rate))
            {
                if (rate < 50 && rate > 0)
                {
                    interval = (int)(1000 / rate);
                }
            }
            _timer.Interval = interval;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _connection.Send("/capture");
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Parser_ImageParsed()
        {
            SetImage();
        }

        private void SetImage()
        {
            Image _tmp = _connection.LastImage;
            if (_tmp != null && _tmp != _last)
            {
                _last = _tmp;
                screen_pct.Image = _last;
            }
        }

        #endregion
    }
}