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
    public abstract class Figure
    {
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }
        string type;

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>
        /// Площадь фигуры - число с плавающей точкой
        /// </returns>
        public virtual double Area() { return 0.0; }

        /// <summary>
        /// Вывод информации о фигуре в формате: "{Название}: {Площадь} = {Значение}."
        /// </summary>
        /// <returns>
        /// Возвращает строку string соответствующего формата
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}: Area = {1}.", this.Type, Area());
        }

        /// <summary>
        /// Сравнение с другим объектом такого же типа по какому-л. значению
        /// </summary>
        /// <param name="o">Объект, с кототорым происходит сравнение</param>
        /// <returns>
        /// Целое число, от знака которого зависит результат сравнения:
        /// 1) меньше 0 - текущий объект расположен перед параметром
        /// 2) равно 0 - объекты "равны"
        /// 3) больше 0 - текущий объект расположен после параметра 
        /// </returns>
        public int CompareTo(object o)
        {
            Figure f = o as Figure;
            if (o != null)
                return this.Area().CompareTo(f.Area());
            else
                throw new Exception();
        }
    }
}
