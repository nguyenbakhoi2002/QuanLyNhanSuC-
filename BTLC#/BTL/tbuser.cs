namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbuser")]
    public partial class tbuser
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Pass { get; set; }

        [StringLength(10)]
        public string Quyen { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }
    }
}
