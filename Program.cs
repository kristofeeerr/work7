using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 10;
            string completionWord = "exit";
            string userInput;
            
            for(int i = 0; i < tryCount; i++) 
            {
                Console.Write("Введите заврещающие слово:");
                userInput = Console.ReadLine();

                if(completionWord == userInput) 
                {
                    Console.WriteLine("До свидания!");
                    break;
                }
                else
                {
                    Console.WriteLine("У вас осталось - " + (tryCount - i - 1 ) + " попыток");
                }
            }
                
        }
    }
}
