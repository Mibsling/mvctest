using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace mvctest.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter your first name")]
        public string CustFirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string CustLastName { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        public string CustAddress { get; set; }
        [Required(ErrorMessage = "Please enter your city")]
        public string CustCity { get; set; }
        [Required(ErrorMessage = "Please enter your province")]
        public string CustProv { get; set; }
        [Required(ErrorMessage = "Please enter your postal code")]
        [StringLength(7)]
        public string CustPostal { get; set; }
        [StringLength(2)]
        public string CustCountry { get; set; }
        public string CustHomePhone { get; set; }
        [Required(ErrorMessage = "Please enter your business phone number")]
        public string CustBusPhone { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string CustEmail { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int? AgentId { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string PasswordNotHashed { get; set; }
        public byte[] PasswordHashed { get; set; }
        public Guid? PasswordSalt { get; set; }
    }
}
