using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Roles> roles { get; set; }
    public DbSet<Tasks> tasks { get; set; }

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

public class Blog
{
    public long Id { get; set; }
    public string Url { get; set; }

    public List<Post> Posts { get; } = new();
   
}

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}
public class User
{
    public int Id { get; set; }
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
    public int Id { get; set; }
    public string JobName { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public List<Tasks> Tasks { get; } = new();
}

public class Tasks
{
    public int Id { get; set; }
    public string TaskName { get; set; }
    public int RolesId { get; set; }
    public Roles Roles { get; set; }
}