using System;

namespace Interfacev2Proj {
    class Program {
        static void Main(string[] args) {

            var p1 = new Product(1, "Basic Widget", 10, 2500);
            var p2 = new Product(2, "Advanced Widget", 25, 1500);
            var p3 = new Product(3, "Supreme Widget", 50, 1000);

            var s1 = new Service(4, "Basic Service", 25, 1000);
            var s2 = new Service(5, "Priority Service", 50, 550);
            var s3 = new Service(6, "24x7 Service", 100, 750);

            var m1 = new Membership(7, "Basic", 100, 1500);                 //  7/31 part2 25:00 Memb class added
            var m2 = new Membership(8, "Basic", 100, 1500);
            var m3 = new Membership(9, "Basic", 100, 1500);



            //var products = new Product[] { p1, p2, p3 };        // initializing an array is one of the only time you will put a ';' after curly brace
            //var services = new Service[] { s1, s2, s3 };
            var pands = new ICalcSales[] { p1, p2, p3, s1, s2, s3, m1, m2, m3};
           
           var total = 0M;// 'M' makes total a decimal or you could add 'decimal' in front of total

            foreach (var pors in pands) {               /// To add new prod or serv, you dont have to change a lot, just 
                total += pors.CalcSales();
            }

                //foreach(var prod in products) {
                //    total += prod.CalcSales();
                //}

                //foreach (var serv in products) {
                //    total += serv.CalcSales();
                //}

                Console.WriteLine($"Total sales is {total}");
          
        }


    }
}
