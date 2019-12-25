namespace Lab2
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
