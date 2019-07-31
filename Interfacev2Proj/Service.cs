using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacev2Proj {
    public class Service {

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
    }
}
