namespace NetChill.Backend.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationV4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieLists",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        MovieId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieLists", "UserId", "dbo.Users");
            DropForeignKey("dbo.MovieLists", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieLists", new[] { "MovieId" });
            DropIndex("dbo.MovieLists", new[] { "UserId" });
            DropTable("dbo.MovieLists");
        }
    }
}
