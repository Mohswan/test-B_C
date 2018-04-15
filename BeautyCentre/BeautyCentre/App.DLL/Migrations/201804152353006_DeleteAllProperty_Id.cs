namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAllProperty_Id : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DataReasons", "Reasons_Id");
            DropColumn("dbo.ItemsConvs", "CatQuanItems_Id");
            DropColumn("dbo.ItemsConvs", "ConvItems_Id");
            DropColumn("dbo.ItemsConvs", "Items_Id");
            DropColumn("dbo.ItemsCourses", "CatQuanItems_Id");
            DropColumn("dbo.ItemsCourses", "Items_Id");
            DropColumn("dbo.ItemsDocCusts", "CatQuanItems_Id");
            DropColumn("dbo.ItemsDocCusts", "Items_Id");
            DropColumn("dbo.ItemsPurchases", "CatQuanItems_Id");
            DropColumn("dbo.ItemsPurchases", "Items_Id");
            DropColumn("dbo.ItemsPurchases", "PurchaseItems_Id");
            DropColumn("dbo.ItemsRequiredpurchases", "CatQuanItems_Id");
            DropColumn("dbo.ItemsRequiredpurchases", "Diagnosis_Id");
            DropColumn("dbo.ItemsRequiredpurchases", "Items_Id");
            DropColumn("dbo.ItemsReturnItems", "CatQuanItems_Id");
            DropColumn("dbo.ItemsReturnItems", "Items_Id");
            DropColumn("dbo.ItemsReturnItems", "ReturnItems_Id");
            RenameColumn(table: "dbo.DataReasons", name: "Reasons_Id1", newName: "Reasons_Id");
            RenameColumn(table: "dbo.ItemsConvs", name: "CatQuanItems_Id1", newName: "CatQuanItems_Id");
            RenameColumn(table: "dbo.ItemsConvs", name: "ConvItems_Id1", newName: "ConvItems_Id");
            RenameColumn(table: "dbo.ItemsConvs", name: "Items_Id1", newName: "Items_Id");
            RenameColumn(table: "dbo.ItemsCourses", name: "CatQuanItems_Id1", newName: "CatQuanItems_Id");
            RenameColumn(table: "dbo.ItemsCourses", name: "Items_Id1", newName: "Items_Id");
            RenameColumn(table: "dbo.ItemsDocCusts", name: "CatQuanItems_Id1", newName: "CatQuanItems_Id");
            RenameColumn(table: "dbo.ItemsDocCusts", name: "Items_Id1", newName: "Items_Id");
            RenameColumn(table: "dbo.ItemsPurchases", name: "CatQuanItems_Id1", newName: "CatQuanItems_Id");
            RenameColumn(table: "dbo.ItemsPurchases", name: "Items_Id1", newName: "Items_Id");
            RenameColumn(table: "dbo.ItemsPurchases", name: "PurchaseItems_Id1", newName: "PurchaseItems_Id");
            RenameColumn(table: "dbo.ItemsRequiredpurchases", name: "CatQuanItems_Id1", newName: "CatQuanItems_Id");
            RenameColumn(table: "dbo.ItemsRequiredpurchases", name: "Diagnosis_Id1", newName: "Diagnosis_Id");
            RenameColumn(table: "dbo.ItemsRequiredpurchases", name: "Items_Id1", newName: "Items_Id");
            RenameColumn(table: "dbo.ItemsReturnItems", name: "CatQuanItems_Id1", newName: "CatQuanItems_Id");
            RenameColumn(table: "dbo.ItemsReturnItems", name: "Items_Id1", newName: "Items_Id");
            RenameColumn(table: "dbo.ItemsReturnItems", name: "ReturnItems_Id1", newName: "ReturnItems_Id");
            RenameIndex(table: "dbo.DataReasons", name: "IX_Reasons_Id1", newName: "IX_Reasons_Id");
            RenameIndex(table: "dbo.ItemsConvs", name: "IX_CatQuanItems_Id1", newName: "IX_CatQuanItems_Id");
            RenameIndex(table: "dbo.ItemsConvs", name: "IX_ConvItems_Id1", newName: "IX_ConvItems_Id");
            RenameIndex(table: "dbo.ItemsConvs", name: "IX_Items_Id1", newName: "IX_Items_Id");
            RenameIndex(table: "dbo.ItemsCourses", name: "IX_CatQuanItems_Id1", newName: "IX_CatQuanItems_Id");
            RenameIndex(table: "dbo.ItemsCourses", name: "IX_Items_Id1", newName: "IX_Items_Id");
            RenameIndex(table: "dbo.ItemsDocCusts", name: "IX_CatQuanItems_Id1", newName: "IX_CatQuanItems_Id");
            RenameIndex(table: "dbo.ItemsDocCusts", name: "IX_Items_Id1", newName: "IX_Items_Id");
            RenameIndex(table: "dbo.ItemsPurchases", name: "IX_CatQuanItems_Id1", newName: "IX_CatQuanItems_Id");
            RenameIndex(table: "dbo.ItemsPurchases", name: "IX_Items_Id1", newName: "IX_Items_Id");
            RenameIndex(table: "dbo.ItemsPurchases", name: "IX_PurchaseItems_Id1", newName: "IX_PurchaseItems_Id");
            RenameIndex(table: "dbo.ItemsRequiredpurchases", name: "IX_CatQuanItems_Id1", newName: "IX_CatQuanItems_Id");
            RenameIndex(table: "dbo.ItemsRequiredpurchases", name: "IX_Diagnosis_Id1", newName: "IX_Diagnosis_Id");
            RenameIndex(table: "dbo.ItemsRequiredpurchases", name: "IX_Items_Id1", newName: "IX_Items_Id");
            RenameIndex(table: "dbo.ItemsReturnItems", name: "IX_CatQuanItems_Id1", newName: "IX_CatQuanItems_Id");
            RenameIndex(table: "dbo.ItemsReturnItems", name: "IX_Items_Id1", newName: "IX_Items_Id");
            RenameIndex(table: "dbo.ItemsReturnItems", name: "IX_ReturnItems_Id1", newName: "IX_ReturnItems_Id");
            DropColumn("dbo.CashCoes", "Company_MyProperty");
            DropColumn("dbo.CashCoes", "PaymentMethod_Id");
            DropColumn("dbo.CashCoes", "SalesRep_Id");
            DropColumn("dbo.CashCoes", "Section_Id");
            DropColumn("dbo.CashCoes", "TypeOPration_Id");
            DropColumn("dbo.CashEmps", "Employee_Id");
            DropColumn("dbo.CashEmps", "Month_Id");
            DropColumn("dbo.CashEmps", "Section_Id");
            DropColumn("dbo.Employees", "CatJob_Id");
            DropColumn("dbo.Employees", "Section_Id");
            DropColumn("dbo.CashOthers", "Exp_Id");
            DropColumn("dbo.CashOthers", "PaymentMethod_Id");
            DropColumn("dbo.CashOthers", "Section_Id");
            DropColumn("dbo.CashReturns", "Company_MyProperty");
            DropColumn("dbo.CashReturns", "PaymentMethod_Id");
            DropColumn("dbo.CashReturns", "SalesRep_Id");
            DropColumn("dbo.CashReturns", "Section_Id");
            DropColumn("dbo.CashReturns", "TypeOPration_Id");
            DropColumn("dbo.ChequeCashCoes", "Bank_Id");
            DropColumn("dbo.ChequeCashCoes", "CashCo_Id");
            DropColumn("dbo.ChequeCashOthers", "Bank_Id");
            DropColumn("dbo.ChequeCashOthers", "CashOther_Id");
            DropColumn("dbo.ChequeCashReturns", "Bank_Id");
            DropColumn("dbo.ChequeCashReturns", "CashReturn_Id");
            DropColumn("dbo.ChequeDocCusts", "Bank_Id");
            DropColumn("dbo.ChequeDocCusts", "DocCust_Id");
            DropColumn("dbo.DocCusts", "Course_Id");
            DropColumn("dbo.DocCusts", "ListCust_Id");
            DropColumn("dbo.DocCusts", "Pation_Id");
            DropColumn("dbo.DocCusts", "PaymentMethod_Id");
            DropColumn("dbo.DocCusts", "Room_Id");
            DropColumn("dbo.DocCusts", "Section_Id");
            DropColumn("dbo.ListCusts", "Pation_Id");
            DropColumn("dbo.ListCusts", "PaymentMethod_Id");
            DropColumn("dbo.ListCusts", "Section_Id");
            DropColumn("dbo.ChequeListCusts", "Bank_Id");
            DropColumn("dbo.ChequeListCusts", "ListCust_Id");
            DropColumn("dbo.ChequeMonthCoes", "Bank_Id");
            DropColumn("dbo.ChequeMonthCoes", "MonthCo_Id");
            DropColumn("dbo.ChequeMonthCusts", "Bank_Id");
            DropColumn("dbo.ChequeMonthCusts", "MonthCust_Id");
            DropColumn("dbo.ChequeMonthMachinCoes", "Bank_Id");
            DropColumn("dbo.ChequeMonthMachinCoes", "MonthMachinCo_Id");
            DropColumn("dbo.ConvItems", "Section_Id");
            DropColumn("dbo.ConvItems", "SectionTo_Id");
            DropColumn("dbo.ConvMachins", "Machin_Id");
            DropColumn("dbo.ConvMachins", "Section_Id");
            DropColumn("dbo.ConvMachins", "SectionTo_Id");
            DropColumn("dbo.ConvTools", "Section_Id");
            DropColumn("dbo.ConvTools", "SectionTo_Id");
            DropColumn("dbo.DateCalls", "Pation_Id");
            DropColumn("dbo.DateCalls", "Section_Id");
            DropColumn("dbo.DocOthers", "ListOther_Id");
            DropColumn("dbo.ListOthers", "Section_Id");
            DropColumn("dbo.DocReps", "ListRep_Id");
            DropColumn("dbo.GzaEmps", "Employee_Id");
            DropColumn("dbo.GzaEmps", "Section_Id");
            DropColumn("dbo.installments", "PurchaseMachin_Id");
            DropColumn("dbo.Items", "CatItem_Id");
            DropColumn("dbo.Items", "Company_MyProperty");
            DropColumn("dbo.Items", "TypeUnit_Id");
            DropColumn("dbo.ItemsCourses", "Course_Id");
            DropColumn("dbo.ItemsDocCusts", "DocCust_Id");
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
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UsersAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashCoes]([CodeId], [Date], [Price], [Note], [DateAdd], [DateUpdate], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [TypeOPrations_Id], [UsersAdd_Id], [UserUpdate_Id])
                      VALUES (@CodeId, @Date, @Price, @Note, @DateAdd, @DateUpdate, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @TypeOPrations_Id, @UsersAdd_Id, @UserUpdate_Id)
                      
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
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UsersAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CashCoes]
                      SET [CodeId] = @CodeId, [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [TypeOPrations_Id] = @TypeOPrations_Id, [UsersAdd_Id] = @UsersAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Car], [Njob], [Name], [Salary], [Address], [TelWhats], [Tel], [Mob], [Email], [Note], [DateAdd], [DateUpdate], [CatJobs_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Car, @Njob, @Name, @Salary, @Address, @TelWhats, @Tel, @Mob, @Email, @Note, @DateAdd, @DateUpdate, @CatJobs_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Car] = @Car, [Njob] = @Njob, [Name] = @Name, [Salary] = @Salary, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [CatJobs_Id] = @CatJobs_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashOthers]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Exps_Id], [PaymentMethods_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Exps_Id, @PaymentMethods_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CashOthers]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Exps_Id] = @Exps_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashReturns]([CodeId], [Date], [Price], [Note], [DateAdd], [DateUpdate], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [TypeOPrations_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@CodeId, @Date, @Price, @Note, @DateAdd, @DateUpdate, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @TypeOPrations_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                      SET [CodeId] = @CodeId, [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [TypeOPrations_Id] = @TypeOPrations_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                    @"INSERT [dbo].[DocCusts]([purpose], [DiagnosisOld], [DateOld], [PreviousBalance], [Date], [RequiredForToday], [total], [Note], [Diagnosis], [Payed], [Precautions], [PriceCurse], [PriceIn], [PriceOld], [PriceAll], [Price], [Discount], [NextDate], [DateAdd], [DateUpdate], [Courses_Id], [ListCusts_Id], [Pations_Id], [PaymentMethods_Id], [Rooms_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@purpose, @DiagnosisOld, @DateOld, @PreviousBalance, @Date, @RequiredForToday, @total, @Note, @Diagnosis, @Payed, @Precautions, @PriceCurse, @PriceIn, @PriceOld, @PriceAll, @Price, @Discount, @NextDate, @DateAdd, @DateUpdate, @Courses_Id, @ListCusts_Id, @Pations_Id, @PaymentMethods_Id, @Rooms_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                      SET [purpose] = @purpose, [DiagnosisOld] = @DiagnosisOld, [DateOld] = @DateOld, [PreviousBalance] = @PreviousBalance, [Date] = @Date, [RequiredForToday] = @RequiredForToday, [total] = @total, [Note] = @Note, [Diagnosis] = @Diagnosis, [Payed] = @Payed, [Precautions] = @Precautions, [PriceCurse] = @PriceCurse, [PriceIn] = @PriceIn, [PriceOld] = @PriceOld, [PriceAll] = @PriceAll, [Price] = @Price, [Discount] = @Discount, [NextDate] = @NextDate, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Courses_Id] = @Courses_Id, [ListCusts_Id] = @ListCusts_Id, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Rooms_Id] = @Rooms_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListCusts]([Type], [Date], [purpose], [PreviousBalance], [Discount], [RequiredForToday], [total], [payed], [Note], [Balance], [VisitNo], [VisitIn], [DateAdd], [DateUpdate], [Pations_Id], [PaymentMethods_Id], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Type, @Date, @purpose, @PreviousBalance, @Discount, @RequiredForToday, @total, @payed, @Note, @Balance, @VisitNo, @VisitIn, @DateAdd, @DateUpdate, @Pations_Id, @PaymentMethods_Id, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListCusts]
                      SET [Type] = @Type, [Date] = @Date, [purpose] = @purpose, [PreviousBalance] = @PreviousBalance, [Discount] = @Discount, [RequiredForToday] = @RequiredForToday, [total] = @total, [payed] = @payed, [Note] = @Note, [Balance] = @Balance, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ConvItems]([Price], [Date], [Note], [DateAdd], [DateUpdate], [Sections_Id], [Sections1_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Price, @Date, @Note, @DateAdd, @DateUpdate, @Sections_Id, @Sections1_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ConvItems]
                      SET [Price] = @Price, [Date] = @Date, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Sections_Id] = @Sections_Id, [Sections1_Id] = @Sections1_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ConvTools]([Price], [Date], [Note], [DateAdd], [DateUpdate], [Sections_Id], [Sections1_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Price, @Date, @Note, @DateAdd, @DateUpdate, @Sections_Id, @Sections1_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ConvTools]
                      SET [Price] = @Price, [Date] = @Date, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Sections_Id] = @Sections_Id, [Sections1_Id] = @Sections1_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListOthers]([Type], [Date], [Name], [Reasons], [VisitNo], [VisitIn], [Note], [DateAdd], [DateUpdate], [Sections_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Type, @Date, @Name, @Reasons, @VisitNo, @VisitIn, @Note, @DateAdd, @DateUpdate, @Sections_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                        Sections_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListOthers]
                      SET [Type] = @Type, [Date] = @Date, [Name] = @Name, [Reasons] = @Reasons, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Sections_Id] = @Sections_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
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
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Items]([Name], [Data], [Packagecost], [Minprice], [MinOrder], [Cartoonprice], [Noofunitsperpackage], [Noofpackagespercartoon], [Unitprice], [Purpose], [Dose], [Precautions], [DateAdd], [DateUpdate], [CatItems_Id], [Companies_Id], [TypeUnits_Id], [UserAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Data, @Packagecost, @Minprice, @MinOrder, @Cartoonprice, @Noofunitsperpackage, @Noofpackagespercartoon, @Unitprice, @Purpose, @Dose, @Precautions, @DateAdd, @DateUpdate, @CatItems_Id, @Companies_Id, @TypeUnits_Id, @UserAdd_Id, @UserUpdate_Id)
                      
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
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Items]
                      SET [Name] = @Name, [Data] = @Data, [Packagecost] = @Packagecost, [Minprice] = @Minprice, [MinOrder] = @MinOrder, [Cartoonprice] = @Cartoonprice, [Noofunitsperpackage] = @Noofunitsperpackage, [Noofpackagespercartoon] = @Noofpackagespercartoon, [Unitprice] = @Unitprice, [Purpose] = @Purpose, [Dose] = @Dose, [Precautions] = @Precautions, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [CatItems_Id] = @CatItems_Id, [Companies_Id] = @Companies_Id, [TypeUnits_Id] = @TypeUnits_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemsDocCusts", "DocCust_Id", c => c.Int());
            AddColumn("dbo.ItemsCourses", "Course_Id", c => c.Int());
            AddColumn("dbo.Items", "TypeUnit_Id", c => c.Int());
            AddColumn("dbo.Items", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.Items", "CatItem_Id", c => c.Int());
            AddColumn("dbo.installments", "PurchaseMachin_Id", c => c.Int());
            AddColumn("dbo.GzaEmps", "Section_Id", c => c.Int());
            AddColumn("dbo.GzaEmps", "Employee_Id", c => c.Int());
            AddColumn("dbo.DocReps", "ListRep_Id", c => c.Int());
            AddColumn("dbo.ListOthers", "Section_Id", c => c.Int());
            AddColumn("dbo.DocOthers", "ListOther_Id", c => c.Int());
            AddColumn("dbo.DateCalls", "Section_Id", c => c.Int());
            AddColumn("dbo.DateCalls", "Pation_Id", c => c.Int());
            AddColumn("dbo.ConvTools", "SectionTo_Id", c => c.Int());
            AddColumn("dbo.ConvTools", "Section_Id", c => c.Int());
            AddColumn("dbo.ConvMachins", "SectionTo_Id", c => c.Int());
            AddColumn("dbo.ConvMachins", "Section_Id", c => c.Int());
            AddColumn("dbo.ConvMachins", "Machin_Id", c => c.Int());
            AddColumn("dbo.ConvItems", "SectionTo_Id", c => c.Int());
            AddColumn("dbo.ConvItems", "Section_Id", c => c.Int());
            AddColumn("dbo.ChequeMonthMachinCoes", "MonthMachinCo_Id", c => c.Int());
            AddColumn("dbo.ChequeMonthMachinCoes", "Bank_Id", c => c.Int());
            AddColumn("dbo.ChequeMonthCusts", "MonthCust_Id", c => c.Int());
            AddColumn("dbo.ChequeMonthCusts", "Bank_Id", c => c.Int());
            AddColumn("dbo.ChequeMonthCoes", "MonthCo_Id", c => c.Int());
            AddColumn("dbo.ChequeMonthCoes", "Bank_Id", c => c.Int());
            AddColumn("dbo.ChequeListCusts", "ListCust_Id", c => c.Int());
            AddColumn("dbo.ChequeListCusts", "Bank_Id", c => c.Int());
            AddColumn("dbo.ListCusts", "Section_Id", c => c.Int());
            AddColumn("dbo.ListCusts", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.ListCusts", "Pation_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "Section_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "Room_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "Pation_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "ListCust_Id", c => c.Int());
            AddColumn("dbo.DocCusts", "Course_Id", c => c.Int());
            AddColumn("dbo.ChequeDocCusts", "DocCust_Id", c => c.Int());
            AddColumn("dbo.ChequeDocCusts", "Bank_Id", c => c.Int());
            AddColumn("dbo.ChequeCashReturns", "CashReturn_Id", c => c.Int());
            AddColumn("dbo.ChequeCashReturns", "Bank_Id", c => c.Int());
            AddColumn("dbo.ChequeCashOthers", "CashOther_Id", c => c.Int());
            AddColumn("dbo.ChequeCashOthers", "Bank_Id", c => c.Int());
            AddColumn("dbo.ChequeCashCoes", "CashCo_Id", c => c.Int());
            AddColumn("dbo.ChequeCashCoes", "Bank_Id", c => c.Int());
            AddColumn("dbo.CashReturns", "TypeOPration_Id", c => c.Int());
            AddColumn("dbo.CashReturns", "Section_Id", c => c.Int());
            AddColumn("dbo.CashReturns", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.CashReturns", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.CashReturns", "Company_MyProperty", c => c.Int());
            AddColumn("dbo.CashOthers", "Section_Id", c => c.Int());
            AddColumn("dbo.CashOthers", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.CashOthers", "Exp_Id", c => c.Int());
            AddColumn("dbo.Employees", "Section_Id", c => c.Int());
            AddColumn("dbo.Employees", "CatJob_Id", c => c.Int());
            AddColumn("dbo.CashEmps", "Section_Id", c => c.Int());
            AddColumn("dbo.CashEmps", "Month_Id", c => c.Int());
            AddColumn("dbo.CashEmps", "Employee_Id", c => c.Int());
            AddColumn("dbo.CashCoes", "TypeOPration_Id", c => c.Int());
            AddColumn("dbo.CashCoes", "Section_Id", c => c.Int());
            AddColumn("dbo.CashCoes", "SalesRep_Id", c => c.Int());
            AddColumn("dbo.CashCoes", "PaymentMethod_Id", c => c.Int());
            AddColumn("dbo.CashCoes", "Company_MyProperty", c => c.Int());
            RenameIndex(table: "dbo.ItemsReturnItems", name: "IX_ReturnItems_Id", newName: "IX_ReturnItems_Id1");
            RenameIndex(table: "dbo.ItemsReturnItems", name: "IX_Items_Id", newName: "IX_Items_Id1");
            RenameIndex(table: "dbo.ItemsReturnItems", name: "IX_CatQuanItems_Id", newName: "IX_CatQuanItems_Id1");
            RenameIndex(table: "dbo.ItemsRequiredpurchases", name: "IX_Items_Id", newName: "IX_Items_Id1");
            RenameIndex(table: "dbo.ItemsRequiredpurchases", name: "IX_Diagnosis_Id", newName: "IX_Diagnosis_Id1");
            RenameIndex(table: "dbo.ItemsRequiredpurchases", name: "IX_CatQuanItems_Id", newName: "IX_CatQuanItems_Id1");
            RenameIndex(table: "dbo.ItemsPurchases", name: "IX_PurchaseItems_Id", newName: "IX_PurchaseItems_Id1");
            RenameIndex(table: "dbo.ItemsPurchases", name: "IX_Items_Id", newName: "IX_Items_Id1");
            RenameIndex(table: "dbo.ItemsPurchases", name: "IX_CatQuanItems_Id", newName: "IX_CatQuanItems_Id1");
            RenameIndex(table: "dbo.ItemsDocCusts", name: "IX_Items_Id", newName: "IX_Items_Id1");
            RenameIndex(table: "dbo.ItemsDocCusts", name: "IX_CatQuanItems_Id", newName: "IX_CatQuanItems_Id1");
            RenameIndex(table: "dbo.ItemsCourses", name: "IX_Items_Id", newName: "IX_Items_Id1");
            RenameIndex(table: "dbo.ItemsCourses", name: "IX_CatQuanItems_Id", newName: "IX_CatQuanItems_Id1");
            RenameIndex(table: "dbo.ItemsConvs", name: "IX_Items_Id", newName: "IX_Items_Id1");
            RenameIndex(table: "dbo.ItemsConvs", name: "IX_ConvItems_Id", newName: "IX_ConvItems_Id1");
            RenameIndex(table: "dbo.ItemsConvs", name: "IX_CatQuanItems_Id", newName: "IX_CatQuanItems_Id1");
            RenameIndex(table: "dbo.DataReasons", name: "IX_Reasons_Id", newName: "IX_Reasons_Id1");
            RenameColumn(table: "dbo.ItemsReturnItems", name: "ReturnItems_Id", newName: "ReturnItems_Id1");
            RenameColumn(table: "dbo.ItemsReturnItems", name: "Items_Id", newName: "Items_Id1");
            RenameColumn(table: "dbo.ItemsReturnItems", name: "CatQuanItems_Id", newName: "CatQuanItems_Id1");
            RenameColumn(table: "dbo.ItemsRequiredpurchases", name: "Items_Id", newName: "Items_Id1");
            RenameColumn(table: "dbo.ItemsRequiredpurchases", name: "Diagnosis_Id", newName: "Diagnosis_Id1");
            RenameColumn(table: "dbo.ItemsRequiredpurchases", name: "CatQuanItems_Id", newName: "CatQuanItems_Id1");
            RenameColumn(table: "dbo.ItemsPurchases", name: "PurchaseItems_Id", newName: "PurchaseItems_Id1");
            RenameColumn(table: "dbo.ItemsPurchases", name: "Items_Id", newName: "Items_Id1");
            RenameColumn(table: "dbo.ItemsPurchases", name: "CatQuanItems_Id", newName: "CatQuanItems_Id1");
            RenameColumn(table: "dbo.ItemsDocCusts", name: "Items_Id", newName: "Items_Id1");
            RenameColumn(table: "dbo.ItemsDocCusts", name: "CatQuanItems_Id", newName: "CatQuanItems_Id1");
            RenameColumn(table: "dbo.ItemsCourses", name: "Items_Id", newName: "Items_Id1");
            RenameColumn(table: "dbo.ItemsCourses", name: "CatQuanItems_Id", newName: "CatQuanItems_Id1");
            RenameColumn(table: "dbo.ItemsConvs", name: "Items_Id", newName: "Items_Id1");
            RenameColumn(table: "dbo.ItemsConvs", name: "ConvItems_Id", newName: "ConvItems_Id1");
            RenameColumn(table: "dbo.ItemsConvs", name: "CatQuanItems_Id", newName: "CatQuanItems_Id1");
            RenameColumn(table: "dbo.DataReasons", name: "Reasons_Id", newName: "Reasons_Id1");
            AddColumn("dbo.ItemsReturnItems", "ReturnItems_Id", c => c.Int());
            AddColumn("dbo.ItemsReturnItems", "Items_Id", c => c.Int());
            AddColumn("dbo.ItemsReturnItems", "CatQuanItems_Id", c => c.Int());
            AddColumn("dbo.ItemsRequiredpurchases", "Items_Id", c => c.Int());
            AddColumn("dbo.ItemsRequiredpurchases", "Diagnosis_Id", c => c.Int());
            AddColumn("dbo.ItemsRequiredpurchases", "CatQuanItems_Id", c => c.Int());
            AddColumn("dbo.ItemsPurchases", "PurchaseItems_Id", c => c.Int());
            AddColumn("dbo.ItemsPurchases", "Items_Id", c => c.Int());
            AddColumn("dbo.ItemsPurchases", "CatQuanItems_Id", c => c.Int());
            AddColumn("dbo.ItemsDocCusts", "Items_Id", c => c.Int());
            AddColumn("dbo.ItemsDocCusts", "CatQuanItems_Id", c => c.Int());
            AddColumn("dbo.ItemsCourses", "Items_Id", c => c.Int());
            AddColumn("dbo.ItemsCourses", "CatQuanItems_Id", c => c.Int());
            AddColumn("dbo.ItemsConvs", "Items_Id", c => c.Int());
            AddColumn("dbo.ItemsConvs", "ConvItems_Id", c => c.Int());
            AddColumn("dbo.ItemsConvs", "CatQuanItems_Id", c => c.Int());
            AddColumn("dbo.DataReasons", "Reasons_Id", c => c.Int());
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
