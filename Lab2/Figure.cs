namespace Lab2
{
    /// <summary>
    /// Geometric figure class
    /// </summary>
    abstract class Figure
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
    }
}
