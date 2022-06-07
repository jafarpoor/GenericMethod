using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generices
{
    public class GenericClass<T> where T : ClassA
    {
        public int ValueClassGenericClass { get; set; }

        // ClassC is inValid
    }

    public class ClassA { public int ValueClassA { get; set; } }

    public class ClassB : ClassA { public int ValueClassB { get; set; } } 

    public class ClassC { }
}
