using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class VerticalLine
    {

        List<Point> vList;
        
        public VerticalLine(int yHigh, int yLow, int x, char sym)
        {
            vList = new List<Point>();

            for (int y = yHigh; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                vList.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point p in vList)
            {
                p.Draw();
            }
        
        }
    
    }
}
