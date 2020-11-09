using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OOPLabb1
{
    class Cider : Product
    {

        private string _flavor;
        public string Flavor
        {
            get { return _flavor; }
            set { _flavor = value; }
        }
    }
}
