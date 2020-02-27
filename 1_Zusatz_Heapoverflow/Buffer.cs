using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heapoverflow
{
    class Buffer
    {
        public Buffer()
        {
            // allocate 1 mega byte
            buffer = new char[1024*1024];
        }

        private char[] buffer;
    }
}
