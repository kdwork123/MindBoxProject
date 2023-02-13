using System;

namespace MindBoxProject
{
    public class Triangle
    {
        /// <summary>
        /// Получение площади треугольника
        /// </summary>
        /// <param name="a">Длина строны A</param>
        /// <param name="b">Длина строны B</param>
        /// <param name="c">Длина строны C</param>
        /// <returns>Площaдь треугольника</returns>
        /// <exception cref="ArgumentException"></exception>
        public double Area(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длина стороны треугольника не может быть отрицательной или равной нулю");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Не правильный треугольник");

            var halfMeter = (a + b + c) / 2;
            var squere = Math.Sqrt(halfMeter * (halfMeter - a) * (halfMeter - b) * (halfMeter - c));

            return squere;
        }

        /// <summary>
        /// Получение информации прямоугольный ли треугольник
        /// </summary>
        /// <param name="a">Длина строны A</param>
        /// <param name="b">Длина строны B</param>
        /// <param name="c">Длина строны C</param>
        /// <returns>Треугольник прямоугольный?</returns>
        /// <exception cref="ArgumentException"></exception>
        public bool IsRectangular(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длина стороны треугольника не может быть отрицательной или равной нулю");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Не правильный треугольник");

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) - Math.Pow(b, 2) == Math.Pow(c, 2);


        }
    }
}
