using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Calcadd
    {
        Calc c;
        public Calcadd()
        {
            c = new Calc();
            c.num1 = 10;
            c.num2 = 12;
        }

        public Calcadd(Calc c)
        {
            this.c = c;
        }
        public Calc Add()
        {
            c.answer = c.num1 + c.num2;
            return c;
        }
    }
}
