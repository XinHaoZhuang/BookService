// <copyright file="Medal.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Medal
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "字符不能超过10个。")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "字符不能超过50个。")]
        public string Title { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "不能为负数。")]
        public decimal Experience { get; set; }

        [MaxLength(500, ErrorMessage = "字符不能超过500个。")]
        public string Detail { get; set; }

        // Foreign Key
        [Required]
        public int MedalImageId { get; set; }

        // Navigation property
        public MedalImage MedalImage { get; set; }
    }
}