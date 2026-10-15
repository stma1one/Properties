namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jjj
            
            Rectangle rec = new Rectangle(4, 5);
            Square sq = new Square(4);
            //Console.WriteLine( sq.Area());
           // Console.WriteLine(sq.Name);
          //  Console.WriteLine(rec.Name);

            Shape[] shapes = new Shape[4];
            shapes[0] = rec;
            shapes[1] = sq;
            shapes[2] = new Circle(5);

            foreach(Shape s in shapes)
            {
                if (s != null)
                {
                    Console.WriteLine(s.Name);
                    Console.WriteLine(s.Area());    
                    //if(s is Circle)
                    //{
                        //Console.WriteLine(((Circle)s).Radius );
                    //}
                    Circle c= s as Circle;
                    if(c != null)
                        Console.WriteLine( c.Radius );
                }
            }



        }
    }
}
