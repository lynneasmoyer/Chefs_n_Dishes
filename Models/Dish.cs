using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required(ErrorMessage="You must include a name.")]
        public string Name {get; set;}


        [Required(ErrorMessage="You must include a tastiness rating.")]
        [Range(1, 5)]
        public int Tastiness {get; set;}
        
        [Required(ErrorMessage="You must include a calorie amount.")]
        [Range(0, Int32.MaxValue)]
        public int Calories {get; set;}

        [Required(ErrorMessage="You must include a description.")]
        public string Description {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [Display(Name="Chef: ")]
        public int ChefId {get;set;}
        public Chef Creator {get;set;}
        
    }
}