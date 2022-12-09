using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noorani_Clock
{
    class Computting
    {
        private int _Hour;
        private int _Minutes;
        private int _Second;

        public int Hour
        {
            get
            {
                return _Hour;
            }
            set
            {
                _Minutes = value * 60;
                _Second = value * 3600;
                _Hour = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _Minutes;
            }
            set
            {
                if (value > 59)
                    _Hour = value / 60;

                _Second = value * 60;
                _Minutes = value;
            }
        }

        public int Second
        {
            get
            {
                return _Second;
            }
            set
            {
                if (value > 59)
                    _Minutes = value / 60;
                if (value > 3599)
                    _Hour = value / 3600;
                _Second = value;
            }
        }
    }
}
