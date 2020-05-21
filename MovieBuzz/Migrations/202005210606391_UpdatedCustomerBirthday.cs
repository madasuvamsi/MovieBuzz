namespace MovieBuzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCustomerBirthday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime());
            DropColumn("dbo.Customers", "Birtday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Birtday", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
