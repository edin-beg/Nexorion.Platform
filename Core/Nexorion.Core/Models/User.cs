using NPoco;


namespace Nexorion.Core.Models
{
    [TableName("users")]
    [PrimaryKey("id", AutoIncrement = false)]
    public class User
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("tenant_id")]
        public Guid TenantId { get; set; }

        [Column("username")]
        public string? Username { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("password_hash")]
        public string? PasswordHash { get; set; }

        [Column("full_name")]
        public string? FullName { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("phone_number")]
        public string? PhoneNumber { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("zip_code")]
        public string? ZipCode { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("position")]
        public string? Position { get; set; }

        [Column("department")]
        public string? Department { get; set; }

        [Column("last_login_at")]
        public DateTime? LastLoginAt { get; set; }

        [Column("profile_image_url")]
        public string? ProfileImageUrl { get; set; }

        [Column("language_preference")]
        public string? LanguagePreference { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}