using System;
using System.Globalization;

namespace Pi
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do Raio");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circu = Circunferacia(raio);
            double vol = Volume(raio);
            Console.WriteLine("Circunferecia :" + circu.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi = " + Pi.ToString("F2",CultureInfo.InvariantCulture));


        }

        static double Circunferacia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {

            return (4 * Pi) * (r * r * r)/3 ; //Match.pow(r, 3); pra fazer o cubo também tem esse jeito
        }
    }
}
