using System;

namespace Antip4kaCalc;

class Program
{
    static void Main(string[] args)
    {
        string buf;
        Console.WriteLine("Введите a ... (Учтите при вводе что необходимо число с плавабщей запятой(Например: 1,2).");
        buf = Console.ReadLine();
        double a = Convert.ToDouble(buf);

        Console.WriteLine("Введите b ... (Учтите при вводе что необходимо число с плавабщей запятой(Например: 1,2).");
        buf = Console.ReadLine();
        double b = Convert.ToDouble(buf);

        Console.WriteLine("Введите c ... (Учтите при вводе что необходимо число с плавабщей запятой(Например: 1,2).");
        buf = Console.ReadLine();
        double c = Convert.ToDouble(buf);


        double d = b * b - 4 * a * c;
        double X1 = 1.2534;
        double X2 = 1.5464;
        Console.WriteLine("Дискриминант:");
        Console.WriteLine(d);
        X1 = (-(b) + (Math.Pow(d, -2))) / (2 * a);
        X2 = (-(b) - (Math.Pow(d, -2))) / (2 * a);
        if (d < 0)
        {
            Console.WriteLine("У уравнения нет корней!");
            
        }

        else if (!(d > 0))
        {
            Console.WriteLine("У уравнения два разных корня", X1);
            Console.WriteLine("X1", X1, ",X2", X2);
            
        }

        else
        {
            Console.WriteLine("У уравнения два равных корня");
            Console.WriteLine(X1);
            return;
        }

    }
}