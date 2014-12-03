using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailExam
{
    public class CountingDictionary<T>
    {
        private readonly IDictionary<T, int> _dict = new Dictionary<T, int>();
        public int Count { get { return _dict.Count; } }

        public int Add(T element)
        {
            if (_dict.ContainsKey(element))
            {
                var howMany = _dict[element] + 1;
                _dict[element] = howMany;
                return howMany;
            }
            _dict[element] = 1;
            return 1;
        }

        public int Get(T element)
        {
            if (_dict.ContainsKey(element))
            {
                return _dict[element];
            }
            return 0;
        }

        public int Remove(T element)
        {
            if (_dict.ContainsKey(element))
            {
                int howMany = _dict[element] - 1;
                if (howMany == 0)
                {
                    _dict.Remove(element);
                }
                else
                {
                    _dict[element] = howMany;
                }
                return howMany;
            }
            return -1;
        }
    }
}
