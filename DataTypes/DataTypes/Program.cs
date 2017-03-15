using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);
            // LONGS
            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);
    
            // DECIMALS
            // Decimals store 128-bit precise decimal values
            // It is accurate to 28 digits
            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", Decimal.MinValue);
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
            // DOUBLES
            // Doubles are 64-bit float types
            Console.WriteLine("Biggest Double : {0}", Double.MaxValue.ToString("#"));

            // It is precise to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            Console.ReadLine();

        }
    }
}
