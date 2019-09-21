using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Geometric figure class
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Figure type
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        /// <summary>
        /// Figure area calculation
        /// </summary>
        public abstract double Area();

        // Метод виртуальный, так как он объявлен в самом базовом классе object 
        // поэтому чтобы его переопределить добавлено ключевое слово override
        /// <summary>
        /// Virtual method ToString override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
    }
}
