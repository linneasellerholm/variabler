using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            Console.WriteLine("Mata in ett heltal: ");
            string inmatat;
            inmatat = Console.ReadLine();
            int mittHeltal = int.Parse(inmatat);
            Console.WriteLine("Mata in ett heltal: ");
            inmatat = Console.ReadLine();
            int mittAndraHeltal = int.Parse(inmatat);
            Console.WriteLine("Summan av talen blir: " + (mittHeltal + mittAndraHeltal));
            Console.WriteLine("Produkten av talen blir: " + (mittHeltal * mittAndraHeltal));
            Console.WriteLine("Kvoten av talen blir: " + (mittHeltal / mittAndraHeltal));

            Console.ReadLine();

            //Övning 2
            Console.WriteLine("Skriv ditt förnamn här:");
            string firstName;
            firstName = Console.ReadLine();
            Console.WriteLine("Skriv ditt efternamn här:");
            string lastName;
            lastName = Console.ReadLine();
            Console.WriteLine("Hej " + firstName + " " + lastName + "!");

            Console.ReadKey();

            //Övning 3
            Console.WriteLine("Mata in antal grader i Celcius:");
            string celcius;
            celcius = Console.ReadLine();
            int graderCelcius = int.Parse(celcius);
            Console.WriteLine("Grader Farenheit:" + (graderCelcius * 1.8 + 32));

            Console.ReadKey();

            //Övning 4
            Console.Write("Mata in grader i Celcius:");
            string celcius1;
            celcius1 = Console.ReadLine();
            int graderCelcius1 = int.Parse(celcius1);
            Console.Write("Grader Farenheit:" + (graderCelcius1 * 1.8 + 32));

            Console.ReadKey();


            //Övning 5
            Console.Write("Cirkelns radie:");
            string cirkelRadie;
            cirkelRadie = Console.ReadLine();
            int radie = int.Parse(cirkelRadie);
            double pi = Math.PI;
            Console.WriteLine("Cirkelns omkrets:" + (radie * pi * 2));
            Console.WriteLine("Cirkelns area:" + (radie * radie * pi));

            Console.ReadKey();


            //Övning 6
            Console.Write("Tresiffrigt tal:");
            string mittTal;
            mittTal = Console.ReadLine();
            int tal = int.Parse(mittTal);
            Console.WriteLine("Siffersumman är:"
                + ((tal / 100)
                + ((tal / 10) - (10 * (tal / 100)))
                + (tal - (tal / 10) * 10)));

            Console.ReadKey();
        }
    }
}
