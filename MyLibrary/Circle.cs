namespace MyLibrary
{
    public class Circle : Figure
    {
        double radius;
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius 
        { 
            get => radius;
            set 
            {
                if (value >= 0)
                    radius = value;
                else
                    throw new InvalidDataException();
            }
        }

        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Расчёт площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        /// <summary>
        /// Расчёт площади круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Площадь круга</returns>
        public double CalculateArea(double radius)
        {
            Radius = radius;
            return CalculateArea();
        }
    }
}
