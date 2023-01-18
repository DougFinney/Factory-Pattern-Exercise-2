using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public static List<Products> product = new List<Products>()
        {
        new Products() { Name = "Fishing Pole", Price = 100.00 },
        new Products() { Name = "Tackle", Price = 50.00 },
        new Products()  { Name = "Bait",Price = 25.00 },
        };
    }
}
