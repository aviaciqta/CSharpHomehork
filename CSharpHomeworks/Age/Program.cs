using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            string s = Birthday.ToString("MM.DD.YYYY");
            int age = today.Year - Birthday.Year;
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
