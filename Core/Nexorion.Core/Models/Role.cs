using NPoco;
using System;

namespace Nexorion.Core.Models
{
    [TableName("roles")]
    [PrimaryKey("id", AutoIncrement = false)]
    public class Role
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("tenant_id")]
        public Guid TenantId { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}