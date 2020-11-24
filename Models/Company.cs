using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        public string Description { get; set; }
        public string Tags { get; set; }
        public string Images { get; set; }
        public string Video { get; set; }
        public string Topic { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
