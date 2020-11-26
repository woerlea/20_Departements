using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Departments
{
    class Person
    {
      public string Name { get; set; }
      public string Department { get; set; }

        public override string ToString() 
        {
            return $"{this.Department}: {this.Name}"; 
        }

    }
}
