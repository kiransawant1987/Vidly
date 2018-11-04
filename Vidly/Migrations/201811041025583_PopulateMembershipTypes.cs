namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate)VALUES(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate)VALUES(2,30,1,15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate)VALUES(3,90,3,20)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate)VALUES(4,90,3,20)");
        }
        
        public override void Down()
        {
        }
    }
}
