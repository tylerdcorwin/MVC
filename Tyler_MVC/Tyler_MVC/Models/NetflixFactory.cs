using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;

namespace Tyler_MVC.Models
{
    public class NetflixFactory : DbContext
    {
        public DbSet<Netflix> Netflix { get; set; }
        //Default construtor
        public NetflixFactory() : base("name=DefaultConnection") //Initializes DB
        {
            Database.SetInitializer(new NetflixInitializer());
        }

        public class NetflixInitializer: DropCreateDatabaseIfModelChanges<NetflixFactory>
        {
            protected override void Seed(NetflixFactory context) //Method to seed the tables with sample data
            {
                base.Seed(context);
                context.Netflix.Add(new Netflix()
                {
                    Title = "The Punisher",
                    Genre = "Action",
                    Image = "~/Images/Punisher.jpg",
                    Rating = "R",
                    Description = "Action packed movie starring some dude" +
                    " with many explosions and stuffs",
                    Movie = true
                });
                //context.Netflix.Add(new Netflix() //Models.Netflix
                //{
                //    Title = "The Emoji Movie",
                //    Genre = "Animation",
                //    Image = "~/Images/Emoji.jpg",
                //    Rating = "PG",
                //    Description = "Funny animated movie about phone emoji's" +
                //    " much sillyness such wonder",
                //    Movie = true
                //});
            }
        }
    }
}