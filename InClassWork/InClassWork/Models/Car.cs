using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InClassWork.Models
{
    public class Car
    {
        //Simple Car Properties
        [Key]
        public int Car_ID { get; set; } //PK for car

        [Required]
        [RegularExpression("..+", ErrorMessage = "Must be at least 2 characters long")]
        public string Model { get; set; } //Car Model

        [Range(10, 5000)]
        public double MaxSpeed { get; set; } //Max Speed

        public string ImageName { get; set; } //Image

        public int Manufacturer_ID { get; set; }

        public virtual Manufactorer Manufactorer { get ;set;}
    }
}