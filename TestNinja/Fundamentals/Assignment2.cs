
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    { 
        public IEnumerable<int> GetOddNumbers(int lim)
        {
            for (var i = 0; i <= lim; i++) 
                if(Math.Sqrt(i)%1==0)
                    yield return i;
        }
    }
}