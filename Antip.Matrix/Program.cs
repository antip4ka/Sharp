using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace Antip.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;

            String Word_1 = "Wake up, Neo ...";
            foreach (var word_1 in Word_1)
            {
                Console.Write(word_1);
                Thread.Sleep(1000);
                
            }
            Console.Beep(7000, 50);
            Console.Clear();

            String Word_2 = "The Matrix has you ...";
            foreach (var word_2 in Word_2)
            {
                Console.Write(word_2);
                Thread.Sleep(1000);
            }
            Console.Beep(7000, 50);
            Console.Clear();

            String Word_3 = "Follow the white rabbit ...";
            foreach (var word_3 in Word_3)
            {
                Console.Write(word_3);
                Thread.Sleep(1000);
            }
            Console.Beep(7000, 50);
            Console.Clear();

            String Word_4 = "Knock, knock, Neo.";
            foreach (var word_4 in Word_4)
            {
                Console.Write(word_4);
                Thread.Sleep(1000);
            }
            Console.Beep(7000, 50);
            Console.Clear();

            Console.ReadLine();
        }
    }
}