using System;

namespace Lab2
{
    using Geometry;
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5, 5);
            rectangle1.Print();

            Square square1 = new Square(5);
            square1.Print();

            Circle circle1 = new Circle(5);
            circle1.Print();

            Console.ReadLine();
        }
    }

}

namespace Geometry
{
    /// <summary>
    /// Класс геометрическая фигура
    /// </summary>
    abstract class GeomFigure
    {
        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract double Area();

        /// <summary>
        /// Переопределение метода ToString(), Краткая информация о фигуре
        /// </summary>
        public override string ToString()
        {
            return Name + " имеет площадь " + Area();
        }

    }

    interface IPrint
    {
        void Print();
    }

    /// <summary>
    /// Класс прямоугольник
    /// </summary>
    class Rectangle : GeomFigure, IPrint
    {
        /// <summary>
        /// Длина 
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; }

        public Rectangle(double p1, double p2)
        {
            Length = p1;
            Width = p2;
            Name = "Прямоугольник";
        }

        public override double Area()
        {
            return Length * Width;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

    /// <summary>
    /// Класс квадрат
    /// </summary>
    class Square : Rectangle, IPrint
    {
        public Square(double size) : base(size, size)
        {
            Name = "Квадрат";
        }
    }

    /// <summary>
    /// Класс круг
    /// </summary>
    class Circle : GeomFigure, IPrint
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }
        public Circle(double p)
        {
            Radius = p;
            Name = "Круг";
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

}
