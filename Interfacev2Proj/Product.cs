using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacev2Proj {
    public class Product : ICalcSales {         // Looks like inheritence, but is implementing Interface
                                                  // Class must include same method names and can be auto generated
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Units { get; set; }

        public Product(int id, string name, decimal price, int units) {
            this.Id = Id;
            this.Name = name;
            this.Price = price;
            this.Units = units;
        }

        public decimal CalcSales() {
            throw new NotImplementedException();
        }
    }
    }
}
