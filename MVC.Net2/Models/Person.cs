using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.NET2.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public required string PersonID { get; set; }
        public required string FullName { get; set; }
        public required string Address { get; set; }
    }
}
