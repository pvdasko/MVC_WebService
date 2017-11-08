namespace TestWeb.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrderDetail { get; set; }

        [Required]
        [StringLength(10)]
        public string IdOrder { get; set; }

        public int? Line { get; set; }

        public int IdProduct { get; set; }

        public double? Quantity { get; set; }

        public int IdUm { get; set; }
    }
}
