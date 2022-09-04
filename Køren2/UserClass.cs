using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køren2
{
    internal class UserClass
    {
        //Properties
        private string name;

        //Encapsulation
        public string Name
        {
            get { return name; }
        }

        //constructer
        public UserClass(string name)
        {
            this.name = name;
        }

        //Override ToString
        public override string ToString()
        {
            return name;
        }
    }
}
