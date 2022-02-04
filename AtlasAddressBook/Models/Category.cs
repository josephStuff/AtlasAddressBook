using System.ComponentModel.DataAnnotations;

namespace AtlasAddressBook.Models
{
    public class Category
    {
        // ---------------------   PRIMARY KEY -------------------
        public int Id { get; set; }

        // ---------------------  FOREIGN KEY ---------------------
        public string? UserId { get; set; }


        [Required]
        [Display(Name = "Category Name")]
        public string? Name { get; set; }

        // --------------------- NAVIGATION PROPERTIES ------------------
        public virtual AppUser? User { get; set; }


        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    }
}
