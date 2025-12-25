namespace vrmninkosesi.Models
{
    public class User //okuyucunun kayıt olduğu ve yorumların kime ait olduğunu tutan sınıf
    {
        public int Id { get; set; }               // Kullanıcı ID
        public string Username { get; set; }      // Görünen ad
        public string Email { get; set; }         // Mail
        public string PasswordHash { get; set; }  // Şifre (basit tutacağız)
        public DateTime CreatedDate { get; set; } // Kayıt tarihi
    }
}
