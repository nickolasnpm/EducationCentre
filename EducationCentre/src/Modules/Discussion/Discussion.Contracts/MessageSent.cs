namespace Discussion.Contracts;

public sealed record MessageSent(string ChannelId, string MessageId, string SenderId, DateTimeOffset SentAt);
