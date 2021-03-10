using Obl_Opgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OblOpgave4REST.Managers
{
    public class BeersManager
    {
        private static readonly List<Beer> Data = new List<Beer>()
        {
            new Beer(){Name = "Grøn Tuborg", Id = 1, Price = 20, Abv = 4.6 },
            new Beer(){Name = "Tuborg Guld", Id = 2, Price = 25, Abv = 5.6 },
            new Beer(){Name = "Carlsberg Elephant", Id = 3, Price = 29, Abv = 7.2 },

        };

        public List<Beer> GetAll(string name, int id, int price, double abv)
        {
            List<Beer> beers = new List<Beer>(Data);
            return beers;
        }

        public Beer GetById(int id)
        {
            return Data.Find(beer => beer.Id == id);
        }

        public Beer Add(Beer value)
        {
            Data.Add(value);
            return value;
        }

        public Beer Delete(int id)
        {
            Beer beer = Data.Find(item1 => item1.Id == id);
            if (beer == null) return null;
            Data.Remove(beer);
            return beer;
        }

        public Beer Update(int id, string name, int price, double abv, Beer value)
        {
            Beer beer = Data.Find(item1 => item1.Id == id);
            if (beer == null) return null;
            beer.Name = value.Name;
            beer.Id = value.Id;
            beer.Price = value.Price;
            beer.Abv = value.Abv;
            return beer;
        }
    }
}
