﻿using Admin.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class UserInfo
    {
        public string carId { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string addr { get; set; }
        public string unit { get; set; }
        public string other { get; set; }
    }
}
