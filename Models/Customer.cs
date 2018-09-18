using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace saf_kaizala_api.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required (AllowEmptyStrings = false)]
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string Surname { get; private set; }
        public string IdentificationNumber { get; private set; }
        public string PhoneNumber { get; private set; }

        public Customer()
        {

        }

        public Customer(string firstname, string middlename, string surname, 
        string identificationNumber, string phoneNumber)
        {
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.Surname = surname;
            this.IdentificationNumber = identificationNumber;
            this.PhoneNumber = phoneNumber;
        }
    }
}