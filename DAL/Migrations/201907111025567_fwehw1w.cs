namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fwehw1w : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "CountFrom", c => c.String(nullable: false));
            AlterColumn("dbo.Transactions", "CountTo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "CountTo", c => c.Double(nullable: false));
            AlterColumn("dbo.Transactions", "CountFrom", c => c.Double(nullable: false));
        }
    }
}
