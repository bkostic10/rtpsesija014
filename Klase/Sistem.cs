﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class Sistem
    {
        private string _ime;
        public Sistem(string ime)
        {
            this._ime = ime;
        }
        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }
    }
}
