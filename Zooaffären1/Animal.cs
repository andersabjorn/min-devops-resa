using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooaffäer
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Price { get; set; }
        public string IsAvaliable { get; set; }

        public Animal(int id, string name, string spicies, int age, string price, string isavalible)
        {
            Id = id;
            Name = name;
            Species = spicies;
            Age = age;
            Price = price;
            IsAvaliable = isavalible;
        }
    }
}