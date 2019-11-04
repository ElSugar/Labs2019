namespace Lab2
{
    class Square : Rectangle, IPrint
    {
        public Square(double size) : base(size, size)
        {
            this.Type = "Квадрат";
        }
    }
}
