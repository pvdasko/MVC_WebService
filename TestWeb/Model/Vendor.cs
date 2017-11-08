namespace TestWeb.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vendor")]
    public partial class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdVendor { get; set; }

        [StringLength(100)]
        public string VendorName { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string IdCountry { get; set; }

        [StringLength(10)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Url { get; set; }
    }
}
