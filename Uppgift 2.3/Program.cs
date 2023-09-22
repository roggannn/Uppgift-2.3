using System;

namespace Uppgift
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            double dagar = double.Parse(Console.ReadLine());

            Console.WriteLine("");


            Console.WriteLine("Hur många kilometer vill du köra med bilen?");
            double km = double.Parse(Console.ReadLine());

            double hyra = 300 + km + ((dagar -1) * 500);

            Console.Clear();
            Console.WriteLine("Det kommer kosta dig " + hyra + " kronor för att hyra bilen i " + dagar + " dagar och köra " + km + " kilometer.");
            Console.ReadKey(); // -=* GJORD AV NOAH *=-


        }

    }

}