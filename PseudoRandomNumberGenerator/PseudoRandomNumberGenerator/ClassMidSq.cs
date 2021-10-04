using System;

namespace PseudoRandomNumberGenerator
{
    class MiddleSquare : PRandom
    {
        public MiddleSquare()
        {
            DateTime date = DateTime.Now;
            _seed = number = (ulong)(date.Ticks % 100000000 + date.Ticks / 100000000);
            _counter = 0;
        }

        public MiddleSquare(ulong seedNumber)
            : base(seedNumber) { }
        
        public override ulong Rand()
        {
            _counter++;
            int leng = number.ToString().Length;
            number *= number;
            string strNumber = number.ToString();
            while (strNumber.Length != leng * 2)
            {
                strNumber = "0" + strNumber;
            }
            number = ulong.Parse(strNumber.Substring(leng / 2, leng));
            return number;
        }
    }
}
