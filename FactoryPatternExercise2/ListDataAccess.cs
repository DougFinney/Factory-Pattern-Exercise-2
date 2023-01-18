using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {

        }

        public List<Products> LoadData()
        {
            Console.WriteLine("I am reviewing the product list data.\n");
            return Products.product;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the list upon review.\n");
        }
    }
}
