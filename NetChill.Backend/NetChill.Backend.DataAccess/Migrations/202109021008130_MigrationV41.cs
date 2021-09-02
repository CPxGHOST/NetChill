namespace NetChill.Backend.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationV41 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FullName", c => c.String(nullable: false));
            DropColumn("dbo.Users", "FName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "FName", c => c.String(nullable: false));
            DropColumn("dbo.Users", "FullName");
        }
    }
}
