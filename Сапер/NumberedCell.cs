using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сапер
{
    class NumberedCell:Cell
    {
        private int number;

        public NumberedCell() : base()
        {
            Random rand = new Random();
            number = rand.Next(1, 10);
        }
        public override int OpenCell()
        {
            return number;
        }

        public override void PrintCell()
        {
            if (open == true)
            {
                Console.Write(number + "   ");
            }
            else
                Console.Write('#' + "   ");
        }
    }
}
