using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBindingMVVM
{
    class Model
    {
        public string Name { get; set; }

        public Model(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}", Name);
        }
    }
}
