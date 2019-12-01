using System.Windows.Markup;

namespace SportHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Types (Id, Name) VALUES (1, 'Ball Sports')");
            Sql("INSERT INTO Types (Id, Name) VALUES (2, 'Strength and Combat Sports')");
            Sql("INSERT INTO Types (Id, Name) VALUES (3, 'Track and Endurance Sports')");
            Sql("INSERT INTO Types (Id, Name) VALUES (4, 'Water,Snow and Ice Sports')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE Id in (1,2,3,4)");
        }
    }
}
