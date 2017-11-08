namespace TestWeb.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Measure")]
    public partial class Measure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUm { get; set; }

        [Required]
        [StringLength(10)]
        public string Description { get; set; }
    }
}
