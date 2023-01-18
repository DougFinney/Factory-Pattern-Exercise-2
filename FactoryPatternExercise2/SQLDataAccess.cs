using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {

        }

        public List<Products> LoadData()
        {
            Console.WriteLine("I am accessing SQL database.\n");
            return Products.product;
        }

        public void SaveData()
        {
            Console.WriteLine("Savig data to SQL database.\n");
        }
    }
}
