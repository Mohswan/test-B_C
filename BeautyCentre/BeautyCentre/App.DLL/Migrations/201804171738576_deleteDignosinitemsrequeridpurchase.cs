namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteDignosinitemsrequeridpurchase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemsRequiredpurchases", "Diagnosis_Id", "dbo.Diagnosis");
            DropIndex("dbo.ItemsRequiredpurchases", new[] { "Diagnosis_Id" });
            DropColumn("dbo.ItemsRequiredpurchases", "Diagnosis_Id");

        }

        public override void Down()
        {
            DropForeignKey("dbo.ItemsRequiredpurchases", "Diagnosis_Id", "dbo.Diagnosis");
            DropIndex("dbo.ItemsRequiredpurchases", new[] { "Diagnosis_Id" });
            DropColumn("dbo.ItemsRequiredpurchases", "Diagnosis_Id");

        }
    }
}
