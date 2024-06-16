namespace FinaBudget.Core;

public static class Configuration
{
    public const int DefaultStatusCode = 200;
    public const int DefaultPageSize = 25;
    public const int DefaultPageNumber = 1;

    public static string FrontendUrl { get; set; } = "http://localhost:5269";
    public static string BackendUrl { get; set; } = "http://localhost:5084";
}