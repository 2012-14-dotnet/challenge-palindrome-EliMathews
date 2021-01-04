using System;
using Domain;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            BossClass.PalindromeChecker();
            Console.WriteLine("Enter '1' to keep using the Palindrome Checker");
            Console.WriteLine("Enter '0' to exit the Palindrome Checker");

        }
    }
}
