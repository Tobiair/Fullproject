﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite
{
    public class CharactersModel
    {
        public int id { get; set; }
        public string name { get; set; }

        public string specialrules { get; set; }

        public string faction { get; set; }
    }
}