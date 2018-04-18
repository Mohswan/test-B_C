namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class DeleteAllProperty_Id1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PurchaseItems", "RequiredpurchaseItems_Id");
            DropColumn("dbo.PurchaseTools", "RequiredpurchaseTools_Id");
            DropColumn("dbo.Remedies", "CatQuanItems_Id");
            DropColumn("dbo.Remedies", "Diagnosis_Id");
            DropColumn("dbo.Remedies", "Items_Id");
            DropColumn("dbo.ToolsConvs", "CatQuanTools_Id");
            DropColumn("dbo.ToolsConvs", "ConvTools_Id");
            DropColumn("dbo.ToolsConvs", "Tools_Id");
            DropColumn("dbo.ToolsPurchases", "CatQuanTools_Id");
            DropColumn("dbo.ToolsPurchases", "PurchaseTools_Id");
            DropColumn("dbo.ToolsPurchases", "Tools_Id");
            DropColumn("dbo.ToolsRequiredpurchases", "CatQuanTools_Id");
            DropColumn("dbo.ToolsRequiredpurchases", "RequiredpurchaseTools_Id");
            DropColumn("dbo.ToolsRequiredpurchases", "Tools_Id");
            DropColumn("dbo.ToolsReturnTools", "CatQuanTools_Id");
            DropColumn("dbo.ToolsReturnTools", "ReturnTools_MyProperty");
            DropColumn("dbo.ToolsReturnTools", "Tools_Id");
            RenameColumn(table: "dbo.PurchaseItems", name: "RequiredpurchaseItems_Id1", newName: "RequiredpurchaseItems_Id");
            RenameColumn(table: "dbo.PurchaseTools", name: "RequiredpurchaseTools_Id1", newName: "RequiredpurchaseTools_Id");
            RenameColumn(table: "dbo.Remedies", name: "CatQuanItems_Id1", newName: "CatQuanItems_Id");
            RenameColumn(table: "dbo.Remedies", name: "Diagnosis_Id1", newName: "Diagnosis_Id");
            RenameColumn(table: "dbo.Remedies", name: "Items_Id1", newName: "Items_Id");
            RenameColumn(table: "dbo.ToolsConvs", name: "CatQuanTools_Id1", newName: "CatQuanTools_Id");
            RenameColumn(table: "dbo.ToolsConvs", name: "ConvTools_Id1", newName: "ConvTools_Id");
            RenameColumn(table: "dbo.ToolsConvs", name: "Tools_Id1", newName: "Tools_Id");
            RenameColumn(table: "dbo.ToolsPurchases", name: "CatQuanTools_Id1", newName: "CatQuanTools_Id");
            RenameColumn(table: "dbo.ToolsPurchases", name: "PurchaseTools_Id1", newName: "PurchaseTools_Id");
            RenameColumn(table: "dbo.ToolsPurchases", name: "Tools_Id1", newName: "Tools_Id");
            RenameColumn(table: "dbo.ToolsRequiredpurchases", name: "CatQuanTools_Id1", newName: "CatQuanTools_Id");
            RenameColumn(table: "dbo.ToolsRequiredpurchases", name: "RequiredpurchaseTools_Id1", newName: "RequiredpurchaseTools_Id");
            RenameColumn(table: "dbo.ToolsRequiredpurchases", name: "Tools_Id1", newName: "Tools_Id");
            RenameColumn(table: "dbo.ToolsReturnTools", name: "CatQuanTools_Id1", newName: "CatQuanTools_Id");
            RenameColumn(table: "dbo.ToolsReturnTools", name: "ReturnTools_MyProperty1", newName: "ReturnTools_MyProperty");
            RenameColumn(table: "dbo.ToolsReturnTools", name: "Tools_Id1", newName: "Tools_Id");
            RenameIndex(table: "dbo.PurchaseItems", name: "IX_RequiredpurchaseItems_Id1", newName: "IX_RequiredpurchaseItems_Id");
            RenameIndex(table: "dbo.PurchaseTools", name: "IX_RequiredpurchaseTools_Id1", newName: "IX_RequiredpurchaseTools_Id");
            RenameIndex(table: "dbo.Remedies", name: "IX_CatQuanItems_Id1", newName: "IX_CatQuanItems_Id");
            RenameIndex(table: "dbo.Remedies", name: "IX_Diagnosis_Id1", newName: "IX_Diagnosis_Id");
            RenameIndex(table: "dbo.Remedies", name: "IX_Items_Id1", newName: "IX_Items_Id");
            RenameIndex(table: "dbo.ToolsConvs", name: "IX_CatQuanTools_Id1", newName: "IX_CatQuanTools_Id");
            RenameIndex(table: "dbo.ToolsConvs", name: "IX_ConvTools_Id1", newName: "IX_ConvTools_Id");
            RenameIndex(table: "dbo.ToolsConvs", name: "IX_Tools_Id1", newName: "IX_Tools_Id");
            RenameIndex(table: "dbo.ToolsPurchases", name: "IX_CatQuanTools_Id1", newName: "IX_CatQuanTools_Id");
            RenameIndex(table: "dbo.ToolsPurchases", name: "IX_PurchaseTools_Id1", newName: "IX_PurchaseTools_Id");
            RenameIndex(table: "dbo.ToolsPurchases", name: "IX_Tools_Id1", newName: "IX_Tools_Id");
            RenameIndex(table: "dbo.ToolsRequiredpurchases", name: "IX_CatQuanTools_Id1", newName: "IX_CatQuanTools_Id");
            RenameIndex(table: "dbo.ToolsRequiredpurchases", name: "IX_RequiredpurchaseTools_Id1", newName: "IX_RequiredpurchaseTools_Id");
            RenameIndex(table: "dbo.ToolsRequiredpurchases", name: "IX_Tools_Id1", newName: "IX_Tools_Id");
            RenameIndex(table: "dbo.ToolsReturnTools", name: "IX_CatQuanTools_Id1", newName: "IX_CatQuanTools_Id");
            RenameIndex(table: "dbo.ToolsReturnTools", name: "IX_ReturnTools_MyProperty1", newName: "IX_ReturnTools_MyProperty");
            RenameIndex(table: "dbo.ToolsReturnTools", name: "IX_Tools_Id1", newName: "IX_Tools_Id");
            DropColumn("dbo.Users", "JobPermation_Id");
            DropColumn("dbo.SalesReps", "Company_MyProperty");
            DropColumn("dbo.SalesReps", "Gender_Id");
            DropColumn("dbo.SalesReps", "HowAbout_Id");
            DropColumn("dbo.SalesReps", "Nation_Id");
            DropColumn("dbo.SalesReps", "Section_Id");
            DropColumn("dbo.Pations", "Gender_Id");
            DropColumn("dbo.Pations", "HowAbout_Id");
            DropColumn("dbo.Pations", "Nation_Id");
            DropColumn("dbo.Pations", "Pationjob_Id");
            DropColumn("dbo.Pations", "Price_Id");
            DropColumn("dbo.MonthCoes", "Company_MyProperty");
            DropColumn("dbo.MonthCoes", "PaymentMethod_Id");
            DropColumn("dbo.MonthCoes", "SalesRep_Id");
            DropColumn("dbo.MonthCoes", "Section_Id");
            DropColumn("dbo.MonthCusts", "Pation_Id");
            DropColumn("dbo.MonthCusts", "PaymentMethod_Id");
            DropColumn("dbo.MonthCusts", "Section_Id");
            DropColumn("dbo.MonthMachinCoes", "Company_MyProperty");
            DropColumn("dbo.MonthMachinCoes", "PaymentMethod_Id");
            DropColumn("dbo.MonthMachinCoes", "PurchaseMachin_Id");
            DropColumn("dbo.MonthMachinCoes", "SalesRep_Id");
            DropColumn("dbo.MonthMachinCoes", "Section_Id");
            DropColumn("dbo.PurchaseMachins", "Company_MyProperty");
            DropColumn("dbo.PurchaseMachins", "Machin_Id");
            DropColumn("dbo.PurchaseMachins", "PaymentMethod_Id");
            DropColumn("dbo.PurchaseMachins", "RequiredpurchaseMachin_Id");
            DropColumn("dbo.PurchaseMachins", "SalesRep_Id");
            DropColumn("dbo.PurchaseMachins", "Section_Id");
            DropColumn("dbo.Machins", "Company_MyProperty");
            DropColumn("dbo.RequiredpurchaseMachins", "Company_MyProperty");
            DropColumn("dbo.RequiredpurchaseMachins", "Machin_Id");
            DropColumn("dbo.RequiredpurchaseMachins", "SalesRep_Id");
            DropColumn("dbo.RequiredpurchaseMachins", "Section_Id");
            DropColumn("dbo.ListReps", "Company_MyProperty");
            DropColumn("dbo.ListReps", "PaymentMethod_Id");
            DropColumn("dbo.ListReps", "SalesRep_Id");
            DropColumn("dbo.ListReps", "Section_Id");
            DropColumn("dbo.PurchaseItems", "Company_MyProperty");
            DropColumn("dbo.PurchaseItems", "PaymentMethod_Id");
            DropColumn("dbo.PurchaseItems", "SalesRep_Id");
            DropColumn("dbo.PurchaseItems", "Section_Id");
            DropColumn("dbo.RequiredpurchaseItems", "Company_MyProperty");
            DropColumn("dbo.RequiredpurchaseItems", "SalesRep_Id");
            DropColumn("dbo.RequiredpurchaseItems", "Section_Id");
            DropColumn("dbo.ReturnItems", "Company_MyProperty");
            DropColumn("dbo.ReturnItems", "SalesRep_Id");
            DropColumn("dbo.ReturnItems", "Section_Id");
            DropColumn("dbo.MachinCourses", "Course_Id");
            DropColumn("dbo.MachinCourses", "Machin_Id");
            DropColumn("dbo.MachinDocOthers", "DocCust_Id");
            DropColumn("dbo.MachinDocOthers", "Machin_Id");
            DropColumn("dbo.PurchaseTools", "Company_MyProperty");
            DropColumn("dbo.PurchaseTools", "PaymentMethod_Id");
            DropColumn("dbo.PurchaseTools", "SalesRep_Id");
            DropColumn("dbo.PurchaseTools", "Section_Id");
            DropColumn("dbo.RequiredpurchaseTools", "Company_MyProperty");
            DropColumn("dbo.RequiredpurchaseTools", "SalesRep_Id");
            DropColumn("dbo.RequiredpurchaseTools", "Section_Id");
            DropColumn("dbo.ReturnMachins", "Company_MyProperty");
            DropColumn("dbo.ReturnMachins", "Machin_Id");
            DropColumn("dbo.ReturnMachins", "SalesRep_Id");
            DropColumn("dbo.ReturnMachins", "Section_Id");
            DropColumn("dbo.ReturnTools", "Company_MyProperty");
            DropColumn("dbo.RoomMachins", "Employee_Id");
            DropColumn("dbo.RoomMachins", "Machin_Id");
            DropColumn("dbo.RoomMachins", "Room_Id");
            DropColumn("dbo.RoomMachins", "Section_Id");
            DropColumn("dbo.SolEmps", "Employee_Id");
            DropColumn("dbo.SolEmps", "Section_Id");
            DropColumn("dbo.Tools", "Company_MyProperty");
            DropColumn("dbo.Tools", "TypeUnit_Id");
            AlterStoredProcedure(
                "dbo.Users_Insert",
                p => new
                {
                    Name = p.String(),
                    Pass = p.String(),
                    Email = p.String(),
                    Tel = p.String(),
                    Tel1 = p.String(),
                    UserAdd = p.Int(),
                    DateAdd = p.String(),
                    UserUpdate = p.Int(),
                    DateUpdate = p.String(),
                    JobPermations_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[Users]([Name], [Pass], [Email], [Tel], [Tel1], [UserAdd], [DateAdd], [UserUpdate], [DateUpdate], [JobPermations_Id])
                      VALUES (@Name, @Pass, @Email, @Tel, @Tel1, @UserAdd, @DateAdd, @UserUpdate, @DateUpdate, @JobPermations_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Users]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Users] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Users_Update",
                p => new
                {
                    Id = p.Int(),
                    Name = p.String(),
                    Pass = p.String(),
                    Email = p.String(),
                    Tel = p.String(),
                    Tel1 = p.String(),
                    UserAdd = p.Int(),
                    DateAdd = p.String(),
                    UserUpdate = p.Int(),
                    DateUpdate = p.String(),
                    JobPermations_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[Users]
                      SET [Name] = @Name, [Pass] = @Pass, [Email] = @Email, [Tel] = @Tel, [Tel1] = @Tel1, [UserAdd] = @UserAdd, [DateAdd] = @DateAdd, [UserUpdate] = @UserUpdate, [DateUpdate] = @DateUpdate, [JobPermations_Id] = @JobPermations_Id
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
                    Companies_Id = p.Int(),
                    Genders_Id = p.Int(),
                    HowAbouts_Id = p.Int(),
                    Nations_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[SalesReps]([Support], [Name], [Address], [TelWhats], [Tel], [Mob], [Email], [blocked], [Note], [DateAdd], [DateUpdate], [Companies_Id], [Genders_Id], [HowAbouts_Id], [Nations_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Support, @Name, @Address, @TelWhats, @Tel, @Mob, @Email, @blocked, @Note, @DateAdd, @DateUpdate, @Companies_Id, @Genders_Id, @HowAbouts_Id, @Nations_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                      SET [Support] = @Support, [Name] = @Name, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [blocked] = @blocked, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [Genders_Id] = @Genders_Id, [HowAbouts_Id] = @HowAbouts_Id, [Nations_Id] = @Nations_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Nations_Id = p.Int(),
                    Pationjobs_Id = p.Int(),
                    Prices_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[Pations]([Name], [Age], [Address], [TelWhats], [Tel], [Mob], [Email], [Note], [DateAdd], [DateUpdate], [Nations_Id], [Pationjobs_Id], [Prices_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Age, @Address, @TelWhats, @Tel, @Mob, @Email, @Note, @DateAdd, @DateUpdate, @Nations_Id, @Pationjobs_Id, @Prices_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Nations_Id = p.Int(),
                    Pationjobs_Id = p.Int(),
                    Prices_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[Pations]
                      SET [Name] = @Name, [Age] = @Age, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Nations_Id] = @Nations_Id, [Pationjobs_Id] = @Pationjobs_Id, [Prices_Id] = @Prices_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[MonthCoes]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[MonthCoes]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Pations_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[MonthCusts]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Pations_Id], [PaymentMethods_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Pations_Id, @PaymentMethods_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Pations_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[MonthCusts]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    PurchaseMachins_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[MonthMachinCoes]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Companies_Id], [PaymentMethods_Id], [PurchaseMachins_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Companies_Id, @PaymentMethods_Id, @PurchaseMachins_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [PurchaseMachins_Id] = @PurchaseMachins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    @"INSERT [dbo].[PurchaseMachins]([Cost], [warranty], [amount], [Price], [Note], [Image], [Date], [discount], [DateAdd], [DateUpdate], [Companies_Id], [Machins_Id], [PaymentMethods_Id], [RequiredpurchaseMachins_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Cost, @warranty, @amount, @Price, @Note, @Image, @Date, @discount, @DateAdd, @DateUpdate, @Companies_Id, @Machins_Id, @PaymentMethods_Id, @RequiredpurchaseMachins_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                      SET [Cost] = @Cost, [warranty] = @warranty, [amount] = @amount, [Price] = @Price, [Note] = @Note, [Image] = @Image, [Date] = @Date, [discount] = @discount, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [Machins_Id] = @Machins_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseMachins_Id] = @RequiredpurchaseMachins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[Machins]([Name], [Note], [ChekMachin], [applications], [DateAdd], [DateUpdate], [Companies_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Note, @ChekMachin, @applications, @DateAdd, @DateUpdate, @Companies_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[Machins]
                      SET [Name] = @Name, [Note] = @Note, [ChekMachin] = @ChekMachin, [applications] = @applications, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    Machins_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[RequiredpurchaseMachins]([Date], [Price], [warranty], [DateEnd], [Support], [Note], [DateAdd], [DateUpdate], [Companies_Id], [Machins_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @warranty, @DateEnd, @Support, @Note, @DateAdd, @DateUpdate, @Companies_Id, @Machins_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    Machins_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseMachins]
                      SET [Date] = @Date, [Price] = @Price, [warranty] = @warranty, [DateEnd] = @DateEnd, [Support] = @Support, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [Machins_Id] = @Machins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[ListReps]([Type], [Date], [VisitNo], [VisitIn], [Note], [DateAdd], [DateUpdate], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Type, @Date, @VisitNo, @VisitIn, @Note, @DateAdd, @DateUpdate, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[ListReps]
                      SET [Type] = @Type, [Date] = @Date, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    RequiredpurchaseItems_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[PurchaseItems]([Date], [discount], [Price], [Note], [amount], [DateAdd], [DateUpdate], [Companies_Id], [PaymentMethods_Id], [RequiredpurchaseItems_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @discount, @Price, @Note, @amount, @DateAdd, @DateUpdate, @Companies_Id, @PaymentMethods_Id, @RequiredpurchaseItems_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    RequiredpurchaseItems_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[PurchaseItems]
                      SET [Date] = @Date, [discount] = @discount, [Price] = @Price, [Note] = @Note, [amount] = @amount, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseItems_Id] = @RequiredpurchaseItems_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.PurchaseItems_Delete",
                p => new
                {
                    Id = p.Int(),
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    RequiredpurchaseItems_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"DELETE [dbo].[PurchaseItems]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseItems_Id] = @RequiredpurchaseItems_Id) OR ([RequiredpurchaseItems_Id] IS NULL AND @RequiredpurchaseItems_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
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
                    Companies_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[RequiredpurchaseItems]([Date], [DateEnd], [Note], [Price], [DateAdd], [DateUpdate], [Companies_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @DateEnd, @Note, @Price, @DateAdd, @DateUpdate, @Companies_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseItems]
                      SET [Date] = @Date, [DateEnd] = @DateEnd, [Note] = @Note, [Price] = @Price, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[ReturnItems]([PurchaseItems], [Discount], [Amount], [Price], [Date], [AmountReturn], [Note], [DateAdd], [DateUpdate], [Companies_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@PurchaseItems, @Discount, @Amount, @Price, @Date, @AmountReturn, @Note, @DateAdd, @DateUpdate, @Companies_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[ReturnItems]
                      SET [PurchaseItems] = @PurchaseItems, [Discount] = @Discount, [Amount] = @Amount, [Price] = @Price, [Date] = @Date, [AmountReturn] = @AmountReturn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    RequiredpurchaseTools_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[PurchaseTools]([Date], [discount], [amount], [Price], [Note], [DateAdd], [DateUpdate], [Companies_Id], [PaymentMethods_Id], [RequiredpurchaseTools_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @discount, @amount, @Price, @Note, @DateAdd, @DateUpdate, @Companies_Id, @PaymentMethods_Id, @RequiredpurchaseTools_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    RequiredpurchaseTools_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[PurchaseTools]
                      SET [Date] = @Date, [discount] = @discount, [amount] = @amount, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseTools_Id] = @RequiredpurchaseTools_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.PurchaseTools_Delete",
                p => new
                {
                    Id = p.Int(),
                    Companies_Id = p.Int(),
                    PaymentMethods_Id = p.Int(),
                    RequiredpurchaseTools_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"DELETE [dbo].[PurchaseTools]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseTools_Id] = @RequiredpurchaseTools_Id) OR ([RequiredpurchaseTools_Id] IS NULL AND @RequiredpurchaseTools_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([UserAdd_Id] = @UserAdd_Id) OR ([UserAdd_Id] IS NULL AND @UserAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
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
                    Companies_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[RequiredpurchaseTools]([warranty], [Date], [DateEnd], [Price], [Note], [DateAdd], [DateUpdate], [Companies_Id], [SalesReps_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@warranty, @Date, @DateEnd, @Price, @Note, @DateAdd, @DateUpdate, @Companies_Id, @SalesReps_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    SalesReps_Id = p.Int(),
                    Sections_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseTools]
                      SET [warranty] = @warranty, [Date] = @Date, [DateEnd] = @DateEnd, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[ReturnTools]([Id], [PurchaseTools], [Discount], [Amount], [Price], [Date], [AmountReturn], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Id, @PurchaseTools, @Discount, @Amount, @Price, @Date, @AmountReturn, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[ReturnTools]
                      SET [Id] = @Id, [PurchaseTools] = @PurchaseTools, [Discount] = @Discount, [Amount] = @Amount, [Price] = @Price, [Date] = @Date, [AmountReturn] = @AmountReturn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([MyProperty] = @MyProperty)"
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
                    Companies_Id = p.Int(),
                    TypeUnits_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"INSERT [dbo].[Tools]([Name], [Note], [Packagecost], [Cartoonprice], [Unitprice], [Noofunitsperpackage], [Noofpackagespercartoon], [DateAdd], [DateUpdate], [Companies_Id], [TypeUnits_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Note, @Packagecost, @Cartoonprice, @Unitprice, @Noofunitsperpackage, @Noofpackagespercartoon, @DateAdd, @DateUpdate, @Companies_Id, @TypeUnits_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                    Companies_Id = p.Int(),
                    TypeUnits_Id = p.Int(),
                    UserAdd_Id = p.Int(),
                    UserUpdate_Id = p.Int(),
                },
                body:
                    @"UPDATE [dbo].[Tools]
                      SET [Name] = @Name, [Note] = @Note, [Packagecost] = @Packagecost, [Cartoonprice] = @Cartoonprice, [Unitprice] = @Unitprice, [Noofunitsperpackage] = @Noofunitsperpackage, [Noofpackagespercartoon] = @Noofpackagespercartoon, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [TypeUnits_Id] = @TypeUnits_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );

        }

        public override void Down()
        {
            AddColumn("dbo.Tools", "TypeUnit_Id", c => c.Int());
            AddColumn("dbo.Tools", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.SolEmps", "Section_Id", c => c.Int());
            AddColumn("dbo.SolEmps", "Employee_Id", c => c.Int());
            AddColumn("dbo.RoomMachins", "Section_Id", c => c.Int());
            AddColumn("dbo.RoomMachins", "Room_Id", c => c.Int());
            AddColumn("dbo.RoomMachins", "Machin_Id", c => c.Int());
            AddColumn("dbo.RoomMachins", "Employee_Id", c => c.Int());
            AddColumn("dbo.ReturnTools", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.ReturnMachins", "Section_Id", c => c.Int());
            AddColumn("dbo.ReturnMachins", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.ReturnMachins", "Machin_Id", c => c.Int());
            AddColumn("dbo.ReturnMachins", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.RequiredpurchaseTools", "Section_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseTools", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseTools", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.PurchaseTools", "Section_Id", c => c.Int());
            AddColumn("dbo.PurchaseTools", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.PurchaseTools", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.PurchaseTools", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.MachinDocOthers", "Machin_Id", c => c.Int());
            AddColumn("dbo.MachinDocOthers", "DocCust_Id", c => c.Int());
            AddColumn("dbo.MachinCourses", "Machin_Id", c => c.Int());
            AddColumn("dbo.MachinCourses", "Course_Id", c => c.Int());
            AddColumn("dbo.ReturnItems", "Section_Id", c => c.Int());
            AddColumn("dbo.ReturnItems", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.ReturnItems", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.RequiredpurchaseItems", "Section_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseItems", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseItems", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.PurchaseItems", "Section_Id", c => c.Int());
            AddColumn("dbo.PurchaseItems", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.PurchaseItems", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.PurchaseItems", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.ListReps", "Section_Id", c => c.Int());
            AddColumn("dbo.ListReps", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.ListReps", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.ListReps", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.RequiredpurchaseMachins", "Section_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseMachins", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseMachins", "Machin_Id", c => c.Int());
            AddColumn("dbo.RequiredpurchaseMachins", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.Machins", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "Section_Id", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "RequiredpurchaseMachin_Id", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "Machin_Id", c => c.Int());
            AddColumn("dbo.PurchaseMachins", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.MonthMachinCoes", "Section_Id", c => c.Int());
            AddColumn("dbo.MonthMachinCoes", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.MonthMachinCoes", "PurchaseMachin_Id", c => c.Int());
            AddColumn("dbo.MonthMachinCoes", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.MonthMachinCoes", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.MonthCusts", "Section_Id", c => c.Int());
            AddColumn("dbo.MonthCusts", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.MonthCusts", "Pation_Id", c => c.Int());
            AddColumn("dbo.MonthCoes", "Section_Id", c => c.Int());
            AddColumn("dbo.MonthCoes", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.MonthCoes", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.MonthCoes", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.Pations", "Price_Id", c => c.Int());
            AddColumn("dbo.Pations", "Pationjob_Id", c => c.Int());
            AddColumn("dbo.Pations", "Nation_Id", c => c.Int());
            AddColumn("dbo.Pations", "HowAbout_Id", c => c.Int());
            AddColumn("dbo.Pations", "Gender_Id", c => c.Int());
            AddColumn("dbo.SalesReps", "Section_Id", c => c.Int());
            AddColumn("dbo.SalesReps", "Nation_Id", c => c.Int());
            AddColumn("dbo.SalesReps", "HowAbout_Id", c => c.Int());
            AddColumn("dbo.SalesReps", "Gender_Id", c => c.Int());
            AddColumn("dbo.SalesReps", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.Users", "JobPermation_Id", c => c.Int());
            RenameIndex(table: "dbo.ToolsReturnTools", name: "IX_Tools_Id", newName: "IX_Tools_Id1");
            RenameIndex(table: "dbo.ToolsReturnTools", name: "IX_ReturnTools_MyProperty", newName: "IX_ReturnTools_MyProperty1");
            RenameIndex(table: "dbo.ToolsReturnTools", name: "IX_CatQuanTools_Id", newName: "IX_CatQuanTools_Id1");
            RenameIndex(table: "dbo.ToolsRequiredpurchases", name: "IX_Tools_Id", newName: "IX_Tools_Id1");
            RenameIndex(table: "dbo.ToolsRequiredpurchases", name: "IX_RequiredpurchaseTools_Id", newName: "IX_RequiredpurchaseTools_Id1");
            RenameIndex(table: "dbo.ToolsRequiredpurchases", name: "IX_CatQuanTools_Id", newName: "IX_CatQuanTools_Id1");
            RenameIndex(table: "dbo.ToolsPurchases", name: "IX_Tools_Id", newName: "IX_Tools_Id1");
            RenameIndex(table: "dbo.ToolsPurchases", name: "IX_PurchaseTools_Id", newName: "IX_PurchaseTools_Id1");
            RenameIndex(table: "dbo.ToolsPurchases", name: "IX_CatQuanTools_Id", newName: "IX_CatQuanTools_Id1");
            RenameIndex(table: "dbo.ToolsConvs", name: "IX_Tools_Id", newName: "IX_Tools_Id1");
            RenameIndex(table: "dbo.ToolsConvs", name: "IX_ConvTools_Id", newName: "IX_ConvTools_Id1");
            RenameIndex(table: "dbo.ToolsConvs", name: "IX_CatQuanTools_Id", newName: "IX_CatQuanTools_Id1");
            RenameIndex(table: "dbo.Remedies", name: "IX_Items_Id", newName: "IX_Items_Id1");
            RenameIndex(table: "dbo.Remedies", name: "IX_Diagnosis_Id", newName: "IX_Diagnosis_Id1");
            RenameIndex(table: "dbo.Remedies", name: "IX_CatQuanItems_Id", newName: "IX_CatQuanItems_Id1");
            RenameIndex(table: "dbo.PurchaseTools", name: "IX_RequiredpurchaseTools_Id", newName: "IX_RequiredpurchaseTools_Id1");
            RenameIndex(table: "dbo.PurchaseItems", name: "IX_RequiredpurchaseItems_Id", newName: "IX_RequiredpurchaseItems_Id1");
            RenameColumn(table: "dbo.ToolsReturnTools", name: "Tools_Id", newName: "Tools_Id1");
            RenameColumn(table: "dbo.ToolsReturnTools", name: "ReturnTools_MyProperty", newName: "ReturnTools_MyProperty1");
            RenameColumn(table: "dbo.ToolsReturnTools", name: "CatQuanTools_Id", newName: "CatQuanTools_Id1");
            RenameColumn(table: "dbo.ToolsRequiredpurchases", name: "Tools_Id", newName: "Tools_Id1");
            RenameColumn(table: "dbo.ToolsRequiredpurchases", name: "RequiredpurchaseTools_Id", newName: "RequiredpurchaseTools_Id1");
            RenameColumn(table: "dbo.ToolsRequiredpurchases", name: "CatQuanTools_Id", newName: "CatQuanTools_Id1");
            RenameColumn(table: "dbo.ToolsPurchases", name: "Tools_Id", newName: "Tools_Id1");
            RenameColumn(table: "dbo.ToolsPurchases", name: "PurchaseTools_Id", newName: "PurchaseTools_Id1");
            RenameColumn(table: "dbo.ToolsPurchases", name: "CatQuanTools_Id", newName: "CatQuanTools_Id1");
            RenameColumn(table: "dbo.ToolsConvs", name: "Tools_Id", newName: "Tools_Id1");
            RenameColumn(table: "dbo.ToolsConvs", name: "ConvTools_Id", newName: "ConvTools_Id1");
            RenameColumn(table: "dbo.ToolsConvs", name: "CatQuanTools_Id", newName: "CatQuanTools_Id1");
            RenameColumn(table: "dbo.Remedies", name: "Items_Id", newName: "Items_Id1");
            RenameColumn(table: "dbo.Remedies", name: "Diagnosis_Id", newName: "Diagnosis_Id1");
            RenameColumn(table: "dbo.Remedies", name: "CatQuanItems_Id", newName: "CatQuanItems_Id1");
            RenameColumn(table: "dbo.PurchaseTools", name: "RequiredpurchaseTools_Id", newName: "RequiredpurchaseTools_Id1");
            RenameColumn(table: "dbo.PurchaseItems", name: "RequiredpurchaseItems_Id", newName: "RequiredpurchaseItems_Id1");
            AddColumn("dbo.ToolsReturnTools", "Tools_Id", c => c.Int());
            AddColumn("dbo.ToolsReturnTools", "ReturnTools_MyProperty", c => c.Int());
            AddColumn("dbo.ToolsReturnTools", "CatQuanTools_Id", c => c.Int());
            AddColumn("dbo.ToolsRequiredpurchases", "Tools_Id", c => c.Int());
            AddColumn("dbo.ToolsRequiredpurchases", "RequiredpurchaseTools_Id", c => c.Int());
            AddColumn("dbo.ToolsRequiredpurchases", "CatQuanTools_Id", c => c.Int());
            AddColumn("dbo.ToolsPurchases", "Tools_Id", c => c.Int());
            AddColumn("dbo.ToolsPurchases", "PurchaseTools_Id", c => c.Int());
            AddColumn("dbo.ToolsPurchases", "CatQuanTools_Id", c => c.Int());
            AddColumn("dbo.ToolsConvs", "Tools_Id", c => c.Int());
            AddColumn("dbo.ToolsConvs", "ConvTools_Id", c => c.Int());
            AddColumn("dbo.ToolsConvs", "CatQuanTools_Id", c => c.Int());
            AddColumn("dbo.Remedies", "Items_Id", c => c.Int());
            AddColumn("dbo.Remedies", "Diagnosis_Id", c => c.Int());
            AddColumn("dbo.Remedies", "CatQuanItems_Id", c => c.Int());
            AddColumn("dbo.PurchaseTools", "RequiredpurchaseTools_Id", c => c.Int());
            AddColumn("dbo.PurchaseItems", "RequiredpurchaseItems_Id", c => c.Int());
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
