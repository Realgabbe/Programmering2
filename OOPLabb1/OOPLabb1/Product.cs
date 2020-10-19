using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb1
{
    class Product
    {

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
