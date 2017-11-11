using System;
using System.Collections.Generic;

namespace LiskovSamples.Dictionary
{
    public class SillyDictionary
    {
        private List<String> _keys = new List<String>();
        private List<String> _values = new List<String>();

        public virtual void Add(String key, String value)
        {
            _keys.Add(key);
            _values.Add(value);
        }

        public virtual String GetValue(String key)
        {
            int valueIndex = _keys.IndexOf(key);
            if (valueIndex == -1)
                return null;

            return _values[valueIndex];
        }
    }
}
