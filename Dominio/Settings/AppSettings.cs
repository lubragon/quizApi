namespace QuizApi.Dominio.Settings
{
    public class AppSettings
    {
        public string ImageBaseUrl { get; set; } = string.Empty;
        public string FilesBaseUrl { get; set; } = string.Empty;
        public string FilesExternalUrl { get; set; } = string.Empty;
        public int ExpireTokenInMinutes { get; set; }
        public string SameSiteMode { get; set; } = string.Empty;
        public string CookieSecurePolicy { get; set; } = string.Empty;
        public string[] Origins { get; set; } = [];
    }
}
