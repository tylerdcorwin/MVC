using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;

namespace Tyler_MVC.Models
{
    public class HuluFactory : DbContext
    {
        public DbSet<Hulu> Hulu { get; set; }
        
        //Default Constructor
        public HuluFactory() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new HuluInitializer());
        }

        public class HuluInitializer: DropCreateDatabaseIfModelChanges<HuluFactory>
        {
            protected override void Seed(HuluFactory context) //Seed tables with sample data
            {
                base.Seed(context);
                context.Hulu.Add(new Hulu()
                {
                    Title = "The Emoji Movie",
                    Genre = "Animation",
                    Image = "~/Images/Emoji.jpg",
                    Rating = "PG",
                    Description = "Funny animated movie about phone emoji's" +
                    " much sillyness such wonder",
                    Movie = true
                });
            }
        }

    }
}