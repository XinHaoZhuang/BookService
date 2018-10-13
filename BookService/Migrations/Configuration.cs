// <copyright file="Configuration.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using BookService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            // This method will be called after migrating to the latest version.

            // You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            context.Authors.AddOrUpdate(
                x => x.Id,
                new Author() { Id = 1, Name = "Jane Austen" },
                new Author() { Id = 2, Name = "Charles Dickens" },
                new Author() { Id = 3, Name = "Miguel de Cervantes" });

            context.Books.AddOrUpdate(
                x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "Price and Prejudice",
                    Year = 1813,
                    AuthorId = 1,
                    Price = 9.99M,
                    Genre = "Comedy of manners"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Northanger Abbey",
                    Year = 1817,
                    AuthorId = 1,
                    Price = 12.95M,
                    Genre = "Gothic parody"
                },
                 new Book()
                 {
                     Id = 3,
                     Title = "David Copperfield",
                     Year = 1850,
                     AuthorId = 2,
                     Price = 15,
                     Genre = "Bildungsroman"
                 },
                new Book()
                {
                    Id = 4,
                    Title = "Don Quixote",
                    Year = 1617,
                    AuthorId = 3,
                    Price = 8.95M,
                    Genre = "Picaresque"
                });

            context.SysMenus.AddOrUpdate(
                x => x.Id,
                new SysMenu()
                {
                    Id = 1,
                    MenuName = "基础设置",
                    SupId = 0,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 2,
                    MenuName = "维修业务",
                    SupId = 0,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 3,
                    MenuName = "报表中心",
                    SupId = 0,
                    SortId = 3,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 4,
                    MenuName = "系统管理",
                    SupId = 0,
                    SortId = 4,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 5,
                    MenuName = "客户类别",
                    SupId = 1,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 6,
                    MenuName = "机型",
                    SupId = 1,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 7,
                    MenuName = "维修意向",
                    SupId = 2,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 8,
                    MenuName = "入厂登记",
                    SupId = 2,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 9,
                    MenuName = "维修台账",
                    SupId = 3,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenu()
                {
                    Id = 10,
                    MenuName = "菜单设置",
                    SupId = 4,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                });
        }
    }
}
