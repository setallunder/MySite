using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySite.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.DateTime)]
        public string Description { get; set; }
        public string Tags { get; set; }
        public string Images { get; set; }
        public string Video { get; set; }
        public string Topic { get; set; }
        public DateTime ExpiryDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
