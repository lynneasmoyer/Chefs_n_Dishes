using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}

        [Required(ErrorMessage="You must include a first name.")]
        public string FirstName {get; set;}


        [Required(ErrorMessage="You must include a last name.")]
        public string LastName {get;set;}


        [Required(ErrorMessage="You must include your birthday.")]
        [FutureDate]
        [DataType(DataType.Date)]
        public DateTime Birthday {get;set;}

        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Dish> CreatedDishes {get;set;}

    

    public int Age()
        {
        int age = DateTime.Now.Year - Birthday.Year;

        if(DateTime.Now.Month < Birthday.Month)
        {
            if(DateTime.Now.Day < Birthday.Day)
            {

            }
        }
        return age;

        }

    public class FutureDateAttribute : ValidationAttribute
        {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime check;
            if(value is DateTime)
            {
                check = (DateTime)value;
            }
            else
            {
                return new ValidationResult("Invalid birthday");
            }
            if(check > DateTime.Now)
            {
                return new ValidationResult("Your birthday must be in the past!");
            }
            return ValidationResult.Success;
        }


    }

}
}