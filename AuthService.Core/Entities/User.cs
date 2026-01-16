using AuthService.Domain.Enums;
namespace AuthService.Domain.Entities
{
    public class User : BaseEntity
    {
        public UserStatus Status { get; set; } = UserStatus.PendingVerification;
        public UserRole Role { get; set; } = UserRole.User;

        // Navigation properties
        public ICollection<Identity> Identities { get; set; } = [];
        public ICollection<Session> Sessions { get; set; } = [];
        public ICollection<AuditLog> AuditLogs { get; set; } = [];

        // Soft delete support
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
}
