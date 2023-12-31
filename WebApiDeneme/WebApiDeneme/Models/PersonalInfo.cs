﻿namespace WebApiDeneme.Models
{
    public class PersonalInfo : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }  
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }



    }
}
