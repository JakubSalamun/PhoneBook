﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Kontakt
    {
        public Kontakt()
        {
        }

        public Kontakt(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public string  Name { get; set; }
        public int  Number { get; set; }
    }
}
