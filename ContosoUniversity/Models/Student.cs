using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }


        [StringLength(50, ErrorMessage = "First NAme can not bi longer then 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }


        [Display(Name = "Full Name")]
        public string FullName {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}