using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InClassWork.Models
{
    public class CarFactory : DbContext //inherit the DBCOntext to allow Entity Framework to Manage DB's
    {
        public DbSet<Car> Cars { get; set; } //Create a set of DB ENtites that can work with "Car" instances in a table
        //Default Constuctor
        public CarFactory() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new CarInitializer()); //Initializes the DB
        }
    }

    public class CarInitializer: DropCreateDatabaseIfModelChanges<CarFactory>
    {
        protected override void Seed(CarFactory context) //Method to seed the tables with sample data
        {
            {
                context.Cars.Add(new Models.Car() { Model = "Rabbit", MaxSpeed = 300 }); //add quick car
                context.Cars.Add(new Car() { Model = "Turtle", MaxSpeed = 150 }); //add an avg. car
            }
        }
    }
}