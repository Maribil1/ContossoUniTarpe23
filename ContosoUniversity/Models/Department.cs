﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department
    {
        [Key] 
        public int DepartmentID { get; set; }
        [StringLength(100, MinimumLength =3)]
        public string Name { get; set;}
        [DataType(DataType.Currency)]
        [Column(TypeName ="Money")]
        public decimal Budget { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}" , ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Required]
        [StringLength(500)]
        public string? DepartmentHead { get; set; }
        [Required]
        [StringLength(500)]
        public string? DepartmentCleaner { get; set; }
        public int? InstructorID { get; set; }
        public byte? RowVersion { get; set; }
        public Instructor? Administrator { get; set; }
        public ICollection<Course>? Courses { get; set; }
           

    }
}
