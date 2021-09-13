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

         Sql("INSERT INTO dbo.Users Values('701cde8a-506a-4cb6-a784-8dae9d340172' , 'Admin' , 'admin@gmail.com' , '12345678', 1)");
         Sql("INSERT INTO [dbo].[Movies] ([Id], [Name], [Category], [YearOfRelease], [AvailabilityStarts], [Description], [IsFeatured], [PosterPath], [ContentPath]) VALUES (N'6b66d862-5514-ec11-b984-7478278301b2', N'Spiderman No Way Home', N'Action', 2021, N'2021-12-17 00:00:00', N'Spider-Man: No Way Home is an upcoming American superhero film based on the Marvel Comics character Spider-Man, co-produced by Columbia Pictures and Marvel Studios, and distributed by Sony Pictures Releasing.', 1, N'https://s3-us-west-2.amazonaws.com/flx-editorial-wordpress/wp-content/uploads/2021/08/23230208/Spider-Man_No_Way_Home_Trailer_Breakdown-Rep.jpg', N'https://www.youtube.com/embed/WgU7P6o-GkM')");
         Sql("INSERT INTO [dbo].[Movies] ([Id], [Name], [Category], [YearOfRelease], [AvailabilityStarts], [Description], [IsFeatured], [PosterPath], [ContentPath]) VALUES (N'cdffa8c9-5514-ec11-b984-7478278301b2', N'The Batman', N'Action', 2022, N'2022-03-04 00:00:00', N'The Riddler plays a deadly game of cat and mouse with Batman and Commissioner Gordon in Gotham City.', 0, N'https://m.media-amazon.com/images/M/MV5BZTE2YTY3YTMtM2FlMS00YmI3LTgyMWUtM2FhMWIyZWRmMDk5XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg', N'https://www.youtube.com/embed/NLOp_6uPccQ')");
         Sql("INSERT INTO [dbo].[Movies] ([Id], [Name], [Category], [YearOfRelease], [AvailabilityStarts], [Description], [IsFeatured], [PosterPath], [ContentPath]) VALUES (N'e63bb007-5614-ec11-b984-7478278301b2', N'Avengers: Endgame', N'Action', 2019, N'2019-04-26 00:00:00', N'After Thanos, an intergalactic warlord, disintegrates half of the universe, the Avengers must reunite and assemble again to reinvigorate their trounced allies and restore balance.', 1, N'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQA_-tL18_rj9zEcjN6n41NEaJm-kRNF9UeOtvksZ4z_OW6jRA9', N'https://www.youtube.com/embed/TcMBFSGVi1c')");
         Sql("INSERT INTO [dbo].[Movies] ([Id], [Name], [Category], [YearOfRelease], [AvailabilityStarts], [Description], [IsFeatured], [PosterPath], [ContentPath]) VALUES (N'c6b48d5e-5614-ec11-b984-7478278301b2', N'Eternals', N'Action', 2021, N'2021-11-05 00:00:00', N'The Eternals, a race of immortal beings with superhuman powers who have secretly lived on Earth for thousands of years, reunite to battle the evil Deviants.', 1, N'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTFInBWWtvbKulV6xz1RHgrFjSrbPUX0PvwGWwYYr54OiuCh_I5', N'https://www.youtube.com/embed/x_me3xsvDgk')");
         Sql("INSERT INTO [dbo].[Movies] ([Id], [Name], [Category], [YearOfRelease], [AvailabilityStarts], [Description], [IsFeatured], [PosterPath], [ContentPath]) VALUES (N'e62161b7-5614-ec11-b984-7478278301b2', N'Despicable Me 3', N'Animation', 2017, N'2017-06-16 00:00:00', N'Gru meets his long-lost twin brother Dru, after getting fired from the Anti-Villain League. However, the siblings find themselves at loggerheads with a child actor-turned-villain.', 0, N'https://contentserver.com.au/assets/525650_p12009522_p_v5_aa.jpg', N'https://www.youtube.com/embed/6DBi41reeF0')");
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
