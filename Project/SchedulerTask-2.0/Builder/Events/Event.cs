﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Event: IComparable
    {
        private DateTime time;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time">Время возникновения события</param>
        public Event(DateTime time)
        {
            this.time = time;
        }

        public DateTime Time
        {
            get { return time; }
            set { }
        }

        public int CompareTo(object obj)
        {
            Event e2 = obj as Event;
            if (e2 == null)
                return 0;

            return DateTime.Compare(Time, e2.Time);
        }
    }
}
