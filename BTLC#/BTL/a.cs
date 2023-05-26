namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class a
    {
        [Key]
        [StringLength(10)]
        public string Khoi { get; set; }
    }
}
