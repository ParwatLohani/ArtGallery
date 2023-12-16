using Microsoft.AspNetCore.Mvc;

namespace ArtGallery.Models
{
    public class Art
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string origin { get; set; }

        public Boolean areyoutheartist { get; set; }

        public Boolean wantstosell { get; set; }

        public int amount { get; set; }

        //public byte[] Image { get; set; }

        //Session Management - Start
        //Session Variables
        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";
        private readonly ILogger<Art> _logger;

        public Art(ILogger<Art> logger)
        {
            _logger = logger;
        }
        
        public void OnGet(HttpContext httpContext)
        {
            if (string.IsNullOrEmpty(httpContext.Session.GetString(SessionKeyName)))
            {
                httpContext.Session.SetString(SessionKeyName, "Parwat Lohani");
                httpContext.Session.SetInt32(SessionKeyAge, 45);
            }
            var name = httpContext.Session.GetString(SessionKeyName);

            var age = httpContext.Session.GetInt32(SessionKeyAge).ToString();

            _logger.LogInformation("Session Name: {Name}", name);
            _logger.LogInformation("Session Age: {Age}", age);
        }
        //Session Management - End

        public Art() { }
    }
}
