namespace Question2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAddress")]
    public partial class CustomerAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        public int AddressID { get; set; }

        [StringLength(10)]
        public string AddressType { get; set; }

        [StringLength(10)]
        public string rowguid { get; set; }

        [StringLength(10)]
        public string ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
