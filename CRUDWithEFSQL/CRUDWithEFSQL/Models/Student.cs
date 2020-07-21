using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithEFSQL.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string RollNo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Class { get; set; }

        public string Year { get; set; }
    }
}
