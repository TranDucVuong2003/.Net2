using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.NET2.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public required string StudentID { get; set; }
        public required string FullName { get; set; }
        public required string Address { get; set; }
        public required string Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        [DataType(DataType.Date)]
        public required string Birthday { get; set; }
        public required string IActive { get; set; }
    }
}
