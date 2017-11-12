using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSamples.CodeContracts
{
    public class SillyList
    {
        private List<String> _innerList = new List<String>();

        public void Add(string value)
        {
            //Contract.Requires<ArgumentException>(value != null);

            _innerList.Add(value);

            //Contract.Ensures(_innerList.Contains(value));
        }

        public Boolean Contains(string value) => _innerList.Contains(value);

    }
}
