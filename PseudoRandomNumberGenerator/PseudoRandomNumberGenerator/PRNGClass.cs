using System;

namespace PseudoRandomNumberGenerator
{
    abstract class PRandom
    {
        public ulong _counter { get; set; }
        public ulong _seed { get; set; }
        public ulong number { get; set; }

        public PRandom() { }
        public PRandom(ulong seedNumber)
        {
            number = _seed = seedNumber;
            _counter = 0;
        }

        public abstract ulong Rand();
    }
}
