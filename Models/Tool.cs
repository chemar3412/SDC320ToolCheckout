/*********************
Name: Chelsea Martin
Date: 5/31/2026
Assignment: SDC320 Course Project Tool Checkout System
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolCheckout.Models
{
    [Table("Tools")]
    public class Tool : Asset
    {
        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public bool IsCheckedOut { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ReplacementCost { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? LastModified { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        // Navigation property
        public virtual ICollection<CheckoutRecord> CheckoutRecords { get; set; } = new List<CheckoutRecord>();

        public Tool()
        {
        }

        public Tool(int id, string name, string category)
            : base(id, name)
        {
            Category = category;
            IsCheckedOut = false;
            DateAdded = DateTime.Now;
        }

        public void Update(string newName, string newCategory)
        {
            Name = newName;
            Category = newCategory;
            LastModified = DateTime.Now;
        }

        public override string GetInfo()
        {
            string status = IsCheckedOut ? "Checked Out" : "Available";
            return $"Tool ID: {Id}\nName: {Name}\nCategory: {Category}\nStatus: {status}";
        }

        public override string ToString()
        {
            return $"{Name} ({Category}) - {(IsCheckedOut ? "Checked Out" : "Available")}";
        }
    }
}
