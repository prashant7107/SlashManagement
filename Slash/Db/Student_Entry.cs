namespace Slash.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Entry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string Address { get; set; }

        public int? EducationId { get; set; }

        public int? CourseId { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_Date { get; set; }

        public int? Time_Start { get; set; }

        public int? Time_End { get; set; }

        public int? TeacherId { get; set; }

        public long Contact_Number { get; set; }

        [StringLength(30)]
        public string Email_Id { get; set; }

        public int Charge { get; set; }

        public int? Paid_Charge { get; set; }

        public DateTime EntryTime { get; set; }

        public int? PhotoId { get; set; }

        public bool? Status { get; set; }

        public DateTime? LastUpdate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Pending_Charge { get; set; }

        [StringLength(1000)]
        public string Remarks { get; set; }

        public virtual Student_Photo Student_Photo { get; set; }

    }
}
