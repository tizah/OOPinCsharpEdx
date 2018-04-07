using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    abstract class Person
    {
        private string name;
        private int age;

        public string Name {
            get
            {
                return name;
            }
                set
            {
                Name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
