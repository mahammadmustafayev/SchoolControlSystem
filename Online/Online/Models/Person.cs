using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Models
{
    public class Person
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual int Age { get; set;}
    }
}
