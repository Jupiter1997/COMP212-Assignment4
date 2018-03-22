namespace Question2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.AddressLine1)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.AddressLine2)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.StateProvince)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.CountryRegion)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.PostalCode)
                .IsFixedLength();

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.AddressType)
                .IsFixedLength();

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.rowguid)
                .IsFixedLength();

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.ModifiedDate)
                .IsFixedLength();

            modelBuilder.Entity<CustomerAddress>()
                .HasOptional(e => e.Customer)
                .WithRequired(e => e.CustomerAddress);

            modelBuilder.Entity<Customer>()
                .Property(e => e.NameStyle)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Title)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.MiddleName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Suffix)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.CompanyName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.SalesPerson)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.EmailAddress)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
