using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxProject
{
    public class Circle
    {
        /// <summary>
        /// Функция подсчета площади круга
        /// </summary>
        /// <param name="r">Радиус круга</param>
        /// <returns>Площадь круга</returns>
        /// <exception cref="ArgumentException"></exception>
        public double Area(double r)
        {
            if (r <= 0)
                 throw new ArgumentException("Радиус круга не может быть отрицательным или равным нулю");

            var squere =  Math.Pow(r, 2) * Math.PI; 
           
            return squere;
        }

    }
}
