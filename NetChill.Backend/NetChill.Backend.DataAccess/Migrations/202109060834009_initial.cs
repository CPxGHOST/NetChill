namespace NetChill.Backend.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Category = c.String(nullable: false, maxLength: 255),
                        YearOfRelease = c.Int(nullable: false),
                        AvailabilityStarts = c.DateTime(nullable: false),
                        Description = c.String(nullable: false),
                        IsFeatured = c.Boolean(nullable: false),
                        PosterPath = c.String(nullable: false),
                        ContentPath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieLists", "UserId", "dbo.Users");
            DropForeignKey("dbo.MovieLists", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieLists", new[] { "MovieId" });
            DropIndex("dbo.MovieLists", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Movies");
            DropTable("dbo.MovieLists");
        }
    }
}
