using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Debaters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Ноль не подходит, введите другое число");
                a = int.Parse(Console.ReadLine());
            }
            Numbertron tron = new Numbertron();
            Jay jay = new Jay();
            SilentBob bob = new SilentBob();
            tron.NewNumber += jay.FetchNewNumber;
            tron.NewNumber += bob.FetchNewNumber;
            tron.Generate(a);
            if (jay.Score > bob.Score)
            {
                Console.WriteLine(jay.Name);
            }
            if (jay.Score < bob.Score)
            {
                Console.WriteLine(bob.Name);
            }
            if (jay.Score == bob.Score)
            {
                Console.WriteLine("DRAW");
            }
            Console.ReadKey();
        }
    }
}
