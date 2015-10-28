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
            Console.SetBufferSize(80, 25); /* ограничивает размер окна */

            HorizontLine hl = new HorizontLine(0,78,0,'+');
            /*VerticalLine vl = new VerticalLine(1, ySize, _x, '+');
                vl.Draw(); */
            Console.ReadLine();
        
        }
    }
}
