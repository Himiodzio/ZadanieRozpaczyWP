using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bazadanychcalosc
{
    public class Postac
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Postac() { }

        public Postac(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
