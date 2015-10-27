using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSize = 70;
            int ySize = 20;

            for (int _x = 1; _x <= xSize; _x++)
            {
                VerticalLine vl = new VerticalLine(1, ySize, _x, '+');
                vl.Draw();
            }

            Console.ReadLine();
        
        }
    }
}
