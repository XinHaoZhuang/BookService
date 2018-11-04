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
                    MenuName = "��������",
                    SupId = 0,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 2,
                    MenuName = "ά��ҵ��",
                    SupId = 0,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 3,
                    MenuName = "��������",
                    SupId = 0,
                    SortId = 3,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 4,
                    MenuName = "ϵͳ����",
                    SupId = 0,
                    SortId = 4,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 5,
                    MenuName = "�ͻ����",
                    SupId = 1,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 6,
                    MenuName = "����",
                    SupId = 1,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 7,
                    MenuName = "ά������",
                    SupId = 2,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 8,
                    MenuName = "�볧�Ǽ�",
                    SupId = 2,
                    SortId = 2,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 9,
                    MenuName = "ά��̨��",
                    SupId = 3,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                },
                new SysMenus()
                {
                    Id = 10,
                    MenuName = "�˵�����",
                    SupId = 4,
                    SortId = 1,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-13")
                });
            context.BaseCustomerTypes.AddOrUpdate(
                x => x.Id,
                new Models.Base.BaseCustomerType()
                {
                    Id = 1,
                    CustomerTypeName = "�ⲿ�ͻ�",
                    FlagRegister = 1,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-14")
                },
                new Models.Base.BaseCustomerType()
                {
                    Id = 2,
                    CustomerTypeName = "�ڲ�����",
                    FlagRegister = 0,
                    FlagDel = 0,
                    OperaName = "ϵͳ����Ա",
                    OperaTime = DateTime.Parse("2018-10-16")
                });
            context.Medals.AddOrUpdate(
                x => x.Id,
                new Medal()
                {
                    Id = 1,
                    Name = "����ѫ��",
                    Title = "�������5�Σ����ܻ�ȡ��ѫ��Ŷ",
                    Experience = 5,
                    Detail = "����ѫ�µ�����������",
                    MedalImageId = 1
                },
                new Medal()
                {
                    Id = 2,
                    Name = "��������",
                    Title = "����3��������Ϊ������ש����",
                    Experience = 3,
                    Detail = "����ѫ�µ�����������",
                    MedalImageId = 2
                });
            context.MedalImages.AddOrUpdate(
                x => x.Id,
                new MedalImage()
                {
                    Id = 1,
                    ImageSmall = "СͼƬ��ַ1",
                    ImageMiddle = "�е�ͼƬ��ַ1",
                    ImageLarge = "����ͼƬ��ַ1"
                },
                new MedalImage()
                {
                    Id = 2,
                    ImageSmall = "СͼƬ��ַ2",
                    ImageMiddle = "�е�ͼƬ��ַ2",
                    ImageLarge = "����ͼƬ��ַ2"
                });
        }
    }
}
