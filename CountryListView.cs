using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryListView
    {
        //propertys
        public  List<CountryModel> Countries { get; set; }
        //constructor
        public CountryListView(List<CountryModel> _countries)
        {
            Countries = _countries;
        }
        //method
        public void Display()
        {
            for(int i=1; i<=Countries.Count; i++) 
            {
                
                Console.WriteLine("{0,4}\t{1,-20}", i ,(Countries[i-1].Name));
            }
        }
    }
}
