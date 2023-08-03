using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryView
    {
        //property
        public CountryModel DisplayCountry { get; set; }
        //constructor
        public CountryView(CountryModel _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }
        //Methods
        public void Display()
        {
            Console.WriteLine("{0,10}{1,10}{2,10}"
                , $"Continent {DisplayCountry.Name}",$"  Continent {DisplayCountry.Continent}",$"  Colers {DisplayColers()}");
        }
        public string DisplayColers()
        {
            string colorString = "";
            List<string> colors = DisplayCountry.Colors;
            foreach (string color in colors)
            {
                colorString += " ";
                colorString += color;
            }
            return colorString;
        }

    }
}
