using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRandomNumberGenerator
{
    class LaggedFibonacciGreenSmithKlem : PRandom
    {
        static ulong _m;
        static ulong _k;

        public LaggedFibonacciGreenSmithKlem()
        {
            _m = 10;
            _seed = number = 1;
            _k = 16;
            _counter = 0;
        }

        public LaggedFibonacciGreenSmithKlem(ulong m, ulong seedNumber, ulong k)
            : base(seedNumber)
        {
            _m = m;
            _k = k;
        }

        public override ulong Rand()
        {
            _counter++;
            number = (number + number - _k) % _m;
            return number;
        }
    }
}
