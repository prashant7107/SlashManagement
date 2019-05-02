namespace Slash.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hour
    {
        public int Id { get; set; }

        public int valuem { get; set; }

        [Required]
        [StringLength(13)]
        public string displaym { get; set; }
    }
}
