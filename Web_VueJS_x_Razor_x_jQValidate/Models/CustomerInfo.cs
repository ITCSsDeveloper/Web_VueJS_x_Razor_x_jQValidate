using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_VueJS_x_Razor_x_jQValidate.Models
{
    public class HomeModel
    {
        public CustomerInfo vCustomerInfo = new CustomerInfo();

        public List<CustomerInfo> CustomerInfo { get; set; }
    }

    public class CustomerInfo
    {
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "This Fild Should be minimum 3 characters and a maximum of 50 characters")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "This Fild Should be minimum 3 characters and a maximum of 50 characters")]
        public string LastName { get; set; }

        [Phone]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$", ErrorMessage = "Email is required and must be properly formatted.")]
        public string Email { get; set; }

        public int Age { get; set; }

        //[Display(ResourceType = typeof(DTOResources), Name = "Income")]
        public decimal Income { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime BirthDate { get; set; }

        public List<int> FavColor { get; set; }
    }

    public class PaymentInfo
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PaymentDate { get; set; }

        public decimal PaymentValue { get; set; }
    }
}