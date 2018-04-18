namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finishtestaddMasterAndDetails : DbMigration
    {

        public override void Up()
        {
         

         
            AddColumn("dbo.ItemsRequiredpurchases", "RequiredpurchaseItems_Id", c => c.Int());
            CreateIndex("dbo.ItemsRequiredpurchases", "RequiredpurchaseItems_Id");
            AddForeignKey("dbo.ItemsRequiredpurchases", "RequiredpurchaseItems_Id", "dbo.RequiredpurchaseItems", "Id");
            DropForeignKey("dbo.ItemsRequiredpurchases", "Diagnosis_Id", "dbo.Diagnosis");
            DropIndex("dbo.ItemsRequiredpurchases", new[] { "Diagnosis_Id" });
            DropColumn("dbo.ItemsRequiredpurchases", "Diagnosis_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemsRequiredpurchases", "Diagnosis_Id", c => c.Int());
            DropForeignKey("dbo.ItemsRequiredpurchases", "RequiredpurchaseItems_Id", "dbo.RequiredpurchaseItems");
            DropIndex("dbo.ItemsRequiredpurchases", new[] { "RequiredpurchaseItems_Id" });
            DropColumn("dbo.ItemsRequiredpurchases", "RequiredpurchaseItems_Id");
            CreateIndex("dbo.ItemsRequiredpurchases", "Diagnosis_Id");
            AddForeignKey("dbo.ItemsRequiredpurchases", "Diagnosis_Id", "dbo.Diagnosis", "Id");
        }
    }
}
