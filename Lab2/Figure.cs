namespace Lab2
{
    /// <summary>
    /// Geometric figure class
    /// </summary>
    abstract class Figure
    {
        string _Type;

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
        /*public override string ToString()
        {
            return this.Type + " имеет площадь " + this.Area().ToString();
            // this line return this.Type has an area equal to this.Area().ToString()
        }
        */
    }
}
