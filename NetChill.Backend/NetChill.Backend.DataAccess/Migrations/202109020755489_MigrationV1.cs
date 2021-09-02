namespace NetChill.Backend.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationV1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Movies", "Id", c => c.Guid(nullable: false, identity: true));
            AddColumn("dbo.Users", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Movies", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            DropColumn("dbo.Movies", "MovieId");
            DropColumn("dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserId", c => c.Guid(nullable: false, identity: true));
            AddColumn("dbo.Movies", "MovieId", c => c.Guid(nullable: false, identity: true));
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Movies");
            DropColumn("dbo.Users", "Id");
            DropColumn("dbo.Movies", "Id");
            AddPrimaryKey("dbo.Users", "UserId");
            AddPrimaryKey("dbo.Movies", "MovieId");
        }
    }
}
