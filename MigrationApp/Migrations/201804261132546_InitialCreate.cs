namespace MigrationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Developer_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Developers", t => t.Developer_Id)
                .Index(t => t.Developer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Developer_Id", "dbo.Developers");
            DropIndex("dbo.Games", new[] { "Developer_Id" });
            DropTable("dbo.Games");
            DropTable("dbo.Developers");
        }
    }
}
