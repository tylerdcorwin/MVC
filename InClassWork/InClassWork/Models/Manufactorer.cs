using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InClassWork.Models
{
    public class Manufactorer
    {
        //Simple car properties
        [Key]
        public int Manufacturer_ID { get; set; } //PK for manufacurer

        [Required(ErrorMessage = "Car manufactorer is required")]
        [RegularExpression("..+", ErrorMessage = "Must be at least 2 chars long")]

        public string make { get; set; }

        public virtual ICollection<Car> Cars { get; set; } //list of associated cars

    }
}