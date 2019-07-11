namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fwehw11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "LastLogin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "LastLogin", c => c.DateTime(nullable: false));
        }
    }
}
