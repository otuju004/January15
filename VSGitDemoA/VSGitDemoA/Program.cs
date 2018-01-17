using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGitDemoA
{
    class Program
    {
       public static void Main()
            {
                string[] colours = { "Red", "Orange", "Yellow", "Green", "Cyan", "Blue", "Violet", "White", "Black","Gray"};
                Random rnd = new Random();
                int index = rnd.Next(0, colours.Length);
                Console.WriteLine("Colour of the day {0}", colours[index]);
            }
        }
}
