using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Square : Rectangle, IPrint
    {
        public Square(double size) : base(size, size)
        {
        }

        public override string ToString()
        {
            return string.Format("Square: Area = {0}.", Area());
        }
    }
}
