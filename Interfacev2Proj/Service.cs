using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacev2Proj {            //Looks like inheritence, but is implementing Interface
    // Class must include same method names and can be auto generated (but will have to update body to meet our needs)
    public class Service : ICalcSales {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public int Hours { get; set; }



        public Service(int id, string name, int rate, int hours) {
            this.Id = Id;
            this.Name = name;
            this.Rate = rate;
            this.Hours = hours;
        }

        public decimal CalcSales() {                                // We can use this...
            return (decimal)Rate * Hours;
        }
            public string About() {
                return "About Services";
            }
        }
    }
