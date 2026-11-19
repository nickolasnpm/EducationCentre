namespace Content.Infrastructure;

public static class ContentIntegrations
{
    public const string SearchIndexName = "content_index";
    public static readonly string[] PlannedAdapters =
        ["Elasticsearch indexer", "Search query service", "Content approval workflow"];
}
