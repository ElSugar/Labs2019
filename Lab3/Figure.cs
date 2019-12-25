using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// Geometric figure class
    /// </summary>
    abstract class Figure : IComparable
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

        /// <summary>
        /// Сравнение элементов (для сортировки списка)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Figure _figure = (Figure)obj;
            if (this.Area() < _figure.Area())
                return -1;
            else if (this.Area() == _figure.Area())
                return 0;
            else return 1;
        }
    }
}