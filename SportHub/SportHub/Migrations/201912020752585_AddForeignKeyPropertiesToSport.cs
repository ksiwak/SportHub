namespace SportHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToSport : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Sports", name: "Player_Id", newName: "PlayerId");
            RenameColumn(table: "dbo.Sports", name: "Type_Id", newName: "TypeId");
            RenameIndex(table: "dbo.Sports", name: "IX_Player_Id", newName: "IX_PlayerId");
            RenameIndex(table: "dbo.Sports", name: "IX_Type_Id", newName: "IX_TypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Sports", name: "IX_TypeId", newName: "IX_Type_Id");
            RenameIndex(table: "dbo.Sports", name: "IX_PlayerId", newName: "IX_Player_Id");
            RenameColumn(table: "dbo.Sports", name: "TypeId", newName: "Type_Id");
            RenameColumn(table: "dbo.Sports", name: "PlayerId", newName: "Player_Id");
        }
    }
}
