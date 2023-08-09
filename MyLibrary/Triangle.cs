namespace MyLibrary
{
    public class Triangle : Figure
    {
        double a;
        double b;
        double c;
        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double A {
            get => a;
            set
            {
                if (value >= 0)
                    a = value;
                else
                    throw new InvalidDataException();
            }
        }
        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double B 
        { 
            get => b;
            set
            {
                if (value >= 0)
                    b = value;
                else
                    throw new InvalidDataException();
            }
        }
        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double C 
        {
            get => c;
            set
            {
                if (value >= 0)
                    c = value;
                else
                    throw new InvalidDataException();
            }
        }

        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Расчёт площади треугольника
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            return CalculateArea();
        }

        /// <summary>
        /// Расчёт площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double CalculateArea()
        {
            double p = (A + B + C) / 2;
            double a = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
            if (a >= 0)
                return a;
            return 0;
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Является ли треугольник прямоугольным</returns>
        public bool IsRightTriangle()
        {
            double[] arr = new double[] { A, B, C };
            arr = arr.OrderByDescending(x => x).ToArray();
            if (Math.Pow(arr[0], 2) == (Math.Pow(arr[1], 2) + Math.Pow(arr[2], 2)))
                return true;
            return false;
        }
    }
}