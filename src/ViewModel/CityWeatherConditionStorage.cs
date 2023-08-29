using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public interface CityWeatherConditionStorage
    {
        public void Insert(CityWeatherCondition condition);
        public List<CityWeatherCondition> GetAll();
    }
}
