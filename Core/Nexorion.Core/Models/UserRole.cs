using NPoco;

namespace Nexorion.Core.Models
{
    [TableName("user_roles")]
    public class UserRole
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("role_id")]
        public Guid RoleId { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}