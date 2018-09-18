using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace saf_kaizala_api.Models
{
    public class ProductRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public string ProductActivationReady { get; private set; }
        public double? Latitude { get; private set; }
        public double? Longitude { get; private set; }
        public string LocationDescription { get; private set; }        
        public Guid SenderId { get; private set; }
        public string SenderName { get; private set; }
        public string SenderPhoneNumber { get; private set; }

        [Required(AllowEmptyStrings = false)]
        public string CorrelationId { get; private set; }
        public int CustomerId { get; private set; }

        public virtual Customer Customer { get; set; }

        public ProductRegistration()
        {

        }

        public ProductRegistration(string name, string activationReady,
            double? latitude, double? longitude, string locationDescription,
            Sender senderInfo,
            string correlationId,
            int customerId)
        {
            this.ProductName = name;
            this.ProductActivationReady = activationReady;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.LocationDescription = locationDescription;
            this.SenderId = senderInfo.Id;
            this.SenderName = senderInfo.Name;
            this.SenderPhoneNumber = senderInfo.PhoneNumber;
            this.CorrelationId = correlationId;
            this.CustomerId = customerId;
        }
    }

    public class Sender
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}