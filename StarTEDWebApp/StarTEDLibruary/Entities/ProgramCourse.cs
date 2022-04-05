﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StarTEDLibruary.Entities
{
    [Index(nameof(CourseID), Name = "IX_CourseID")]
    [Index(nameof(ProgramID), Name = "IX_ProgramID")]
    [Index(nameof(ProgramID), nameof(CourseID), Name = "UN_dbo.ProgramCourses_ProgramIDCourseID", IsUnique = true)]
    public partial class ProgramCourse
    {
        [Key]
        public int ProgramCourseID { get; set; }
        public int ProgramID { get; set; }
        [Required]
        [StringLength(7)]
        [Unicode(false)]
        public string CourseID { get; set; }
        public bool Required { get; set; }
        [StringLength(50)]
        public string Comments { get; set; }
        public int SectionLimit { get; set; }
        public bool Active { get; set; }

        [ForeignKey(nameof(ProgramID))]
        [InverseProperty("ProgramCourses")]
        public virtual Program Program { get; set; }
    }
}