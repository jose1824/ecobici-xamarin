using System;
using System.Collections.Generic;
using System.Text;

namespace ecobici
{
    public class Todo
    {
        public int id { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public double[,] location { get; set; }
    }
}
