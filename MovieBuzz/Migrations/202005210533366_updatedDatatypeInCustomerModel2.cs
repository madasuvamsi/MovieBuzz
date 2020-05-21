namespace MovieBuzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDatatypeInCustomerModel2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
        }
    }
}
