namespace App.DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CashCoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        TypeOPration_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        TypeOPrations_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.TypeOPrations", t => t.TypeOPrations_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.TypeOPrations_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        TelWhats = c.String(),
                        Tel1 = c.String(),
                        Mob = c.String(),
                        taxID = c.String(),
                        regID = c.String(),
                        products = c.String(),
                        DateEnd = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        specializations_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.specializations", t => t.specializations_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.specializations_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.specializations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pass = c.String(),
                        Email = c.String(),
                        Tel = c.String(),
                        Tel1 = c.String(),
                        UserAdd = c.Int(nullable: false),
                        DateAdd = c.String(),
                        UserUpdate = c.Int(nullable: false),
                        DateUpdate = c.String(),
                        JobPermation_Id = c.Int(),
                        JobPermations_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobPermations", t => t.JobPermations_Id)
                .Index(t => t.JobPermations_Id);
            
            CreateTable(
                "dbo.JobPermations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesReps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Support = c.Byte(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        TelWhats = c.String(),
                        Tel = c.String(),
                        Mob = c.String(),
                        Email = c.String(),
                        blocked = c.Byte(nullable: false),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        Gender_Id = c.Int(),
                        HowAbout_Id = c.Int(),
                        Nation_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        Genders_Id = c.Int(),
                        HowAbouts_Id = c.Int(),
                        Nations_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.Genders", t => t.Genders_Id)
                .ForeignKey("dbo.HowAbouts", t => t.HowAbouts_Id)
                .ForeignKey("dbo.Nations", t => t.Nations_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.Genders_Id)
                .Index(t => t.HowAbouts_Id)
                .Index(t => t.Nations_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HowAbouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Tel = c.String(),
                        Tel1 = c.String(),
                        receptionist = c.String(),
                        mob = c.String(),
                        Email = c.String(),
                        DayJob = c.String(),
                        HourJob = c.String(),
                        Mark = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.TypeOPrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CashEmps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sol = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Gza = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Employee_Id = c.Int(),
                        Month_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Employees_Id = c.Int(),
                        Months_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_Id)
                .ForeignKey("dbo.Months", t => t.Months_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Employees_Id)
                .Index(t => t.Months_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Car = c.Byte(nullable: false),
                        Njob = c.Byte(nullable: false),
                        Name = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address = c.String(),
                        TelWhats = c.String(),
                        Tel = c.String(),
                        Mob = c.String(),
                        Email = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        CatJob_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        CatJobs_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatJobs", t => t.CatJobs_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.CatJobs_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.CatJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Months",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CashOthers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Exp_Id = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Exps_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exps", t => t.Exps_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Exps_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Exps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.CashReturns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        TypeOPration_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        TypeOPrations_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.TypeOPrations", t => t.TypeOPrations_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.TypeOPrations_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.CatItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        description = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.CatQuanItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CatQuanTools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChequeCashCoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        CashCo_Id = c.Int(),
                        Banks_Id = c.Int(),
                        CashCoes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.CashCoes", t => t.CashCoes_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.CashCoes_Id);
            
            CreateTable(
                "dbo.ChequeCashOthers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        CashOther_Id = c.Int(),
                        Banks_Id = c.Int(),
                        CashOthers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.CashOthers", t => t.CashOthers_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.CashOthers_Id);
            
            CreateTable(
                "dbo.ChequeCashReturns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        CashReturn_Id = c.Int(),
                        Banks_Id = c.Int(),
                        CashReturns_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.CashReturns", t => t.CashReturns_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.CashReturns_Id);
            
            CreateTable(
                "dbo.ChequeDocCusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        DocCust_Id = c.Int(),
                        Banks_Id = c.Int(),
                        DocCusts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.DocCusts", t => t.DocCusts_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.DocCusts_Id);
            
            CreateTable(
                "dbo.DocCusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        purpose = c.String(),
                        DiagnosisOld = c.String(),
                        DateOld = c.DateTime(nullable: false),
                        PreviousBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        RequiredForToday = c.Decimal(nullable: false, precision: 18, scale: 2),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        Diagnosis = c.String(),
                        Payed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precautions = c.String(),
                        PriceCurse = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceIn = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceOld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceAll = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NextDate = c.DateTime(nullable: false),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Course_Id = c.Int(),
                        ListCust_Id = c.Int(),
                        Pation_Id = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        Room_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Courses_Id = c.Int(),
                        ListCusts_Id = c.Int(),
                        Pations_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        Rooms_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Courses_Id)
                .ForeignKey("dbo.ListCusts", t => t.ListCusts_Id)
                .ForeignKey("dbo.Pations", t => t.Pations_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.Rooms", t => t.Rooms_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Courses_Id)
                .Index(t => t.ListCusts_Id)
                .Index(t => t.Pations_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.Rooms_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NoOfVisits = c.Int(nullable: false),
                        Schedule = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ListCusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        purpose = c.String(),
                        PreviousBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RequiredForToday = c.Decimal(nullable: false, precision: 18, scale: 2),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        payed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VisitNo = c.Byte(nullable: false),
                        VisitIn = c.Byte(nullable: false),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Pation_Id = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Pations_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pations", t => t.Pations_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Pations_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Pations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Double(nullable: false),
                        Address = c.String(),
                        TelWhats = c.String(),
                        Tel = c.String(),
                        Mob = c.String(),
                        Email = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Gender_Id = c.Int(),
                        HowAbout_Id = c.Int(),
                        Nation_Id = c.Int(),
                        Pationjob_Id = c.Int(),
                        Price_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Nations_Id = c.Int(),
                        Pationjobs_Id = c.Int(),
                        Prices_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nations", t => t.Nations_Id)
                .ForeignKey("dbo.Pationjobs", t => t.Pationjobs_Id)
                .ForeignKey("dbo.Prices", t => t.Prices_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Nations_Id)
                .Index(t => t.Pationjobs_Id)
                .Index(t => t.Prices_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Pationjobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ChequeListCusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        ListCust_Id = c.Int(),
                        Banks_Id = c.Int(),
                        ListCusts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.ListCusts", t => t.ListCusts_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.ListCusts_Id);
            
            CreateTable(
                "dbo.ChequeMonthCoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        MonthCo_Id = c.Int(),
                        Banks_Id = c.Int(),
                        MonthCoes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.MonthCoes", t => t.MonthCoes_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.MonthCoes_Id);
            
            CreateTable(
                "dbo.MonthCoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ChequeMonthCusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        MonthCust_Id = c.Int(),
                        Banks_Id = c.Int(),
                        MonthCusts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.MonthCusts", t => t.MonthCusts_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.MonthCusts_Id);
            
            CreateTable(
                "dbo.MonthCusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Pation_Id = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Pations_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pations", t => t.Pations_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Pations_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ChequeMonthMachinCoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Bank_Id = c.Int(),
                        MonthMachinCo_Id = c.Int(),
                        Banks_Id = c.Int(),
                        MonthMachinCoes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Banks_Id)
                .ForeignKey("dbo.MonthMachinCoes", t => t.MonthMachinCoes_Id)
                .Index(t => t.Banks_Id)
                .Index(t => t.MonthMachinCoes_Id);
            
            CreateTable(
                "dbo.MonthMachinCoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        PurchaseMachin_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        Companies_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        PurchaseMachins_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.PurchaseMachins", t => t.PurchaseMachins_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.PurchaseMachins_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.PurchaseMachins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        warranty = c.String(),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        Image = c.Binary(),
                        Date = c.DateTime(nullable: false),
                        discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        Machin_Id = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        RequiredpurchaseMachin_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        Machins_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        RequiredpurchaseMachins_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.Machins", t => t.Machins_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.RequiredpurchaseMachins", t => t.RequiredpurchaseMachins_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.Machins_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.RequiredpurchaseMachins_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Machins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Note = c.String(),
                        ChekMachin = c.Byte(nullable: false),
                        applications = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.RequiredpurchaseMachins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        warranty = c.String(),
                        DateEnd = c.DateTime(nullable: false),
                        Support = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        Machin_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        Machins_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.Machins", t => t.Machins_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.Machins_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ConvItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Section_Id = c.Int(),
                        SectionTo_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Sections1_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Sections", t => t.Sections1_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Sections1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ConvMachins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Double(nullable: false),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Machin_Id = c.Int(),
                        Section_Id = c.Int(),
                        SectionTo_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Machins_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Sections1_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Machins", t => t.Machins_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Sections", t => t.Sections1_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Machins_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Sections1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ConvTools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Section_Id = c.Int(),
                        SectionTo_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Sections1_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Sections", t => t.Sections1_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Sections1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.DataReasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.String(),
                        IdCode = c.Int(nullable: false),
                        Reasons_Id = c.Int(),
                        Reasons_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reasons", t => t.Reasons_Id1)
                .Index(t => t.Reasons_Id1);
            
            CreateTable(
                "dbo.Reasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DateCalls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOld = c.DateTime(nullable: false),
                        DateNext = c.DateTime(nullable: false),
                        purpose = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Pation_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Pations_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pations", t => t.Pations_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Pations_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Diagnosis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        symptoms = c.String(),
                        recommendations = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.DocOthers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        ListOther_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        ListOthers_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ListOthers", t => t.ListOthers_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.ListOthers_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ListOthers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Byte(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(),
                        Reasons = c.String(),
                        VisitNo = c.Byte(nullable: false),
                        VisitIn = c.Byte(nullable: false),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.DocReps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        ListRep_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        ListReps_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ListReps", t => t.ListReps_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.ListReps_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ListReps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        VisitNo = c.Byte(nullable: false),
                        VisitIn = c.Byte(nullable: false),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.GzaEmps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        Gza = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Employee_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Employees_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Employees_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.installments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.Byte(nullable: false),
                        Date = c.DateTime(nullable: false),
                        PurchaseMachin_Id = c.Int(),
                        PurchaseMachins_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseMachins", t => t.PurchaseMachins_Id)
                .Index(t => t.PurchaseMachins_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Data = c.String(),
                        Packagecost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Minprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinOrder = c.Int(nullable: false),
                        Cartoonprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Noofunitsperpackage = c.Int(nullable: false),
                        Noofpackagespercartoon = c.Int(nullable: false),
                        Unitprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Purpose = c.String(),
                        Dose = c.String(),
                        Precautions = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        CatItem_Id = c.Int(),
                        Company_MyProperty = c.Int(),
                        TypeUnit_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        CatItems_Id = c.Int(),
                        Companies_Id = c.Int(),
                        TypeUnits_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatItems", t => t.CatItems_Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.TypeUnits", t => t.TypeUnits_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.CatItems_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.TypeUnits_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.TypeUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemsConvs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanItems_Id = c.Int(),
                        ConvItems_Id = c.Int(),
                        Items_Id = c.Int(),
                        CatQuanItems_Id1 = c.Int(),
                        ConvItems_Id1 = c.Int(),
                        Items_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanItems", t => t.CatQuanItems_Id1)
                .ForeignKey("dbo.ConvItems", t => t.ConvItems_Id1)
                .ForeignKey("dbo.Items", t => t.Items_Id1)
                .Index(t => t.CatQuanItems_Id1)
                .Index(t => t.ConvItems_Id1)
                .Index(t => t.Items_Id1);
            
            CreateTable(
                "dbo.ItemsCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanItems_Id = c.Int(),
                        Course_Id = c.Int(),
                        Items_Id = c.Int(),
                        CatQuanItems_Id1 = c.Int(),
                        Courses_Id = c.Int(),
                        Items_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanItems", t => t.CatQuanItems_Id1)
                .ForeignKey("dbo.Courses", t => t.Courses_Id)
                .ForeignKey("dbo.Items", t => t.Items_Id1)
                .Index(t => t.CatQuanItems_Id1)
                .Index(t => t.Courses_Id)
                .Index(t => t.Items_Id1);
            
            CreateTable(
                "dbo.ItemsDocCusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dose = c.Double(nullable: false),
                        CatQuanItems_Id = c.Int(),
                        DocCust_Id = c.Int(),
                        Items_Id = c.Int(),
                        CatQuanItems_Id1 = c.Int(),
                        DocCusts_Id = c.Int(),
                        Items_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanItems", t => t.CatQuanItems_Id1)
                .ForeignKey("dbo.DocCusts", t => t.DocCusts_Id)
                .ForeignKey("dbo.Items", t => t.Items_Id1)
                .Index(t => t.CatQuanItems_Id1)
                .Index(t => t.DocCusts_Id)
                .Index(t => t.Items_Id1);
            
            CreateTable(
                "dbo.ItemsPurchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanItems_Id = c.Int(),
                        Items_Id = c.Int(),
                        PurchaseItems_Id = c.Int(),
                        CatQuanItems_Id1 = c.Int(),
                        Items_Id1 = c.Int(),
                        PurchaseItems_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanItems", t => t.CatQuanItems_Id1)
                .ForeignKey("dbo.Items", t => t.Items_Id1)
                .ForeignKey("dbo.PurchaseItems", t => t.PurchaseItems_Id1)
                .Index(t => t.CatQuanItems_Id1)
                .Index(t => t.Items_Id1)
                .Index(t => t.PurchaseItems_Id1);
            
            CreateTable(
                "dbo.PurchaseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        RequiredpurchaseItems_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        RequiredpurchaseItems_Id1 = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.RequiredpurchaseItems", t => t.RequiredpurchaseItems_Id1)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.RequiredpurchaseItems_Id1)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.RequiredpurchaseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        Note = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ItemsRequiredpurchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanItems_Id = c.Int(),
                        Diagnosis_Id = c.Int(),
                        Items_Id = c.Int(),
                        CatQuanItems_Id1 = c.Int(),
                        Diagnosis_Id1 = c.Int(),
                        Items_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanItems", t => t.CatQuanItems_Id1)
                .ForeignKey("dbo.Diagnosis", t => t.Diagnosis_Id1)
                .ForeignKey("dbo.Items", t => t.Items_Id1)
                .Index(t => t.CatQuanItems_Id1)
                .Index(t => t.Diagnosis_Id1)
                .Index(t => t.Items_Id1);
            
            CreateTable(
                "dbo.ItemsReturnItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanItems_Id = c.Int(),
                        Items_Id = c.Int(),
                        ReturnItems_Id = c.Int(),
                        CatQuanItems_Id1 = c.Int(),
                        Items_Id1 = c.Int(),
                        ReturnItems_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanItems", t => t.CatQuanItems_Id1)
                .ForeignKey("dbo.Items", t => t.Items_Id1)
                .ForeignKey("dbo.ReturnItems", t => t.ReturnItems_Id1)
                .Index(t => t.CatQuanItems_Id1)
                .Index(t => t.Items_Id1)
                .Index(t => t.ReturnItems_Id1);
            
            CreateTable(
                "dbo.ReturnItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseItems = c.Int(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        AmountReturn = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.MachinCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Course_Id = c.Int(),
                        Machin_Id = c.Int(),
                        Courses_Id = c.Int(),
                        Machins_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Courses_Id)
                .ForeignKey("dbo.Machins", t => t.Machins_Id)
                .Index(t => t.Courses_Id)
                .Index(t => t.Machins_Id);
            
            CreateTable(
                "dbo.MachinDocOthers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocCust_Id = c.Int(),
                        Machin_Id = c.Int(),
                        DocCusts_Id = c.Int(),
                        Machins_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocCusts", t => t.DocCusts_Id)
                .ForeignKey("dbo.Machins", t => t.Machins_Id)
                .Index(t => t.DocCusts_Id)
                .Index(t => t.Machins_Id);
            
            CreateTable(
                "dbo.PurchaseTools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        PaymentMethod_Id = c.Int(),
                        RequiredpurchaseTools_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        PaymentMethods_Id = c.Int(),
                        RequiredpurchaseTools_Id1 = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethods_Id)
                .ForeignKey("dbo.RequiredpurchaseTools", t => t.RequiredpurchaseTools_Id1)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.PaymentMethods_Id)
                .Index(t => t.RequiredpurchaseTools_Id1)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.RequiredpurchaseTools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        warranty = c.String(),
                        Date = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Remedies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Double(nullable: false),
                        CatQuanItems_Id = c.Int(),
                        Diagnosis_Id = c.Int(),
                        Items_Id = c.Int(),
                        CatQuanItems_Id1 = c.Int(),
                        Diagnosis_Id1 = c.Int(),
                        Items_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanItems", t => t.CatQuanItems_Id1)
                .ForeignKey("dbo.Diagnosis", t => t.Diagnosis_Id1)
                .ForeignKey("dbo.Items", t => t.Items_Id1)
                .Index(t => t.CatQuanItems_Id1)
                .Index(t => t.Diagnosis_Id1)
                .Index(t => t.Items_Id1);
            
            CreateTable(
                "dbo.ReturnMachins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseMachin = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Double(nullable: false),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        Machin_Id = c.Int(),
                        SalesRep_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        Machins_Id = c.Int(),
                        SalesReps_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.Machins", t => t.Machins_Id)
                .ForeignKey("dbo.SalesReps", t => t.SalesReps_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.Machins_Id)
                .Index(t => t.SalesReps_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ReturnTools",
                c => new
                    {
                        MyProperty = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        PurchaseTools = c.Int(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        AmountReturn = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.MyProperty)
                .ForeignKey("dbo.Companies", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.SalesReps", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.RoomMachins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Employee_Id = c.Int(),
                        Machin_Id = c.Int(),
                        Room_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Employees_Id = c.Int(),
                        Machins_Id = c.Int(),
                        Rooms_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_Id)
                .ForeignKey("dbo.Machins", t => t.Machins_Id)
                .ForeignKey("dbo.Rooms", t => t.Rooms_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Employees_Id)
                .Index(t => t.Machins_Id)
                .Index(t => t.Rooms_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.SolEmps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Employee_Id = c.Int(),
                        Section_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Employees_Id = c.Int(),
                        Sections_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_Id)
                .ForeignKey("dbo.Sections", t => t.Sections_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Employees_Id)
                .Index(t => t.Sections_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Note = c.String(),
                        Packagecost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cartoonprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unitprice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Noofunitsperpackage = c.Int(nullable: false),
                        Noofpackagespercartoon = c.Int(nullable: false),
                        DateAdd = c.String(),
                        DateUpdate = c.String(),
                        Company_MyProperty = c.Int(),
                        TypeUnit_Id = c.Int(),
                        UserAdd_Id = c.Int(),
                        UserUpdate_Id = c.Int(),
                        Companies_Id = c.Int(),
                        TypeUnits_Id = c.Int(),
                        Users_Id = c.Int(),
                        Users1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .ForeignKey("dbo.TypeUnits", t => t.TypeUnits_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .Index(t => t.Companies_Id)
                .Index(t => t.TypeUnits_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Users1_Id);
            
            CreateTable(
                "dbo.ToolsConvs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanTools_Id = c.Int(),
                        ConvTools_Id = c.Int(),
                        Tools_Id = c.Int(),
                        CatQuanTools_Id1 = c.Int(),
                        ConvTools_Id1 = c.Int(),
                        Tools_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanTools", t => t.CatQuanTools_Id1)
                .ForeignKey("dbo.ConvTools", t => t.ConvTools_Id1)
                .ForeignKey("dbo.Tools", t => t.Tools_Id1)
                .Index(t => t.CatQuanTools_Id1)
                .Index(t => t.ConvTools_Id1)
                .Index(t => t.Tools_Id1);
            
            CreateTable(
                "dbo.ToolsPurchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanTools_Id = c.Int(),
                        PurchaseTools_Id = c.Int(),
                        Tools_Id = c.Int(),
                        CatQuanTools_Id1 = c.Int(),
                        PurchaseTools_Id1 = c.Int(),
                        Tools_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanTools", t => t.CatQuanTools_Id1)
                .ForeignKey("dbo.PurchaseTools", t => t.PurchaseTools_Id1)
                .ForeignKey("dbo.Tools", t => t.Tools_Id1)
                .Index(t => t.CatQuanTools_Id1)
                .Index(t => t.PurchaseTools_Id1)
                .Index(t => t.Tools_Id1);
            
            CreateTable(
                "dbo.ToolsRequiredpurchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanTools_Id = c.Int(),
                        RequiredpurchaseTools_Id = c.Int(),
                        Tools_Id = c.Int(),
                        CatQuanTools_Id1 = c.Int(),
                        RequiredpurchaseTools_Id1 = c.Int(),
                        Tools_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanTools", t => t.CatQuanTools_Id1)
                .ForeignKey("dbo.RequiredpurchaseTools", t => t.RequiredpurchaseTools_Id1)
                .ForeignKey("dbo.Tools", t => t.Tools_Id1)
                .Index(t => t.CatQuanTools_Id1)
                .Index(t => t.RequiredpurchaseTools_Id1)
                .Index(t => t.Tools_Id1);
            
            CreateTable(
                "dbo.ToolsReturnTools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CatQuanTools_Id = c.Int(),
                        ReturnTools_MyProperty = c.Int(),
                        Tools_Id = c.Int(),
                        CatQuanTools_Id1 = c.Int(),
                        ReturnTools_MyProperty1 = c.Int(),
                        Tools_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CatQuanTools", t => t.CatQuanTools_Id1)
                .ForeignKey("dbo.ReturnTools", t => t.ReturnTools_MyProperty1)
                .ForeignKey("dbo.Tools", t => t.Tools_Id1)
                .Index(t => t.CatQuanTools_Id1)
                .Index(t => t.ReturnTools_MyProperty1)
                .Index(t => t.Tools_Id1);
            
            CreateStoredProcedure(
                "dbo.Banks_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Banks]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Banks]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Banks] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Banks_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Banks]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Banks_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Banks]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
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
                    @"INSERT [dbo].[CashCoes]([CodeId], [Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [TypeOPration_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [TypeOPrations_Id], [Users_Id], [Users1_Id])
                      VALUES (@CodeId, @Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @TypeOPration_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @TypeOPrations_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CashCoes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CashCoes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
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
                      SET [CodeId] = @CodeId, [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [TypeOPration_Id] = @TypeOPration_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [TypeOPrations_Id] = @TypeOPrations_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CashCoes_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CashCoes]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([TypeOPrations_Id] = @TypeOPrations_Id) OR ([TypeOPrations_Id] IS NULL AND @TypeOPrations_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        specializations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Companies]([Name], [Address], [TelWhats], [Tel1], [Mob], [taxID], [regID], [products], [DateEnd], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [specializations_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Address, @TelWhats, @Tel1, @Mob, @taxID, @regID, @products, @DateEnd, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @specializations_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Companies]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Companies] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        specializations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Companies]
                      SET [Name] = @Name, [Address] = @Address, [TelWhats] = @TelWhats, [Tel1] = @Tel1, [Mob] = @Mob, [taxID] = @taxID, [regID] = @regID, [products] = @products, [DateEnd] = @DateEnd, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [specializations_Id] = @specializations_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Companies_Delete",
                p => new
                    {
                        Id = p.Int(),
                        specializations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Companies]
                      WHERE (((([Id] = @Id) AND (([specializations_Id] = @specializations_Id) OR ([specializations_Id] IS NULL AND @specializations_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        JobPermation_Id = p.Int(),
                        JobPermations_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Users]([Name], [Pass], [Email], [Tel], [Tel1], [UserAdd], [DateAdd], [UserUpdate], [DateUpdate], [JobPermation_Id], [JobPermations_Id])
                      VALUES (@Name, @Pass, @Email, @Tel, @Tel1, @UserAdd, @DateAdd, @UserUpdate, @DateUpdate, @JobPermation_Id, @JobPermations_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Users]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Users] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        JobPermation_Id = p.Int(),
                        JobPermations_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Users]
                      SET [Name] = @Name, [Pass] = @Pass, [Email] = @Email, [Tel] = @Tel, [Tel1] = @Tel1, [UserAdd] = @UserAdd, [DateAdd] = @DateAdd, [UserUpdate] = @UserUpdate, [DateUpdate] = @DateUpdate, [JobPermation_Id] = @JobPermation_Id, [JobPermations_Id] = @JobPermations_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Users_Delete",
                p => new
                    {
                        Id = p.Int(),
                        JobPermations_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Users]
                      WHERE (([Id] = @Id) AND (([JobPermations_Id] = @JobPermations_Id) OR ([JobPermations_Id] IS NULL AND @JobPermations_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.JobPermations_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[JobPermations]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[JobPermations]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[JobPermations] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.JobPermations_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[JobPermations]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.JobPermations_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[JobPermations]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentMethods_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[PaymentMethods]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PaymentMethods]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PaymentMethods] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentMethods_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[PaymentMethods]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentMethods_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PaymentMethods]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Genders_Id = p.Int(),
                        HowAbouts_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[SalesReps]([Support], [Name], [Address], [TelWhats], [Tel], [Mob], [Email], [blocked], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [Gender_Id], [HowAbout_Id], [Nation_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [Genders_Id], [HowAbouts_Id], [Nations_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Support, @Name, @Address, @TelWhats, @Tel, @Mob, @Email, @blocked, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @Gender_Id, @HowAbout_Id, @Nation_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @Genders_Id, @HowAbouts_Id, @Nations_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[SalesReps]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[SalesReps] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Genders_Id = p.Int(),
                        HowAbouts_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[SalesReps]
                      SET [Support] = @Support, [Name] = @Name, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [blocked] = @blocked, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [Gender_Id] = @Gender_Id, [HowAbout_Id] = @HowAbout_Id, [Nation_Id] = @Nation_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [Genders_Id] = @Genders_Id, [HowAbouts_Id] = @HowAbouts_Id, [Nations_Id] = @Nations_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.SalesReps_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        Genders_Id = p.Int(),
                        HowAbouts_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[SalesReps]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([Genders_Id] = @Genders_Id) OR ([Genders_Id] IS NULL AND @Genders_Id IS NULL))) AND (([HowAbouts_Id] = @HowAbouts_Id) OR ([HowAbouts_Id] IS NULL AND @HowAbouts_Id IS NULL))) AND (([Nations_Id] = @Nations_Id) OR ([Nations_Id] IS NULL AND @Nations_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Genders_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Genders]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Genders]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Genders] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Genders_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Genders]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Genders_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Genders]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.HowAbouts_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[HowAbouts]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[HowAbouts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[HowAbouts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.HowAbouts_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[HowAbouts]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.HowAbouts_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[HowAbouts]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Nations_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Nations]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Nations]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Nations] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Nations_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Nations]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Nations_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Nations]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Sections]([Name], [Address], [Tel], [Tel1], [receptionist], [mob], [Email], [DayJob], [HourJob], [Mark], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Address, @Tel, @Tel1, @receptionist, @mob, @Email, @DayJob, @HourJob, @Mark, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Sections]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Sections] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Sections]
                      SET [Name] = @Name, [Address] = @Address, [Tel] = @Tel, [Tel1] = @Tel1, [receptionist] = @receptionist, [mob] = @mob, [Email] = @Email, [DayJob] = @DayJob, [HourJob] = @HourJob, [Mark] = @Mark, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Sections_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Sections]
                      WHERE ((([Id] = @Id) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.TypeOPrations_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[TypeOPrations]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[TypeOPrations]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[TypeOPrations] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.TypeOPrations_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[TypeOPrations]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.TypeOPrations_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[TypeOPrations]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Car], [Njob], [Name], [Salary], [Address], [TelWhats], [Tel], [Mob], [Email], [Note], [DateAdd], [DateUpdate], [CatJob_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [CatJobs_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Car, @Njob, @Name, @Salary, @Address, @TelWhats, @Tel, @Mob, @Email, @Note, @DateAdd, @DateUpdate, @CatJob_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @CatJobs_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Car] = @Car, [Njob] = @Njob, [Name] = @Name, [Salary] = @Salary, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [CatJob_Id] = @CatJob_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [CatJobs_Id] = @CatJobs_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Employees_Delete",
                p => new
                    {
                        Id = p.Int(),
                        CatJobs_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ((((([Id] = @Id) AND (([CatJobs_Id] = @CatJobs_Id) OR ([CatJobs_Id] IS NULL AND @CatJobs_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.CatJobs_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[CatJobs]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CatJobs]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CatJobs] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.CatJobs_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[CatJobs]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CatJobs_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CatJobs]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Months_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Months]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Months]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Months] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Months_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Months]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Months_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Months]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CashOthers]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Exp_Id], [PaymentMethod_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Exps_Id], [PaymentMethods_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Exp_Id, @PaymentMethod_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Exps_Id, @PaymentMethods_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CashOthers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CashOthers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CashOthers]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Exp_Id] = @Exp_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Exps_Id] = @Exps_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CashOthers_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Exps_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CashOthers]
                      WHERE (((((([Id] = @Id) AND (([Exps_Id] = @Exps_Id) OR ([Exps_Id] IS NULL AND @Exps_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Exps_Insert",
                p => new
                    {
                        Name = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Exps]([Name], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Exps]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Exps] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Exps]
                      SET [Name] = @Name, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Exps_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Exps]
                      WHERE ((([Id] = @Id) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
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
                    @"INSERT [dbo].[CashReturns]([CodeId], [Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [TypeOPration_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [TypeOPrations_Id], [Users_Id], [Users1_Id])
                      VALUES (@CodeId, @Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @TypeOPration_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @TypeOPrations_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CashReturns]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CashReturns] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
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
                    @"UPDATE [dbo].[CashReturns]
                      SET [CodeId] = @CodeId, [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [TypeOPration_Id] = @TypeOPration_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [TypeOPrations_Id] = @TypeOPrations_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CashReturns_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        TypeOPrations_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CashReturns]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([TypeOPrations_Id] = @TypeOPrations_Id) OR ([TypeOPrations_Id] IS NULL AND @TypeOPrations_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.CatItems_Insert",
                p => new
                    {
                        Name = p.String(),
                        description = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[CatItems]([Name], [description], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @description, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CatItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CatItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[CatItems]
                      SET [Name] = @Name, [description] = @description, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CatItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CatItems]
                      WHERE ((([Id] = @Id) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.CatQuanItems_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[CatQuanItems]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CatQuanItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CatQuanItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.CatQuanItems_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[CatQuanItems]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CatQuanItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CatQuanItems]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CatQuanTools_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[CatQuanTools]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[CatQuanTools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[CatQuanTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.CatQuanTools_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[CatQuanTools]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.CatQuanTools_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[CatQuanTools]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Courses_Id = p.Int(),
                        ListCusts_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Rooms_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[DocCusts]([purpose], [DiagnosisOld], [DateOld], [PreviousBalance], [Date], [RequiredForToday], [total], [Note], [Diagnosis], [Payed], [Precautions], [PriceCurse], [PriceIn], [PriceOld], [PriceAll], [Price], [Discount], [NextDate], [DateAdd], [DateUpdate], [Course_Id], [ListCust_Id], [Pation_Id], [PaymentMethod_Id], [Room_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Courses_Id], [ListCusts_Id], [Pations_Id], [PaymentMethods_Id], [Rooms_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@purpose, @DiagnosisOld, @DateOld, @PreviousBalance, @Date, @RequiredForToday, @total, @Note, @Diagnosis, @Payed, @Precautions, @PriceCurse, @PriceIn, @PriceOld, @PriceAll, @Price, @Discount, @NextDate, @DateAdd, @DateUpdate, @Course_Id, @ListCust_Id, @Pation_Id, @PaymentMethod_Id, @Room_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Courses_Id, @ListCusts_Id, @Pations_Id, @PaymentMethods_Id, @Rooms_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[DocCusts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[DocCusts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Courses_Id = p.Int(),
                        ListCusts_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Rooms_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[DocCusts]
                      SET [purpose] = @purpose, [DiagnosisOld] = @DiagnosisOld, [DateOld] = @DateOld, [PreviousBalance] = @PreviousBalance, [Date] = @Date, [RequiredForToday] = @RequiredForToday, [total] = @total, [Note] = @Note, [Diagnosis] = @Diagnosis, [Payed] = @Payed, [Precautions] = @Precautions, [PriceCurse] = @PriceCurse, [PriceIn] = @PriceIn, [PriceOld] = @PriceOld, [PriceAll] = @PriceAll, [Price] = @Price, [Discount] = @Discount, [NextDate] = @NextDate, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Course_Id] = @Course_Id, [ListCust_Id] = @ListCust_Id, [Pation_Id] = @Pation_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Room_Id] = @Room_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Courses_Id] = @Courses_Id, [ListCusts_Id] = @ListCusts_Id, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Rooms_Id] = @Rooms_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[DocCusts]
                      WHERE ((((((((([Id] = @Id) AND (([Courses_Id] = @Courses_Id) OR ([Courses_Id] IS NULL AND @Courses_Id IS NULL))) AND (([ListCusts_Id] = @ListCusts_Id) OR ([ListCusts_Id] IS NULL AND @ListCusts_Id IS NULL))) AND (([Pations_Id] = @Pations_Id) OR ([Pations_Id] IS NULL AND @Pations_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Rooms_Id] = @Rooms_Id) OR ([Rooms_Id] IS NULL AND @Rooms_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Courses]([Name], [NoOfVisits], [Schedule], [Price], [Discount], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @NoOfVisits, @Schedule, @Price, @Discount, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Courses]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Courses] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Courses]
                      SET [Name] = @Name, [NoOfVisits] = @NoOfVisits, [Schedule] = @Schedule, [Price] = @Price, [Discount] = @Discount, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Courses_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Courses]
                      WHERE ((([Id] = @Id) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListCusts]([Type], [Date], [purpose], [PreviousBalance], [Discount], [RequiredForToday], [total], [payed], [Note], [Balance], [VisitNo], [VisitIn], [DateAdd], [DateUpdate], [Pation_Id], [PaymentMethod_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Pations_Id], [PaymentMethods_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Type, @Date, @purpose, @PreviousBalance, @Discount, @RequiredForToday, @total, @payed, @Note, @Balance, @VisitNo, @VisitIn, @DateAdd, @DateUpdate, @Pation_Id, @PaymentMethod_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Pations_Id, @PaymentMethods_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ListCusts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ListCusts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListCusts]
                      SET [Type] = @Type, [Date] = @Date, [purpose] = @purpose, [PreviousBalance] = @PreviousBalance, [Discount] = @Discount, [RequiredForToday] = @RequiredForToday, [total] = @total, [payed] = @payed, [Note] = @Note, [Balance] = @Balance, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Pation_Id] = @Pation_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ListCusts_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ListCusts]
                      WHERE (((((([Id] = @Id) AND (([Pations_Id] = @Pations_Id) OR ([Pations_Id] IS NULL AND @Pations_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Pationjobs_Id = p.Int(),
                        Prices_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Pations]([Name], [Age], [Address], [TelWhats], [Tel], [Mob], [Email], [Note], [DateAdd], [DateUpdate], [Gender_Id], [HowAbout_Id], [Nation_Id], [Pationjob_Id], [Price_Id], [UserAdd_Id], [UserUpdate_Id], [Nations_Id], [Pationjobs_Id], [Prices_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Age, @Address, @TelWhats, @Tel, @Mob, @Email, @Note, @DateAdd, @DateUpdate, @Gender_Id, @HowAbout_Id, @Nation_Id, @Pationjob_Id, @Price_Id, @UserAdd_Id, @UserUpdate_Id, @Nations_Id, @Pationjobs_Id, @Prices_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Pations]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Pations] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Nations_Id = p.Int(),
                        Pationjobs_Id = p.Int(),
                        Prices_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Pations]
                      SET [Name] = @Name, [Age] = @Age, [Address] = @Address, [TelWhats] = @TelWhats, [Tel] = @Tel, [Mob] = @Mob, [Email] = @Email, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Gender_Id] = @Gender_Id, [HowAbout_Id] = @HowAbout_Id, [Nation_Id] = @Nation_Id, [Pationjob_Id] = @Pationjob_Id, [Price_Id] = @Price_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Nations_Id] = @Nations_Id, [Pationjobs_Id] = @Pationjobs_Id, [Prices_Id] = @Prices_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Pations_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Nations_Id = p.Int(),
                        Pationjobs_Id = p.Int(),
                        Prices_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Pations]
                      WHERE (((((([Id] = @Id) AND (([Nations_Id] = @Nations_Id) OR ([Nations_Id] IS NULL AND @Nations_Id IS NULL))) AND (([Pationjobs_Id] = @Pationjobs_Id) OR ([Pationjobs_Id] IS NULL AND @Pationjobs_Id IS NULL))) AND (([Prices_Id] = @Prices_Id) OR ([Prices_Id] IS NULL AND @Prices_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Pationjobs_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Pationjobs]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Pationjobs]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Pationjobs] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Pationjobs_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Pationjobs]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Pationjobs_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Pationjobs]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Prices]([Name], [Price1], [Price2], [Price3], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Price1, @Price2, @Price3, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Prices]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Prices] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Prices]
                      SET [Name] = @Name, [Price1] = @Price1, [Price2] = @Price2, [Price3] = @Price3, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Prices_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Prices]
                      WHERE ((([Id] = @Id) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Rooms_Insert",
                p => new
                    {
                        Name = p.String(),
                        Note = p.String(),
                        DateAdd = p.String(),
                        DateUpdate = p.String(),
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Rooms]([Name], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Rooms]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Rooms] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Rooms]
                      SET [Name] = @Name, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Rooms_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Rooms]
                      WHERE ((([Id] = @Id) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[MonthCoes]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[MonthCoes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[MonthCoes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[MonthCoes]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.MonthCoes_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[MonthCoes]
                      WHERE ((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[MonthCusts]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Pation_Id], [PaymentMethod_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Pations_Id], [PaymentMethods_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Pation_Id, @PaymentMethod_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Pations_Id, @PaymentMethods_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[MonthCusts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[MonthCusts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[MonthCusts]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Pation_Id] = @Pation_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Pations_Id] = @Pations_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.MonthCusts_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Pations_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[MonthCusts]
                      WHERE (((((([Id] = @Id) AND (([Pations_Id] = @Pations_Id) OR ([Pations_Id] IS NULL AND @Pations_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        PurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[MonthMachinCoes]([Date], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [PurchaseMachin_Id], [SalesRep_Id], [Section_Id], [UserAdd_Id], [Companies_Id], [PaymentMethods_Id], [PurchaseMachins_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @PurchaseMachin_Id, @SalesRep_Id, @Section_Id, @UserAdd_Id, @Companies_Id, @PaymentMethods_Id, @PurchaseMachins_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[MonthMachinCoes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[MonthMachinCoes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        PurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[MonthMachinCoes]
                      SET [Date] = @Date, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [PurchaseMachin_Id] = @PurchaseMachin_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [PurchaseMachins_Id] = @PurchaseMachins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.MonthMachinCoes_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        PurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[MonthMachinCoes]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([PurchaseMachins_Id] = @PurchaseMachins_Id) OR ([PurchaseMachins_Id] IS NULL AND @PurchaseMachins_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[PurchaseMachins]([Cost], [warranty], [amount], [Price], [Note], [Image], [Date], [discount], [DateAdd], [DateUpdate], [Company_MyProperty], [Machin_Id], [PaymentMethod_Id], [RequiredpurchaseMachin_Id], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [Machins_Id], [PaymentMethods_Id], [RequiredpurchaseMachins_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Cost, @warranty, @amount, @Price, @Note, @Image, @Date, @discount, @DateAdd, @DateUpdate, @Company_MyProperty, @Machin_Id, @PaymentMethod_Id, @RequiredpurchaseMachin_Id, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @Machins_Id, @PaymentMethods_Id, @RequiredpurchaseMachins_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PurchaseMachins]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PurchaseMachins] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseMachins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[PurchaseMachins]
                      SET [Cost] = @Cost, [warranty] = @warranty, [amount] = @amount, [Price] = @Price, [Note] = @Note, [Image] = @Image, [Date] = @Date, [discount] = @discount, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [Machin_Id] = @Machin_Id, [PaymentMethod_Id] = @PaymentMethod_Id, [RequiredpurchaseMachin_Id] = @RequiredpurchaseMachin_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [Machins_Id] = @Machins_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseMachins_Id] = @RequiredpurchaseMachins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PurchaseMachins]
                      WHERE ((((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([Machins_Id] = @Machins_Id) OR ([Machins_Id] IS NULL AND @Machins_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseMachins_Id] = @RequiredpurchaseMachins_Id) OR ([RequiredpurchaseMachins_Id] IS NULL AND @RequiredpurchaseMachins_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Machins]([Name], [Note], [ChekMachin], [applications], [DateAdd], [DateUpdate], [Company_MyProperty], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Note, @ChekMachin, @applications, @DateAdd, @DateUpdate, @Company_MyProperty, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Machins]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Machins] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Machins]
                      SET [Name] = @Name, [Note] = @Note, [ChekMachin] = @ChekMachin, [applications] = @applications, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Machins_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Machins]
                      WHERE (((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[RequiredpurchaseMachins]([Date], [Price], [warranty], [DateEnd], [Support], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [Machin_Id], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [Machins_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @Price, @warranty, @DateEnd, @Support, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @Machin_Id, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @Machins_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[RequiredpurchaseMachins]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[RequiredpurchaseMachins] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseMachins]
                      SET [Date] = @Date, [Price] = @Price, [warranty] = @warranty, [DateEnd] = @DateEnd, [Support] = @Support, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [Machin_Id] = @Machin_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [Machins_Id] = @Machins_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.RequiredpurchaseMachins_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        Machins_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[RequiredpurchaseMachins]
                      WHERE ((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([Machins_Id] = @Machins_Id) OR ([Machins_Id] IS NULL AND @Machins_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ConvItems]([Price], [Date], [Note], [DateAdd], [DateUpdate], [Section_Id], [SectionTo_Id], [UserAdd_Id], [UserUpdate_Id], [Sections_Id], [Sections1_Id], [Users_Id], [Users1_Id])
                      VALUES (@Price, @Date, @Note, @DateAdd, @DateUpdate, @Section_Id, @SectionTo_Id, @UserAdd_Id, @UserUpdate_Id, @Sections_Id, @Sections1_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ConvItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ConvItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ConvItems]
                      SET [Price] = @Price, [Date] = @Date, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Section_Id] = @Section_Id, [SectionTo_Id] = @SectionTo_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Sections_Id] = @Sections_Id, [Sections1_Id] = @Sections1_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ConvItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ConvItems]
                      WHERE ((((([Id] = @Id) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Sections1_Id] = @Sections1_Id) OR ([Sections1_Id] IS NULL AND @Sections1_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ConvTools]([Price], [Date], [Note], [DateAdd], [DateUpdate], [Section_Id], [SectionTo_Id], [UserAdd_Id], [UserUpdate_Id], [Sections_Id], [Sections1_Id], [Users_Id], [Users1_Id])
                      VALUES (@Price, @Date, @Note, @DateAdd, @DateUpdate, @Section_Id, @SectionTo_Id, @UserAdd_Id, @UserUpdate_Id, @Sections_Id, @Sections1_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ConvTools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ConvTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ConvTools]
                      SET [Price] = @Price, [Date] = @Date, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Section_Id] = @Section_Id, [SectionTo_Id] = @SectionTo_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Sections_Id] = @Sections_Id, [Sections1_Id] = @Sections1_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ConvTools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Sections_Id = p.Int(),
                        Sections1_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ConvTools]
                      WHERE ((((([Id] = @Id) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Sections1_Id] = @Sections1_Id) OR ([Sections1_Id] IS NULL AND @Sections1_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Reasons_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Reasons]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Reasons]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Reasons] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Reasons_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Reasons]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Reasons_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Reasons]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Diagnosis]([Name], [symptoms], [recommendations], [Note], [DateAdd], [DateUpdate], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @symptoms, @recommendations, @Note, @DateAdd, @DateUpdate, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Diagnosis]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Diagnosis] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Diagnosis]
                      SET [Name] = @Name, [symptoms] = @symptoms, [recommendations] = @recommendations, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Diagnosis_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Diagnosis]
                      WHERE ((([Id] = @Id) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListOthers]([Type], [Date], [Name], [Reasons], [VisitNo], [VisitIn], [Note], [DateAdd], [DateUpdate], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Type, @Date, @Name, @Reasons, @VisitNo, @VisitIn, @Note, @DateAdd, @DateUpdate, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ListOthers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ListOthers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListOthers]
                      SET [Type] = @Type, [Date] = @Date, [Name] = @Name, [Reasons] = @Reasons, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ListOthers_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ListOthers]
                      WHERE (((([Id] = @Id) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ListReps]([Type], [Date], [VisitNo], [VisitIn], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [PaymentMethods_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Type, @Date, @VisitNo, @VisitIn, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @PaymentMethods_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ListReps]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ListReps] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ListReps]
                      SET [Type] = @Type, [Date] = @Date, [VisitNo] = @VisitNo, [VisitIn] = @VisitIn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ListReps_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ListReps]
                      WHERE ((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Items]([Name], [Data], [Packagecost], [Minprice], [MinOrder], [Cartoonprice], [Noofunitsperpackage], [Noofpackagespercartoon], [Unitprice], [Purpose], [Dose], [Precautions], [DateAdd], [DateUpdate], [CatItem_Id], [Company_MyProperty], [TypeUnit_Id], [UserAdd_Id], [UserUpdate_Id], [CatItems_Id], [Companies_Id], [TypeUnits_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Data, @Packagecost, @Minprice, @MinOrder, @Cartoonprice, @Noofunitsperpackage, @Noofpackagespercartoon, @Unitprice, @Purpose, @Dose, @Precautions, @DateAdd, @DateUpdate, @CatItem_Id, @Company_MyProperty, @TypeUnit_Id, @UserAdd_Id, @UserUpdate_Id, @CatItems_Id, @Companies_Id, @TypeUnits_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Items]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Items] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Items]
                      SET [Name] = @Name, [Data] = @Data, [Packagecost] = @Packagecost, [Minprice] = @Minprice, [MinOrder] = @MinOrder, [Cartoonprice] = @Cartoonprice, [Noofunitsperpackage] = @Noofunitsperpackage, [Noofpackagespercartoon] = @Noofpackagespercartoon, [Unitprice] = @Unitprice, [Purpose] = @Purpose, [Dose] = @Dose, [Precautions] = @Precautions, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [CatItem_Id] = @CatItem_Id, [Company_MyProperty] = @Company_MyProperty, [TypeUnit_Id] = @TypeUnit_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [CatItems_Id] = @CatItems_Id, [Companies_Id] = @Companies_Id, [TypeUnits_Id] = @TypeUnits_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Items_Delete",
                p => new
                    {
                        Id = p.Int(),
                        CatItems_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Items]
                      WHERE (((((([Id] = @Id) AND (([CatItems_Id] = @CatItems_Id) OR ([CatItems_Id] IS NULL AND @CatItems_Id IS NULL))) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([TypeUnits_Id] = @TypeUnits_Id) OR ([TypeUnits_Id] IS NULL AND @TypeUnits_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.TypeUnits_Insert",
                p => new
                    {
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[TypeUnits]([Name])
                      VALUES (@Name)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[TypeUnits]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[TypeUnits] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.TypeUnits_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[TypeUnits]
                      SET [Name] = @Name
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.TypeUnits_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[TypeUnits]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseItems_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[PurchaseItems]([Date], [discount], [Price], [Note], [amount], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [RequiredpurchaseItems_Id], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [PaymentMethods_Id], [RequiredpurchaseItems_Id1], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @discount, @Price, @Note, @amount, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @RequiredpurchaseItems_Id, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @PaymentMethods_Id, @RequiredpurchaseItems_Id1, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PurchaseItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PurchaseItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseItems_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[PurchaseItems]
                      SET [Date] = @Date, [discount] = @discount, [Price] = @Price, [Note] = @Note, [amount] = @amount, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [RequiredpurchaseItems_Id] = @RequiredpurchaseItems_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseItems_Id1] = @RequiredpurchaseItems_Id1, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.PurchaseItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseItems_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PurchaseItems]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseItems_Id1] = @RequiredpurchaseItems_Id1) OR ([RequiredpurchaseItems_Id1] IS NULL AND @RequiredpurchaseItems_Id1 IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[RequiredpurchaseItems]([Date], [DateEnd], [Note], [Price], [DateAdd], [DateUpdate], [Company_MyProperty], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @DateEnd, @Note, @Price, @DateAdd, @DateUpdate, @Company_MyProperty, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[RequiredpurchaseItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[RequiredpurchaseItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseItems]
                      SET [Date] = @Date, [DateEnd] = @DateEnd, [Note] = @Note, [Price] = @Price, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.RequiredpurchaseItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[RequiredpurchaseItems]
                      WHERE (((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ReturnItems]([PurchaseItems], [Discount], [Amount], [Price], [Date], [AmountReturn], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@PurchaseItems, @Discount, @Amount, @Price, @Date, @AmountReturn, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[ReturnItems]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ReturnItems] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ReturnItems]
                      SET [PurchaseItems] = @PurchaseItems, [Discount] = @Discount, [Amount] = @Amount, [Price] = @Price, [Date] = @Date, [AmountReturn] = @AmountReturn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ReturnItems_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ReturnItems]
                      WHERE (((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseTools_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[PurchaseTools]([Date], [discount], [amount], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [PaymentMethod_Id], [RequiredpurchaseTools_Id], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [PaymentMethods_Id], [RequiredpurchaseTools_Id1], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@Date, @discount, @amount, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @PaymentMethod_Id, @RequiredpurchaseTools_Id, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @PaymentMethods_Id, @RequiredpurchaseTools_Id1, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PurchaseTools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[PurchaseTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseTools_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[PurchaseTools]
                      SET [Date] = @Date, [discount] = @discount, [amount] = @amount, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [PaymentMethod_Id] = @PaymentMethod_Id, [RequiredpurchaseTools_Id] = @RequiredpurchaseTools_Id, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [PaymentMethods_Id] = @PaymentMethods_Id, [RequiredpurchaseTools_Id1] = @RequiredpurchaseTools_Id1, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.PurchaseTools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        PaymentMethods_Id = p.Int(),
                        RequiredpurchaseTools_Id1 = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PurchaseTools]
                      WHERE (((((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([PaymentMethods_Id] = @PaymentMethods_Id) OR ([PaymentMethods_Id] IS NULL AND @PaymentMethods_Id IS NULL))) AND (([RequiredpurchaseTools_Id1] = @RequiredpurchaseTools_Id1) OR ([RequiredpurchaseTools_Id1] IS NULL AND @RequiredpurchaseTools_Id1 IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[RequiredpurchaseTools]([warranty], [Date], [DateEnd], [Price], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [SalesRep_Id], [Section_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [SalesReps_Id], [Sections_Id], [Users_Id], [Users1_Id])
                      VALUES (@warranty, @Date, @DateEnd, @Price, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @SalesRep_Id, @Section_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @SalesReps_Id, @Sections_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[RequiredpurchaseTools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[RequiredpurchaseTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[RequiredpurchaseTools]
                      SET [warranty] = @warranty, [Date] = @Date, [DateEnd] = @DateEnd, [Price] = @Price, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [SalesRep_Id] = @SalesRep_Id, [Section_Id] = @Section_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [SalesReps_Id] = @SalesReps_Id, [Sections_Id] = @Sections_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.RequiredpurchaseTools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        SalesReps_Id = p.Int(),
                        Sections_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[RequiredpurchaseTools]
                      WHERE (((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([SalesReps_Id] = @SalesReps_Id) OR ([SalesReps_Id] IS NULL AND @SalesReps_Id IS NULL))) AND (([Sections_Id] = @Sections_Id) OR ([Sections_Id] IS NULL AND @Sections_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ReturnTools]([Id], [PurchaseTools], [Discount], [Amount], [Price], [Date], [AmountReturn], [Note], [DateAdd], [DateUpdate], [Company_MyProperty], [UserAdd_Id], [UserUpdate_Id], [Users_Id], [Users1_Id])
                      VALUES (@Id, @PurchaseTools, @Discount, @Amount, @Price, @Date, @AmountReturn, @Note, @DateAdd, @DateUpdate, @Company_MyProperty, @UserAdd_Id, @UserUpdate_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @MyProperty int
                      SELECT @MyProperty = [MyProperty]
                      FROM [dbo].[ReturnTools]
                      WHERE @@ROWCOUNT > 0 AND [MyProperty] = scope_identity()
                      
                      SELECT t0.[MyProperty]
                      FROM [dbo].[ReturnTools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[MyProperty] = @MyProperty"
            );
            
            CreateStoredProcedure(
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
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ReturnTools]
                      SET [Id] = @Id, [PurchaseTools] = @PurchaseTools, [Discount] = @Discount, [Amount] = @Amount, [Price] = @Price, [Date] = @Date, [AmountReturn] = @AmountReturn, [Note] = @Note, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([MyProperty] = @MyProperty)"
            );
            
            CreateStoredProcedure(
                "dbo.ReturnTools_Delete",
                p => new
                    {
                        MyProperty = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ReturnTools]
                      WHERE ((([MyProperty] = @MyProperty) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Tools]([Name], [Note], [Packagecost], [Cartoonprice], [Unitprice], [Noofunitsperpackage], [Noofpackagespercartoon], [DateAdd], [DateUpdate], [Company_MyProperty], [TypeUnit_Id], [UserAdd_Id], [UserUpdate_Id], [Companies_Id], [TypeUnits_Id], [Users_Id], [Users1_Id])
                      VALUES (@Name, @Note, @Packagecost, @Cartoonprice, @Unitprice, @Noofunitsperpackage, @Noofpackagespercartoon, @DateAdd, @DateUpdate, @Company_MyProperty, @TypeUnit_Id, @UserAdd_Id, @UserUpdate_Id, @Companies_Id, @TypeUnits_Id, @Users_Id, @Users1_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Tools]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Tools] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        UserAdd_Id = p.Int(),
                        UserUpdate_Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Tools]
                      SET [Name] = @Name, [Note] = @Note, [Packagecost] = @Packagecost, [Cartoonprice] = @Cartoonprice, [Unitprice] = @Unitprice, [Noofunitsperpackage] = @Noofunitsperpackage, [Noofpackagespercartoon] = @Noofpackagespercartoon, [DateAdd] = @DateAdd, [DateUpdate] = @DateUpdate, [Company_MyProperty] = @Company_MyProperty, [TypeUnit_Id] = @TypeUnit_Id, [UserAdd_Id] = @UserAdd_Id, [UserUpdate_Id] = @UserUpdate_Id, [Companies_Id] = @Companies_Id, [TypeUnits_Id] = @TypeUnits_Id, [Users_Id] = @Users_Id, [Users1_Id] = @Users1_Id
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Tools_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Companies_Id = p.Int(),
                        TypeUnits_Id = p.Int(),
                        Users_Id = p.Int(),
                        Users1_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Tools]
                      WHERE ((((([Id] = @Id) AND (([Companies_Id] = @Companies_Id) OR ([Companies_Id] IS NULL AND @Companies_Id IS NULL))) AND (([TypeUnits_Id] = @TypeUnits_Id) OR ([TypeUnits_Id] IS NULL AND @TypeUnits_Id IS NULL))) AND (([Users_Id] = @Users_Id) OR ([Users_Id] IS NULL AND @Users_Id IS NULL))) AND (([Users1_Id] = @Users1_Id) OR ([Users1_Id] IS NULL AND @Users1_Id IS NULL)))"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Tools_Delete");
            DropStoredProcedure("dbo.Tools_Update");
            DropStoredProcedure("dbo.Tools_Insert");
            DropStoredProcedure("dbo.ReturnTools_Delete");
            DropStoredProcedure("dbo.ReturnTools_Update");
            DropStoredProcedure("dbo.ReturnTools_Insert");
            DropStoredProcedure("dbo.RequiredpurchaseTools_Delete");
            DropStoredProcedure("dbo.RequiredpurchaseTools_Update");
            DropStoredProcedure("dbo.RequiredpurchaseTools_Insert");
            DropStoredProcedure("dbo.PurchaseTools_Delete");
            DropStoredProcedure("dbo.PurchaseTools_Update");
            DropStoredProcedure("dbo.PurchaseTools_Insert");
            DropStoredProcedure("dbo.ReturnItems_Delete");
            DropStoredProcedure("dbo.ReturnItems_Update");
            DropStoredProcedure("dbo.ReturnItems_Insert");
            DropStoredProcedure("dbo.RequiredpurchaseItems_Delete");
            DropStoredProcedure("dbo.RequiredpurchaseItems_Update");
            DropStoredProcedure("dbo.RequiredpurchaseItems_Insert");
            DropStoredProcedure("dbo.PurchaseItems_Delete");
            DropStoredProcedure("dbo.PurchaseItems_Update");
            DropStoredProcedure("dbo.PurchaseItems_Insert");
            DropStoredProcedure("dbo.TypeUnits_Delete");
            DropStoredProcedure("dbo.TypeUnits_Update");
            DropStoredProcedure("dbo.TypeUnits_Insert");
            DropStoredProcedure("dbo.Items_Delete");
            DropStoredProcedure("dbo.Items_Update");
            DropStoredProcedure("dbo.Items_Insert");
            DropStoredProcedure("dbo.ListReps_Delete");
            DropStoredProcedure("dbo.ListReps_Update");
            DropStoredProcedure("dbo.ListReps_Insert");
            DropStoredProcedure("dbo.ListOthers_Delete");
            DropStoredProcedure("dbo.ListOthers_Update");
            DropStoredProcedure("dbo.ListOthers_Insert");
            DropStoredProcedure("dbo.Diagnosis_Delete");
            DropStoredProcedure("dbo.Diagnosis_Update");
            DropStoredProcedure("dbo.Diagnosis_Insert");
            DropStoredProcedure("dbo.Reasons_Delete");
            DropStoredProcedure("dbo.Reasons_Update");
            DropStoredProcedure("dbo.Reasons_Insert");
            DropStoredProcedure("dbo.ConvTools_Delete");
            DropStoredProcedure("dbo.ConvTools_Update");
            DropStoredProcedure("dbo.ConvTools_Insert");
            DropStoredProcedure("dbo.ConvItems_Delete");
            DropStoredProcedure("dbo.ConvItems_Update");
            DropStoredProcedure("dbo.ConvItems_Insert");
            DropStoredProcedure("dbo.RequiredpurchaseMachins_Delete");
            DropStoredProcedure("dbo.RequiredpurchaseMachins_Update");
            DropStoredProcedure("dbo.RequiredpurchaseMachins_Insert");
            DropStoredProcedure("dbo.Machins_Delete");
            DropStoredProcedure("dbo.Machins_Update");
            DropStoredProcedure("dbo.Machins_Insert");
            DropStoredProcedure("dbo.PurchaseMachins_Delete");
            DropStoredProcedure("dbo.PurchaseMachins_Update");
            DropStoredProcedure("dbo.PurchaseMachins_Insert");
            DropStoredProcedure("dbo.MonthMachinCoes_Delete");
            DropStoredProcedure("dbo.MonthMachinCoes_Update");
            DropStoredProcedure("dbo.MonthMachinCoes_Insert");
            DropStoredProcedure("dbo.MonthCusts_Delete");
            DropStoredProcedure("dbo.MonthCusts_Update");
            DropStoredProcedure("dbo.MonthCusts_Insert");
            DropStoredProcedure("dbo.MonthCoes_Delete");
            DropStoredProcedure("dbo.MonthCoes_Update");
            DropStoredProcedure("dbo.MonthCoes_Insert");
            DropStoredProcedure("dbo.Rooms_Delete");
            DropStoredProcedure("dbo.Rooms_Update");
            DropStoredProcedure("dbo.Rooms_Insert");
            DropStoredProcedure("dbo.Prices_Delete");
            DropStoredProcedure("dbo.Prices_Update");
            DropStoredProcedure("dbo.Prices_Insert");
            DropStoredProcedure("dbo.Pationjobs_Delete");
            DropStoredProcedure("dbo.Pationjobs_Update");
            DropStoredProcedure("dbo.Pationjobs_Insert");
            DropStoredProcedure("dbo.Pations_Delete");
            DropStoredProcedure("dbo.Pations_Update");
            DropStoredProcedure("dbo.Pations_Insert");
            DropStoredProcedure("dbo.ListCusts_Delete");
            DropStoredProcedure("dbo.ListCusts_Update");
            DropStoredProcedure("dbo.ListCusts_Insert");
            DropStoredProcedure("dbo.Courses_Delete");
            DropStoredProcedure("dbo.Courses_Update");
            DropStoredProcedure("dbo.Courses_Insert");
            DropStoredProcedure("dbo.DocCusts_Delete");
            DropStoredProcedure("dbo.DocCusts_Update");
            DropStoredProcedure("dbo.DocCusts_Insert");
            DropStoredProcedure("dbo.CatQuanTools_Delete");
            DropStoredProcedure("dbo.CatQuanTools_Update");
            DropStoredProcedure("dbo.CatQuanTools_Insert");
            DropStoredProcedure("dbo.CatQuanItems_Delete");
            DropStoredProcedure("dbo.CatQuanItems_Update");
            DropStoredProcedure("dbo.CatQuanItems_Insert");
            DropStoredProcedure("dbo.CatItems_Delete");
            DropStoredProcedure("dbo.CatItems_Update");
            DropStoredProcedure("dbo.CatItems_Insert");
            DropStoredProcedure("dbo.CashReturns_Delete");
            DropStoredProcedure("dbo.CashReturns_Update");
            DropStoredProcedure("dbo.CashReturns_Insert");
            DropStoredProcedure("dbo.Exps_Delete");
            DropStoredProcedure("dbo.Exps_Update");
            DropStoredProcedure("dbo.Exps_Insert");
            DropStoredProcedure("dbo.CashOthers_Delete");
            DropStoredProcedure("dbo.CashOthers_Update");
            DropStoredProcedure("dbo.CashOthers_Insert");
            DropStoredProcedure("dbo.Months_Delete");
            DropStoredProcedure("dbo.Months_Update");
            DropStoredProcedure("dbo.Months_Insert");
            DropStoredProcedure("dbo.CatJobs_Delete");
            DropStoredProcedure("dbo.CatJobs_Update");
            DropStoredProcedure("dbo.CatJobs_Insert");
            DropStoredProcedure("dbo.Employees_Delete");
            DropStoredProcedure("dbo.Employees_Update");
            DropStoredProcedure("dbo.Employees_Insert");
            DropStoredProcedure("dbo.TypeOPrations_Delete");
            DropStoredProcedure("dbo.TypeOPrations_Update");
            DropStoredProcedure("dbo.TypeOPrations_Insert");
            DropStoredProcedure("dbo.Sections_Delete");
            DropStoredProcedure("dbo.Sections_Update");
            DropStoredProcedure("dbo.Sections_Insert");
            DropStoredProcedure("dbo.Nations_Delete");
            DropStoredProcedure("dbo.Nations_Update");
            DropStoredProcedure("dbo.Nations_Insert");
            DropStoredProcedure("dbo.HowAbouts_Delete");
            DropStoredProcedure("dbo.HowAbouts_Update");
            DropStoredProcedure("dbo.HowAbouts_Insert");
            DropStoredProcedure("dbo.Genders_Delete");
            DropStoredProcedure("dbo.Genders_Update");
            DropStoredProcedure("dbo.Genders_Insert");
            DropStoredProcedure("dbo.SalesReps_Delete");
            DropStoredProcedure("dbo.SalesReps_Update");
            DropStoredProcedure("dbo.SalesReps_Insert");
            DropStoredProcedure("dbo.PaymentMethods_Delete");
            DropStoredProcedure("dbo.PaymentMethods_Update");
            DropStoredProcedure("dbo.PaymentMethods_Insert");
            DropStoredProcedure("dbo.JobPermations_Delete");
            DropStoredProcedure("dbo.JobPermations_Update");
            DropStoredProcedure("dbo.JobPermations_Insert");
            DropStoredProcedure("dbo.Users_Delete");
            DropStoredProcedure("dbo.Users_Update");
            DropStoredProcedure("dbo.Users_Insert");
            DropStoredProcedure("dbo.Companies_Delete");
            DropStoredProcedure("dbo.Companies_Update");
            DropStoredProcedure("dbo.Companies_Insert");
            DropStoredProcedure("dbo.CashCoes_Delete");
            DropStoredProcedure("dbo.CashCoes_Update");
            DropStoredProcedure("dbo.CashCoes_Insert");
            DropStoredProcedure("dbo.Banks_Delete");
            DropStoredProcedure("dbo.Banks_Update");
            DropStoredProcedure("dbo.Banks_Insert");
            DropForeignKey("dbo.ToolsReturnTools", "Tools_Id1", "dbo.Tools");
            DropForeignKey("dbo.ToolsReturnTools", "ReturnTools_MyProperty1", "dbo.ReturnTools");
            DropForeignKey("dbo.ToolsReturnTools", "CatQuanTools_Id1", "dbo.CatQuanTools");
            DropForeignKey("dbo.ToolsRequiredpurchases", "Tools_Id1", "dbo.Tools");
            DropForeignKey("dbo.ToolsRequiredpurchases", "RequiredpurchaseTools_Id1", "dbo.RequiredpurchaseTools");
            DropForeignKey("dbo.ToolsRequiredpurchases", "CatQuanTools_Id1", "dbo.CatQuanTools");
            DropForeignKey("dbo.ToolsPurchases", "Tools_Id1", "dbo.Tools");
            DropForeignKey("dbo.ToolsPurchases", "PurchaseTools_Id1", "dbo.PurchaseTools");
            DropForeignKey("dbo.ToolsPurchases", "CatQuanTools_Id1", "dbo.CatQuanTools");
            DropForeignKey("dbo.ToolsConvs", "Tools_Id1", "dbo.Tools");
            DropForeignKey("dbo.ToolsConvs", "ConvTools_Id1", "dbo.ConvTools");
            DropForeignKey("dbo.ToolsConvs", "CatQuanTools_Id1", "dbo.CatQuanTools");
            DropForeignKey("dbo.Tools", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Tools", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Tools", "TypeUnits_Id", "dbo.TypeUnits");
            DropForeignKey("dbo.Tools", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.SolEmps", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.SolEmps", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.SolEmps", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.SolEmps", "Employees_Id", "dbo.Employees");
            DropForeignKey("dbo.RoomMachins", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.RoomMachins", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.RoomMachins", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.RoomMachins", "Rooms_Id", "dbo.Rooms");
            DropForeignKey("dbo.RoomMachins", "Machins_Id", "dbo.Machins");
            DropForeignKey("dbo.RoomMachins", "Employees_Id", "dbo.Employees");
            DropForeignKey("dbo.ReturnTools", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ReturnTools", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ReturnTools", "Id", "dbo.Sections");
            DropForeignKey("dbo.ReturnTools", "Id", "dbo.SalesReps");
            DropForeignKey("dbo.ReturnTools", "Id", "dbo.Companies");
            DropForeignKey("dbo.ReturnMachins", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ReturnMachins", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ReturnMachins", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.ReturnMachins", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.ReturnMachins", "Machins_Id", "dbo.Machins");
            DropForeignKey("dbo.ReturnMachins", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.Remedies", "Items_Id1", "dbo.Items");
            DropForeignKey("dbo.Remedies", "Diagnosis_Id1", "dbo.Diagnosis");
            DropForeignKey("dbo.Remedies", "CatQuanItems_Id1", "dbo.CatQuanItems");
            DropForeignKey("dbo.PurchaseTools", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.PurchaseTools", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.PurchaseTools", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.PurchaseTools", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.PurchaseTools", "RequiredpurchaseTools_Id1", "dbo.RequiredpurchaseTools");
            DropForeignKey("dbo.RequiredpurchaseTools", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.RequiredpurchaseTools", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.RequiredpurchaseTools", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.RequiredpurchaseTools", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.RequiredpurchaseTools", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.PurchaseTools", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.PurchaseTools", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.MachinDocOthers", "Machins_Id", "dbo.Machins");
            DropForeignKey("dbo.MachinDocOthers", "DocCusts_Id", "dbo.DocCusts");
            DropForeignKey("dbo.MachinCourses", "Machins_Id", "dbo.Machins");
            DropForeignKey("dbo.MachinCourses", "Courses_Id", "dbo.Courses");
            DropForeignKey("dbo.ItemsReturnItems", "ReturnItems_Id1", "dbo.ReturnItems");
            DropForeignKey("dbo.ReturnItems", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ReturnItems", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ReturnItems", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.ReturnItems", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.ReturnItems", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.ItemsReturnItems", "Items_Id1", "dbo.Items");
            DropForeignKey("dbo.ItemsReturnItems", "CatQuanItems_Id1", "dbo.CatQuanItems");
            DropForeignKey("dbo.ItemsRequiredpurchases", "Items_Id1", "dbo.Items");
            DropForeignKey("dbo.ItemsRequiredpurchases", "Diagnosis_Id1", "dbo.Diagnosis");
            DropForeignKey("dbo.ItemsRequiredpurchases", "CatQuanItems_Id1", "dbo.CatQuanItems");
            DropForeignKey("dbo.ItemsPurchases", "PurchaseItems_Id1", "dbo.PurchaseItems");
            DropForeignKey("dbo.PurchaseItems", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.PurchaseItems", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.PurchaseItems", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.PurchaseItems", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.PurchaseItems", "RequiredpurchaseItems_Id1", "dbo.RequiredpurchaseItems");
            DropForeignKey("dbo.RequiredpurchaseItems", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.RequiredpurchaseItems", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.RequiredpurchaseItems", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.RequiredpurchaseItems", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.RequiredpurchaseItems", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.PurchaseItems", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.PurchaseItems", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.ItemsPurchases", "Items_Id1", "dbo.Items");
            DropForeignKey("dbo.ItemsPurchases", "CatQuanItems_Id1", "dbo.CatQuanItems");
            DropForeignKey("dbo.ItemsDocCusts", "Items_Id1", "dbo.Items");
            DropForeignKey("dbo.ItemsDocCusts", "DocCusts_Id", "dbo.DocCusts");
            DropForeignKey("dbo.ItemsDocCusts", "CatQuanItems_Id1", "dbo.CatQuanItems");
            DropForeignKey("dbo.ItemsCourses", "Items_Id1", "dbo.Items");
            DropForeignKey("dbo.ItemsCourses", "Courses_Id", "dbo.Courses");
            DropForeignKey("dbo.ItemsCourses", "CatQuanItems_Id1", "dbo.CatQuanItems");
            DropForeignKey("dbo.ItemsConvs", "Items_Id1", "dbo.Items");
            DropForeignKey("dbo.ItemsConvs", "ConvItems_Id1", "dbo.ConvItems");
            DropForeignKey("dbo.ItemsConvs", "CatQuanItems_Id1", "dbo.CatQuanItems");
            DropForeignKey("dbo.Items", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Items", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Items", "TypeUnits_Id", "dbo.TypeUnits");
            DropForeignKey("dbo.Items", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.Items", "CatItems_Id", "dbo.CatItems");
            DropForeignKey("dbo.installments", "PurchaseMachins_Id", "dbo.PurchaseMachins");
            DropForeignKey("dbo.GzaEmps", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.GzaEmps", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.GzaEmps", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.GzaEmps", "Employees_Id", "dbo.Employees");
            DropForeignKey("dbo.DocReps", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.DocReps", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.DocReps", "ListReps_Id", "dbo.ListReps");
            DropForeignKey("dbo.ListReps", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ListReps", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ListReps", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.ListReps", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.ListReps", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.ListReps", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.DocOthers", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.DocOthers", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.DocOthers", "ListOthers_Id", "dbo.ListOthers");
            DropForeignKey("dbo.ListOthers", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ListOthers", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ListOthers", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.Diagnosis", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Diagnosis", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.DateCalls", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.DateCalls", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.DateCalls", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.DateCalls", "Pations_Id", "dbo.Pations");
            DropForeignKey("dbo.DataReasons", "Reasons_Id1", "dbo.Reasons");
            DropForeignKey("dbo.ConvTools", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ConvTools", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ConvTools", "Sections1_Id", "dbo.Sections");
            DropForeignKey("dbo.ConvTools", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.ConvMachins", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ConvMachins", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ConvMachins", "Sections1_Id", "dbo.Sections");
            DropForeignKey("dbo.ConvMachins", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.ConvMachins", "Machins_Id", "dbo.Machins");
            DropForeignKey("dbo.ConvItems", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ConvItems", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ConvItems", "Sections1_Id", "dbo.Sections");
            DropForeignKey("dbo.ConvItems", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.ChequeMonthMachinCoes", "MonthMachinCoes_Id", "dbo.MonthMachinCoes");
            DropForeignKey("dbo.MonthMachinCoes", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.MonthMachinCoes", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.MonthMachinCoes", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.MonthMachinCoes", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.MonthMachinCoes", "PurchaseMachins_Id", "dbo.PurchaseMachins");
            DropForeignKey("dbo.PurchaseMachins", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.PurchaseMachins", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.PurchaseMachins", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.PurchaseMachins", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.PurchaseMachins", "RequiredpurchaseMachins_Id", "dbo.RequiredpurchaseMachins");
            DropForeignKey("dbo.RequiredpurchaseMachins", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.RequiredpurchaseMachins", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.RequiredpurchaseMachins", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.RequiredpurchaseMachins", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.RequiredpurchaseMachins", "Machins_Id", "dbo.Machins");
            DropForeignKey("dbo.RequiredpurchaseMachins", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.PurchaseMachins", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.PurchaseMachins", "Machins_Id", "dbo.Machins");
            DropForeignKey("dbo.Machins", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Machins", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Machins", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.PurchaseMachins", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.MonthMachinCoes", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.MonthMachinCoes", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.ChequeMonthMachinCoes", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.ChequeMonthCusts", "MonthCusts_Id", "dbo.MonthCusts");
            DropForeignKey("dbo.MonthCusts", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.MonthCusts", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.MonthCusts", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.MonthCusts", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.MonthCusts", "Pations_Id", "dbo.Pations");
            DropForeignKey("dbo.ChequeMonthCusts", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.ChequeMonthCoes", "MonthCoes_Id", "dbo.MonthCoes");
            DropForeignKey("dbo.MonthCoes", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.MonthCoes", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.MonthCoes", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.MonthCoes", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.MonthCoes", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.MonthCoes", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.ChequeMonthCoes", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.ChequeListCusts", "ListCusts_Id", "dbo.ListCusts");
            DropForeignKey("dbo.ChequeListCusts", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.ChequeDocCusts", "DocCusts_Id", "dbo.DocCusts");
            DropForeignKey("dbo.DocCusts", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.DocCusts", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.DocCusts", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.DocCusts", "Rooms_Id", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Rooms", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.DocCusts", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.DocCusts", "Pations_Id", "dbo.Pations");
            DropForeignKey("dbo.ListCusts", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ListCusts", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ListCusts", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.ListCusts", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.ListCusts", "Pations_Id", "dbo.Pations");
            DropForeignKey("dbo.Pations", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Pations", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Pations", "Prices_Id", "dbo.Prices");
            DropForeignKey("dbo.Prices", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Prices", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Pations", "Pationjobs_Id", "dbo.Pationjobs");
            DropForeignKey("dbo.Pations", "Nations_Id", "dbo.Nations");
            DropForeignKey("dbo.DocCusts", "ListCusts_Id", "dbo.ListCusts");
            DropForeignKey("dbo.DocCusts", "Courses_Id", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Courses", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.ChequeDocCusts", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.ChequeCashReturns", "CashReturns_Id", "dbo.CashReturns");
            DropForeignKey("dbo.ChequeCashReturns", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.ChequeCashOthers", "CashOthers_Id", "dbo.CashOthers");
            DropForeignKey("dbo.ChequeCashOthers", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.ChequeCashCoes", "CashCoes_Id", "dbo.CashCoes");
            DropForeignKey("dbo.ChequeCashCoes", "Banks_Id", "dbo.Banks");
            DropForeignKey("dbo.CatItems", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.CatItems", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CashReturns", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.CashReturns", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CashReturns", "TypeOPrations_Id", "dbo.TypeOPrations");
            DropForeignKey("dbo.CashReturns", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.CashReturns", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.CashReturns", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.CashReturns", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.CashOthers", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.CashOthers", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CashOthers", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.CashOthers", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.CashOthers", "Exps_Id", "dbo.Exps");
            DropForeignKey("dbo.Exps", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Exps", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CashEmps", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.CashEmps", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CashEmps", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.CashEmps", "Months_Id", "dbo.Months");
            DropForeignKey("dbo.CashEmps", "Employees_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Employees", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Employees", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.Employees", "CatJobs_Id", "dbo.CatJobs");
            DropForeignKey("dbo.CashCoes", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.CashCoes", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CashCoes", "TypeOPrations_Id", "dbo.TypeOPrations");
            DropForeignKey("dbo.CashCoes", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.CashCoes", "SalesReps_Id", "dbo.SalesReps");
            DropForeignKey("dbo.SalesReps", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.SalesReps", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.SalesReps", "Sections_Id", "dbo.Sections");
            DropForeignKey("dbo.Sections", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Sections", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.SalesReps", "Nations_Id", "dbo.Nations");
            DropForeignKey("dbo.SalesReps", "HowAbouts_Id", "dbo.HowAbouts");
            DropForeignKey("dbo.SalesReps", "Genders_Id", "dbo.Genders");
            DropForeignKey("dbo.SalesReps", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.CashCoes", "PaymentMethods_Id", "dbo.PaymentMethods");
            DropForeignKey("dbo.CashCoes", "Companies_Id", "dbo.Companies");
            DropForeignKey("dbo.Companies", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Companies", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "JobPermations_Id", "dbo.JobPermations");
            DropForeignKey("dbo.Companies", "specializations_Id", "dbo.specializations");
            DropIndex("dbo.ToolsReturnTools", new[] { "Tools_Id1" });
            DropIndex("dbo.ToolsReturnTools", new[] { "ReturnTools_MyProperty1" });
            DropIndex("dbo.ToolsReturnTools", new[] { "CatQuanTools_Id1" });
            DropIndex("dbo.ToolsRequiredpurchases", new[] { "Tools_Id1" });
            DropIndex("dbo.ToolsRequiredpurchases", new[] { "RequiredpurchaseTools_Id1" });
            DropIndex("dbo.ToolsRequiredpurchases", new[] { "CatQuanTools_Id1" });
            DropIndex("dbo.ToolsPurchases", new[] { "Tools_Id1" });
            DropIndex("dbo.ToolsPurchases", new[] { "PurchaseTools_Id1" });
            DropIndex("dbo.ToolsPurchases", new[] { "CatQuanTools_Id1" });
            DropIndex("dbo.ToolsConvs", new[] { "Tools_Id1" });
            DropIndex("dbo.ToolsConvs", new[] { "ConvTools_Id1" });
            DropIndex("dbo.ToolsConvs", new[] { "CatQuanTools_Id1" });
            DropIndex("dbo.Tools", new[] { "Users1_Id" });
            DropIndex("dbo.Tools", new[] { "Users_Id" });
            DropIndex("dbo.Tools", new[] { "TypeUnits_Id" });
            DropIndex("dbo.Tools", new[] { "Companies_Id" });
            DropIndex("dbo.SolEmps", new[] { "Users1_Id" });
            DropIndex("dbo.SolEmps", new[] { "Users_Id" });
            DropIndex("dbo.SolEmps", new[] { "Sections_Id" });
            DropIndex("dbo.SolEmps", new[] { "Employees_Id" });
            DropIndex("dbo.RoomMachins", new[] { "Users1_Id" });
            DropIndex("dbo.RoomMachins", new[] { "Users_Id" });
            DropIndex("dbo.RoomMachins", new[] { "Sections_Id" });
            DropIndex("dbo.RoomMachins", new[] { "Rooms_Id" });
            DropIndex("dbo.RoomMachins", new[] { "Machins_Id" });
            DropIndex("dbo.RoomMachins", new[] { "Employees_Id" });
            DropIndex("dbo.ReturnTools", new[] { "Users1_Id" });
            DropIndex("dbo.ReturnTools", new[] { "Users_Id" });
            DropIndex("dbo.ReturnTools", new[] { "Id" });
            DropIndex("dbo.ReturnMachins", new[] { "Users1_Id" });
            DropIndex("dbo.ReturnMachins", new[] { "Users_Id" });
            DropIndex("dbo.ReturnMachins", new[] { "Sections_Id" });
            DropIndex("dbo.ReturnMachins", new[] { "SalesReps_Id" });
            DropIndex("dbo.ReturnMachins", new[] { "Machins_Id" });
            DropIndex("dbo.ReturnMachins", new[] { "Companies_Id" });
            DropIndex("dbo.Remedies", new[] { "Items_Id1" });
            DropIndex("dbo.Remedies", new[] { "Diagnosis_Id1" });
            DropIndex("dbo.Remedies", new[] { "CatQuanItems_Id1" });
            DropIndex("dbo.RequiredpurchaseTools", new[] { "Users1_Id" });
            DropIndex("dbo.RequiredpurchaseTools", new[] { "Users_Id" });
            DropIndex("dbo.RequiredpurchaseTools", new[] { "Sections_Id" });
            DropIndex("dbo.RequiredpurchaseTools", new[] { "SalesReps_Id" });
            DropIndex("dbo.RequiredpurchaseTools", new[] { "Companies_Id" });
            DropIndex("dbo.PurchaseTools", new[] { "Users1_Id" });
            DropIndex("dbo.PurchaseTools", new[] { "Users_Id" });
            DropIndex("dbo.PurchaseTools", new[] { "Sections_Id" });
            DropIndex("dbo.PurchaseTools", new[] { "SalesReps_Id" });
            DropIndex("dbo.PurchaseTools", new[] { "RequiredpurchaseTools_Id1" });
            DropIndex("dbo.PurchaseTools", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.PurchaseTools", new[] { "Companies_Id" });
            DropIndex("dbo.MachinDocOthers", new[] { "Machins_Id" });
            DropIndex("dbo.MachinDocOthers", new[] { "DocCusts_Id" });
            DropIndex("dbo.MachinCourses", new[] { "Machins_Id" });
            DropIndex("dbo.MachinCourses", new[] { "Courses_Id" });
            DropIndex("dbo.ReturnItems", new[] { "Users1_Id" });
            DropIndex("dbo.ReturnItems", new[] { "Users_Id" });
            DropIndex("dbo.ReturnItems", new[] { "Sections_Id" });
            DropIndex("dbo.ReturnItems", new[] { "SalesReps_Id" });
            DropIndex("dbo.ReturnItems", new[] { "Companies_Id" });
            DropIndex("dbo.ItemsReturnItems", new[] { "ReturnItems_Id1" });
            DropIndex("dbo.ItemsReturnItems", new[] { "Items_Id1" });
            DropIndex("dbo.ItemsReturnItems", new[] { "CatQuanItems_Id1" });
            DropIndex("dbo.ItemsRequiredpurchases", new[] { "Items_Id1" });
            DropIndex("dbo.ItemsRequiredpurchases", new[] { "Diagnosis_Id1" });
            DropIndex("dbo.ItemsRequiredpurchases", new[] { "CatQuanItems_Id1" });
            DropIndex("dbo.RequiredpurchaseItems", new[] { "Users1_Id" });
            DropIndex("dbo.RequiredpurchaseItems", new[] { "Users_Id" });
            DropIndex("dbo.RequiredpurchaseItems", new[] { "Sections_Id" });
            DropIndex("dbo.RequiredpurchaseItems", new[] { "SalesReps_Id" });
            DropIndex("dbo.RequiredpurchaseItems", new[] { "Companies_Id" });
            DropIndex("dbo.PurchaseItems", new[] { "Users1_Id" });
            DropIndex("dbo.PurchaseItems", new[] { "Users_Id" });
            DropIndex("dbo.PurchaseItems", new[] { "Sections_Id" });
            DropIndex("dbo.PurchaseItems", new[] { "SalesReps_Id" });
            DropIndex("dbo.PurchaseItems", new[] { "RequiredpurchaseItems_Id1" });
            DropIndex("dbo.PurchaseItems", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.PurchaseItems", new[] { "Companies_Id" });
            DropIndex("dbo.ItemsPurchases", new[] { "PurchaseItems_Id1" });
            DropIndex("dbo.ItemsPurchases", new[] { "Items_Id1" });
            DropIndex("dbo.ItemsPurchases", new[] { "CatQuanItems_Id1" });
            DropIndex("dbo.ItemsDocCusts", new[] { "Items_Id1" });
            DropIndex("dbo.ItemsDocCusts", new[] { "DocCusts_Id" });
            DropIndex("dbo.ItemsDocCusts", new[] { "CatQuanItems_Id1" });
            DropIndex("dbo.ItemsCourses", new[] { "Items_Id1" });
            DropIndex("dbo.ItemsCourses", new[] { "Courses_Id" });
            DropIndex("dbo.ItemsCourses", new[] { "CatQuanItems_Id1" });
            DropIndex("dbo.ItemsConvs", new[] { "Items_Id1" });
            DropIndex("dbo.ItemsConvs", new[] { "ConvItems_Id1" });
            DropIndex("dbo.ItemsConvs", new[] { "CatQuanItems_Id1" });
            DropIndex("dbo.Items", new[] { "Users1_Id" });
            DropIndex("dbo.Items", new[] { "Users_Id" });
            DropIndex("dbo.Items", new[] { "TypeUnits_Id" });
            DropIndex("dbo.Items", new[] { "Companies_Id" });
            DropIndex("dbo.Items", new[] { "CatItems_Id" });
            DropIndex("dbo.installments", new[] { "PurchaseMachins_Id" });
            DropIndex("dbo.GzaEmps", new[] { "Users1_Id" });
            DropIndex("dbo.GzaEmps", new[] { "Users_Id" });
            DropIndex("dbo.GzaEmps", new[] { "Sections_Id" });
            DropIndex("dbo.GzaEmps", new[] { "Employees_Id" });
            DropIndex("dbo.ListReps", new[] { "Users1_Id" });
            DropIndex("dbo.ListReps", new[] { "Users_Id" });
            DropIndex("dbo.ListReps", new[] { "Sections_Id" });
            DropIndex("dbo.ListReps", new[] { "SalesReps_Id" });
            DropIndex("dbo.ListReps", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.ListReps", new[] { "Companies_Id" });
            DropIndex("dbo.DocReps", new[] { "Users1_Id" });
            DropIndex("dbo.DocReps", new[] { "Users_Id" });
            DropIndex("dbo.DocReps", new[] { "ListReps_Id" });
            DropIndex("dbo.ListOthers", new[] { "Users1_Id" });
            DropIndex("dbo.ListOthers", new[] { "Users_Id" });
            DropIndex("dbo.ListOthers", new[] { "Sections_Id" });
            DropIndex("dbo.DocOthers", new[] { "Users1_Id" });
            DropIndex("dbo.DocOthers", new[] { "Users_Id" });
            DropIndex("dbo.DocOthers", new[] { "ListOthers_Id" });
            DropIndex("dbo.Diagnosis", new[] { "Users1_Id" });
            DropIndex("dbo.Diagnosis", new[] { "Users_Id" });
            DropIndex("dbo.DateCalls", new[] { "Users1_Id" });
            DropIndex("dbo.DateCalls", new[] { "Users_Id" });
            DropIndex("dbo.DateCalls", new[] { "Sections_Id" });
            DropIndex("dbo.DateCalls", new[] { "Pations_Id" });
            DropIndex("dbo.DataReasons", new[] { "Reasons_Id1" });
            DropIndex("dbo.ConvTools", new[] { "Users1_Id" });
            DropIndex("dbo.ConvTools", new[] { "Users_Id" });
            DropIndex("dbo.ConvTools", new[] { "Sections1_Id" });
            DropIndex("dbo.ConvTools", new[] { "Sections_Id" });
            DropIndex("dbo.ConvMachins", new[] { "Users1_Id" });
            DropIndex("dbo.ConvMachins", new[] { "Users_Id" });
            DropIndex("dbo.ConvMachins", new[] { "Sections1_Id" });
            DropIndex("dbo.ConvMachins", new[] { "Sections_Id" });
            DropIndex("dbo.ConvMachins", new[] { "Machins_Id" });
            DropIndex("dbo.ConvItems", new[] { "Users1_Id" });
            DropIndex("dbo.ConvItems", new[] { "Users_Id" });
            DropIndex("dbo.ConvItems", new[] { "Sections1_Id" });
            DropIndex("dbo.ConvItems", new[] { "Sections_Id" });
            DropIndex("dbo.RequiredpurchaseMachins", new[] { "Users1_Id" });
            DropIndex("dbo.RequiredpurchaseMachins", new[] { "Users_Id" });
            DropIndex("dbo.RequiredpurchaseMachins", new[] { "Sections_Id" });
            DropIndex("dbo.RequiredpurchaseMachins", new[] { "SalesReps_Id" });
            DropIndex("dbo.RequiredpurchaseMachins", new[] { "Machins_Id" });
            DropIndex("dbo.RequiredpurchaseMachins", new[] { "Companies_Id" });
            DropIndex("dbo.Machins", new[] { "Users1_Id" });
            DropIndex("dbo.Machins", new[] { "Users_Id" });
            DropIndex("dbo.Machins", new[] { "Companies_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "Users1_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "Users_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "Sections_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "SalesReps_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "RequiredpurchaseMachins_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "Machins_Id" });
            DropIndex("dbo.PurchaseMachins", new[] { "Companies_Id" });
            DropIndex("dbo.MonthMachinCoes", new[] { "Users1_Id" });
            DropIndex("dbo.MonthMachinCoes", new[] { "Users_Id" });
            DropIndex("dbo.MonthMachinCoes", new[] { "Sections_Id" });
            DropIndex("dbo.MonthMachinCoes", new[] { "SalesReps_Id" });
            DropIndex("dbo.MonthMachinCoes", new[] { "PurchaseMachins_Id" });
            DropIndex("dbo.MonthMachinCoes", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.MonthMachinCoes", new[] { "Companies_Id" });
            DropIndex("dbo.ChequeMonthMachinCoes", new[] { "MonthMachinCoes_Id" });
            DropIndex("dbo.ChequeMonthMachinCoes", new[] { "Banks_Id" });
            DropIndex("dbo.MonthCusts", new[] { "Users1_Id" });
            DropIndex("dbo.MonthCusts", new[] { "Users_Id" });
            DropIndex("dbo.MonthCusts", new[] { "Sections_Id" });
            DropIndex("dbo.MonthCusts", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.MonthCusts", new[] { "Pations_Id" });
            DropIndex("dbo.ChequeMonthCusts", new[] { "MonthCusts_Id" });
            DropIndex("dbo.ChequeMonthCusts", new[] { "Banks_Id" });
            DropIndex("dbo.MonthCoes", new[] { "Users1_Id" });
            DropIndex("dbo.MonthCoes", new[] { "Users_Id" });
            DropIndex("dbo.MonthCoes", new[] { "Sections_Id" });
            DropIndex("dbo.MonthCoes", new[] { "SalesReps_Id" });
            DropIndex("dbo.MonthCoes", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.MonthCoes", new[] { "Companies_Id" });
            DropIndex("dbo.ChequeMonthCoes", new[] { "MonthCoes_Id" });
            DropIndex("dbo.ChequeMonthCoes", new[] { "Banks_Id" });
            DropIndex("dbo.ChequeListCusts", new[] { "ListCusts_Id" });
            DropIndex("dbo.ChequeListCusts", new[] { "Banks_Id" });
            DropIndex("dbo.Rooms", new[] { "Users1_Id" });
            DropIndex("dbo.Rooms", new[] { "Users_Id" });
            DropIndex("dbo.Prices", new[] { "Users1_Id" });
            DropIndex("dbo.Prices", new[] { "Users_Id" });
            DropIndex("dbo.Pations", new[] { "Users1_Id" });
            DropIndex("dbo.Pations", new[] { "Users_Id" });
            DropIndex("dbo.Pations", new[] { "Prices_Id" });
            DropIndex("dbo.Pations", new[] { "Pationjobs_Id" });
            DropIndex("dbo.Pations", new[] { "Nations_Id" });
            DropIndex("dbo.ListCusts", new[] { "Users1_Id" });
            DropIndex("dbo.ListCusts", new[] { "Users_Id" });
            DropIndex("dbo.ListCusts", new[] { "Sections_Id" });
            DropIndex("dbo.ListCusts", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.ListCusts", new[] { "Pations_Id" });
            DropIndex("dbo.Courses", new[] { "Users1_Id" });
            DropIndex("dbo.Courses", new[] { "Users_Id" });
            DropIndex("dbo.DocCusts", new[] { "Users1_Id" });
            DropIndex("dbo.DocCusts", new[] { "Users_Id" });
            DropIndex("dbo.DocCusts", new[] { "Sections_Id" });
            DropIndex("dbo.DocCusts", new[] { "Rooms_Id" });
            DropIndex("dbo.DocCusts", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.DocCusts", new[] { "Pations_Id" });
            DropIndex("dbo.DocCusts", new[] { "ListCusts_Id" });
            DropIndex("dbo.DocCusts", new[] { "Courses_Id" });
            DropIndex("dbo.ChequeDocCusts", new[] { "DocCusts_Id" });
            DropIndex("dbo.ChequeDocCusts", new[] { "Banks_Id" });
            DropIndex("dbo.ChequeCashReturns", new[] { "CashReturns_Id" });
            DropIndex("dbo.ChequeCashReturns", new[] { "Banks_Id" });
            DropIndex("dbo.ChequeCashOthers", new[] { "CashOthers_Id" });
            DropIndex("dbo.ChequeCashOthers", new[] { "Banks_Id" });
            DropIndex("dbo.ChequeCashCoes", new[] { "CashCoes_Id" });
            DropIndex("dbo.ChequeCashCoes", new[] { "Banks_Id" });
            DropIndex("dbo.CatItems", new[] { "Users1_Id" });
            DropIndex("dbo.CatItems", new[] { "Users_Id" });
            DropIndex("dbo.CashReturns", new[] { "Users1_Id" });
            DropIndex("dbo.CashReturns", new[] { "Users_Id" });
            DropIndex("dbo.CashReturns", new[] { "TypeOPrations_Id" });
            DropIndex("dbo.CashReturns", new[] { "Sections_Id" });
            DropIndex("dbo.CashReturns", new[] { "SalesReps_Id" });
            DropIndex("dbo.CashReturns", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.CashReturns", new[] { "Companies_Id" });
            DropIndex("dbo.Exps", new[] { "Users1_Id" });
            DropIndex("dbo.Exps", new[] { "Users_Id" });
            DropIndex("dbo.CashOthers", new[] { "Users1_Id" });
            DropIndex("dbo.CashOthers", new[] { "Users_Id" });
            DropIndex("dbo.CashOthers", new[] { "Sections_Id" });
            DropIndex("dbo.CashOthers", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.CashOthers", new[] { "Exps_Id" });
            DropIndex("dbo.Employees", new[] { "Users1_Id" });
            DropIndex("dbo.Employees", new[] { "Users_Id" });
            DropIndex("dbo.Employees", new[] { "Sections_Id" });
            DropIndex("dbo.Employees", new[] { "CatJobs_Id" });
            DropIndex("dbo.CashEmps", new[] { "Users1_Id" });
            DropIndex("dbo.CashEmps", new[] { "Users_Id" });
            DropIndex("dbo.CashEmps", new[] { "Sections_Id" });
            DropIndex("dbo.CashEmps", new[] { "Months_Id" });
            DropIndex("dbo.CashEmps", new[] { "Employees_Id" });
            DropIndex("dbo.Sections", new[] { "Users1_Id" });
            DropIndex("dbo.Sections", new[] { "Users_Id" });
            DropIndex("dbo.SalesReps", new[] { "Users1_Id" });
            DropIndex("dbo.SalesReps", new[] { "Users_Id" });
            DropIndex("dbo.SalesReps", new[] { "Sections_Id" });
            DropIndex("dbo.SalesReps", new[] { "Nations_Id" });
            DropIndex("dbo.SalesReps", new[] { "HowAbouts_Id" });
            DropIndex("dbo.SalesReps", new[] { "Genders_Id" });
            DropIndex("dbo.SalesReps", new[] { "Companies_Id" });
            DropIndex("dbo.Users", new[] { "JobPermations_Id" });
            DropIndex("dbo.Companies", new[] { "Users1_Id" });
            DropIndex("dbo.Companies", new[] { "Users_Id" });
            DropIndex("dbo.Companies", new[] { "specializations_Id" });
            DropIndex("dbo.CashCoes", new[] { "Users1_Id" });
            DropIndex("dbo.CashCoes", new[] { "Users_Id" });
            DropIndex("dbo.CashCoes", new[] { "TypeOPrations_Id" });
            DropIndex("dbo.CashCoes", new[] { "Sections_Id" });
            DropIndex("dbo.CashCoes", new[] { "SalesReps_Id" });
            DropIndex("dbo.CashCoes", new[] { "PaymentMethods_Id" });
            DropIndex("dbo.CashCoes", new[] { "Companies_Id" });
            DropTable("dbo.ToolsReturnTools");
            DropTable("dbo.ToolsRequiredpurchases");
            DropTable("dbo.ToolsPurchases");
            DropTable("dbo.ToolsConvs");
            DropTable("dbo.Tools");
            DropTable("dbo.SolEmps");
            DropTable("dbo.RoomMachins");
            DropTable("dbo.ReturnTools");
            DropTable("dbo.ReturnMachins");
            DropTable("dbo.Remedies");
            DropTable("dbo.RequiredpurchaseTools");
            DropTable("dbo.PurchaseTools");
            DropTable("dbo.MachinDocOthers");
            DropTable("dbo.MachinCourses");
            DropTable("dbo.ReturnItems");
            DropTable("dbo.ItemsReturnItems");
            DropTable("dbo.ItemsRequiredpurchases");
            DropTable("dbo.RequiredpurchaseItems");
            DropTable("dbo.PurchaseItems");
            DropTable("dbo.ItemsPurchases");
            DropTable("dbo.ItemsDocCusts");
            DropTable("dbo.ItemsCourses");
            DropTable("dbo.ItemsConvs");
            DropTable("dbo.TypeUnits");
            DropTable("dbo.Items");
            DropTable("dbo.installments");
            DropTable("dbo.GzaEmps");
            DropTable("dbo.ListReps");
            DropTable("dbo.DocReps");
            DropTable("dbo.ListOthers");
            DropTable("dbo.DocOthers");
            DropTable("dbo.Diagnosis");
            DropTable("dbo.DateCalls");
            DropTable("dbo.Reasons");
            DropTable("dbo.DataReasons");
            DropTable("dbo.ConvTools");
            DropTable("dbo.ConvMachins");
            DropTable("dbo.ConvItems");
            DropTable("dbo.RequiredpurchaseMachins");
            DropTable("dbo.Machins");
            DropTable("dbo.PurchaseMachins");
            DropTable("dbo.MonthMachinCoes");
            DropTable("dbo.ChequeMonthMachinCoes");
            DropTable("dbo.MonthCusts");
            DropTable("dbo.ChequeMonthCusts");
            DropTable("dbo.MonthCoes");
            DropTable("dbo.ChequeMonthCoes");
            DropTable("dbo.ChequeListCusts");
            DropTable("dbo.Rooms");
            DropTable("dbo.Prices");
            DropTable("dbo.Pationjobs");
            DropTable("dbo.Pations");
            DropTable("dbo.ListCusts");
            DropTable("dbo.Courses");
            DropTable("dbo.DocCusts");
            DropTable("dbo.ChequeDocCusts");
            DropTable("dbo.ChequeCashReturns");
            DropTable("dbo.ChequeCashOthers");
            DropTable("dbo.ChequeCashCoes");
            DropTable("dbo.CatQuanTools");
            DropTable("dbo.CatQuanItems");
            DropTable("dbo.CatItems");
            DropTable("dbo.CashReturns");
            DropTable("dbo.Exps");
            DropTable("dbo.CashOthers");
            DropTable("dbo.Months");
            DropTable("dbo.CatJobs");
            DropTable("dbo.Employees");
            DropTable("dbo.CashEmps");
            DropTable("dbo.TypeOPrations");
            DropTable("dbo.Sections");
            DropTable("dbo.Nations");
            DropTable("dbo.HowAbouts");
            DropTable("dbo.Genders");
            DropTable("dbo.SalesReps");
            DropTable("dbo.PaymentMethods");
            DropTable("dbo.JobPermations");
            DropTable("dbo.Users");
            DropTable("dbo.specializations");
            DropTable("dbo.Companies");
            DropTable("dbo.CashCoes");
            DropTable("dbo.Banks");
        }
    }
}
