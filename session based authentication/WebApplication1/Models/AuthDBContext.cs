namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AuthDBContext : DbContext
    {
        // Your context has been configured to use a 'AuthDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplication1.Models.AuthDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AuthDBContext' 
        // connection string in the application configuration file.
        public AuthDBContext()
            : base("name=AuthDBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<UserInformation> UserTable { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}