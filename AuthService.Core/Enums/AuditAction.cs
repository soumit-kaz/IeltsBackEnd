namespace AuthService.Domain.Enums
{

    public enum AuditAction
    {
        Login = 0,
        Logout = 1,
        LoginFailed = 2,
        Register = 3,
        PasswordChanged = 4,
        PasswordReset = 5,
        EmailVerified = 6,
        AccountLocked = 7,
        AccountUnlocked = 8,
        SessionRevoked = 9,
        TokenRefreshed = 10,
        OAuthLinked = 11,
        SuspiciousActivity = 12
    }
}
