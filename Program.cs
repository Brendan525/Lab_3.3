using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word");
            string myword = Console.ReadLine();
            reverse(myword);
        }
      
        
        static string reverse(string myword)
        {
            bool redo = true;
            do
            {
                Regex entry = new Regex(@"^[A-Za-z][^0-9|@|!|#|$|%|^|&|*|(|)|-|=|+|_|[|\]|\|\||,|<|.|>|/|\|?|]{1,30}$");

                bool matched = entry.IsMatch(myword);

                if (matched)
                {
                    Stack stack = new Stack();

                    for (int i = 0; i < myword.Length; i++)
                    {
                        stack.Push(myword[i]);
                    }
                    foreach (char letter in stack)
                    {
                        Console.Write(letter);
                        redo = false;
                    }
                }
                else
                {
                    Console.WriteLine("The word is not valid. Please try again");
                    Console.WriteLine("Enter a word");
                    myword = Console.ReadLine();
                    redo = true;
                }
            } while (redo);

            return myword;

        }
    }
}
