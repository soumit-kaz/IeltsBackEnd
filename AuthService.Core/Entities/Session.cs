using System.ComponentModel.DataAnnotations.Schema;

namespace AuthService.Domain.Entities
{
    public class Session : BaseEntity
    {
        public Guid UserId { get; set; }
        public string DeviceId { get; set; } = string.Empty;
        public string RefreshTokenHash { get; set; } = string.Empty; // SHA256 hash
        public string IpAddress { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        public string? Location { get; set; } // City, Country from GeoIP
        public bool IsRevoked { get; set; } = false;
        public DateTime LastUsedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        // Navigation property
        public User User { get; set; } = null!;

        // Computed properties (not mapped to database)
        [NotMapped]
        public bool IsExpired => DateTime.UtcNow > ExpiresAt;

        [NotMapped]
        public bool IsActive => !IsRevoked && !IsExpired;
    }
}
