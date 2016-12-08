using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace hkboygod1203.Models
{
    public class Record
    {
        public int RecordId { get; set; }

        [DataType(DataType.Date)]
        public string Date { get; set; }

        public string CustomerName { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public string DeliveryAddress { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}