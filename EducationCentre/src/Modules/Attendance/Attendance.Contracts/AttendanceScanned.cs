namespace Attendance.Contracts;

public sealed record AttendanceScanned(string SessionId, string StudentId, DateTimeOffset ScannedAt);
