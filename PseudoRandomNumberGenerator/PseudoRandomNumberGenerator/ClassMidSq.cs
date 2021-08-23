using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRandomNumberGenerator
{
    class MiddleSquare
    {
        static int _counter;
        static Int64 _seedNumber;
        static Int64 number;
        //public List<string> MiddleSquare()
        //{
        //    int seedNumber = 1234;
        //    int leng = seedNumber.ToString().Length;
        //    List<string> alreadySeen = new List<string>();
        //    int number = seedNumber;
        //    int counter = 0;
        //    bool notIn = true;
        //    do
        //    {
        //        counter++;
        //        alreadySeen.Add(number.ToString());
        //        number = number * number;
        //        string strNumber = number.ToString();
        //        while (strNumber.Length != leng)
        //        {
        //            strNumber = "0" + strNumber;
        //        }
        //        alreadySeen.Add(strNumber);
        //        number = int.Parse(strNumber.Substring(2, 4));
        //        if (alreadySeen.Contains(number.ToString()))
        //            notIn = false;
        //    } while (notIn);
        //    return alreadySeen;
        //}
        //public List<string> MiddleSquare(int seedNumber)
        //{
        //    int leng = seedNumber.ToString().Length;
        //    List<string> alreadySeen = new List<string>();
        //    int number = seedNumber;
        //    int counter = 0;
        //    bool notIn = true;
        //    do
        //    {
        //        counter++;
        //        alreadySeen.Add(number.ToString());
        //        number = number * number;
        //        string strNumber = number.ToString();
        //        while (strNumber.Length != leng * 2)
        //        {
        //            strNumber = "0" + strNumber;
        //        }
        //        alreadySeen.Add(strNumber);
        //        number = int.Parse(strNumber.Substring(leng / 2, leng));
        //        if (alreadySeen.Contains(number.ToString()))
        //            notIn = false;
        //    } while (notIn);
        //    return alreadySeen;
        //}
        public MiddleSquare()
        {
            DateTime date = DateTime.Now;
            _seedNumber = number = date.Ticks % 100000000 + date.Ticks / 100000000;
            _counter = 0;
        }

        public MiddleSquare(Int64 seedNumber)
        {
            number = _seedNumber = seedNumber;
            _counter = 0;
        }
        
        public Int64 MiddleMiddle()
        {
            _counter++;
            int leng = number.ToString().Length;
            number = number * number;
            string strNumber = number.ToString();
            while (strNumber.Length != leng * 2)
            {
                strNumber = "0" + strNumber;
            }
            number = Int64.Parse(strNumber.Substring(leng / 2, leng));
            return number;
        }

        public Int64 Counter { get { return _counter; } }
        public Int64 SeedNumber { get { return _seedNumber; } }
    }
}
