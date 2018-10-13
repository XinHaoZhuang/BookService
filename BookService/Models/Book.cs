// <copyright file="Book.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string Genre { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }

        // Navigation property
        public Author Author { get; set; }
    }
}