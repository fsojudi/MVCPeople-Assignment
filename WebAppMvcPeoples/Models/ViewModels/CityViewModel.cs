using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPeople.Models.ViewModels
{
    public class CityViewModel
    {
        public List<City> Cities { get; set; }


        public CityViewModel() { Cities = new List<City>(); }
    }

}
