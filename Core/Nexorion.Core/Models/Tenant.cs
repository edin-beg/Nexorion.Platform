using NPoco;
using System;


namespace Nexorion.Core.Models
{
    [TableName("tenants")]
    [PrimaryKey("id", AutoIncrement = false)]
    public class Tenant
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("code")]
        public string? Code { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [Column("tax_number")]
        public string? TaxNumber { get; set; }

        [Column("registration_number")]
        public string? RegistrationNumber { get; set; }

        [Column("vat_number")]
        public string? VatNumber { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("zip_code")]
        public string? ZipCode { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("website")]
        public string? Website { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}