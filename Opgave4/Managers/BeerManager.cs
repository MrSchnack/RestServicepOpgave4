using System.Collections.Generic;
using Opgave1;

namespace Opgave4.Controllers
{
    public class BeerManager
    {
        private static int _nextId = 1;
        private static readonly List<Beer> Data = new List<Beer>
        {
            new Beer {Id = _nextId++, Name = "Tuborg", Price = 12.50, Abv = 4.6 },
            new Beer {Id = _nextId++, Name = "Carlsberg", Price = 13.50, Abv = 4.5},
            new Beer {Id = _nextId++, Name = "Guiness", Price = 14.50, Abv = 5.5}
        };

        public BeerManager()
        {
        }
        
        public List<Beer> GetAll()
        {
            return new List<Beer>(Data);
        }

        public Beer GetById(int id)
        {
            return Data.Find(beer => beer.Id == id);
        }

        public Beer Add(Beer newBeer)
        {
            newBeer.Id = _nextId++;
            Data.Add(newBeer);
            return newBeer;
        }
        public Beer Delete(int id)
        {
            Beer beer = Data.Find(beer1 => beer1.Id == id);
            if (beer == null) return null;
            Data.Remove(beer);
            return beer;
        }
        public Beer Update(int id, Beer updates)
        {
            Beer beer = Data.Find(beer1 => beer1.Id == id);
            if (beer == null) return null;
            beer.Name = updates.Name;
            beer.Price = updates.Price;
            beer.Abv = updates.Abv;
            return beer;


        }

    };
}