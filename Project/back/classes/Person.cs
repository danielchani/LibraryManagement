using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.back.classes
{
    [Serializable]
    public abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        

        protected Person(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
