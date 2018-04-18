namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finishtestaddMasterAndDetails_ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemsRequiredpurchases", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemsRequiredpurchases", "name");
        }
    }
}
