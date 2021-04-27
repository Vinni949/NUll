using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сапер
{
    class BombCell:Cell 
    {
        private char bomb = '*';

        public BombCell():base()
        {

        }

        public void OpenCell()
        {
        }
        public override int AddScore()
        {
            Random rand = new Random();
            int number = rand.Next(1, 10);
            if (number == 10)
            { return -100; }
            else if (number == 6 || number == 3)
            { return -10; }
            else
                return -10;

        }
        public override void PrintCell()
        {
            if (open == true)
            {
                Console.Write(bomb + "   ");
            }
            else
                Console.Write('#' + "   ");
        }
    }
}
