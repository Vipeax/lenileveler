using System;
using System.Collections.Generic;
using System.Text;

namespace LenHandler.objects
{
    public class GliderLoots
    {

        #region Variables de classe

        private int _po;
        private int _ps;
        private int _pc;

        private GliderLoot _lastLoot;
        private List<GliderLoot> _greyLoot;
        private List<GliderLoot> _whiteLoot;
        private List<GliderLoot> _greenLoot;
        private List<GliderLoot> _blueLoot;
        private List<GliderLoot> _purpleLoot;

        #endregion


        #region Constructeurs

        public GliderLoots()
        {
            _po = 0;
            _ps = 0;
            _pc = 0;

            _lastLoot = null;
            _greyLoot = new List<GliderLoot>();
            _whiteLoot = new List<GliderLoot>();
            _greenLoot = new List<GliderLoot>();
            _blueLoot = new List<GliderLoot>();
            _purpleLoot = new List<GliderLoot>();
        }

        #endregion


        #region

        public int PO
        {
            get { return _po; }
        }

        public int PS
        {
            get { return _po; }
        }

        public int PC
        {
            get { return _po; }
        }

        public GliderLoot LastLoot
        {
            get { return _lastLoot; }
        }

        public List<GliderLoot> GreyLoot
        {
            get { return _greyLoot; }
        }

        public List<GliderLoot> WhiteLoot
        {
            get { return _whiteLoot; }
        }

        public List<GliderLoot> GreenLoot
        {
            get { return _greenLoot; }
        }

        public List<GliderLoot> BlueLoot
        {
            get { return _blueLoot; }
        }

        public List<GliderLoot> PurpleLoot
        {
            get { return _purpleLoot; }
        }

        public bool CanParse(string log)
        {
            // Log is a loot
            return false;
        }

        public void Parse(string log)
        {
            // Parse loot
        }

        #endregion
    }
}
