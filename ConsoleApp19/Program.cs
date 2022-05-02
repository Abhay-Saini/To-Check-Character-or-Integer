
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIntigerOrCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input please");
            char value = Convert.ToChar( Console.ReadLine());

            Console.WriteLine("value is {0} ", value);

            if(value >= 65 && value <= 90 || value >= 97 && value <= 122)
            {
                Console.WriteLine("This is a character");
            }
            else
            {
                Console.WriteLine("This is integer");
            }

            Console.ReadLine();
        }
    }
}
