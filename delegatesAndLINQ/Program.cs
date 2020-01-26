#define delegate_1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static delegatesAndLINQ.delegate_1;

namespace delegatesAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
#if delegate_1
            #region delegate_1
            // Problem: 
            // PART I) open delegate_1.cs file and declare the
            // type SayHello as a delegate that takes a single
            // string parameter and returns a string result.

            // PART II) next, declare a delegate of type SayHello with name HelloSayer
            // and assign to it an anonymous function (you can use lambda) which
            // does something useful with the string passed to it. For example, it prints it.


            // type the code for PART II here

            SayHello HelloSayer = x => Console.WriteLine(x);

            HelloSayer("Hello there");
            #endregion

#elif delegate_2
            #region delegate_2

            #endregion
#endif
        }
    }
}
