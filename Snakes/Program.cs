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

            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(6, 7, '@');

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);

            plist.RemoveAt(1);

            foreach (Point _p in plist)
            {
                _p.Draw();
            }

            Console.ReadLine();
        
        }
    }
}
