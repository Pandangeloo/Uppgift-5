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
               
                
                //Tom rad för snyggare i konsolen
                Console.WriteLine();

            //Programmet ska inte funka om man skriver in fel tecken. 
            
                if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.WriteLine("Nu blev det fel. Försök igen\n");
                continue;
                
            }



            Console.WriteLine("Ange första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ange andra talet:");
            double num2 = Convert.ToDouble(Console.ReadLine());


            //Kontrollerar division med 0
            if (operation == '/' && num2 == 0)
            {
                Console.WriteLine("Division med 0 fungerar inte. Du får börja om");
                continue ;
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

            Console.WriteLine($"\nResultat: {result} \n");

                Console.WriteLine("För att avsluta kalkylatorn tryck 1. \nFör att försöka igen tryck på vad som helst.");
                Console.WriteLine(" ");
                char yesOrNo = Console.ReadKey().KeyChar;

               
                
                if (yesOrNo == '1')
                {
                    Console.WriteLine("\nNu avslutas programmet. Hejdå!");
                    Console.ReadKey();
                    return;
                }
                else 
                {
                    Console.WriteLine("Kul att du vill använda kalkylatorn igen! Då börjar vi om");
                    continue;
                }
                

                Console.ReadKey();


            }


            
        
        }

    }


}
