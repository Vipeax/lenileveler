using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace LenHandler.objects
{
    public class GliderImage
    {
        #region Variables de classe

        private Image _lastImage;

        private bool _isParsing;
        private string _parsedData;

        public delegate void Event_Parsing();
        public event Event_Parsing Parsing;

        public delegate void Event_Parsed();
        public event Event_Parsed Parsed;

        #endregion


        #region Constructeurs

        public GliderImage()
        {
            _lastImage = null;
            _isParsing = false;
            _parsedData = "";
        }

        #endregion


        #region Functions

        public bool CanParse(string log)
        {
            // Is first line of an image OR is something else than image stream
            return false;
        }

        public void Parse(string log)
        {
            if (CanParse(log))
            {
                if (_isParsing)
                {
                    _parsedData += log;
                }
                _isParsing = true;
                Parsing();
            }
            else if (_isParsing)
            {
                _lastImage = Image.FromStream(new MemoryStream(ASCIIEncoding.Default.GetBytes(_parsedData)));
                _parsedData = "";
                Parsed();
            }
            else
            {
                _parsedData = "";
            }
        }

        public Image GetLast(bool keepLast)
        {
            Image tmp = _lastImage;
            if (!keepLast)
            {
                _lastImage = null;
            }
            return tmp;
        }

        #endregion
    }
}
