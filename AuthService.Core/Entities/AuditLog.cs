using System;
using System.Collections.Generic;
using System.Text;

namespace AuthService.Domain.Entities
{
    public class AuditLog : BaseEntity
    {
        public Guid? UserId { get; set; } // Nullable - some actions happen before user exists
        public AuditAction Action { get; set; }
        public string Metadata { get; set; } = "{}"; // JSON string, will be mapped to JSONB
        public string IpAddress { get; set; } = string.Empty;
        public string? UserAgent { get; set; }

        // Navigation property (optional)
        public User? User { get; set; }
    }
}
