using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower()) 
            {
                case "list":
                case "List":
                    return new ListDataAccess();
                case "sql":
                case "mysql":
                    return new SQLDataAccess();
                case "mongo":
                case "mongoDb":
                    return new MongoDataAccess();
                default:
                    return new SQLDataAccess();
            }
        }
    }
}
