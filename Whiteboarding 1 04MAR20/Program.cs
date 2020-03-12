using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboarding_1_04MAR20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = {  1, 1, 5, 2, 5, 2, 3, 3, 6, 4, 6, 4};
            Console.WriteLine();
            Console.WriteLine(RepByteArr(myarr));
        }
        //take a byte array with values from 0 - 255
        //
        public static bool RepByteArr(int[] x)
        {
            Array.Sort(x);
            for(int i = 0; i < x.Length/2; i =+ 2)
            {
                if (x[i] == x[i+1] )
                {
                    return true;
                }
                break;
            }
            return false;

        }

    }
    
  
}
