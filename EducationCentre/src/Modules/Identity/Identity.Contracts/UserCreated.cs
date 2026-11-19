namespace Identity.Contracts;

public sealed record UserCreated(string UserId, string TenantId, string Email);
