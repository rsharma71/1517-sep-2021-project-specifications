﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StarTEDLibruary.Entities
{
    [Index(nameof(SchoolCode), Name = "IX_SchoolCode")]
    public partial class Program
    {
        public Program()
        {
            ProgramCourses = new HashSet<ProgramCourse>();
        }

        [Key]
        public int ProgramID { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ProgramName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string DiplomaName { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string SchoolCode { get; set; }
        [Column(TypeName = "money")]
        public decimal Tuition { get; set; }
        [Column(TypeName = "money")]
        public decimal InternationalTuition { get; set; }

        [ForeignKey(nameof(SchoolCode))]
        [InverseProperty(nameof(School.Programs))]
        public virtual School SchoolCodeNavigation { get; set; }
        [InverseProperty(nameof(ProgramCourse.Program))]
        public virtual ICollection<ProgramCourse> ProgramCourses { get; set; }
    }
}