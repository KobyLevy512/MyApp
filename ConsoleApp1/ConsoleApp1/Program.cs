using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Reverse(string s)
        {
            if (s.Length == 0) return;
            Reverse(s.Substring(1));
            Console.Write(s[0]);
        }
        static void Main(string[] args)
        {
            Reverse("abcd");
            Console.ReadLine();
        }
    }
}
