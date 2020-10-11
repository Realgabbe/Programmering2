using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb1
{
    class Customer
    {
        public List<Product> _cart = new List<Product>();

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
