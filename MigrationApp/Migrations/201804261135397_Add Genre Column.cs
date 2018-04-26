namespace MigrationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Genre");
        }
    }
}
