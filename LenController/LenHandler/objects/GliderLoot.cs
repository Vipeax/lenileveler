using System;
using System.Collections.Generic;
using System.Text;

namespace LenHandler.objects
{
    public enum GliderLootColor
    {
        Grey = 0,
        White = 1,
        Green = 2,
        Blue = 3,
        Purple = 4
    }
    
    public class GliderLoot
    {

        #region Variables de classes

        private GliderLootColor _color;
        private string _name;
        private string _code;

        #endregion


        #region Constructeurs

        public GliderLoot(GliderLootColor Color, string Name, string Code)
        {
            _color = Color;
            _name = Name;
            _code = Code;
        }

        #endregion


        #region Functions

        public string Code
        {
            get { return _code; }
        }

        public string Name
        {
            get { return _name; }
        }

        public GliderLootColor Color
        {
            get { return _color; }
        }

        #endregion
    }
}
