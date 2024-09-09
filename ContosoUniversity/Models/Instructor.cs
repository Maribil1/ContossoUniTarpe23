using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        
        public string FirstMidName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string LastMidName {  get; set; } 
        public string FullName { get { return LastMidName + "," + FirstMidName; } }//uus andmeväli moodustab juba olemasolevast andmetest
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        [Display(Name ="Hired on:")]
        public DateTime HireDate { get; set; }
        public ICollection<CourseAssignment>?CourseAssignments { get; set; }
        public OfficeAssignment? OfficeAssignment { get; set; }
        public int Age { get; set; }      
        public string? Sex { get; set; }
        public string? Address { get; set; }


    }
}
