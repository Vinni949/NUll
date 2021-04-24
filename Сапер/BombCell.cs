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

        public override int OpenCell()
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
