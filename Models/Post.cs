using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace vrmninkosesi.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string Category { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? ImagePath { get; set; }


        // 🔽 BU SATIR YOKSA, TÜM COMMENTS HATALARI ÇIKAR
        public ICollection<Comment>? Comments { get; set; }

    }
}


// Her property → bir sütun