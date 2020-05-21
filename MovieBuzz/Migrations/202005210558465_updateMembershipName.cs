namespace MovieBuzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set MembershipName='Pay As you go' where Id=1");
            Sql("Update MembershipTypes Set MembershipName='Monthly' where Id=2");
            Sql("Update MembershipTypes Set MembershipName='Quarterly' where Id=3");
            Sql("Update MembershipTypes Set MembershipName='Yearly' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
