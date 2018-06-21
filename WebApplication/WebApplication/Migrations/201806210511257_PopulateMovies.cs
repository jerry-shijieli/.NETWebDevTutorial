namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) Values ('Shrek', 5, '2002-01-04', '2001-10-11', 4)");
            Sql("Insert Into Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) Values ('Titanic', 4, '1998-01-01', '1997-7-1', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
