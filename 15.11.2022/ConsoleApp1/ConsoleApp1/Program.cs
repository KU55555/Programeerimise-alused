using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite football player t-shirt number!");
           string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);     
          //int 16 et parsida

            // teen siia if ja else loogikaga vastused 
            if (numberParsed < 50)
            {
                Console.WriteLine("Cool player");
                
                }
            
            
            
            
            else if (numberParsed > 50)
            {
                Console.WriteLine("Not cool player");
        }









    }
    }
}
