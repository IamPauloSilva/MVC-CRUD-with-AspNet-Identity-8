using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models
{
    public class Premium
    {
        [Key]

        public int Id
        {
            get; set;
        }
        [DisplayName("Title")]
        [Required(ErrorMessage = "Please add a title!")]
        public string Title { get; set; } = string.Empty;

        
        [DisplayName("Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [DisplayName("Student")]
        [Required(ErrorMessage ="Invalid student")]
        
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
