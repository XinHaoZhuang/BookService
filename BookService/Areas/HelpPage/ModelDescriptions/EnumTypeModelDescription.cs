// <copyright file="EnumTypeModelDescription.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Areas.HelpPage.ModelDescriptions
{
    using System.Collections.ObjectModel;

    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            this.Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}