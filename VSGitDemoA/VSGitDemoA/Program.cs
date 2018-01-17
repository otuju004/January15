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
                string[] colours = { "Red", "Orange", "Yellow", "Green", "Cyan", "Blue", "Violet", "White", "Black","Gray" };
                Random rnd = new Random();
                int index = rnd.Next(0, colours.Length);
                Console.WriteLine("Yo listen up, here's the story
About a little guy that lives in a {0} world
And all day and all night and everything he sees is just {0}
Like him, inside and outside
{0} his house with a {0} little window
And a {0} Corvette
And everything is {0} for him
And himself and everybody around
'Cause he ain't got nobody to listen
I'm {0} da ba dee da ba daa
Da ba dee da ba daa, da ba dee da ba daa, da ba dee da ba daa
Da ba dee da ba daa, da ba dee da ba daa, da ba dee da ba daa", colours[index]);
            }
        }
}

                                  
