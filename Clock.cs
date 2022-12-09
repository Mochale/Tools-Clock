using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noorani_Clock
{
    class Clock
    {
        public Clock() { }

        /// <summary>
        /// Fill the clock Properties
        /// </summary>
        /// <param name="hour">set hour (intger) </param>
        /// <param name="minute">set minute (integer)</param>
        /// <param name="secound">set secound (integer)</param>
        /// <param name="Am">(True or False) set Clock waht you want</param>
        public Clock(int hour, int minute, int secound, bool am)
        {
            Hour = hour;
            Minute = minute;
            Second = secound;
            AmPM_Enabled = am;
        }

        private bool _am;
        private int _Hour;
        private int _Minute;
        private int _Second;
        private string _amOrpm = "AM";

        public int Hour
        {
            get
            {
                return _Hour;
            }
            set
            {
                _Hour = value;
            }
        }

        public int Minute
        {
            get { return _Minute; }
            set
            {
                if (value > 59)
                {
                    Hour += value / 60;
                    value = value % 60;
                }
                else if (value < 0)
                {
                    Hour -=  1;
                    value = 60 + (value % 60);
                }
                _Minute = value;
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
                {
                    Minute += value / 60;
                    value = value % 60;
                }
                else if (value < 0)
                {
                    Minute -= 1;
                    value = 60 + (value % 60);
                }
                _Second = value;
            }
        }

        public bool AmPM_Enabled
        {
            get
            {
                return _am;
            }
            set
            {
                if (value == true)
                {
                    if (Hour < 24)
                    {
                        if (Hour > 12)
                        {
                            _amOrpm = "PM";
                            Hour -= 12;
                        }
                        else
                            _amOrpm = "AM";
                    }
                    else
                        _amOrpm = "NT";
                }
                else
                {
                    if (Hour < 24)
                    {
                        if (_amOrpm == "PM")
                        {
                            Hour += 12;
                        }
                        _amOrpm = "AM";
                    }
                    else
                        _amOrpm = "NT";
                }
                _am = value;
            }
        }
        /// <summary>
        /// Get Long Time HH:MM:SS (AM or PM)
        /// </summary>
        /// <param name="c">Your Clock</param>
        /// <returns></returns>
        public static string GetLongTime(Clock c)
        {
            string thisClock = string.Empty;
            thisClock = c.Hour + ":" + c.Minute + ":" + c.Second + " " + c._amOrpm;
            return thisClock;
        }

        /// <summary>
        /// Get Short Time HH:MM (AM or PM)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string GetShortTime(Clock c)
        {
            string thisClock = string.Empty;

            thisClock = c.Hour + ":" + c.Minute + " " + c._amOrpm;

            return thisClock;
        }

        public static Clock operator +(Clock c1, Clock c2)
        {
            c1.AmPM_Enabled = false;
            c2.AmPM_Enabled = false;

            int hour = c1.Hour + c2.Hour;
            int min = c1.Minute + c2.Minute;
            int sec = c1.Second + c2.Second;

            Clock c3 = new Clock(hour, min, sec, false);
            return c3;
        }

        public static Clock operator -(Clock c1, Clock c2)
        {

            c1.AmPM_Enabled = false;
            c2.AmPM_Enabled = false;

            int hour = c1._Hour - c2._Hour;
            int min = c1._Minute - c2._Minute;
            int sec = c1._Second - c2._Second;

            Clock c3 = new Clock(hour, min, sec, false);
            return c3;
        }

    }
}
