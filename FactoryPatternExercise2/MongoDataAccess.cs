using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {

        }

        public List<Products> LoadData()
        {
            Console.WriteLine("Accessing your MongoDb.\n");
                return Products.product;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to your MongoDb.\n");
        }
    }
}
