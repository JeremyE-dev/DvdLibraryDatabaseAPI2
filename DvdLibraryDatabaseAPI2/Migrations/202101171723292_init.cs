namespace DvdLibraryDatabaseAPI2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorId = c.Int(nullable: false, identity: true),
                        director = c.String(),
                    })
                .PrimaryKey(t => t.DirectorId);
            
            CreateTable(
                "dbo.Dvds",
                c => new
                    {
                        DvdId = c.Int(nullable: false, identity: true),
                        DirectorId = c.Int(),
                        RatingId = c.Int(),
                        ReleaseYearId = c.Int(),
                        Title = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.DvdId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingId = c.Int(nullable: false, identity: true),
                        rating = c.String(),
                    })
                .PrimaryKey(t => t.RatingId);
            
            CreateTable(
                "dbo.ReleaseYears",
                c => new
                    {
                        ReleaseYearId = c.Int(nullable: false, identity: true),
                        releaseYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReleaseYearId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReleaseYears");
            DropTable("dbo.Ratings");
            DropTable("dbo.Dvds");
            DropTable("dbo.Directors");
        }
    }
}
