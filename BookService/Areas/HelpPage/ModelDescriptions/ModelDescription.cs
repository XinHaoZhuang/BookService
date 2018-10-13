// <copyright file="ModelDescription.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Areas.HelpPage.ModelDescriptions
{
    using System;

    /// <summary>
    /// Describes a type model.
    /// </summary>
    public abstract class ModelDescription
    {
        public string Documentation { get; set; }

        public Type ModelType { get; set; }

        public string Name { get; set; }
    }
}