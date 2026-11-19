namespace Identity.Contracts;

public interface IUserLookup
{
    Task<UserSummaryDto?> FindByIdAsync(string userId, CancellationToken cancellationToken);
}
