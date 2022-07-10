using System;

namespace ACP_Antip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("АЦП 10-разрядное");
            Console.WriteLine("Введите опорное напряжение");
            double OporU = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите измеряемое напряжение");
            double IzmerU = Convert.ToDouble(Console.ReadLine());

            double[] ArrRazryad = new double[10];
            ArrRazryad[0] = 0.5 * OporU;
            for (int i = 1; i < ArrRazryad.Length; i++)
            {
                ArrRazryad[i] = 0.5 * ArrRazryad[i - 1];
                Console.WriteLine(ArrRazryad[i]);
            }
//            if (0<=IzmerU & IzmerU <= (OporU / 2))
//            {
//                Console.WriteLine(0);
//            }
//            else
//            {
//                Console.WriteLine(1);
//            }
            foreach (int a in ArrRazryad)
            {
                if (a <= IzmerU && IzmerU <= (OporU / 2))
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
            Console.ReadLine();    
        }
    }
}