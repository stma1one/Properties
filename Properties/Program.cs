namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //עבודבה מהווב
            Rectangle rec = new Rectangle(4, 5);
            Square sq1 = new Square(4);
            Square sq2 = new Square(6);
            Circle cir = new Circle(4);
            Shape[] shapes = new Shape[4] { rec, sq1, sq2, cir };



        }
    }
}
