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
        public string Model { get; set; } //Car Model
        public double MaxSpeed { get; set; } //Max Speed

    }
}