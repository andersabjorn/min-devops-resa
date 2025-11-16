using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zooaffäer;

namespace Zooaffären1
{
    public class Hanteraren
    {
        public List<Animal> _lista = new List<Animal>();

        public void AddAnimal(Animal djur)
        {
            _lista.Add(djur);
        }
        public List<Animal> GetAllAnimals()
        {
            return _lista;
        }

        public bool DeleteAnimal(int id)
        {
            Animal djurAttTaBort = HittaDjur(id);
            if (djurAttTaBort != null)
            {
                _lista.Remove(djurAttTaBort);
                return true;
            }
            return false;
        }
        private Animal HittaDjur(int id)
        {

            return _lista.FirstOrDefault(a => a.Id == id);

        }
    }

}

