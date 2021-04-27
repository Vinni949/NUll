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
            return -100;
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
