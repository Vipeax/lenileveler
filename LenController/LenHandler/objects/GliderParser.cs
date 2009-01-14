using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LenHandler.objects
{
    public class GliderParser
    {
        #region Variables de classe

        private List<string> _log;

        private GliderImage _lastImage;

        private GliderLoots _loots;
        private GliderStatus _status;
        private GliderImage _image;

        public delegate void Event_ImageParsing();
        public event Event_ImageParsing ImageParsing;

        public delegate void Event_ImageParsed();
        public event Event_ImageParsed ImageParsed;

        #endregion


        #region Constructeurs

        public GliderParser()
        {
            _log = new List<string>();

            _lastImage = null;

            _loots = new GliderLoots();
            _status = new GliderStatus();
            _image = new GliderImage();
            _image.Parsed += new GliderImage.Event_Parsed(_imageParsed);
            _image.Parsing += new GliderImage.Event_Parsing(_imageParsing);
        }

        #endregion


        #region Functions

        public List<string> Log
        {
            get { return _log; }
        }

        public GliderLoots Loots
        {
            get { return _loots; }
        }

        public GliderStatus Status
        {
            get { return _status; }
        }

        public void Add(string log)
        {
            Parse(log);
        }

        public Image GetLastImage(bool keep)
        {
            return _image.GetLast(keep);
        }

        public Image GetLastImage()
        {
            return GetLastImage(false);
        }

        private void Parse(string log)
        {
            if (_image.CanParse(log))
            {
                _image.Parse(log);
            }
            else if (_loots.CanParse(log))
            {
                _loots.Parse(log);
            }
            else if (_status.CanParse(log))
            {
                _status.Parse(log);
            }
            else
            {
                _log.Add(DateTime.Now.ToString() + ": " + log);
            }
        }

        private void _imageParsing()
        {
            ImageParsing();
        }

        private void _imageParsed()
        {
            ImageParsed();
        }


        #endregion
    }
}
