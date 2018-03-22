namespace Question2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressID { get; set; }

        [StringLength(10)]
        public string AddressLine1 { get; set; }

        [StringLength(10)]
        public string AddressLine2 { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(10)]
        public string StateProvince { get; set; }

        [StringLength(10)]
        public string CountryRegion { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }
    }
}
