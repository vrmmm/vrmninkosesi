using System;
using System.ComponentModel.DataAnnotations;

namespace vrmninkosesi.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string AuthorName { get; set; }  // Okuyucu adı

        [Required]
        public string Content { get; set; }     // Yorum metni

        public DateTime CreatedDate { get; set; }

        // İlişki
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}


