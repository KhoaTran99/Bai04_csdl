namespace Bai04_csdl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(50)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(200)]
        public string StudentName { get; set; }

        public double AveregeScore { get; set; }

        public int FacultyID { get; set; }

        // khai báo thuộc tính giới tính
        public string Gioitinh {  get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
