namespace Academic.Contracts;

public interface IEnrollmentLookup
{
    Task<bool> IsEnrolledAsync(string studentId, string courseId, CancellationToken cancellationToken);
}
