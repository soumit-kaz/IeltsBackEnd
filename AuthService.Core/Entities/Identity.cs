using AuthService.Domain.Enums;

namespace AuthService.Domain.Entities
{
    public class Identity : BaseEntity
    {
        public Guid UserId { get; set; }
        public IdentityProvider Provider { get; set; }
        public string ProviderUid { get; set; } = string.Empty;
        public string? PasswordHash { get; set; }
        public bool Verified { get; set; } = false;

        // Navigation property
        public User User { get; set; } = null!;
    }
}
