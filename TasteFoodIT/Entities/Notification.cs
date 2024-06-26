﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIT.Entities
{
    public class Notification
    {

        public int NotificationID { get; set; }
        public DateTime Date { get; set; }
        public string Description  { get; set; }
        public bool IsRead  { get; set; }
        public string NotificationIcon  { get; set; }
        public string IconCircleColor  { get; set; }
    }
}