﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidaysPlan
{
    public class Person
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime UploadDate { get; set; }
        public string Description { get; set; }
    }
}
