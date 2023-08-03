using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TimTool;

namespace MVC_Countries
{
    internal class CountryController
    {
        //properties
        public List<CountryModel> CountryDb { get; set; }
        ////Constructor
        public
            CountryController()
        {
            CountryDb = new List<CountryModel>()
            {
                new CountryModel("Canada" ,"NorthAmerica" ,"red","Wite" ),
                new CountryModel("Mexico","NorthAmerica" ,"green","Wite","red" ),
                new CountryModel("USA","NorthAmerica" ,"red","Wite","Blue " ),
            };
        }

        //methods
        public void WelcomeAction()
        {
            do
            {
                Console.WriteLine("Hello, welcome to the country app.\n " +
                    "Please select a country from the following list:");
                CountryListView menuList = new CountryListView(CountryDb);
                menuList.Display();
                int chois = Gatekeeper.GetPositiveInputIntBetween(1, CountryDb.Count);
                CountryAction(CountryDb[chois-1]);
            }while (Gatekeeper.GetContinue());
        }
        public void CountryAction(CountryModel c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }
    }
}
