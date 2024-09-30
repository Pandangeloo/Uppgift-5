using System;

namespace EnkelKalkylator
{

    class Program
    {
        static void Main(string[] args)
        {
            bool keepOnGoing = true;
            Console.WriteLine("Enkel Kalkylator");
            while (keepOnGoing)
            {
                
            //Start"Menyn"
            
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

                                
                double num1;
                double num2;

            Console.WriteLine("Ange första talet: ");

                //En loop som kollar att det är en korrekt inmatning
                //Om det är fel kommer den starta om igen tills dess man skriver en siffra, då går den vidare. 

                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Du skrev nog fel. Försök igen med ett giltligt tal. ");
                }

                             
                       
            Console.WriteLine("Ange andra talet:");

                //En loop som kollar att det är en korrekt inmatning
                //Om det är fel kommer den starta om igen tills dess man skriver en siffra, då går den vidare

                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Du skrev nog fel. Försök igen med ett giltligt tal. ");
                }


                //Kontrollerar division med 0
                if (operation == '/' && num2 == 0)
            {
                Console.WriteLine("Division med 0 fungerar inte. Du får börja om");
                continue ;
            }


            double result = 0;

                //Här löser vi matematiken, eller börjar om. 
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
                    continue;
            }

            Console.WriteLine($"\nResultat: {result} \n");

                
                
                
                //Avslutningsmenyn, går att välja att hoppa upp till start eller avsluta med if-else. 
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
                    Console.WriteLine("\nKul att du vill använda kalkylatorn igen! Då börjar vi om");
                    Console.WriteLine();
                    continue;
                }
                
                              
            }


            
        
        }

    }


}
