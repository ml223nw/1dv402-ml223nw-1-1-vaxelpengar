using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Växelpengar_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler.

            double avrundaSum = 0d;
            double totalSum = 0d;
            double summa = 0d;
            uint betalt;
            uint attbetala = 0;
            uint växel;

            // Här matar användaren in priset. Fungerar endast med heltal eller fyrtal, annars ett felmeddelande.
            while (true)
            {
                try
                {
                    Console.WriteLine("Ange totalsumma: ");
                    summa = double.Parse(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("FEL! Ange ett heltal eller fyrtal.");
                }

            }


            // Eventuella fyrtal avrundas.
            attbetala = (uint)Math.Round(summa);

            // Här matar användaren in kontanter. Fungerar endast med heltal eller fyrtal, annars ett felmeddelande.
            while (true)
            {
                try
                {
                    Console.WriteLine("Ange erhållet belopp: ");
                    betalt = uint.Parse(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("FEL! Ange ett heltal eller fyrtal.");
                }
            }


            växel = betalt - attbetala;
            avrundaSum = summa - attbetala;

            // Kvitto skrivs ut.
            Console.WriteLine("\nKVITTO ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Totalt\t\t: {0,10:c}", summa);
            Console.WriteLine("Öresavrundning\t: {0,10:c}", avrundaSum);
            Console.WriteLine("Att betala\t: {0,10:c0}", attbetala);
            Console.WriteLine("Kontant\t\t: {0,10:c0}", betalt);
            Console.WriteLine("Tillbaka\t: {0,10:c0}", växel);
            Console.WriteLine("---------------------------");

            // Här delas sedlar/mynt upp i lämpligt antal och presenteras endast om värdet är större än 0.
            if (växel >= 500)
            {
                Console.WriteLine("500-lappar:\t: {0}", (växel / 500));
                växel %= 500;
            }

            if (växel >= 100)
            {
                Console.WriteLine("100-lappar:\t: {0}", (växel / 100));
                växel %= 100;
            }

            if (växel >= 50)
            {
                Console.WriteLine("50-lappar:\t: {0}", (växel / 50));
                växel %= 50;
            }

            if (växel >= 20)
            {
                Console.WriteLine("20-lappar:\t: {0}", (växel / 20));
                växel %= 20;
            }

            if (växel >= 10)
            {
                Console.WriteLine("10-lappar:\t: {0}", (växel / 10));
                växel %= 10;
            }

            if (växel >= 5)
            {
                Console.WriteLine("5-kronor:\t: {0}", (växel / 5));
                växel %= 5;
            }

            if (växel >= 1)
            {
                Console.WriteLine("1-kronor:\t: {0}", växel);
            }
            //// PROGRAM SLUT PROGRAM SLUT PROGRAM SLUT PROGRAM SLUT PROGRAM SLUT \\\\
        }
    }
}
