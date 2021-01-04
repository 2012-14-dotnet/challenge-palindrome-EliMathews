using System;

namespace Domain
{
    public class BossClass
    {
        public static void PalindromeChecker()
        {   
                
            Console.Write("Enter a string to Check Palindrome : ");
            string Name = Console.ReadLine();
            string Reverse = string.Empty;
            foreach (char c in Name)
            {
                Reverse = c + Reverse;
            }
            if (Name.Equals(Reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{Name} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{Name} is not Palindrome");
            }
            Console.ReadKey();
        }
        public class Exit
        {
            public static void ExitMethod()
            {
            var Exit = Console.ReadLine();
            if (Exit = 1)
            {
                PalindromeChecker();
            }
            }

        } 
    }
}
