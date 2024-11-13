namespace SportsStore.Infrastructure {
    
    public static class UrlExtentions {

        public static string PathAndQuery(this HttpRequest request) => request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
