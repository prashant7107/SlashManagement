namespace Slash.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teachers_List
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Teacher { get; set; }

        public long? Contact_num { get; set; }

        [StringLength(300)]
        public string Subjects { get; set; }

        public string Remarks { get; set; }

        public bool? Status { get; set; }

        [StringLength(200)]
        public string Email { get; set; }
    }
}
