using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generices
{
    public class TestKeyValuePair<TKey , TValue>
    {
        public TKey Generickey { get; set; }
        public TValue GenericValue { get; set; }
    }
}
