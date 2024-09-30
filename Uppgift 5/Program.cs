using System;

namespace EnkelKalkylator
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enkel Kalkylator");
            Console.WriteLine("Ange operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;

            //Programmet ska inte funka om man skriver in fel tecken. 
            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.WriteLine("Nu blev det fel. Programmet avslutas");
                return;
                
            }




            Console.WriteLine("Ange första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ange andra talet:");
            double num2 = Convert.ToDouble(Console.ReadLine());



            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Ogiltligt");
                    return;
            }

            Console.WriteLine($"Resultat: {result}");

            Console.ReadKey();
        }

    }
}
