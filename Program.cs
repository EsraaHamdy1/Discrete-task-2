using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2; Console.Write("Enter the starting number: "); n1 = Convert.ToInt32(Console.ReadLine()); Console.Write("Enter the ending number: "); n2 = Convert.ToInt32(Console.ReadLine()); for (int i = n1; i <= n2; i++) { if (IsPrime(i)) { Console.Write(i + " "); } }
            Console.ReadLine();
        }
        public static bool IsPrime(int n) { if (n <= 1) { return false; } for (int i = 2; i <= Math.Sqrt(n); i++) { if (n % i == 0) { return false; } } return true; }


    }
}


