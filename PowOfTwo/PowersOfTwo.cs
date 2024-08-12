using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowOfTwo
{
    internal class PowersOfTwo : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            var maxPow = Math.Round(Math.Log(int.MaxValue, 2));
            for(int i = 0; i<maxPow; i++)
                yield return (int)Math.Pow(2, i);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int this[int index]
        {
            get { return (int)Math.Pow(2, index); }
        }
    }
}
