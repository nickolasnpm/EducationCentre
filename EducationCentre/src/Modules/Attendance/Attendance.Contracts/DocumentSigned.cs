namespace Attendance.Contracts;

public sealed record DocumentSigned(string DocumentId, string SignerId, DateTimeOffset SignedAt);
