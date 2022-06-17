using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Hint: change DESKTOP-123ABC\SQLEXPRESS to your server name
        //       alternatively use localhost or localhost\SQLEXPRESS

        string connectionString = @"Data Source=localhost;Initial Catalog=blogdb;Integrated Security=True";

        using (BloggingContext db = new BloggingContext(connectionString))
        {
            Console.WriteLine($"Database ConnectionString: {db.ConnectionString}.");

            // Create
            Console.WriteLine("Inserting a new user");

            db.Add(new User
            {
                FirstName = "Jan",
                LastName = "Nowak",
                Age = 45,
                City = "Krakow",
                Etnicity = "Caucasian",
                Gender = "Male",
            });
            db.SaveChanges();

            // Read
            Console.WriteLine("Querying for a user");

            User user = db.User
                .OrderBy(b => b.Id)
                .First();

            // Update
            Console.WriteLine("Updating the user and adding a role");

            user.FirstName = "Karol";
            user.Roles.Add(new Roles { JobName = "Network Admin" });
            db.SaveChanges();

            // Delete
            Console.WriteLine("Delete the user");

            db.Remove(user);
            db.SaveChanges();
        }
    }
}