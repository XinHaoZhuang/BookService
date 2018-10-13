// <copyright file="KeyValuePairModelDescription.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Areas.HelpPage.ModelDescriptions
{
    public class KeyValuePairModelDescription : ModelDescription
    {
        public ModelDescription KeyModelDescription { get; set; }

        public ModelDescription ValueModelDescription { get; set; }
    }
}