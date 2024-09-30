using System;

namespace EnkelKalkylator
{

    class Program
    {
        static void Main(string[] args)
        {
            bool keepOnGoing = true;

            while (keepOnGoing)
            {
                
            

            Console.WriteLine("Enkel Kalkylator");
            Console.WriteLine("Ange operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
                    //  char.Parse(Console.ReadLine());

            //Programmet ska inte funka om man skriver in fel tecken. 
            
                if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.WriteLine("Nu blev det fel. Försök igen");
                return;
                
            }



            Console.WriteLine("Ange första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ange andra talet:");
            double num2 = Convert.ToDouble(Console.ReadLine());


            //Kontrollerar division med 0
            if (operation == '/' && num2 == 0)
            {
                Console.WriteLine("Division med 0 fungerar inte.");
                return ;
            }


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


            Console.WriteLine("Nu avslutas programmet. Hejdå!");
        
        }

    }
}
