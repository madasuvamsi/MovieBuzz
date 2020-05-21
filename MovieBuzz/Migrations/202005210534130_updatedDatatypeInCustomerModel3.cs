namespace MovieBuzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDatatypeInCustomerModel3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Int(nullable: false));
        }
    }
}
