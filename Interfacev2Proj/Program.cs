using System;

namespace Interfacev2Proj {
    class Program {
        static void Main(string[] args) {

            var p1 = new Product(1, "Basic Widget", 10, 2500);
            var p2 = new Product(2, "Advanced Widget", 25, 1500);
            var p3 = new Product(3, "Supreme Widget", 50, 1000);

            var s4 = new Service(4, "Basic Service", 25, 1000);
            var s5 = new Service(5, "Priority Service", 50, 550);
            var s6 = new Service(6, "24x7 Service", 100, 750);
        }


    }
}
