namespace SportHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSportTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Complex = c.String(),
                        Player_Id = c.String(maxLength: 128),
                        Type_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Player_Id)
                .ForeignKey("dbo.Types", t => t.Type_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sports", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Sports", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Sports", new[] { "Type_Id" });
            DropIndex("dbo.Sports", new[] { "Player_Id" });
            DropTable("dbo.Types");
            DropTable("dbo.Sports");
        }
    }
}
