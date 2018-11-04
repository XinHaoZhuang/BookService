namespace BookService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class basecustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseCustomerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerTypeName = c.String(nullable: false),
                        FlagRegister = c.Int(nullable: false),
                        FlagDel = c.Int(nullable: false),
                        OperaName = c.String(),
                        OperaTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BaseCustomerTypes");
        }
    }
}
