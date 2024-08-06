using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actividad_10
{
    abstract class Products
    {
        public string Name { get; set; }
        public Products(string name)
        {
            Name = name;
        }
    }
}