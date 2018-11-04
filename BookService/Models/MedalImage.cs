// <copyright file="MedalImage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MedalImage
    {
        public int Id { get; set; }

        public string ImageSmall { get; set; }

        public string ImageMiddle { get; set; }

        public string ImageLarge { get; set; }
    }
}