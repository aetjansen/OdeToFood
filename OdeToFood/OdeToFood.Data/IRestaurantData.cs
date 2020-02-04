using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Arno's Pizza", Location = "Drenthe", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Top Taco's", Location = "Assen", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Enormous Escargots", Location = "Zwolle", Cuisine = CuisineType.French },
                new Restaurant { Id = 4, Name = "Super Stampot", Location = "Groningen", Cuisine = CuisineType.Dutch }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}

