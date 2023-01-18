namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? List, SQL, or MongoDb");

            var response = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(response);

            List<Products> product = data.LoadData();

            data.SaveData();

            Console.WriteLine("Your items have been loaded:");
            foreach (var item in product)
            {
                Console.WriteLine($"Product Name: {item.Name}");
                Console.WriteLine($"Price: {item.Price}\n");
            }
        }
    }
}
