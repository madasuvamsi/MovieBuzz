namespace MovieBuzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(GenreName) Values('Comedy')");
            Sql("Insert into Genres(GenreName) Values('Action')");
            Sql("Insert into Genres(GenreName) Values('Family')");
            Sql("Insert into Genres(GenreName) Values('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
