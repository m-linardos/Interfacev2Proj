using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacev2Proj {
    public class Membership : ICalcSales {          //Looks like inheritence, but is implementing Interface
        // Class must include same method names and can be auto generated (but will have to update body to meet our needs)

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Units { get; set; }

        public Membership(int id, string name, decimal price, int units) {
            this.Id = Id;
            this.Name = name;
            this.Price = price;
            this.Units = units;
        }

        public decimal CalcSales() {                                // We can use this 
            return Price * Units;
        }

        public string About() {
            return "About Membership";
        }
    }


}

