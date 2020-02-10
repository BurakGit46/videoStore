namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTyperModifyColumnSingUpFee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SingUpFee", c => c.Short(nullable: false));
            DropColumn("dbo.MembershipTypes", "SingUpFree");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "SingUpFree", c => c.Short(nullable: false));
            DropColumn("dbo.MembershipTypes", "SingUpFee");
        }
    }
}
