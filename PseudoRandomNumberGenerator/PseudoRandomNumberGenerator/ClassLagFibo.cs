using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRandomNumberGenerator
{
    class LaggedFibonacci : PRandom
    {
        static ulong _m;
        static ulong _seed1;
        static ulong number1;

        public LaggedFibonacci()
        {
            _m = 10;
            _seed = number = 1;
            _seed1 = number1 = 2;
            _counter = 0;
        }

        public LaggedFibonacci(ulong mo, ulong seedNumber, ulong seed1)
            : base(seedNumber)
        {
            _m = mo;
            _seed1 = number1 = seed1;
        }

        public override ulong Rand()
        {
            _counter++;
            if (_counter % 2 == 1)
            {
                number1 = (number + number1) % _m;
                return number1;
            }
            else
            {
                number = (number + number1) % _m;
                return number;
            }
        }
    }
}
