namespace App.DLL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=DB")
        {
        }

        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<CashCoes> CashCoes { get; set; }
        public virtual DbSet<CashEmps> CashEmps { get; set; }
        public virtual DbSet<CashOthers> CashOthers { get; set; }
        public virtual DbSet<CashReturns> CashReturns { get; set; }
        public virtual DbSet<CatItems> CatItems { get; set; }
        public virtual DbSet<CatJobs> CatJobs { get; set; }
        public virtual DbSet<CatQuanItems> CatQuanItems { get; set; }
        public virtual DbSet<CatQuanTools> CatQuanTools { get; set; }
        public virtual DbSet<ChequeCashCoes> ChequeCashCoes { get; set; }
        public virtual DbSet<ChequeCashOthers> ChequeCashOthers { get; set; }
        public virtual DbSet<ChequeCashReturns> ChequeCashReturns { get; set; }
        public virtual DbSet<ChequeDocCusts> ChequeDocCusts { get; set; }
        public virtual DbSet<ChequeListCusts> ChequeListCusts { get; set; }
        public virtual DbSet<ChequeMonthCoes> ChequeMonthCoes { get; set; }
        public virtual DbSet<ChequeMonthCusts> ChequeMonthCusts { get; set; }
        public virtual DbSet<ChequeMonthMachinCoes> ChequeMonthMachinCoes { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<ConvItems> ConvItems { get; set; }
        public virtual DbSet<ConvMachins> ConvMachins { get; set; }
        public virtual DbSet<ConvTools> ConvTools { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<DataReasons> DataReasons { get; set; }
        public virtual DbSet<DateCalls> DateCalls { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<DocCusts> DocCusts { get; set; }
        public virtual DbSet<DocOthers> DocOthers { get; set; }
        public virtual DbSet<DocReps> DocReps { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Exps> Exps { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<GzaEmps> GzaEmps { get; set; }
        public virtual DbSet<HowAbouts> HowAbouts { get; set; }
        public virtual DbSet<installments> installments { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<ItemsConvs> ItemsConvs { get; set; }
        public virtual DbSet<ItemsCourses> ItemsCourses { get; set; }
        public virtual DbSet<ItemsDocCusts> ItemsDocCusts { get; set; }
        public virtual DbSet<ItemsPurchases> ItemsPurchases { get; set; }
        public virtual DbSet<ItemsRequiredpurchases> ItemsRequiredpurchases { get; set; }
        public virtual DbSet<ItemsReturnItems> ItemsReturnItems { get; set; }
        public virtual DbSet<JobPermations> JobPermations { get; set; }
        public virtual DbSet<ListCusts> ListCusts { get; set; }
        public virtual DbSet<ListOthers> ListOthers { get; set; }
        public virtual DbSet<ListReps> ListReps { get; set; }
        public virtual DbSet<MachinCourses> MachinCourses { get; set; }
        public virtual DbSet<MachinDocOthers> MachinDocOthers { get; set; }
        public virtual DbSet<Machins> Machins { get; set; }
        public virtual DbSet<MonthCoes> MonthCoes { get; set; }
        public virtual DbSet<MonthCusts> MonthCusts { get; set; }
        public virtual DbSet<MonthMachinCoes> MonthMachinCoes { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Nations> Nations { get; set; }
        public virtual DbSet<Pationjobs> Pationjobs { get; set; }
        public virtual DbSet<Pations> Pations { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<PurchaseItems> PurchaseItems { get; set; }
        public virtual DbSet<PurchaseMachins> PurchaseMachins { get; set; }
        public virtual DbSet<PurchaseTools> PurchaseTools { get; set; }
        public virtual DbSet<Reasons> Reasons { get; set; }
        public virtual DbSet<Remedies> Remedies { get; set; }
        public virtual DbSet<RequiredpurchaseItems> RequiredpurchaseItems { get; set; }
        public virtual DbSet<RequiredpurchaseMachins> RequiredpurchaseMachins { get; set; }
        public virtual DbSet<RequiredpurchaseTools> RequiredpurchaseTools { get; set; }
        public virtual DbSet<ReturnItems> ReturnItems { get; set; }
        public virtual DbSet<ReturnMachins> ReturnMachins { get; set; }
        public virtual DbSet<ReturnTools> ReturnTools { get; set; }
        public virtual DbSet<RoomMachins> RoomMachins { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<SalesReps> SalesReps { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<SolEmps> SolEmps { get; set; }
        public virtual DbSet<specializations> specializations { get; set; }
        public virtual DbSet<Tools> Tools { get; set; }
        public virtual DbSet<ToolsConvs> ToolsConvs { get; set; }
        public virtual DbSet<ToolsPurchases> ToolsPurchases { get; set; }
        public virtual DbSet<ToolsRequiredpurchases> ToolsRequiredpurchases { get; set; }
        public virtual DbSet<ToolsReturnTools> ToolsReturnTools { get; set; }
        public virtual DbSet<TypeOPrations> TypeOPrations { get; set; }
        public virtual DbSet<TypeUnits> TypeUnits { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Banks>().MapToStoredProcedures();
           //     //.HasMany(e => e.ChequeCashCoes)
           //     //.WithOptional(e => e.Banks)
           //     //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<Banks>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeCashOthers)
                //.WithOptional(e => e.Banks)
                //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<Banks>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeCashReturns)
                //.WithOptional(e => e.Banks)
                //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<Banks>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeDocCusts)
                //.WithOptional(e => e.Banks)
                //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<Banks>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeListCusts)
                //.WithOptional(e => e.Banks)
                //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<Banks>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeMonthCoes)
                //.WithOptional(e => e.Banks)
                //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<Banks>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeMonthCusts)
                //.WithOptional(e => e.Banks)
                //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<Banks>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeMonthMachinCoes)
                //.WithOptional(e => e.Banks)
                //.HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<CashCoes>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeCashCoes)
                //.WithOptional(e => e.CashCoes)
                //.HasForeignKey(e => e.CashCo_Id);

            modelBuilder.Entity<CashOthers>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeCashOthers)
                //.WithOptional(e => e.CashOthers)
                //.HasForeignKey(e => e.CashOther_Id);

            modelBuilder.Entity<CashReturns>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeCashReturns)
                //.WithOptional(e => e.CashReturns)
                //.HasForeignKey(e => e.CashReturn_Id);

            modelBuilder.Entity<CatItems>().MapToStoredProcedures();
                //.HasMany(e => e.Items)
                //.WithOptional(e => e.CatItems)
                //.HasForeignKey(e => e.CatItem_Id);

            modelBuilder.Entity<CatJobs>().MapToStoredProcedures();
                //.HasMany(e => e.Employees)
                //.WithOptional(e => e.CatJobs)
                //.HasForeignKey(e => e.CatJob_Id);

            modelBuilder.Entity<CatQuanItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsConvs)
                //.WithOptional(e => e.CatQuanItems)
                //.HasForeignKey(e => e.CatQuanItems_Id);

            modelBuilder.Entity<CatQuanItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsCourses)
                //.WithOptional(e => e.CatQuanItems)
                //.HasForeignKey(e => e.CatQuanItems_Id);

            modelBuilder.Entity<CatQuanItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsDocCusts)
                //.WithOptional(e => e.CatQuanItems)
                //.HasForeignKey(e => e.CatQuanItems_Id);

            modelBuilder.Entity<CatQuanItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsPurchases)
                //.WithOptional(e => e.CatQuanItems)
                //.HasForeignKey(e => e.CatQuanItems_Id);

            modelBuilder.Entity<CatQuanItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsRequiredpurchases)
                //.WithOptional(e => e.CatQuanItems)
                //.HasForeignKey(e => e.CatQuanItems_Id);

            modelBuilder.Entity<CatQuanItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsReturnItems)
                //.WithOptional(e => e.CatQuanItems)
                //.HasForeignKey(e => e.CatQuanItems_Id);

            modelBuilder.Entity<CatQuanItems>().MapToStoredProcedures();
                //.HasMany(e => e.Remedies)
                //.WithOptional(e => e.CatQuanItems)
                //.HasForeignKey(e => e.CatQuanItems_Id);

            modelBuilder.Entity<CatQuanTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsConvs)
                //.WithOptional(e => e.CatQuanTools)
                //.HasForeignKey(e => e.CatQuanTools_Id);

            modelBuilder.Entity<CatQuanTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsPurchases)
                //.WithOptional(e => e.CatQuanTools)
                //.HasForeignKey(e => e.CatQuanTools_Id);

            modelBuilder.Entity<CatQuanTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsRequiredpurchases)
                //.WithOptional(e => e.CatQuanTools)
                //.HasForeignKey(e => e.CatQuanTools_Id);

            modelBuilder.Entity<CatQuanTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsReturnTools)
                //.WithOptional(e => e.CatQuanTools)
                //.HasForeignKey(e => e.CatQuanTools_Id);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.CashCoes)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.CashReturns)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.Items)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.ListReps)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.Machins)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCoes)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.MonthMachinCoes)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseItems)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseTools)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseItems)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseMachins)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseTools)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnItems)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnMachins)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnTools)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.SalesReps)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<Companies>().MapToStoredProcedures();
                //.HasMany(e => e.Tools)
                //.WithOptional(e => e.Companies)
                //.HasForeignKey(e => e.Company_MyProperty);

            modelBuilder.Entity<ConvItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsConvs)
                //.WithOptional(e => e.ConvItems)
                //.HasForeignKey(e => e.ConvItems_Id);

            modelBuilder.Entity<ConvTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsConvs)
                //.WithOptional(e => e.ConvTools)
                //.HasForeignKey(e => e.ConvTools_Id);

            modelBuilder.Entity<Courses>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts)
                //.WithOptional(e => e.Courses)
                //.HasForeignKey(e => e.Course_Id);

            modelBuilder.Entity<Courses>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsCourses)
                //.WithOptional(e => e.Courses)
                //.HasForeignKey(e => e.Course_Id);

            modelBuilder.Entity<Courses>().MapToStoredProcedures();
                //.HasMany(e => e.MachinCourses)
                //.WithOptional(e => e.Courses)
                //.HasForeignKey(e => e.Course_Id);

            modelBuilder.Entity<Diagnosis>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsRequiredpurchases)
                //.WithOptional(e => e.Diagnosis)
                //.HasForeignKey(e => e.Diagnosis_Id);

            modelBuilder.Entity<Diagnosis>().MapToStoredProcedures();
                //.HasMany(e => e.Remedies)
                //.WithOptional(e => e.Diagnosis)
                //.HasForeignKey(e => e.Diagnosis_Id);

            modelBuilder.Entity<DocCusts>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeDocCusts)
                //.WithOptional(e => e.DocCusts)
                //.HasForeignKey(e => e.DocCust_Id);

            modelBuilder.Entity<DocCusts>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsDocCusts)
                //.WithOptional(e => e.DocCusts)
                //.HasForeignKey(e => e.DocCust_Id);

            modelBuilder.Entity<DocCusts>().MapToStoredProcedures();
                //.HasMany(e => e.MachinDocOthers)
                //.WithOptional(e => e.DocCusts)
                //.HasForeignKey(e => e.DocCust_Id);

            modelBuilder.Entity<Employees>().MapToStoredProcedures();
                //.HasMany(e => e.CashEmps)
                //.WithOptional(e => e.Employees)
                //.HasForeignKey(e => e.Employee_Id);

            modelBuilder.Entity<Employees>().MapToStoredProcedures();
                //.HasMany(e => e.GzaEmps)
                //.WithOptional(e => e.Employees)
                //.HasForeignKey(e => e.Employee_Id);

            modelBuilder.Entity<Employees>().MapToStoredProcedures();
                //.HasMany(e => e.RoomMachins)
                //.WithOptional(e => e.Employees)
                //.HasForeignKey(e => e.Employee_Id);

            modelBuilder.Entity<Employees>().MapToStoredProcedures();
                //.HasMany(e => e.SolEmps)
                //.WithOptional(e => e.Employees)
                //.HasForeignKey(e => e.Employee_Id);

            modelBuilder.Entity<Exps>().MapToStoredProcedures();
                //.HasMany(e => e.CashOthers)
                //.WithOptional(e => e.Exps)
                //.HasForeignKey(e => e.Exp_Id);

            modelBuilder.Entity<Genders>().MapToStoredProcedures();
                //.HasMany(e => e.Pations)
                //.WithOptional(e => e.Genders)
                //.HasForeignKey(e => e.Gender_Id);

            modelBuilder.Entity<Genders>().MapToStoredProcedures();
                //.HasMany(e => e.SalesReps)
                //.WithOptional(e => e.Genders)
                //.HasForeignKey(e => e.Gender_Id);

            modelBuilder.Entity<HowAbouts>().MapToStoredProcedures();
                //.HasMany(e => e.Pations)
                //.WithOptional(e => e.HowAbouts)
                //.HasForeignKey(e => e.HowAbout_Id);

            modelBuilder.Entity<HowAbouts>().MapToStoredProcedures();
                //.HasMany(e => e.SalesReps)
                //.WithOptional(e => e.HowAbouts)
                //.HasForeignKey(e => e.HowAbout_Id);

            modelBuilder.Entity<Items>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsConvs)
                //.WithOptional(e => e.Items)
                //.HasForeignKey(e => e.Items_Id);

            modelBuilder.Entity<Items>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsCourses)
                //.WithOptional(e => e.Items)
                //.HasForeignKey(e => e.Items_Id);

            modelBuilder.Entity<Items>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsDocCusts)
                //.WithOptional(e => e.Items)
                //.HasForeignKey(e => e.Items_Id);

            modelBuilder.Entity<Items>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsPurchases)
                //.WithOptional(e => e.Items)
                //.HasForeignKey(e => e.Items_Id);

            modelBuilder.Entity<Items>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsRequiredpurchases)
                //.WithOptional(e => e.Items)
                //.HasForeignKey(e => e.Items_Id);

            modelBuilder.Entity<Items>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsReturnItems)
                //.WithOptional(e => e.Items)
                //.HasForeignKey(e => e.Items_Id);

            modelBuilder.Entity<Items>().MapToStoredProcedures();
                //.HasMany(e => e.Remedies)
                //.WithOptional(e => e.Items)
                //.HasForeignKey(e => e.Items_Id);

            modelBuilder.Entity<JobPermations>().MapToStoredProcedures();
                //.HasMany(e => e.Users)
                //.WithOptional(e => e.JobPermations)
                //.HasForeignKey(e => e.JobPermation_Id);

            modelBuilder.Entity<ListCusts>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeListCusts)
                //.WithOptional(e => e.ListCusts)
                //.HasForeignKey(e => e.ListCust_Id);

            modelBuilder.Entity<ListCusts>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts)
                //.WithOptional(e => e.ListCusts)
                //.HasForeignKey(e => e.ListCust_Id);

            modelBuilder.Entity<ListOthers>().MapToStoredProcedures();
                //.HasMany(e => e.DocOthers)
                //.WithOptional(e => e.ListOthers)
                //.HasForeignKey(e => e.ListOther_Id);

            modelBuilder.Entity<ListReps>().MapToStoredProcedures();
                //.HasMany(e => e.DocReps)
                //.WithOptional(e => e.ListReps)
                //.HasForeignKey(e => e.ListRep_Id);

            modelBuilder.Entity<Machins>().MapToStoredProcedures();
                //.HasMany(e => e.ConvMachins)
                //.WithOptional(e => e.Machins)
                //.HasForeignKey(e => e.Machin_Id);

            modelBuilder.Entity<Machins>().MapToStoredProcedures();
                //.HasMany(e => e.MachinCourses)
                //.WithOptional(e => e.Machins)
                //.HasForeignKey(e => e.Machin_Id);

            modelBuilder.Entity<Machins>().MapToStoredProcedures();
                //.HasMany(e => e.MachinDocOthers)
                //.WithOptional(e => e.Machins)
                //.HasForeignKey(e => e.Machin_Id);

            modelBuilder.Entity<Machins>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins)
                //.WithOptional(e => e.Machins)
                //.HasForeignKey(e => e.Machin_Id);

            modelBuilder.Entity<Machins>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseMachins)
                //.WithOptional(e => e.Machins)
                //.HasForeignKey(e => e.Machin_Id);

            modelBuilder.Entity<Machins>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnMachins)
                //.WithOptional(e => e.Machins)
                //.HasForeignKey(e => e.Machin_Id);

            modelBuilder.Entity<Machins>().MapToStoredProcedures();
                //.HasMany(e => e.RoomMachins)
                //.WithOptional(e => e.Machins)
                //.HasForeignKey(e => e.Machin_Id);

            modelBuilder.Entity<MonthCoes>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeMonthCoes)
                //.WithOptional(e => e.MonthCoes)
                //.HasForeignKey(e => e.MonthCo_Id);

            modelBuilder.Entity<MonthCusts>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeMonthCusts)
                //.WithOptional(e => e.MonthCusts)
                //.HasForeignKey(e => e.MonthCust_Id);

            modelBuilder.Entity<MonthMachinCoes>().MapToStoredProcedures();
                //.HasMany(e => e.ChequeMonthMachinCoes)
                //.WithOptional(e => e.MonthMachinCoes)
                //.HasForeignKey(e => e.MonthMachinCo_Id);

            modelBuilder.Entity<Months>().MapToStoredProcedures();
                //.HasMany(e => e.CashEmps)
                //.WithOptional(e => e.Months)
                //.HasForeignKey(e => e.Month_Id);

            modelBuilder.Entity<Nations>().MapToStoredProcedures();
                //.HasMany(e => e.Pations)
                //.WithOptional(e => e.Nations)
                //.HasForeignKey(e => e.Nation_Id);

            modelBuilder.Entity<Nations>().MapToStoredProcedures();
                //.HasMany(e => e.SalesReps)
                //.WithOptional(e => e.Nations)
                //.HasForeignKey(e => e.Nation_Id);

            modelBuilder.Entity<Pationjobs>().MapToStoredProcedures();
                //.HasMany(e => e.Pations)
                //.WithOptional(e => e.Pationjobs)
                //.HasForeignKey(e => e.Pationjob_Id);

            modelBuilder.Entity<Pations>().MapToStoredProcedures();
                //.HasMany(e => e.DateCalls)
                //.WithOptional(e => e.Pations)
                //.HasForeignKey(e => e.Pation_Id);

            modelBuilder.Entity<Pations>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts)
                //.WithOptional(e => e.Pations)
                //.HasForeignKey(e => e.Pation_Id);

            modelBuilder.Entity<Pations>().MapToStoredProcedures();
                //.HasMany(e => e.ListCusts)
                //.WithOptional(e => e.Pations)
                //.HasForeignKey(e => e.Pation_Id);

            modelBuilder.Entity<Pations>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCusts)
                //.WithOptional(e => e.Pations)
                //.HasForeignKey(e => e.Pation_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.CashCoes)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.CashOthers)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.CashReturns)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.ListCusts)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.ListReps)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCoes)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCusts)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.MonthMachinCoes)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseItems)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<PaymentMethods>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseTools)
                //.WithOptional(e => e.PaymentMethods)
                //.HasForeignKey(e => e.PaymentMethod_Id);

            modelBuilder.Entity<Prices>().MapToStoredProcedures();
                //.HasMany(e => e.Pations)
                //.WithOptional(e => e.Prices)
                //.HasForeignKey(e => e.Price_Id);

            modelBuilder.Entity<PurchaseItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsPurchases)
                //.WithOptional(e => e.PurchaseItems)
                //.HasForeignKey(e => e.PurchaseItems_Id);

            modelBuilder.Entity<PurchaseMachins>().MapToStoredProcedures();
                //.HasMany(e => e.installments)
                //.WithOptional(e => e.PurchaseMachins)
                //.HasForeignKey(e => e.PurchaseMachin_Id);

            modelBuilder.Entity<PurchaseMachins>().MapToStoredProcedures();
                //.HasMany(e => e.MonthMachinCoes)
                //.WithOptional(e => e.PurchaseMachins)
                //.HasForeignKey(e => e.PurchaseMachin_Id);

            modelBuilder.Entity<PurchaseTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsPurchases)
                //.WithOptional(e => e.PurchaseTools)
                //.HasForeignKey(e => e.PurchaseTools_Id);

            modelBuilder.Entity<Reasons>().MapToStoredProcedures();
                //.HasMany(e => e.DataReasons)
                //.WithOptional(e => e.Reasons)
                //.HasForeignKey(e => e.Reasons_Id);

            modelBuilder.Entity<RequiredpurchaseItems>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseItems)
                //.WithOptional(e => e.RequiredpurchaseItems)
                //.HasForeignKey(e => e.RequiredpurchaseItems_Id);

            modelBuilder.Entity<RequiredpurchaseMachins>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins)
                //.WithOptional(e => e.RequiredpurchaseMachins)
                //.HasForeignKey(e => e.RequiredpurchaseMachin_Id);

            modelBuilder.Entity<RequiredpurchaseTools>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseTools)
                //.WithOptional(e => e.RequiredpurchaseTools)
                //.HasForeignKey(e => e.RequiredpurchaseTools_Id);

            modelBuilder.Entity<RequiredpurchaseTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsRequiredpurchases)
                //.WithOptional(e => e.RequiredpurchaseTools)
                //.HasForeignKey(e => e.RequiredpurchaseTools_Id);

            modelBuilder.Entity<ReturnItems>().MapToStoredProcedures();
                //.HasMany(e => e.ItemsReturnItems)
                //.WithOptional(e => e.ReturnItems)
                //.HasForeignKey(e => e.ReturnItems_Id);

            modelBuilder.Entity<ReturnTools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsReturnTools)
                //.WithOptional(e => e.ReturnTools)
                //.HasForeignKey(e => e.ReturnTools_MyProperty);

            modelBuilder.Entity<Rooms>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts)
                //.WithOptional(e => e.Rooms)
                //.HasForeignKey(e => e.Room_Id);

            modelBuilder.Entity<Rooms>().MapToStoredProcedures();
                //.HasMany(e => e.RoomMachins)
                //.WithOptional(e => e.Rooms)
                //.HasForeignKey(e => e.Room_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.CashCoes)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.CashReturns)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.ListReps)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCoes)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.MonthMachinCoes)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseItems)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseTools)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseItems)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseMachins)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseTools)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnItems)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<SalesReps>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnMachins)
                //.WithOptional(e => e.SalesReps)
                //.HasForeignKey(e => e.SalesRep_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.CashCoes)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.CashEmps)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.CashOthers)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.CashReturns)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ConvItems)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ConvItems1)
                //.WithOptional(e => e.Sections1)
                //.HasForeignKey(e => e.SectionTo_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ConvMachins)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ConvMachins1)
                //.WithOptional(e => e.Sections1)
                //.HasForeignKey(e => e.SectionTo_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ConvTools)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ConvTools1)
                //.WithOptional(e => e.Sections1)
                //.HasForeignKey(e => e.SectionTo_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.DateCalls)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.Employees)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.GzaEmps)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ListCusts)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ListOthers)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ListReps)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCoes)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCusts)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.MonthMachinCoes)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseItems)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseTools)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseItems)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseMachins)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseTools)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnItems)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnMachins)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.RoomMachins)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.SalesReps)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Sections>().MapToStoredProcedures();
                //.HasMany(e => e.SolEmps)
                //.WithOptional(e => e.Sections)
                //.HasForeignKey(e => e.Section_Id);

            modelBuilder.Entity<Tools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsConvs)
                //.WithOptional(e => e.Tools)
                //.HasForeignKey(e => e.Tools_Id);

            modelBuilder.Entity<Tools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsPurchases)
                //.WithOptional(e => e.Tools)
                //.HasForeignKey(e => e.Tools_Id);

            modelBuilder.Entity<Tools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsRequiredpurchases)
                //.WithOptional(e => e.Tools)
                //.HasForeignKey(e => e.Tools_Id);

            modelBuilder.Entity<Tools>().MapToStoredProcedures();
                //.HasMany(e => e.ToolsReturnTools)
                //.WithOptional(e => e.Tools)
                //.HasForeignKey(e => e.Tools_Id);

            modelBuilder.Entity<TypeOPrations>().MapToStoredProcedures();
                //.HasMany(e => e.CashCoes)
                //.WithOptional(e => e.TypeOPrations)
                //.HasForeignKey(e => e.TypeOPration_Id);

            modelBuilder.Entity<TypeOPrations>().MapToStoredProcedures();
                //.HasMany(e => e.CashReturns)
                //.WithOptional(e => e.TypeOPrations)
                //.HasForeignKey(e => e.TypeOPration_Id);

            modelBuilder.Entity<TypeUnits>().MapToStoredProcedures();
                //.HasMany(e => e.Items)
                //.WithOptional(e => e.TypeUnits)
                //.HasForeignKey(e => e.TypeUnit_Id);

            modelBuilder.Entity<TypeUnits>().MapToStoredProcedures();
                //.HasMany(e => e.Tools)
                //.WithOptional(e => e.TypeUnits)
                //.HasForeignKey(e => e.TypeUnit_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashCoes)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashCoes1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashEmps)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashEmps1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashOthers)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashOthers1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashReturns)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CashReturns1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CatItems)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.CatItems1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Companies)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Companies1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ConvItems)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ConvItems1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ConvMachins)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ConvMachins1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ConvTools)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ConvTools1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Courses)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Courses1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DateCalls)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DateCalls1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Diagnosis)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Diagnosis1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DocCusts1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DocOthers)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DocOthers1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DocReps)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.DocReps1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Employees)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Employees1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Exps)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Exps1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.GzaEmps)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.GzaEmps1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Items)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Items1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ListCusts)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ListCusts1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ListOthers)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ListOthers1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ListReps)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ListReps1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Machins)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Machins1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCoes)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCoes1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCusts)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.MonthCusts1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.MonthMachinCoes)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.MonthMachinCoes1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Pations)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Pations1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Prices)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Prices1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseItems)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseItems1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseMachins1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseTools)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.PurchaseTools1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseItems)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseItems1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseMachins)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseMachins1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseTools)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RequiredpurchaseTools1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnItems)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnItems1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnMachins)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnMachins1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnTools)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.ReturnTools1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RoomMachins)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.RoomMachins1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Rooms)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Rooms1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.SalesReps)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.SalesReps1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Sections)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Sections1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.SolEmps)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.SolEmps1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Tools)
                //.WithOptional(e => e.Users)
                //.HasForeignKey(e => e.UserAdd_Id);

            modelBuilder.Entity<Users>().MapToStoredProcedures();
                //.HasMany(e => e.Tools1)
                //.WithOptional(e => e.Users1)
                //.HasForeignKey(e => e.UserUpdate_Id);
        }
    }
}
