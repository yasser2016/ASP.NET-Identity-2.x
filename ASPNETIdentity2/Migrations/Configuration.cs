namespace ASPNETIdentity2.Migrations
{
    using ASPNETIdentity2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNETIdentity2.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ASPNETIdentity2.Models.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            // context.Users.AddOrUpdate(new MyUser { UserName = "Gimmi", Id = Guid.NewGuid().ToString(), Email ="gimmi@gmail.com" });
            //
        }
    }
}
