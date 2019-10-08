using System;
using System.Collections.Generic;

namespace Planner{

    class City {
        private string _city;
        private int _yearEstablished;
        public string mayor;
         public List<Building> Buildings { get; set; }
         public void newBuilding(Building building)
        {
            Buildings.Add(building);
        }

        public City(string city, int year)
        {
            _city = city;
            _yearEstablished = year;
            Buildings = new List<Building>();
        }

    }
}
