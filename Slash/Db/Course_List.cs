namespace Slash.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Course_List
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Subject { get; set; }

        public bool? Status { get; set; }
    }
}
