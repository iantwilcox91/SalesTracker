using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesTracker.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }

        public Item(string name, string description, decimal cost, int quantity, int id)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Quantity = quantity;
            Id = id;
        }
        public Item() { }
    }
}