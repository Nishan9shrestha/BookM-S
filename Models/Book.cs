using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace BookM_S.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; } = "";
        public string Title { get; set; } = "";
        public string IsbnNumber { get; set; } = "";
        public string AuthorName { get; set; } = "";
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PhotoUrl { get; set; } = ""; // URL for photos
        [NotMapped]
        public IFormFile PhotoFile { get; set; } // File for uploading
    }
}
