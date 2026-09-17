using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public double Area() { return 0.0; }
        public double Perimeter() { return 0.0; }

    }

    public class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { if(value>0) 
                radius = value; }
        }

        public Circle(int r) { Radius = r; }
        public double Area() { return Math.Pow(Radius,2)*Math.PI; }
        public double Perimeter() { return 2*Math.PI*Radius; }

    }
    //Gooday Mate
    public class Rectangle
    {
        private double length;

        public double Length
        {
            get { return length; }
            set { if(value>0) length = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { if(value>0)
                    width = value; }
        }
        public Rectangle(double length,double width)
        {
            Length=length;
            Width = width;
        }

        public double Area() { return Length*Width; }
        public double Perimeter() { return 2 * Length*Width; }
    }

    public class Square : Rectangle
    {
        //פעולה בונה של ריבוע 
        //מזמנת את הפעולה הבונה של ההורה (כדי ליצור ריבוע קודם צריך שיהיה
        //מלבן)
        public Square(double length):base(length,length)
        {

        }
    }

   
}
