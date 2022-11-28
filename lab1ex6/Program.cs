using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
          descrescatoare.
              • Exemplu: citim 3,9,0 Afisam : 9 3 0 */

            Console.WriteLine("Introduce three numbers, and I`ll show them in descending order");
            Console.WriteLine("Introduce your first number");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce your second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce your third number");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Your numbers in descending order are:");

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
                }
                else
                {
                    Console.WriteLine(firstNumber + " " + thirdNumber + " " + secondNumber);
                }
            }
            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine(secondNumber + " " + firstNumber + " " + thirdNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber + " " + thirdNumber + " " + firstNumber);
                }
            }
            else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber))
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(thirdNumber + " " + firstNumber + " " + secondNumber);
                }
                else
                {
                    Console.WriteLine(thirdNumber + " " + secondNumber + " " + firstNumber);
                }
            }
        }
    }
}
