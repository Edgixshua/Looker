﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Looker
{
    public class Event
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Venue { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
