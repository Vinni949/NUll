using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сапер
{
    class Cell
    {
        protected bool open;

        public Cell()
            {
            open = false;
            }
        
        public virtual int OpenCell()
        {
            open = true;
            return 0;
        }
        public virtual void PrintCell()
        {
            

        }
    }
}
