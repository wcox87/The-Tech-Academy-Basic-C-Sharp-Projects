using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment248
{
    public class Employee<T>
    {
        public void Add(T input) { }
        public List<T> things { get; set; }
    }
}
