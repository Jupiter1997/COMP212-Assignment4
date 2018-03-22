namespace Question2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(10)]
        public string NameStyle { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string MiddleName { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Suffix { get; set; }

        [StringLength(10)]
        public string CompanyName { get; set; }

        [StringLength(10)]
        public string SalesPerson { get; set; }

        [StringLength(10)]
        public string EmailAddress { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }
    }
}
