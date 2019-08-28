namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, Name) VALUES ( 1, 'Family')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, Name) VALUES ( 2, 'Romance')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, Name) VALUES ( 3, 'Action')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, Name) VALUES ( 4, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
