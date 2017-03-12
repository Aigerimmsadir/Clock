using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    class Numbers
    {

        public List<Point> bricks = new List<Point>();
        public Numbers()
        {
            Point twelve = new Point(8, 2); twelve.sign = "12"; bricks.Add(twelve);
            Point eleven = new Point(6, 3); eleven.sign = "11"; bricks.Add(eleven);
            Point ten = new Point(4, 4); ten.sign = "10"; bricks.Add(ten);
            Point nine = new Point(2, 5); nine.sign = "9"; bricks.Add(nine);
            Point eight = new Point(4, 6); eight.sign = "8"; bricks.Add(eight);
            Point seven = new Point(6, 7); seven.sign = "7"; bricks.Add(seven);
            Point six = new Point(8, 8); six.sign = "6"; bricks.Add(six);
            Point five = new Point(10, 7); five.sign = "5"; bricks.Add(five);
            Point four = new Point(12, 6); four.sign = "4"; bricks.Add(four);
            Point three = new Point(14, 5); three.sign = "3"; bricks.Add(three);
            Point two = new Point(12, 4); two.sign = "2"; bricks.Add(two);
            Point one = new Point(10, 3); one.sign = "1"; bricks.Add(one);


        }
        public void Draw()
        {
            for (int i = bricks.Count - 1; i >= 0; --i)
            {
                Console.SetCursorPosition(bricks[i].x, bricks[i].y);
                Console.Write(bricks[i].sign);

            }


        }
        public void Color()
        {

            Console.Clear();
            Draw();
            for (int i = bricks.Count - 1; true; i--)
            {
                if (i < 0)
                {
                    i = bricks.Count - 1;
                }
          
                Console.SetCursorPosition(bricks[i].x, bricks[i].y);
                Console.Write(bricks[i].sign);
                Console.ForegroundColor = ConsoleColor.Cyan;
                if ((i - 1) >= 0 )
                {
                    Console.SetCursorPosition(bricks[i - 1].x, bricks[i - 1].y);
                    Console.Write(bricks[i - 1].sign);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                }

            }

        }

    }
}
