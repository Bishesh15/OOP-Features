using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDemo
{
    internal class StarPattern
    {
        //Square Pattern
        public void Square(int n)
        {
            Console.WriteLine("Square Pattern");
            for (int i = 0; i < n; i++)
            {
                string row = "";
                for (int j = 0; j < n; j++)
                {
                    row = row + "*";
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
        }
        //Right Triangle
        public void RightTriangle(int n)
        {
            Console.WriteLine("Right Triangle Pattern");
            for (int i = 1; i <= n; i++)
            {
                string row = "";
                for (int j = 0; j < i; j++)
                {
                    row = row + "*";
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
        }
        //Inverted Right
        public void InvertedRight(int n)
        {
            Console.WriteLine("Inverted Right Triangle Pattern");
            for (int i = n; i >= 1; i--)
            {
                string row = "";
                for (int j = 0; j < i; j++)
                {
                    row = row + "*";
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
        }
        //Pyramid
        public void Pyramid(int n)
        {
            Console.WriteLine("Pyramid Pattern");
            for (int i = 1; i <= n; i++)
            {
                string row = "";
                for (int s = 1; s <= n - i; s++)
                {
                    row = row + " ";
                }
                for (int j = 1; j <= (i * 2 - 1); j++)
                {
                    row = row + "*";
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
        }
        //Diamond
        public void Diamond(int n)
        {
            Console.WriteLine("Diamond Pattern");
            for (int i = 1; i <= n; i++)
            {
                string row = "";
                for (int s = 1; s <= n - i; s++)
                {
                    row = row + " ";
                }
                for (int j = 1; j <= (i * 2 - 1); j++)
                {
                    row = row + "*";
                }
                Console.WriteLine(row);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                string row = "";
                for (int s = 1; s <= n - i; s++)
                {
                    row = row + " ";
                }
                for (int j = 1; j <= (i * 2 - 1); j++)
                {
                    row = row + "*";
                }
                Console.WriteLine(row);
            }
        }

        public void Run()
        {
            int n = 5;
            Square(5);
            RightTriangle(5);
            InvertedRight(5);
            Pyramid(5);
            Diamond(5);           
        }
    }
}
