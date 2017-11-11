using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSamples.Dictionary
{
    public class SlightlyBetterDictionary : SillyDictionary
    {
        private Dictionary<String, String> _innerDictionary = new Dictionary<String, String>();


        public override void Add(String key, String value) => _innerDictionary.Add(key, value);

        public override String GetValue(String key) => _innerDictionary[key];
    }
}
