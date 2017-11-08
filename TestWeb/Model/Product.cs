namespace TestWeb.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProduct { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string CodeBar { get; set; }

        public double? Quantity { get; set; }

        [StringLength(10)]
        public string IdUm { get; set; }
    }
}
