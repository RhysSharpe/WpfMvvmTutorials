using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvvmDemo
{
    // Remember that Model classes only contain data, not behaviour, that's why these classes should contain only properties.

    public class Model
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsMale { get; set; }
    }
}
