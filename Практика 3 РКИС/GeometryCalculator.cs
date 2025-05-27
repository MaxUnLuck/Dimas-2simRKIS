using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_РКИС
{
    public static class Calculate
    {
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            try
            {
                double dx = x2 - x1;
                double dy = y2 - y1;
                return Math.Sqrt(dx * dx + dy * dy);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                throw;
            }
        }
    }
}

