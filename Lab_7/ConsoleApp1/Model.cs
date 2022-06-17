using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Tasks> Tasks { get; set; }

    public string ConnectionString { get; }

    public BloggingContext(string connectionString)
    {
        this.ConnectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(this.ConnectionString);
    }
}

public class User
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string Etnicity { get; set; }
    public string Gender { get; set; }
    public List<Roles> Roles { get; } = new();
}

public class Roles
{
    public long Id { get; set; }
    public string JobName { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public List<Tasks> Tasks { get; } = new();
}

public class Tasks
{
    public long Id { get; set; }
    public string TaskName { get; set; }
    public long RolesId { get; set; }
    public Roles Roles { get; set; }
}