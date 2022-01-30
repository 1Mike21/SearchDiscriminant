using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantLib
{
    public class Discriminant
    {
        public static string CalculatingDiscriminant(double A, double B, double C)
        {
            double x;
            double D = Math.Pow(B, 2) - 4 * A * C; //формула дискриминанта
            D = Math.Sqrt(D); 
            double x1 = (-B + D) / 2 * A;//первый корень дискриминанта
            double x2 = (-B - D) / 2 * A;//второй корень дискриминанта

            if (D > 0)
            {
                return $"Уравнение имеет 2 вещественных корня: x1={x1}, x2={x2}";
                
            }

           else if (D == 0)
            {
                return $"Уравнение имеет 1 вещественный корень: x1={x1}";
            }

            else
            {
                return $"Вещественных корней нет";
            }
        }
    }
}
