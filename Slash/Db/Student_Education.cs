namespace Slash.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Education
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Education { get; set; }

        public bool? Status { get; set; }
    }
}
