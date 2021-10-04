using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRandomNumberGenerator
{
    class LinearCongruential : PRandom
    {
        static ulong _modulus;
        static ulong _multiplier;
        static ulong _increment;

        public LinearCongruential()
        {
            _modulus = 4294967295;
            _multiplier = 214013;
            _increment = 2531011;
            _seed= number = 1;
            _counter = 0;
        }

        public LinearCongruential(ulong modulus, ulong multiplier, ulong increment, ulong seedNumber)
            : base(seedNumber)
        {
            _modulus = modulus;
            _multiplier = multiplier;
            _increment = increment;
        }

        public override ulong Rand()
        {
            _counter++;
            number = (_multiplier * number + _increment) % _modulus;
            return number;
        }
    }
}
