using System;
using System.Linq;
using System.Threading.Tasks;

namespace lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hint: change `DESKTOP-123ABC\SQLEXPRESS` to your server name
            //       alternatively use `localhost` or `localhost\SQLEXPRESS`
            Task task = DoTasks();

            task.Wait();
            string connectionString = @"Data Source=DESKTOP-RFJRJ41\SQLEXPRESS;Initial Catalog=blogdb;Integrated Security=True";

            using (BloggingContext db = new BloggingContext(connectionString))
            {
                var usss = new User
                {
                    FirstName = "Andrzej",
                    LastName = "Jawlak",
                    Age = 11,
                    City = "krakow",
                    Etnicity = "dddd",
                    Gender = "nierozpoznano",
                };
                db.User.Add(usss);
                db.SaveChanges();
                Console.WriteLine("Querying for a user");

                var user = db.User.Where(b => b.Id == usss.Id);
                Console.WriteLine(user.Count());
                Console.WriteLine("Delete the user");

                db.Remove(user);
                db.SaveChanges();
            }

        }
        private static async Task DoTasks()
        {
            int couter = 0;

            for (int i = 0; i < 12; i += 3)
            {
              
                Task<bool> task1 = DoTask(i + 0);
                Task<bool> task2 = DoTask2(i + 1);
              

                // waiting for the all results
                if (await task1) couter += 1;
                if (await task2) couter += 1;
                
            }

            Console.WriteLine("Tasks done: " + couter);
        }

        private static async Task<bool> DoTask(int taskId)
        {
            return await Task<bool>.Run(() =>
            {
                string connectionString = @"Data Source=DESKTOP-RFJRJ41\SQLEXPRESS;Initial Catalog=blogdb;Integrated Security=True";

                using (BloggingContext db = new BloggingContext(connectionString))
                {

                    Console.WriteLine($"Database ConnectionString: {db.ConnectionString}.");

                    // Create
                    Console.WriteLine("Inserting a new user");

                    db.Add(new User
                    {
                        FirstName = "Andrzej",
                        LastName = "Jawlak",
                        Age = 11,
                        City = "krakow",
                        Etnicity = "dddd",
                        Gender = "nierozpoznano",
                    });
                    db.SaveChanges();

                }

                return true;
            });
        }
        private static async Task<bool> DoTask2(int taskId)
        {
            return await Task<bool>.Run(() =>
            {
                string connectionString = @"Data Source=DESKTOP-RFJRJ41\SQLEXPRESS;Initial Catalog=blogdb;Integrated Security=True";

                using (BloggingContext db = new BloggingContext(connectionString))
                {
                    db.Add(new User
                    {
                        FirstName = "Testerawaita",
                        LastName = "tester",
                        Age = 33,
                        City = "krakow",
                        Etnicity = "aaa",
                        Gender = "helikopter",
                    });
                    db.SaveChanges();

                 

                }

                return true;
            });
        }
    }
}
