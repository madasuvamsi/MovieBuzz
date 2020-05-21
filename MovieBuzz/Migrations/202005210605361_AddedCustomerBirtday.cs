namespace MovieBuzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomerBirtday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birtday", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birtday");
        }
    }
}
