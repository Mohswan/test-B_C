namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserAllClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SalesReps", "UserAdd_Id");
            DropColumn("dbo.SalesReps", "UserUpdate_Id");
            DropColumn("dbo.Sections", "UserAdd_Id");
            DropColumn("dbo.Sections", "UserUpdate_Id");
            DropColumn("dbo.CashEmps", "UserAdd_Id");
            DropColumn("dbo.CashEmps", "UserUpdate_Id");
            DropColumn("dbo.Employees", "UserAdd_Id");
            DropColumn("dbo.Employees", "UserUpdate_Id");
            DropColumn("dbo.CashOthers", "UserAdd_Id");
            DropColumn("dbo.CashOthers", "UserUpdate_Id");
            DropColumn("dbo.Exps", "UserAdd_Id");
            DropColumn("dbo.Exps", "UserUpdate_Id");
            DropColumn("dbo.CashReturns", "UserAdd_Id");
            DropColumn("dbo.CashReturns", "UserUpdate_Id");
            DropColumn("dbo.CatItems", "UserAdd_Id");
            DropColumn("dbo.CatItems", "UserUpdate_Id");
            DropColumn("dbo.DocCusts", "UserAdd_Id");
            DropColumn("dbo.DocCusts", "UserUpdate_Id");
            DropColumn("dbo.Courses", "UserAdd_Id");
            DropColumn("dbo.Courses", "UserUpdate_Id");
            DropColumn("dbo.ListCusts", "UserAdd_Id");
            DropColumn("dbo.ListCusts", "UserUpdate_Id");
            DropColumn("dbo.Pations", "UserAdd_Id");
            DropColumn("dbo.Pations", "UserUpdate_Id");
            DropColumn("dbo.Prices", "UserAdd_Id");
            DropColumn("dbo.Prices", "UserUpdate_Id");
            DropColumn("dbo.Rooms", "UserAdd_Id");
            DropColumn("dbo.Rooms", "UserUpdate_Id");
            DropColumn("dbo.MonthCoes", "UserAdd_Id");
            DropColumn("dbo.MonthCoes", "UserUpdate_Id");
            DropColumn("dbo.MonthCusts", "UserAdd_Id");
            DropColumn("dbo.MonthCusts", "UserUpdate_Id");
            DropColumn("dbo.MonthMachinCoes", "UserAdd_Id");
            DropColumn("dbo.PurchaseMachins", "UserAdd_Id");
            DropColumn("dbo.PurchaseMachins", "UserUpdate_Id");
            DropColumn("dbo.Machins", "UserAdd_Id");
            DropColumn("dbo.Machins", "UserUpdate_Id");
            DropColumn("dbo.RequiredpurchaseMachins", "UserAdd_Id");
            DropColumn("dbo.RequiredpurchaseMachins", "UserUpdate_Id");
            DropColumn("dbo.ConvItems", "UserAdd_Id");
            DropColumn("dbo.ConvItems", "UserUpdate_Id");
            DropColumn("dbo.ConvMachins", "UserAdd_Id");
            DropColumn("dbo.ConvMachins", "UserUpdate_Id");
            DropColumn("dbo.ConvTools", "UserAdd_Id");
            DropColumn("dbo.ConvTools", "UserUpdate_Id");
            DropColumn("dbo.DateCalls", "UserAdd_Id");
            DropColumn("dbo.DateCalls", "UserUpdate_Id");
            DropColumn("dbo.Diagnosis", "UserAdd_Id");
            DropColumn("dbo.Diagnosis", "UserUpdate_Id");
            DropColumn("dbo.DocOthers", "UserAdd_Id");
            DropColumn("dbo.DocOthers", "UserUpdate_Id");
            DropColumn("dbo.ListOthers", "UserAdd_Id");
            DropColumn("dbo.ListOthers", "UserUpdate_Id");
            DropColumn("dbo.DocReps", "UserAdd_Id");
            DropColumn("dbo.DocReps", "UserUpdate_Id");
            DropColumn("dbo.ListReps", "UserAdd_Id");
            DropColumn("dbo.ListReps", "UserUpdate_Id");
            DropColumn("dbo.GzaEmps", "UserAdd_Id");
            DropColumn("dbo.GzaEmps", "UserUpdate_Id");
            DropColumn("dbo.Items", "UserAdd_Id");
            DropColumn("dbo.Items", "UserUpdate_Id");
            DropColumn("dbo.PurchaseItems", "UserAdd_Id");
            DropColumn("dbo.PurchaseItems", "UserUpdate_Id");
            DropColumn("dbo.RequiredpurchaseItems", "UserAdd_Id");
            DropColumn("dbo.RequiredpurchaseItems", "UserUpdate_Id");
            DropColumn("dbo.ReturnItems", "UserAdd_Id");
            DropColumn("dbo.ReturnItems", "UserUpdate_Id");
            DropColumn("dbo.PurchaseTools", "UserAdd_Id");
            DropColumn("dbo.PurchaseTools", "UserUpdate_Id");
            DropColumn("dbo.RequiredpurchaseTools", "UserAdd_Id");
            DropColumn("dbo.RequiredpurchaseTools", "UserUpdate_Id");
            DropColumn("dbo.ReturnMachins", "UserAdd_Id");
            DropColumn("dbo.ReturnMachins", "UserUpdate_Id");
            DropColumn("dbo.ReturnTools", "UserAdd_Id");
            DropColumn("dbo.ReturnTools", "UserUpdate_Id");
            DropColumn("dbo.RoomMachins", "UserAdd_Id");
            DropColumn("dbo.RoomMachins", "UserUpdate_Id");
            DropColumn("dbo.SolEmps", "UserAdd_Id");
            DropColumn("dbo.SolEmps", "UserUpdate_Id");
            DropColumn("dbo.Tools", "UserAdd_Id");
            DropColumn("dbo.Tools", "UserUpdate_Id");
            RenameColumn(table: "dbo.Sections", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Sections", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.SalesReps", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.SalesReps", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Employees", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Employees", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.CashEmps", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.CashEmps", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Exps", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Exps", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.CashOthers", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.CashOthers", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.CashReturns", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.CashReturns", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.CatItems", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.CatItems", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Courses", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Courses", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Prices", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Prices", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Pations", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Pations", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ListCusts", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ListCusts", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Rooms", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Rooms", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.DocCusts", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.DocCusts", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.MonthCoes", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.MonthCoes", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.MonthCusts", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.MonthCusts", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Machins", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Machins", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.RequiredpurchaseMachins", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.RequiredpurchaseMachins", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.PurchaseMachins", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.PurchaseMachins", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.MonthMachinCoes", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.MonthMachinCoes", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ConvItems", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ConvItems", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ConvMachins", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ConvMachins", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ConvTools", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ConvTools", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.DateCalls", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.DateCalls", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Diagnosis", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Diagnosis", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ListOthers", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ListOthers", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.DocOthers", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.DocOthers", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ListReps", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ListReps", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.DocReps", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.DocReps", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.GzaEmps", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.GzaEmps", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Items", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Items", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.RequiredpurchaseItems", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.RequiredpurchaseItems", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.PurchaseItems", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.PurchaseItems", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ReturnItems", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ReturnItems", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.RequiredpurchaseTools", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.RequiredpurchaseTools", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.PurchaseTools", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.PurchaseTools", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ReturnMachins", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ReturnMachins", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.ReturnTools", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.ReturnTools", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.RoomMachins", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.RoomMachins", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.SolEmps", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.SolEmps", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.Tools", name: "Users_Id", newName: "UserAdd_Id");
            RenameColumn(table: "dbo.Tools", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameIndex(table: "dbo.SalesReps", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.SalesReps", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Sections", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Sections", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.CashEmps", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.CashEmps", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.CashOthers", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.CashOthers", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Exps", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Exps", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.CashReturns", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.CashReturns", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.CatItems", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.CatItems", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.DocCusts", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.DocCusts", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ListCusts", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ListCusts", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Pations", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Pations", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Prices", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Prices", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Rooms", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Rooms", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.MonthCoes", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.MonthCoes", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.MonthCusts", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.MonthCusts", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.MonthMachinCoes", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.MonthMachinCoes", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.PurchaseMachins", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.PurchaseMachins", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Machins", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Machins", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.RequiredpurchaseMachins", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.RequiredpurchaseMachins", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ConvItems", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ConvItems", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ConvMachins", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ConvMachins", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ConvTools", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ConvTools", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.DateCalls", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.DateCalls", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Diagnosis", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Diagnosis", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.DocOthers", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.DocOthers", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ListOthers", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ListOthers", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.DocReps", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.DocReps", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ListReps", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ListReps", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.GzaEmps", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.GzaEmps", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Items", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Items", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.PurchaseItems", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.PurchaseItems", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.RequiredpurchaseItems", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.RequiredpurchaseItems", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ReturnItems", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ReturnItems", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.PurchaseTools", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.PurchaseTools", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.RequiredpurchaseTools", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.RequiredpurchaseTools", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ReturnMachins", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ReturnMachins", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.ReturnTools", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.ReturnTools", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.RoomMachins", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.RoomMachins", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.SolEmps", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.SolEmps", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Tools", name: "IX_Users_Id", newName: "IX_UserAdd_Id");
            RenameIndex(table: "dbo.Tools", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            DropColumn("dbo.CashCoes", "UserAdd_Id");
            DropColumn("dbo.Companies", "UserAdd_Id");
            AlterStoredProcedure(
                "dbo.CashCoes_Insert",
                p => new
                    {
                        CodeId = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        TypeOPration_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashCoes]([CodeId], [Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [TypeOPration_Id], [UserUpdate_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [TypeOPrations_Id], [Users_Id], [Users1_Id])
                      VALUES (@CodeId, @Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @TypeOPration_Id, @UserUpdate_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @TypeOPrations_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CashCoes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CashCoes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.CashCoes_Update",
                p => new
                    {
                        Id = p.Int(),
                        CodeId = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        TypeOPration_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CashCoes]
                      SET [CodeId] = @CodeId, [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [TypeOPration_Id] = @TypeOPration_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [TypeOPrations_Id] = @TypeOPrations_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Companies_Insert",
                p => new
                    {
                        Name = p.String(),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel1 = p.String(),
                        Mob = p.String(),
                        taxID = p.String(),
                        regID = p.String(),
                        products = p.String(),
                        DateEnd = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserUpdate_Id = p.Int(),
                        specializations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Companies]([Name], [Address], [TelWhats], [Tel1], [Mob], [taxID], [regID], [products], [DateEnd], [DateAdd], [DateUpdate], [UserUpdate_Id], [specializations_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Address, @TelWhats, @Tel1, @Mob, @taxID, @regID, @products, @DateEnd, @DateAdd, @DateUpdate, @UserUpdate_Id, @specializations_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Companies]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Companies] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Companies_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel1 = p.String(),
                        Mob = p.String(),
                        taxID = p.String(),
                        regID = p.String(),
                        products = p.String(),
                        DateEnd = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserUpdate_Id = p.Int(),
                        specializations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Companies]
                      SET [Name] = @Name, [Address] = @Address, [TelWhats] = @TelWhats, [Tel1] = @Tel1, [Mob] = @Mob, [taxID] = @taxID, [regID] = @regID, [products] = @products, [DateEnd] = @DateEnd, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserUpdate_Id] = @UserUpdate_Id, [specializations_Id] = @specializations_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.SalesReps_Insert",
                p => new
                    {
                        Support = p.Byte(),
                        Name = p.String(),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel = p.String(),
                        Mob = p.String(),
                        Email = p.String(),
                        blocked = p.Byte(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Gender_Id = p.Int(),
                        HowAbout_Id = p.Int(),
                        Nation_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Genders_Id = p.Int(),
                        HowAbouts_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[SalesReps]([Support], [Name], [Address], [TelWhats], [Tel], [Mob], [Email], [blocked], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [Gender_Id], [HowAbout_Id], [Nation_Id], [Section_Id], [Companies_Id], [Genders_Id], [HowAbouts_Id], [Nations_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Support, @Name, @Address, @TelWhats, @Tel, @Mob, @Email, @blocked, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @Gender_Id, @HowAbout_Id, @Nation_Id, @Section_Id, @Companies_Id, @Genders_Id, @HowAbouts_Id, @Nations_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[SalesReps]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[SalesReps] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.SalesReps_Update",
                p => new
                    {
                        Id = p.Int(),
                        Support = p.Byte(),
                        Name = p.String(),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel = p.String(),
                        Mob = p.String(),
                        Email = p.String(),
                        blocked = p.Byte(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Gender_Id = p.Int(),
                        HowAbout_Id = p.Int(),
                        Nation_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Genders_Id = p.Int(),
                        HowAbouts_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[SalesReps]
                      SET [Support] = @Support, [Name] = @Name, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [blocked] = @blocked, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [Gender_Id] = @Gender_Id, [HowAbout_Id] = @HowAbout_Id, [Nation_Id] = @Nation_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [Genders_Id] = @Genders_Id, [HowAbouts_Id] = @HowAbouts_Id, [Nations_Id] = @Nations_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.SalesReps_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        Genders_Id = p.Int(),
                        HowAbouts_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[SalesReps]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([Genders_Id] = @Genders_Id) OR ([Genders_Id] IS NULL AND @Genders_Id IS NULL))) AND (([HowAbouts_Id] = @HowAbouts_Id) OR ([HowAbouts_Id] IS NULL AND @HowAbouts_Id IS NULL))) AND (([Nations_Id] = @Nations_Id) OR ([Nations_Id] IS NULL AND @Nations_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Sections_Insert",
                p => new
                    {
                        Name = p.String(),
                        Address = p.String(),
                        Tel = p.String(),
                        Tel1 = p.String(),
                        receptionist = p.String(),
                        mob = p.String(),
                        Email = p.String(),
                        DayJob = p.String(),
                        HourJob = p.String(),
                        Mark = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Sections]([Name], [Address], [Tel], [Tel1], [receptionist], [mob], [Email], [DayJob], [HourJob], [Mark], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Address, @Tel, @Tel1, @receptionist, @mob, @Email, @DayJob, @HourJob, @Mark, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Sections]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Sections] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Sections_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Address = p.String(),
                        Tel = p.String(),
                        Tel1 = p.String(),
                        receptionist = p.String(),
                        mob = p.String(),
                        Email = p.String(),
                        DayJob = p.String(),
                        HourJob = p.String(),
                        Mark = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Sections]
                      SET [Name] = @Name, [Address] = @Address, [Tel] = @Tel, [Tel1] = @Tel1, [receptionist] = @receptionist, [mob] = @mob, [Email] = @Email, [DayJob] = @DayJob, [HourJob] = @HourJob, [Mark] = @Mark, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Sections_Delete",
                p => new
                    {
                        Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Sections]
                      WHERE ((([Id] = @Id) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Employees_Insert",
                p => new
                    {
                        Car = p.Byte(),
                        Njob = p.Byte(),
                        Name = p.String(),
                        Salary = p.Decimal(precision: 18, scale: 2),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel = p.String(),
                        Mob = p.String(),
                        Email = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        CatJob_Id = p.Int(),
                        Section_Id = p.Int(),
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Car], [Njob], [Name], [Salary], [Address], [TelWhats], [Tel], [Mob], [Email], [Note], [DateAdd], [DateUpdate], [CatJob_Id], [Section_Id], [CatJobs_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Car, @Njob, @Name, @Salary, @Address, @TelWhats, @Tel, @Mob, @Email, @Note, @DateAdd, @DateUpdate, @CatJob_Id, @Section_Id, @CatJobs_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Employees_Update",
                p => new
                    {
                        Id = p.Int(),
                        Car = p.Byte(),
                        Njob = p.Byte(),
                        Name = p.String(),
                        Salary = p.Decimal(precision: 18, scale: 2),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel = p.String(),
                        Mob = p.String(),
                        Email = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        CatJob_Id = p.Int(),
                        Section_Id = p.Int(),
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Car] = @Car, [Njob] = @Njob, [Name] = @Name, [Salary] = @Salary, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [CatJob_Id] = @CatJob_Id, [Section_Id] = @Section_Id, [CatJobs_Id] = @CatJobs_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Employees_Delete",
                p => new
                    {
                        Id = p.Int(),
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ((((([Id] = @Id) AND (([CatJobs_Id] = @CatJobs_Id) OR ([CatJobs_Id] IS NULL AND @CatJobs_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.CashOthers_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Exp_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Section_Id = p.Int(),
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashOthers]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Exp_Id], [PaymentMethod_Id], [Section_Id], [Exps_Id], [PaymentMethods_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Exp_Id, @PaymentMethod_Id, @Section_Id, @Exps_Id, @PaymentMethods_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CashOthers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CashOthers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.CashOthers_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Exp_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Section_Id = p.Int(),
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CashOthers]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Exp_Id] = @Exp_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Section_Id] = @Section_Id, [Exps_Id] = @Exps_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.CashOthers_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CashOthers]
                      WHERE (((((([Id] = @Id) AND (([Exps_Id] = @Exps_Id) OR ([Exps_Id] IS NULL AND @Exps_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Exps_Insert",
                p => new
                    {
                        Name = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Exps]([Name], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Exps]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Exps] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Exps_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Exps]
                      SET [Name] = @Name, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Exps_Delete",
                p => new
                    {
                        Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Exps]
                      WHERE ((([Id] = @Id) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.CashReturns_Insert",
                p => new
                    {
                        CodeId = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        TypeOPration_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashReturns]([CodeId], [Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [TypeOPration_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [TypeOPrations_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@CodeId, @Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @TypeOPration_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @TypeOPrations_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CashReturns]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CashReturns] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.CashReturns_Update",
                p => new
                    {
                        Id = p.Int(),
                        CodeId = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        TypeOPration_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CashReturns]
                      SET [CodeId] = @CodeId, [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [TypeOPration_Id] = @TypeOPration_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [TypeOPrations_Id] = @TypeOPrations_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.CashReturns_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CashReturns]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([TypeOPrations_Id] = @TypeOPrations_Id) OR ([TypeOPrations_Id] IS NULL AND @TypeOPrations_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.CatItems_Insert",
                p => new
                    {
                        Name = p.String(),
                        description = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CatItems]([Name], [description], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @description, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CatItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CatItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.CatItems_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        description = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CatItems]
                      SET [Name] = @Name, [description] = @description, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.CatItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CatItems]
                      WHERE ((([Id] = @Id) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.DocCusts_Insert",
                p => new
                    {
                        purpose = p.String(),
                        DiagnosisOld = p.String(),
                        DateOld = p.DateTime(),
                        PreviousBalance = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        RequiredForToday = p.Decimal(precision: 18, scale: 2),
                        total = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        Diagnosis = p.String(),
                        Payed = p.Decimal(precision: 18, scale: 2),
                        Precautions = p.String(),
                        PriceCurse = p.Decimal(precision: 18, scale: 2),
                        PriceIn = p.Decimal(precision: 18, scale: 2),
                        PriceOld = p.Decimal(precision: 18, scale: 2),
                        PriceAll = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        NextDate = p.DateTime(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Course_Id = p.Int(),
                        ListCust_Id = p.Int(),
                        Pation_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Room_Id = p.Int(),
                        Section_Id = p.Int(),
                        Courses_Id = p.Int(),
                        ListCusts_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Rooms_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[DocCusts]([purpose], [DiagnosisOld], [DateOld], [PreviousBalance], [Date], [RequiredForToday], [total], [Note], [Diagnosis], [Payed], [Precautions], [PriceCurse], [PriceIn], [PriceOld], [PriceAll], [Price], [Discount], [NextDate], [DateAdd], [DateUpdate], [Course_Id], [ListCust_Id], [Pation_Id], [PaymentMethod_Id], [Room_Id], [Section_Id], [Courses_Id], [ListCusts_Id], [Pations_Id], [PaymentMethods_Id], [Rooms_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@purpose, @DiagnosisOld, @DateOld, @PreviousBalance, @Date, @RequiredForToday, @total, @Note, @Diagnosis, @Payed, @Precautions, @PriceCurse, @PriceIn, @PriceOld, @PriceAll, @Price, @Discount, @NextDate, @DateAdd, @DateUpdate, @Course_Id, @ListCust_Id, @Pation_Id, @PaymentMethod_Id, @Room_Id, @Section_Id, @Courses_Id, @ListCusts_Id, @Pations_Id, @PaymentMethods_Id, @Rooms_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[DocCusts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[DocCusts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.DocCusts_Update",
                p => new
                    {
                        Id = p.Int(),
                        purpose = p.String(),
                        DiagnosisOld = p.String(),
                        DateOld = p.DateTime(),
                        PreviousBalance = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        RequiredForToday = p.Decimal(precision: 18, scale: 2),
                        total = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        Diagnosis = p.String(),
                        Payed = p.Decimal(precision: 18, scale: 2),
                        Precautions = p.String(),
                        PriceCurse = p.Decimal(precision: 18, scale: 2),
                        PriceIn = p.Decimal(precision: 18, scale: 2),
                        PriceOld = p.Decimal(precision: 18, scale: 2),
                        PriceAll = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        NextDate = p.DateTime(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Course_Id = p.Int(),
                        ListCust_Id = p.Int(),
                        Pation_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Room_Id = p.Int(),
                        Section_Id = p.Int(),
                        Courses_Id = p.Int(),
                        ListCusts_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Rooms_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[DocCusts]
                      SET [purpose] = @purpose, [DiagnosisOld] = @DiagnosisOld, [DateOld] = @DateOld, [PreviousBalance] = @PreviousBalance, [Date] = @Date, [RequiredForToday] = @RequiredForToday, [total] = @total, [Note] = @Note, [Diagnosis] = @Diagnosis, [Payed] = @Payed, [Precautions] = @Precautions, [PriceCurse] = @PriceCurse, [PriceIn] = @PriceIn, [PriceOld] = @PriceOld, [PriceAll] = @PriceAll, [Price] = @Price, [Discount] = @Discount, [NextDate] = @NextDate, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Course_Id] = @Course_Id, [ListCust_Id] = @ListCust_Id, [Pation_Id] = @Pation_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Room_Id] = @Room_Id, [Section_Id] = @Section_Id, [Courses_Id] = @Courses_Id, [ListCusts_Id] = @ListCusts_Id, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Rooms_Id] = @Rooms_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.DocCusts_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Courses_Id = p.Int(),
                        ListCusts_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Rooms_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[DocCusts]
                      WHERE ((((((((([Id] = @Id) AND (([Courses_Id] = @Courses_Id) OR ([Courses_Id] IS NULL AND @Courses_Id IS NULL))) AND (([ListCusts_Id] = @ListCusts_Id) OR ([ListCusts_Id] IS NULL AND @ListCusts_Id IS NULL))) AND (([Pations_Id] = @Pations_Id) OR ([Pations_Id] IS NULL AND @Pations_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Rooms_Id] = @Rooms_Id) OR ([Rooms_Id] IS NULL AND @Rooms_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Courses_Insert",
                p => new
                    {
                        Name = p.String(),
                        NoOfVisits = p.Int(),
                        Schedule = p.Int(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Courses]([Name], [NoOfVisits], [Schedule], [Price], [Discount], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @NoOfVisits, @Schedule, @Price, @Discount, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Courses]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Courses] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Courses_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        NoOfVisits = p.Int(),
                        Schedule = p.Int(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Courses]
                      SET [Name] = @Name, [NoOfVisits] = @NoOfVisits, [Schedule] = @Schedule, [Price] = @Price, [Discount] = @Discount, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Courses_Delete",
                p => new
                    {
                        Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Courses]
                      WHERE ((([Id] = @Id) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.ListCusts_Insert",
                p => new
                    {
                        Type = p.Int(),
                        Date = p.DateTime(),
                        purpose = p.String(),
                        PreviousBalance = p.Decimal(precision: 18, scale: 2),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        RequiredForToday = p.Decimal(precision: 18, scale: 2),
                        total = p.Decimal(precision: 18, scale: 2),
                        payed = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        Balance = p.Decimal(precision: 18, scale: 2),
                        VisitNo = p.Byte(),
                        VisitIn = p.Byte(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Pation_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Section_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListCusts]([Type], [Date], [purpose], [PreviousBalance], [Discount], [RequiredForToday], [total], [payed], [Note], [Balance], [VisitNo], [VisitIn], [DateAdd], [DateUpdate], [Pation_Id], [PaymentMethod_Id], [Section_Id], [Pations_Id], [PaymentMethods_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Type, @Date, @purpose, @PreviousBalance, @Discount, @RequiredForToday, @total, @payed, @Note, @Balance, @VisitNo, @VisitIn, @DateAdd, @DateUpdate, @Pation_Id, @PaymentMethod_Id, @Section_Id, @Pations_Id, @PaymentMethods_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ListCusts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ListCusts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.ListCusts_Update",
                p => new
                    {
                        Id = p.Int(),
                        Type = p.Int(),
                        Date = p.DateTime(),
                        purpose = p.String(),
                        PreviousBalance = p.Decimal(precision: 18, scale: 2),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        RequiredForToday = p.Decimal(precision: 18, scale: 2),
                        total = p.Decimal(precision: 18, scale: 2),
                        payed = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        Balance = p.Decimal(precision: 18, scale: 2),
                        VisitNo = p.Byte(),
                        VisitIn = p.Byte(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Pation_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Section_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListCusts]
                      SET [Type] = @Type, [Date] = @Date, [purpose] = @purpose, [PreviousBalance] = @PreviousBalance, [Discount] = @Discount, [RequiredForToday] = @RequiredForToday, [total] = @total, [payed] = @payed, [Note] = @Note, [Balance] = @Balance, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Pation_Id] = @Pation_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Section_Id] = @Section_Id, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.ListCusts_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ListCusts]
                      WHERE (((((([Id] = @Id) AND (([Pations_Id] = @Pations_Id) OR ([Pations_Id] IS NULL AND @Pations_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Pations_Insert",
                p => new
                    {
                        Name = p.String(),
                        Age = p.Double(),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel = p.String(),
                        Mob = p.String(),
                        Email = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Gender_Id = p.Int(),
                        HowAbout_Id = p.Int(),
                        Nation_Id = p.Int(),
                        Pationjob_Id = p.Int(),
                        Price_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Pationjobs_Id = p.Int(),
                        Prices_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Pations]([Name], [Age], [Address], [TelWhats], [Tel], [Mob], [Email], [Note], [DateAdd], [DateUpdate], [Gender_Id], [HowAbout_Id], [Nation_Id], [Pationjob_Id], [Price_Id], [Nations_Id], [Pationjobs_Id], [Prices_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Age, @Address, @TelWhats, @Tel, @Mob, @Email, @Note, @DateAdd, @DateUpdate, @Gender_Id, @HowAbout_Id, @Nation_Id, @Pationjob_Id, @Price_Id, @Nations_Id, @Pationjobs_Id, @Prices_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Pations]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Pations] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Pations_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Age = p.Double(),
                        Address = p.String(),
                        TelWhats = p.String(),
                        Tel = p.String(),
                        Mob = p.String(),
                        Email = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Gender_Id = p.Int(),
                        HowAbout_Id = p.Int(),
                        Nation_Id = p.Int(),
                        Pationjob_Id = p.Int(),
                        Price_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Pationjobs_Id = p.Int(),
                        Prices_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Pations]
                      SET [Name] = @Name, [Age] = @Age, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Gender_Id] = @Gender_Id, [HowAbout_Id] = @HowAbout_Id, [Nation_Id] = @Nation_Id, [Pationjob_Id] = @Pationjob_Id, [Price_Id] = @Price_Id, [Nations_Id] = @Nations_Id, [Pationjobs_Id] = @Pationjobs_Id, [Prices_Id] = @Prices_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Pations_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Nations_Id = p.Int(),
                        Pationjobs_Id = p.Int(),
                        Prices_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Pations]
                      WHERE (((((([Id] = @Id) AND (([Nations_Id] = @Nations_Id) OR ([Nations_Id] IS NULL AND @Nations_Id IS NULL))) AND (([Pationjobs_Id] = @Pationjobs_Id) OR ([Pationjobs_Id] IS NULL AND @Pationjobs_Id IS NULL))) AND (([Prices_Id] = @Prices_Id) OR ([Prices_Id] IS NULL AND @Prices_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Prices_Insert",
                p => new
                    {
                        Name = p.String(),
                        Price1 = p.Decimal(precision: 18, scale: 2),
                        Price2 = p.Decimal(precision: 18, scale: 2),
                        Price3 = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Prices]([Name], [Price1], [Price2], [Price3], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Price1, @Price2, @Price3, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Prices]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Prices] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Prices_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Price1 = p.Decimal(precision: 18, scale: 2),
                        Price2 = p.Decimal(precision: 18, scale: 2),
                        Price3 = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Prices]
                      SET [Name] = @Name, [Price1] = @Price1, [Price2] = @Price2, [Price3] = @Price3, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Prices_Delete",
                p => new
                    {
                        Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Prices]
                      WHERE ((([Id] = @Id) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Rooms_Insert",
                p => new
                    {
                        Name = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Rooms]([Name], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Rooms]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Rooms] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Rooms_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Rooms]
                      SET [Name] = @Name, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Rooms_Delete",
                p => new
                    {
                        Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Rooms]
                      WHERE ((([Id] = @Id) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.MonthCoes_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[MonthCoes]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[MonthCoes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[MonthCoes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.MonthCoes_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[MonthCoes]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.MonthCoes_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[MonthCoes]
                      WHERE ((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.MonthCusts_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Pation_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Section_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[MonthCusts]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Pation_Id], [PaymentMethod_Id], [Section_Id], [Pations_Id], [PaymentMethods_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Pation_Id, @PaymentMethod_Id, @Section_Id, @Pations_Id, @PaymentMethods_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[MonthCusts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[MonthCusts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.MonthCusts_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Pation_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        Section_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[MonthCusts]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Pation_Id] = @Pation_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Section_Id] = @Section_Id, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.MonthCusts_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[MonthCusts]
                      WHERE (((((([Id] = @Id) AND (([Pations_Id] = @Pations_Id) OR ([Pations_Id] IS NULL AND @Pations_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.MonthMachinCoes_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        PurchaseMachin_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        PurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[MonthMachinCoes]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [PurchaseMachin_Id], [SalesRep_Id], [Section_Id], [Companies_Id], [PaymentMethods_Id], [PurchaseMachins_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @PurchaseMachin_Id, @SalesRep_Id, @Section_Id, @Companies_Id, @PaymentMethods_Id, @PurchaseMachins_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[MonthMachinCoes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[MonthMachinCoes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.MonthMachinCoes_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        PurchaseMachin_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        PurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[MonthMachinCoes]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [PurchaseMachin_Id] = @PurchaseMachin_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [PurchaseMachins_Id] = @PurchaseMachins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.MonthMachinCoes_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        PurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[MonthMachinCoes]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([PurchaseMachins_Id] = @PurchaseMachins_Id) OR ([PurchaseMachins_Id] IS NULL AND @PurchaseMachins_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseMachins_Insert",
                p => new
                    {
                        Cost = p.Decimal(precision: 18, scale: 2),
                        warranty = p.String(),
                        amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        Image = p.Binary(),
                        Date = p.DateTime(),
                        discount = p.Decimal(precision: 18, scale: 2),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Machin_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        RequiredpurchaseMachin_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[PurchaseMachins]([Cost], [warranty], [amount], [Price], [Note], [Image], [Date], [discount], [DateAdd], [DateUpdate], [Company_MyProperty], [Machin_Id], [PaymentMethod_Id], [RequiredpurchaseMachin_Id], [SalesRep_Id], [Section_Id], [Companies_Id], [Machins_Id], [PaymentMethods_Id], [RequiredpurchaseMachins_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Cost, @warranty, @amount, @Price, @Note, @Image, @Date, @discount, @DateAdd, @DateUpdate, @Company_MyProperty, @Machin_Id, @PaymentMethod_Id, @RequiredpurchaseMachin_Id, @SalesRep_Id, @Section_Id, @Companies_Id, @Machins_Id, @PaymentMethods_Id, @RequiredpurchaseMachins_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PurchaseMachins]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PurchaseMachins] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseMachins_Update",
                p => new
                    {
                        Id = p.Int(),
                        Cost = p.Decimal(precision: 18, scale: 2),
                        warranty = p.String(),
                        amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        Image = p.Binary(),
                        Date = p.DateTime(),
                        discount = p.Decimal(precision: 18, scale: 2),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Machin_Id = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        RequiredpurchaseMachin_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[PurchaseMachins]
                      SET [Cost] = @Cost, [warranty] = @warranty, [amount] = @amount, [Price] = @Price, [Note] = @Note, [Image] = @Image, [Date] = @Date, [discount] = @discount, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [Machin_Id] = @Machin_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [RequiredpurchaseMachin_Id] = @RequiredpurchaseMachin_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [Machins_Id] = @Machins_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseMachins_Id] = @RequiredpurchaseMachins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseMachins_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PurchaseMachins]
                      WHERE ((((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([Machins_Id] = @Machins_Id) OR ([Machins_Id] IS NULL AND @Machins_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseMachins_Id] = @RequiredpurchaseMachins_Id) OR ([RequiredpurchaseMachins_Id] IS NULL AND @RequiredpurchaseMachins_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Machins_Insert",
                p => new
                    {
                        Name = p.String(),
                        Note = p.String(),
                        ChekMachin = p.Byte(),
                        applications = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Companies_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Machins]([Name], [Note], [ChekMachin], [applications], [DateAdd], [DateUpdate], [Company_MyProperty], [Companies_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Note, @ChekMachin, @applications, @DateAdd, @DateUpdate, @Company_MyProperty, @Companies_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Machins]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Machins] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Machins_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Note = p.String(),
                        ChekMachin = p.Byte(),
                        applications = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Companies_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Machins]
                      SET [Name] = @Name, [Note] = @Note, [ChekMachin] = @ChekMachin, [applications] = @applications, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [Companies_Id] = @Companies_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Machins_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Machins]
                      WHERE (((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseMachins_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        warranty = p.String(),
                        DateEnd = p.DateTime(),
                        Support = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Machin_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[RequiredpurchaseMachins]([Date], [Price], [warranty], [DateEnd], [Support], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [Machin_Id], [SalesRep_Id], [Section_Id], [Companies_Id], [Machins_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @warranty, @DateEnd, @Support, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @Machin_Id, @SalesRep_Id, @Section_Id, @Companies_Id, @Machins_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[RequiredpurchaseMachins]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[RequiredpurchaseMachins] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseMachins_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        warranty = p.String(),
                        DateEnd = p.DateTime(),
                        Support = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        Machin_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseMachins]
                      SET [Date] = @Date, [Price] = @Price, [warranty] = @warranty, [DateEnd] = @DateEnd, [Support] = @Support, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [Machin_Id] = @Machin_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [Machins_Id] = @Machins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseMachins_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[RequiredpurchaseMachins]
                      WHERE ((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([Machins_Id] = @Machins_Id) OR ([Machins_Id] IS NULL AND @Machins_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.ConvItems_Insert",
                p => new
                    {
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Section_Id = p.Int(),
                        SectionTo_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ConvItems]([Price], [Date], [Note], [DateAdd], [DateUpdate], [Section_Id], [SectionTo_Id], [Sections_Id], [Sections1_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Price, @Date, @Note, @DateAdd, @DateUpdate, @Section_Id, @SectionTo_Id, @Sections_Id, @Sections1_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ConvItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ConvItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.ConvItems_Update",
                p => new
                    {
                        Id = p.Int(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Section_Id = p.Int(),
                        SectionTo_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ConvItems]
                      SET [Price] = @Price, [Date] = @Date, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Section_Id] = @Section_Id, [SectionTo_Id] = @SectionTo_Id, [Sections_Id] = @Sections_Id, [Sections1_Id] = @Sections1_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.ConvItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ConvItems]
                      WHERE ((((([Id] = @Id) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Sections1_Id] = @Sections1_Id) OR ([Sections1_Id] IS NULL AND @Sections1_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.ConvTools_Insert",
                p => new
                    {
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Section_Id = p.Int(),
                        SectionTo_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ConvTools]([Price], [Date], [Note], [DateAdd], [DateUpdate], [Section_Id], [SectionTo_Id], [Sections_Id], [Sections1_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Price, @Date, @Note, @DateAdd, @DateUpdate, @Section_Id, @SectionTo_Id, @Sections_Id, @Sections1_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ConvTools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ConvTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.ConvTools_Update",
                p => new
                    {
                        Id = p.Int(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Section_Id = p.Int(),
                        SectionTo_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ConvTools]
                      SET [Price] = @Price, [Date] = @Date, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Section_Id] = @Section_Id, [SectionTo_Id] = @SectionTo_Id, [Sections_Id] = @Sections_Id, [Sections1_Id] = @Sections1_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.ConvTools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ConvTools]
                      WHERE ((((([Id] = @Id) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Sections1_Id] = @Sections1_Id) OR ([Sections1_Id] IS NULL AND @Sections1_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Diagnosis_Insert",
                p => new
                    {
                        Name = p.String(),
                        symptoms = p.String(),
                        recommendations = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Diagnosis]([Name], [symptoms], [recommendations], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @symptoms, @recommendations, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Diagnosis]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Diagnosis] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Diagnosis_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        symptoms = p.String(),
                        recommendations = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Diagnosis]
                      SET [Name] = @Name, [symptoms] = @symptoms, [recommendations] = @recommendations, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Diagnosis_Delete",
                p => new
                    {
                        Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Diagnosis]
                      WHERE ((([Id] = @Id) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.ListOthers_Insert",
                p => new
                    {
                        Type = p.Byte(),
                        Date = p.DateTime(),
                        Name = p.String(),
                        Reasons = p.String(),
                        VisitNo = p.Byte(),
                        VisitIn = p.Byte(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Section_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListOthers]([Type], [Date], [Name], [Reasons], [VisitNo], [VisitIn], [Note], [DateAdd], [DateUpdate], [Section_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Type, @Date, @Name, @Reasons, @VisitNo, @VisitIn, @Note, @DateAdd, @DateUpdate, @Section_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ListOthers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ListOthers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.ListOthers_Update",
                p => new
                    {
                        Id = p.Int(),
                        Type = p.Byte(),
                        Date = p.DateTime(),
                        Name = p.String(),
                        Reasons = p.String(),
                        VisitNo = p.Byte(),
                        VisitIn = p.Byte(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Section_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListOthers]
                      SET [Type] = @Type, [Date] = @Date, [Name] = @Name, [Reasons] = @Reasons, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Section_Id] = @Section_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.ListOthers_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ListOthers]
                      WHERE (((([Id] = @Id) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.ListReps_Insert",
                p => new
                    {
                        Type = p.Int(),
                        Date = p.DateTime(),
                        VisitNo = p.Byte(),
                        VisitIn = p.Byte(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListReps]([Type], [Date], [VisitNo], [VisitIn], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Type, @Date, @VisitNo, @VisitIn, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ListReps]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ListReps] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.ListReps_Update",
                p => new
                    {
                        Id = p.Int(),
                        Type = p.Int(),
                        Date = p.DateTime(),
                        VisitNo = p.Byte(),
                        VisitIn = p.Byte(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListReps]
                      SET [Type] = @Type, [Date] = @Date, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.ListReps_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ListReps]
                      WHERE ((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Items_Insert",
                p => new
                    {
                        Name = p.String(),
                        Data = p.String(),
                        Packagecost = p.Decimal(precision: 18, scale: 2),
                        Minprice = p.Decimal(precision: 18, scale: 2),
                        MinOrder = p.Int(),
                        Cartoonprice = p.Decimal(precision: 18, scale: 2),
                        Noofunitsperpackage = p.Int(),
                        Noofpackagespercartoon = p.Int(),
                        Unitprice = p.Decimal(precision: 18, scale: 2),
                        Purpose = p.String(),
                        Dose = p.String(),
                        Precautions = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        CatItem_Id = p.Int(),
                        Company_MyProperty = p.Int(),
                        TypeUnit_Id = p.Int(),
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Items]([Name], [Data], [Packagecost], [Minprice], [MinOrder], [Cartoonprice], [Noofunitsperpackage], [Noofpackagespercartoon], [Unitprice], [Purpose], [Dose], [Precautions], [DateAdd], [DateUpdate], [CatItem_Id], [Company_MyProperty], [TypeUnit_Id], [CatItems_Id], [Companies_Id], [TypeUnits_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Data, @Packagecost, @Minprice, @MinOrder, @Cartoonprice, @Noofunitsperpackage, @Noofpackagespercartoon, @Unitprice, @Purpose, @Dose, @Precautions, @DateAdd, @DateUpdate, @CatItem_Id, @Company_MyProperty, @TypeUnit_Id, @CatItems_Id, @Companies_Id, @TypeUnits_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Items]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Items] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Items_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Data = p.String(),
                        Packagecost = p.Decimal(precision: 18, scale: 2),
                        Minprice = p.Decimal(precision: 18, scale: 2),
                        MinOrder = p.Int(),
                        Cartoonprice = p.Decimal(precision: 18, scale: 2),
                        Noofunitsperpackage = p.Int(),
                        Noofpackagespercartoon = p.Int(),
                        Unitprice = p.Decimal(precision: 18, scale: 2),
                        Purpose = p.String(),
                        Dose = p.String(),
                        Precautions = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        CatItem_Id = p.Int(),
                        Company_MyProperty = p.Int(),
                        TypeUnit_Id = p.Int(),
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Items]
                      SET [Name] = @Name, [Data] = @Data, [Packagecost] = @Packagecost, [Minprice] = @Minprice, [MinOrder] = @MinOrder, [Cartoonprice] = @Cartoonprice, [Noofunitsperpackage] = @Noofunitsperpackage, [Noofpackagespercartoon] = @Noofpackagespercartoon, [Unitprice] = @Unitprice, [Purpose] = @Purpose, [Dose] = @Dose, [Precautions] = @Precautions, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [CatItem_Id] = @CatItem_Id, [Company_MyProperty] = @Company_MyProperty, [TypeUnit_Id] = @TypeUnit_Id, [CatItems_Id] = @CatItems_Id, [Companies_Id] = @Companies_Id, [TypeUnits_Id] = @TypeUnits_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Items_Delete",
                p => new
                    {
                        Id = p.Int(),
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Items]
                      WHERE (((((([Id] = @Id) AND (([CatItems_Id] = @CatItems_Id) OR ([CatItems_Id] IS NULL AND @CatItems_Id IS NULL))) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([TypeUnits_Id] = @TypeUnits_Id) OR ([TypeUnits_Id] IS NULL AND @TypeUnits_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseItems_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        discount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        amount = p.Decimal(precision: 18, scale: 2),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        RequiredpurchaseItems_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseItems_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[PurchaseItems]([Date], [discount], [Price], [Note], [amount], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [RequiredpurchaseItems_Id], [SalesRep_Id], [Section_Id], [Companies_Id], [PaymentMethods_Id], [RequiredpurchaseItems_Id1], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @discount, @Price, @Note, @amount, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @RequiredpurchaseItems_Id, @SalesRep_Id, @Section_Id, @Companies_Id, @PaymentMethods_Id, @RequiredpurchaseItems_Id1, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PurchaseItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PurchaseItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseItems_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        discount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        amount = p.Decimal(precision: 18, scale: 2),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        RequiredpurchaseItems_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseItems_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[PurchaseItems]
                      SET [Date] = @Date, [discount] = @discount, [Price] = @Price, [Note] = @Note, [amount] = @amount, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [RequiredpurchaseItems_Id] = @RequiredpurchaseItems_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseItems_Id1] = @RequiredpurchaseItems_Id1, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseItems_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PurchaseItems]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseItems_Id1] = @RequiredpurchaseItems_Id1) OR ([RequiredpurchaseItems_Id1] IS NULL AND @RequiredpurchaseItems_Id1 IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseItems_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        DateEnd = p.DateTime(),
                        Note = p.String(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[RequiredpurchaseItems]([Date], [DateEnd], [Note], [Price], [DateAdd], [DateUpdate], [Company_MyProperty], [SalesRep_Id], [Section_Id], [Companies_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @DateEnd, @Note, @Price, @DateAdd, @DateUpdate, @Company_MyProperty, @SalesRep_Id, @Section_Id, @Companies_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[RequiredpurchaseItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[RequiredpurchaseItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseItems_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        DateEnd = p.DateTime(),
                        Note = p.String(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseItems]
                      SET [Date] = @Date, [DateEnd] = @DateEnd, [Note] = @Note, [Price] = @Price, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[RequiredpurchaseItems]
                      WHERE (((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.ReturnItems_Insert",
                p => new
                    {
                        PurchaseItems = p.Int(),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        Amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        AmountReturn = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ReturnItems]([PurchaseItems], [Discount], [Amount], [Price], [Date], [AmountReturn], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [SalesRep_Id], [Section_Id], [Companies_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@PurchaseItems, @Discount, @Amount, @Price, @Date, @AmountReturn, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @SalesRep_Id, @Section_Id, @Companies_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ReturnItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ReturnItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.ReturnItems_Update",
                p => new
                    {
                        Id = p.Int(),
                        PurchaseItems = p.Int(),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        Amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        AmountReturn = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ReturnItems]
                      SET [PurchaseItems] = @PurchaseItems, [Discount] = @Discount, [Amount] = @Amount, [Price] = @Price, [Date] = @Date, [AmountReturn] = @AmountReturn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.ReturnItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ReturnItems]
                      WHERE (((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseTools_Insert",
                p => new
                    {
                        Date = p.DateTime(),
                        discount = p.Decimal(precision: 18, scale: 2),
                        amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        RequiredpurchaseTools_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseTools_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[PurchaseTools]([Date], [discount], [amount], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [RequiredpurchaseTools_Id], [SalesRep_Id], [Section_Id], [Companies_Id], [PaymentMethods_Id], [RequiredpurchaseTools_Id1], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @discount, @amount, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @RequiredpurchaseTools_Id, @SalesRep_Id, @Section_Id, @Companies_Id, @PaymentMethods_Id, @RequiredpurchaseTools_Id1, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PurchaseTools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PurchaseTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseTools_Update",
                p => new
                    {
                        Id = p.Int(),
                        Date = p.DateTime(),
                        discount = p.Decimal(precision: 18, scale: 2),
                        amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        PaymentMethod_Id = p.Int(),
                        RequiredpurchaseTools_Id = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseTools_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[PurchaseTools]
                      SET [Date] = @Date, [discount] = @discount, [amount] = @amount, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [RequiredpurchaseTools_Id] = @RequiredpurchaseTools_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseTools_Id1] = @RequiredpurchaseTools_Id1, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.PurchaseTools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseTools_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PurchaseTools]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseTools_Id1] = @RequiredpurchaseTools_Id1) OR ([RequiredpurchaseTools_Id1] IS NULL AND @RequiredpurchaseTools_Id1 IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseTools_Insert",
                p => new
                    {
                        warranty = p.String(),
                        Date = p.DateTime(),
                        DateEnd = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[RequiredpurchaseTools]([warranty], [Date], [DateEnd], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [SalesRep_Id], [Section_Id], [Companies_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@warranty, @Date, @DateEnd, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @SalesRep_Id, @Section_Id, @Companies_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[RequiredpurchaseTools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[RequiredpurchaseTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseTools_Update",
                p => new
                    {
                        Id = p.Int(),
                        warranty = p.String(),
                        Date = p.DateTime(),
                        DateEnd = p.DateTime(),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        SalesRep_Id = p.Int(),
                        Section_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseTools]
                      SET [warranty] = @warranty, [Date] = @Date, [DateEnd] = @DateEnd, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.RequiredpurchaseTools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[RequiredpurchaseTools]
                      WHERE (((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.ReturnTools_Insert",
                p => new
                    {
                        Id = p.Int(),
                        PurchaseTools = p.Int(),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        Amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        AmountReturn = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ReturnTools]([Id], [PurchaseTools], [Discount], [Amount], [Price], [Date], [AmountReturn], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Id, @PurchaseTools, @Discount, @Amount, @Price, @Date, @AmountReturn, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @MyProperty int
                      SELECT @MyProperty = [MyProperty]
                      FROM [dbo].[ReturnTools]
                      WHERE @@ROWCOUNT > 0 AND [MyProperty] = scope_identity()
                      
                      SELECT t0.[MyProperty]
                      FROM [dbo].[ReturnTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[MyProperty] = @MyProperty"
            );
            
            AlterStoredProcedure(
                "dbo.ReturnTools_Update",
                p => new
                    {
                        MyProperty = p.Int(),
                        Id = p.Int(),
                        PurchaseTools = p.Int(),
                        Discount = p.Decimal(precision: 18, scale: 2),
                        Amount = p.Decimal(precision: 18, scale: 2),
                        Price = p.Decimal(precision: 18, scale: 2),
                        Date = p.DateTime(),
                        AmountReturn = p.Decimal(precision: 18, scale: 2),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ReturnTools]
                      SET [Id] = @Id, [PurchaseTools] = @PurchaseTools, [Discount] = @Discount, [Amount] = @Amount, [Price] = @Price, [Date] = @Date, [AmountReturn] = @AmountReturn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([MyProperty] = @MyProperty)"
            );
            
            AlterStoredProcedure(
                "dbo.ReturnTools_Delete",
                p => new
                    {
                        MyProperty = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ReturnTools]
                      WHERE ((([MyProperty] = @MyProperty) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
            AlterStoredProcedure(
                "dbo.Tools_Insert",
                p => new
                    {
                        Name = p.String(),
                        Note = p.String(),
                        Packagecost = p.Decimal(precision: 18, scale: 2),
                        Cartoonprice = p.Decimal(precision: 18, scale: 2),
                        Unitprice = p.Decimal(precision: 18, scale: 2),
                        Noofunitsperpackage = p.Int(),
                        Noofpackagespercartoon = p.Int(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        TypeUnit_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Tools]([Name], [Note], [Packagecost], [Cartoonprice], [Unitprice], [Noofunitsperpackage], [Noofpackagespercartoon], [DateAdd], [DateUpdate], [Company_MyProperty], [TypeUnit_Id], [Companies_Id], [TypeUnits_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Note, @Packagecost, @Cartoonprice, @Unitprice, @Noofunitsperpackage, @Noofpackagespercartoon, @DateAdd, @DateUpdate, @Company_MyProperty, @TypeUnit_Id, @Companies_Id, @TypeUnits_Id, @UserAdd_Id, @UserUpdate_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Tools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Tools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.Tools_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Note = p.String(),
                        Packagecost = p.Decimal(precision: 18, scale: 2),
                        Cartoonprice = p.Decimal(precision: 18, scale: 2),
                        Unitprice = p.Decimal(precision: 18, scale: 2),
                        Noofunitsperpackage = p.Int(),
                        Noofpackagespercartoon = p.Int(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        Company_MyProperty = p.Int(),
                        TypeUnit_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Tools]
                      SET [Name] = @Name, [Note] = @Note, [Packagecost] = @Packagecost, [Cartoonprice] = @Cartoonprice, [Unitprice] = @Unitprice, [Noofunitsperpackage] = @Noofunitsperpackage, [Noofpackagespercartoon] = @Noofpackagespercartoon, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [TypeUnit_Id] = @TypeUnit_Id, [Companies_Id] = @Companies_Id, [TypeUnits_Id] = @TypeUnits_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Tools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Tools]
                      WHERE ((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([TypeUnits_Id] = @TypeUnits_Id) OR ([TypeUnits_Id] IS NULL AND @TypeUnits_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.CashCoes", "UserAdd_Id", c => c.Int());
            RenameIndex(table: "dbo.Tools", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Tools", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.SolEmps", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.SolEmps", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.RoomMachins", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.RoomMachins", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ReturnTools", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ReturnTools", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ReturnMachins", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ReturnMachins", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.RequiredpurchaseTools", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.RequiredpurchaseTools", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.PurchaseTools", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.PurchaseTools", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ReturnItems", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ReturnItems", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.RequiredpurchaseItems", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.RequiredpurchaseItems", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.PurchaseItems", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.PurchaseItems", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Items", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Items", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.GzaEmps", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.GzaEmps", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ListReps", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ListReps", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.DocReps", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.DocReps", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ListOthers", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ListOthers", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.DocOthers", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.DocOthers", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Diagnosis", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Diagnosis", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.DateCalls", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.DateCalls", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ConvTools", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ConvTools", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ConvMachins", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ConvMachins", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ConvItems", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ConvItems", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.RequiredpurchaseMachins", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.RequiredpurchaseMachins", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Machins", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Machins", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.PurchaseMachins", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.PurchaseMachins", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.MonthMachinCoes", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.MonthMachinCoes", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.MonthCusts", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.MonthCusts", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.MonthCoes", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.MonthCoes", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Rooms", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Rooms", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Prices", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Prices", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Pations", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Pations", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.ListCusts", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.ListCusts", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.DocCusts", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.DocCusts", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.CatItems", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.CatItems", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.CashReturns", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.CashReturns", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Exps", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Exps", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.CashOthers", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.CashOthers", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.CashEmps", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.CashEmps", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.Sections", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Sections", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.SalesReps", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.SalesReps", name: "IX_UserAdd_Id", newName: "IX_Users_Id");
            RenameColumn(table: "dbo.Tools", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Tools", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.SolEmps", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.SolEmps", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.RoomMachins", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.RoomMachins", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ReturnTools", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ReturnTools", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ReturnMachins", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ReturnMachins", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.PurchaseTools", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.PurchaseTools", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.RequiredpurchaseTools", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.RequiredpurchaseTools", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ReturnItems", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ReturnItems", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.PurchaseItems", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.PurchaseItems", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.RequiredpurchaseItems", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.RequiredpurchaseItems", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Items", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Items", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.GzaEmps", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.GzaEmps", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.DocReps", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.DocReps", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ListReps", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ListReps", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.DocOthers", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.DocOthers", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ListOthers", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ListOthers", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Diagnosis", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Diagnosis", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.DateCalls", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.DateCalls", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ConvTools", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ConvTools", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ConvMachins", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ConvMachins", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ConvItems", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ConvItems", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.MonthMachinCoes", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.MonthMachinCoes", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.PurchaseMachins", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.PurchaseMachins", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.RequiredpurchaseMachins", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.RequiredpurchaseMachins", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Machins", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Machins", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.MonthCusts", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.MonthCusts", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.MonthCoes", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.MonthCoes", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.DocCusts", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.DocCusts", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Rooms", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Rooms", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.ListCusts", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.ListCusts", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Pations", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Pations", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Prices", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Prices", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Courses", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Courses", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.CatItems", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.CatItems", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.CashReturns", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.CashReturns", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.CashOthers", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.CashOthers", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Exps", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Exps", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.CashEmps", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.CashEmps", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Employees", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Employees", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.SalesReps", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.SalesReps", name: "UserAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Sections", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Sections", name: "UserAdd_Id", newName: "Users_Id");
            AddColumn("dbo.Tools", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Tools", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.SolEmps", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.SolEmps", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.RoomMachins", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.RoomMachins", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ReturnTools", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ReturnTools", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ReturnMachins", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ReturnMachins", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseTools", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseTools", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.PurchaseTools", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.PurchaseTools", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ReturnItems", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ReturnItems", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseItems", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseItems", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.PurchaseItems", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.PurchaseItems", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Items", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Items", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.GzaEmps", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.GzaEmps", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ListReps", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ListReps", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.DocReps", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.DocReps", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ListOthers", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ListOthers", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.DocOthers", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.DocOthers", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Diagnosis", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Diagnosis", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.DateCalls", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.DateCalls", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ConvTools", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ConvTools", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ConvMachins", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ConvMachins", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ConvItems", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ConvItems", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseMachins", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseMachins", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Machins", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Machins", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.MonthMachinCoes", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.MonthCusts", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.MonthCusts", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.MonthCoes", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.MonthCoes", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Rooms", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Rooms", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Prices", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Prices", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Pations", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Pations", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.ListCusts", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.ListCusts", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Courses", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Courses", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.CatItems", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.CatItems", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.CashReturns", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.CashReturns", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Exps", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Exps", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.CashOthers", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.CashOthers", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Employees", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Employees", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.CashEmps", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.CashEmps", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.Sections", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.Sections", "UserAdd_Id", c => c.Int());
            AddColumn("dbo.SalesReps", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.SalesReps", "UserAdd_Id", c => c.Int());
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
