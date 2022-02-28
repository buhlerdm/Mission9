using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreProject.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseID { get; set; }

        [BindNever]
        public ICollection<PurchaseLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an Address")]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Please enter an Address")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a zipcode")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }

    }
}
