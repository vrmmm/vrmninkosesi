namespace vrmninkosesi.Models
{
    public class Follow // takip ilişkisini tutan sınıf
    {
        public int Id { get; set; }
        public int FollowerUserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
