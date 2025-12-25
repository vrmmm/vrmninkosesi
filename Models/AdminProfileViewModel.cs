using System.Collections.Generic;

namespace vrmninkosesi.Models
{
    public class AdminProfileViewModel
    {
        // Hakkımda alanı
        public string AboutMe { get; set; } = "";

        // Sosyal medya linkleri
        public string InstagramUrl { get; set; } = "";
        public string LinkedInUrl { get; set; } = "";
        public string GitHubUrl { get; set; } = "";

        // Profil fotoğrafı (wwwroot/images/profile.jpg)
        public string ProfileImagePath { get; set; } = "C:\\Users\\evrim\\source\\repos\\vrmninkosesi\\wwwroot\\images\\foto..png";

        // Yayınlanan yazılar
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}



