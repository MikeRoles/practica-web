using MyAsp.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyAsp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="+KPitza",Location="BArcelona",Cuisine=CuisineType.Indian},
                new Restaurant{Id=2,Name="Burguer King",Location="Girona",Cuisine=CuisineType.Mexican},
                new Restaurant{Id=3,Name="Japo",Location="Lleida",Cuisine=CuisineType.Italian}
            };

       }


        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;

        }
    }
}
