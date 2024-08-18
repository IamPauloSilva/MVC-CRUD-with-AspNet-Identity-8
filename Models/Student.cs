using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please add a name!")]
        [DisplayName("Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please add an email!")]
        [DisplayName("Mail")]
        [EmailAddress(ErrorMessage ="Invalid Email!")]
        public string email { get; set; } = string.Empty;

        public List<Premium> Premiums { get; set; } = new();

    }
}
