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
                new SysMenus()
                {
                    Id = 1,
                    MenuName = "基础设置",
                    SupId = 0,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 2,
                    MenuName = "维修业务",
                    SupId = 0,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 3,
                    MenuName = "报表中心",
                    SupId = 0,
                    SortId = 3,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 4,
                    MenuName = "系统管理",
                    SupId = 0,
                    SortId = 4,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 5,
                    MenuName = "客户类别",
                    SupId = 1,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 6,
                    MenuName = "机型",
                    SupId = 1,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 7,
                    MenuName = "维修意向",
                    SupId = 2,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 8,
                    MenuName = "入厂登记",
                    SupId = 2,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 9,
                    MenuName = "维修台账",
                    SupId = 3,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 10,
                    MenuName = "菜单设置",
                    SupId = 4,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-13")
                });
            context.BaseCustomerTypes.AddOrUpdate(
                x => x.Id,
                new Models.Base.BaseCustomerType()
                {
                    Id = 1,
                    CustomerTypeName = "外部客户",
                    FlagRegister = 1,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-14")
                },
                new Models.Base.BaseCustomerType()
                {
                    Id = 2,
                    CustomerTypeName = "内部部门",
                    FlagRegister = 0,
                    FlagDel = 0,
                    OperaName = "系统管理员",
                    OperaTime = DateTime.Parse("2018-10-16")
                });
            context.Medals.AddOrUpdate(
                x => x.Id,
                new Medal()
                {
                    Id = 1,
                    Name = "分享勋章",
                    Title = "参与分享5次，就能获取此勋章哦",
                    Experience = 5,
                    Detail = "分享勋章的来历和意义",
                    MedalImageId = 1
                },
                new Medal()
                {
                    Id = 2,
                    Name = "义卖达人",
                    Title = "发起3次义卖，为公益添砖加瓦",
                    Experience = 3,
                    Detail = "分享勋章的来历和意义",
                    MedalImageId = 2
                });
            context.MedalImages.AddOrUpdate(
                x => x.Id,
                new MedalImage()
                {
                    Id = 1,
                    ImageSmall = "小图片地址1",
                    ImageMiddle = "中等图片地址1",
                    ImageLarge = "大型图片地址1"
                },
                new MedalImage()
                {
                    Id = 2,
                    ImageSmall = "小图片地址2",
                    ImageMiddle = "中等图片地址2",
                    ImageLarge = "大型图片地址2"
                });
        }
    }
}
