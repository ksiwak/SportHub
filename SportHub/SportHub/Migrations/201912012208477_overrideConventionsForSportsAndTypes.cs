namespace SportHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class overrideConventionsForSportsAndTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sports", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Sports", "Type_Id", "dbo.Types");
            DropIndex("dbo.Sports", new[] { "Player_Id" });
            DropIndex("dbo.Sports", new[] { "Type_Id" });
            AlterColumn("dbo.Sports", "Complex", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Sports", "Player_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Sports", "Type_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Types", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Sports", "Player_Id");
            CreateIndex("dbo.Sports", "Type_Id");
            AddForeignKey("dbo.Sports", "Player_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sports", "Type_Id", "dbo.Types", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sports", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Sports", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Sports", new[] { "Type_Id" });
            DropIndex("dbo.Sports", new[] { "Player_Id" });
            AlterColumn("dbo.Types", "Name", c => c.String());
            AlterColumn("dbo.Sports", "Type_Id", c => c.Byte());
            AlterColumn("dbo.Sports", "Player_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Sports", "Complex", c => c.String());
            CreateIndex("dbo.Sports", "Type_Id");
            CreateIndex("dbo.Sports", "Player_Id");
            AddForeignKey("dbo.Sports", "Type_Id", "dbo.Types", "Id");
            AddForeignKey("dbo.Sports", "Player_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
