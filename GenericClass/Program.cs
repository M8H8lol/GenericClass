using System;
using System.Collections.Generic;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> familyQueue = new Queue<string>();

            familyQueue.Enqueue("Mom");
            familyQueue.Enqueue("Dad");


            while (familyQueue.Count > 0)
            {
                Console.WriteLine("This is your new costumer!");

                Console.WriteLine(familyQueue.Peek());

                Console.WriteLine($"{familyQueue.Peek()}: Hello son!");

                string answer = Console.ReadLine().ToLower();

                if (answer != "hello")
                {
                    Console.WriteLine("Be polite, say hi back idiot");
                }
                else
                {
                    Console.WriteLine($"Do you want a book {familyQueue.Peek().ToLower()}?");

                    Console.WriteLine($"{familyQueue.Peek()}: Yes please!");

                    Console.WriteLine($"*You proceed to give {familyQueue.Peek().ToLower()} a book*");

                    Console.WriteLine($"Bye {familyQueue.Peek().ToLower()}!");

                    string family = familyQueue.Dequeue();
                }
            }

            Console.ReadKey();
        }
    }
}

