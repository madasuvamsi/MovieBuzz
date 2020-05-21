namespace MovieBuzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotationsToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "customerName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "customerName", c => c.String());
        }
    }
}
