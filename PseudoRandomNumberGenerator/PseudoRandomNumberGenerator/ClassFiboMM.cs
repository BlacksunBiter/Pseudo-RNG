using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRandomNumberGenerator
{
    class ClassFiboMitchellMoore
    {
        static ulong _m;
        static List<ulong> _seed;
        static List<ulong> number;
        static ulong _counter;

        public ClassFiboMitchellMoore()
        {
            _m = 100;
            _counter = 55;
            for (ulong i =0; i<_counter; i++)
            {
                _seed.Add(i);
            }
             number = _seed;
            
        }

        public ClassFiboMitchellMoore(ulong m, List<ulong> seed)
        {
            if (m % 2 != 1)
                _m = m;
            else
                _m = m + 1;
            _seed = number = seed;
            _counter = 55;
        }

        public ulong Rand()
        {
            _counter++;
            number.Add((number[number.Count-23] + number[number.Count - 24]) % _m);
            return number[number.Count-1];
        }

        public ulong Counter { get { return _counter; } }
        public List<ulong> Seed { get { return _seed; } }
        public List<ulong> Number { get { return number; } }
    }
}
