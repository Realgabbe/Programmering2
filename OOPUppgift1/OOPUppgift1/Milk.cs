using System;
using System.Collections.Generic;
using System.Text;

namespace OOPUppgift1
{
    class Milk : Product
    {
        private int _fatContent;

        public int FatContent
        {
            get { return _fatContent; }
            set
            {
                if (value == 0)
                    return;
                _fatContent = value;
            }
        }

    }
}