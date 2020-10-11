using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OOPLabb1
{
    class Cider : Product
    {
        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value;}
        }
    }
}
