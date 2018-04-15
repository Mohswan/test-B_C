namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserAllClass1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CashCoes", "UserUpdate_Id");
            DropColumn("dbo.Companies", "UserUpdate_Id");
            RenameColumn(table: "dbo.Companies", name: "Users_Id", newName: "UsersAdd_Id");
            RenameColumn(table: "dbo.Companies", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameColumn(table: "dbo.CashCoes", name: "Users_Id", newName: "UsersAdd_Id");
            RenameColumn(table: "dbo.CashCoes", name: "Users1_Id", newName: "UserUpdate_Id");
            RenameIndex(table: "dbo.CashCoes", name: "IX_Users_Id", newName: "IX_UsersAdd_Id");
            RenameIndex(table: "dbo.CashCoes", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_Users_Id", newName: "IX_UsersAdd_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_Users1_Id", newName: "IX_UserUpdate_Id");
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
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UsersAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashCoes]([CodeId], [Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [TypeOPration_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [TypeOPrations_Id], [UsersAdd_Id], [UserUpdate_Id])
                      VALUES (@CodeId, @Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @TypeOPration_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @TypeOPrations_Id, @UsersAdd_Id, @UserUpdate_Id)
                      
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
                      SET [CodeId] = @CodeId, [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [TypeOPration_Id] = @TypeOPration_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [TypeOPrations_Id] = @TypeOPrations_Id, [UsersAdd_Id] = @UsersAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.CashCoes_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        UsersAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CashCoes]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([TypeOPrations_Id] = @TypeOPrations_Id) OR ([TypeOPrations_Id] IS NULL AND @TypeOPrations_Id IS NULL))) AND (([UsersAdd_Id] = @UsersAdd_Id) OR ([UsersAdd_Id] IS NULL AND @UsersAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
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
                        specializations_Id = p.Int(),
                        UsersAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Companies]([Name], [Address], [TelWhats], [Tel1], [Mob], [taxID], [regID], [products], [DateEnd], [DateAdd], [DateUpdate], [specializations_Id], [UsersAdd_Id], [UserUpdate_Id])
                      VALUES (@Name, @Address, @TelWhats, @Tel1, @Mob, @taxID, @regID, @products, @DateEnd, @DateAdd, @DateUpdate, @specializations_Id, @UsersAdd_Id, @UserUpdate_Id)
                      
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
                        specializations_Id = p.Int(),
                        UsersAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Companies]
                      SET [Name] = @Name, [Address] = @Address, [TelWhats] = @TelWhats, [Tel1] = @Tel1, [Mob] = @Mob, [taxID] = @taxID, [regID] = @regID, [products] = @products, [DateEnd] = @DateEnd, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [specializations_Id] = @specializations_Id, [UsersAdd_Id] = @UsersAdd_Id, [UserUpdate_Id] = @UserUpdate_Id
                      WHERE ([Id] = @Id)"
            );
            
            AlterStoredProcedure(
                "dbo.Companies_Delete",
                p => new
                    {
                        Id = p.Int(),
                        specializations_Id = p.Int(),
                        UsersAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Companies]
                      WHERE (((([Id] = @Id) AND (([specializations_Id] = @specializations_Id) OR ([specializations_Id] IS NULL AND @specializations_Id IS NULL))) AND (([UsersAdd_Id] = @UsersAdd_Id) OR ([UsersAdd_Id] IS NULL AND @UsersAdd_Id IS NULL))) AND (([UserUpdate_Id] = @UserUpdate_Id) OR ([UserUpdate_Id] IS NULL AND @UserUpdate_Id IS NULL)))"
            );
            
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Companies", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_UsersAdd_Id", newName: "IX_Users_Id");
            RenameIndex(table: "dbo.CashCoes", name: "IX_UserUpdate_Id", newName: "IX_Users1_Id");
            RenameIndex(table: "dbo.CashCoes", name: "IX_UsersAdd_Id", newName: "IX_Users_Id");
            RenameColumn(table: "dbo.CashCoes", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.CashCoes", name: "UsersAdd_Id", newName: "Users_Id");
            RenameColumn(table: "dbo.Companies", name: "UserUpdate_Id", newName: "Users1_Id");
            RenameColumn(table: "dbo.Companies", name: "UsersAdd_Id", newName: "Users_Id");
            AddColumn("dbo.Companies", "UserUpdate_Id", c => c.Int());
            AddColumn("dbo.CashCoes", "UserUpdate_Id", c => c.Int());
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
