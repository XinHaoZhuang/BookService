// <copyright file="IModelDocumentationProvider.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Areas.HelpPage.ModelDescriptions
{
    using System;
    using System.Reflection;

    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}