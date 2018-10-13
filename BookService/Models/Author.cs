// <copyright file="Author.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}