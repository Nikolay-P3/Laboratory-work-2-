using System;

namespace Laboratory_work_2
{
    
    class Program { }
   public class Kvadrat
    {
        public double a;
        public Kvadrat()
        {

        }

        public Kvadrat(double a)
        {
            this.a = a;
        }

        public virtual double Perimetr(double a)
        {
            return a * 4;
        }

        public virtual double Square(double a)
        {
            return a * a;
        }

        public virtual void Show()
        {
            Console.WriteLine("Длина стороны квадрата: " + a);
        }
    }

    public class Cube : Kvadrat
    {
        public Cube() : base()
        {

        }
        public Cube(double a) : base(a)
        {

        }

        public override double Perimetr(double a)
        {
            return a * 12;
        }

        public override double Square(double a)
        {
            return base.Square(a) * 6;
        }

        public double Volume(double a)
        {
            return Math.Pow(a, 3);
        }

    }
}
