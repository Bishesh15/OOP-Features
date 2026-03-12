using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDemo
{
    internal class ReverseString
    {
        public void Reverse()
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine("Reversed : " + reversed);
        }
    }
}