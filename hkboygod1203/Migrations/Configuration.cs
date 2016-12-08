namespace hkboygod1203.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using hkboygod1203.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<hkboygod1203.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(hkboygod1203.Models.ApplicationDbContext context)
        {
            context.Records.AddOrUpdate(p => p.CustomerName,
        new Record
        {            
            Date = "11/11/2016",
            CustomerName = "Samson Lee",
            ProductName = "Surface Book",
            Quantity = 1,
            DeliveryAddress = "15/F, Cyberport 2, 100 Cyberport Road, Hong Kong",
            Email = "hkboygod@outlook.com",
        },
         new Record
         {
             Date = "11/12/2016",
             CustomerName = "Samson Lee",
             ProductName = "Surface Pro",
             Quantity = 1,
             DeliveryAddress = "15/F, Cyberport 2, 100 Cyberport Road, Hong Kong",
             Email = "hkboygod@outlook.com",
         },
         new Record
         {
             Date = "11/13/2016",
             CustomerName = "Verlebie Chan",
             ProductName = "Surface Pro",
             Quantity = 1,
             DeliveryAddress = "15/F, Cyberport 2, 100 Cyberport Road, Hong Kong",
             Email = "verlebiehololens@outlook.com",
         },
         new Record
         {
             Date = "11/20/2016",
             CustomerName = "Angus Tong",
             ProductName = "Surface Pro",
             Quantity = 1,
             DeliveryAddress = "15/F, Cyberport 2, 100 Cyberport Road, Hong Kong",
             Email = "angustong@outlook.com",
         },
         new Record
         {
             Date = "11/30/2016",
             CustomerName = "Delon Yau",
             ProductName = "Surface Studio",
             Quantity = 1,
             DeliveryAddress = "15/F, Cyberport 2, 100 Cyberport Road, Hong Kong",
             Email = "delonknowsmore@outlook.com",
         }
         );

        }
    }
}
