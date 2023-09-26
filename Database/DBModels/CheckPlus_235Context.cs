using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CheckPlus_235Context : DbContext
    {
        public CheckPlus_235Context()
        {
        }

        public CheckPlus_235Context(DbContextOptions<CheckPlus_235Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AchbatchCntrlRec> AchbatchCntrlRecs { get; set; }
        public virtual DbSet<AchbatchDetail> AchbatchDetails { get; set; }
        public virtual DbSet<AchbatchHeadRec> AchbatchHeadRecs { get; set; }
        public virtual DbSet<AchfileCntrlRec> AchfileCntrlRecs { get; set; }
        public virtual DbSet<AchfileHeadRec> AchfileHeadRecs { get; set; }
        public virtual DbSet<Achqueue> Achqueues { get; set; }
        public virtual DbSet<Achtemplate> Achtemplates { get; set; }
        public virtual DbSet<AsaltSignat> AsaltSignats { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AuthSignBank> AuthSignBanks { get; set; }
        public virtual DbSet<AuthSignCompany> AuthSignCompanies { get; set; }
        public virtual DbSet<AuthSignature> AuthSignatures { get; set; }
        public virtual DbSet<AutoNum> AutoNums { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BatchSignatory> BatchSignatories { get; set; }
        public virtual DbSet<BtchDet> BtchDets { get; set; }
        public virtual DbSet<CbooksBankFin> CbooksBankFins { get; set; }
        public virtual DbSet<CbooksBranchesFin> CbooksBranchesFins { get; set; }
        public virtual DbSet<CbooksCbooksPrint> CbooksCbooksPrints { get; set; }
        public virtual DbSet<CbooksCbooksReq> CbooksCbooksReqs { get; set; }
        public virtual DbSet<CbooksChkBooksEntry> CbooksChkBooksEntries { get; set; }
        public virtual DbSet<CbooksImportHeader> CbooksImportHeaders { get; set; }
        public virtual DbSet<CbooksMicrline> CbooksMicrlines { get; set; }
        public virtual DbSet<CbooksSynonym> CbooksSynonyms { get; set; }
        public virtual DbSet<CbooksTypeOfAccount> CbooksTypeOfAccounts { get; set; }
        public virtual DbSet<ChecksD1> ChecksD1s { get; set; }
        public virtual DbSet<ChecksH3> ChecksH3s { get; set; }
        public virtual DbSet<ClientLocation> ClientLocations { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CustomFont> CustomFonts { get; set; }
        public virtual DbSet<DatabasesC> DatabasesCs { get; set; }
        public virtual DbSet<EAlertAuditLog> EAlertAuditLogs { get; set; }
        public virtual DbSet<EAlertCustom> EAlertCustoms { get; set; }
        public virtual DbSet<EAlertEmail> EAlertEmails { get; set; }
        public virtual DbSet<EAlertEvent> EAlertEvents { get; set; }
        public virtual DbSet<EAlertWildcard> EAlertWildcards { get; set; }
        public virtual DbSet<EalertsSamplePatern> EalertsSamplePaterns { get; set; }
        public virtual DbSet<ElegiblePrinter> ElegiblePrinters { get; set; }
        public virtual DbSet<EmailCustomization> EmailCustomizations { get; set; }
        public virtual DbSet<EmailPref> EmailPrefs { get; set; }
        public virtual DbSet<EventsSource> EventsSources { get; set; }
        public virtual DbSet<FeesTable> FeesTables { get; set; }
        public virtual DbSet<FieldsList> FieldsLists { get; set; }
        public virtual DbSet<Fontlist> Fontlists { get; set; }
        public virtual DbSet<FormItemEntity> FormItemEntities { get; set; }
        public virtual DbSet<Format> Formats { get; set; }
        public virtual DbSet<FtptransProf> FtptransProfs { get; set; }
        public virtual DbSet<GenParBlank> GenParBlanks { get; set; }
        public virtual DbSet<GenParamManCheck> GenParamManChecks { get; set; }
        public virtual DbSet<GenSysPar> GenSysPars { get; set; }
        public virtual DbSet<GenSysUser> GenSysUsers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupRight> GroupRights { get; set; }
        public virtual DbSet<IeScreenDet> IeScreenDets { get; set; }
        public virtual DbSet<IeScreenHead> IeScreenHeads { get; set; }
        public virtual DbSet<Iedetail> Iedetails { get; set; }
        public virtual DbSet<Ieheader> Ieheaders { get; set; }
        public virtual DbSet<IelayoutLineItemX> IelayoutLineItemXes { get; set; }
        public virtual DbSet<IelayoutLineheader> IelayoutLineheaders { get; set; }
        public virtual DbSet<IelayoutlineItem> IelayoutlineItems { get; set; }
        public virtual DbSet<IesortDefinit> IesortDefinits { get; set; }
        public virtual DbSet<Ietemplate> Ietemplates { get; set; }
        public virtual DbSet<ImpCheckLog> ImpCheckLogs { get; set; }
        public virtual DbSet<ImportHeader> ImportHeaders { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MicrlineLayout> MicrlineLayouts { get; set; }
        public virtual DbSet<OutDataMapMaindet> OutDataMapMaindets { get; set; }
        public virtual DbSet<OutDataMapMainhead> OutDataMapMainheads { get; set; }
        public virtual DbSet<OutMapDetailsStub> OutMapDetailsStubs { get; set; }
        public virtual DbSet<OutMapHeadStub> OutMapHeadStubs { get; set; }
        public virtual DbSet<Payee> Payees { get; set; }
        public virtual DbSet<Payor> Payors { get; set; }
        public virtual DbSet<PclCheck> PclChecks { get; set; }
        public virtual DbSet<PclStub> PclStubs { get; set; }
        public virtual DbSet<PosPayProf> PosPayProfs { get; set; }
        public virtual DbSet<PropertyPcl> PropertyPcls { get; set; }
        public virtual DbSet<ReconcBtchDet> ReconcBtchDets { get; set; }
        public virtual DbSet<ReconcChecksH3> ReconcChecksH3s { get; set; }
        public virtual DbSet<ReconcImportHeader> ReconcImportHeaders { get; set; }
        public virtual DbSet<ReportsXright> ReportsXrights { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<SignComboD> SignComboDs { get; set; }
        public virtual DbSet<SignComboH> SignComboHs { get; set; }
        public virtual DbSet<SignatCostCenter> SignatCostCenters { get; set; }
        public virtual DbSet<SynLinkChildDoc> SynLinkChildDocs { get; set; }
        public virtual DbSet<Synonym> Synonyms { get; set; }
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }
        public virtual DbSet<TemplatesxPrinter> TemplatesxPrinters { get; set; }
        public virtual DbSet<TemplatesxPrintersAll> TemplatesxPrintersAlls { get; set; }
        public virtual DbSet<TemplatesxPrintersByUsersCheckBook> TemplatesxPrintersByUsersCheckBooks { get; set; }
        public virtual DbSet<TemplatesxPrintersByUsersManageCheck> TemplatesxPrintersByUsersManageChecks { get; set; }
        public virtual DbSet<TemplatesxPrintersPcsNetwork> TemplatesxPrintersPcsNetworks { get; set; }
        public virtual DbSet<TemplatesxPrintersSplit> TemplatesxPrintersSplits { get; set; }
        public virtual DbSet<TemplxPrinterSecurityFeat> TemplxPrinterSecurityFeats { get; set; }
        public virtual DbSet<TraysXlayoutPool> TraysXlayoutPools { get; set; }
        public virtual DbSet<TypesAccount> TypesAccounts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserPassHistory> UserPassHistories { get; set; }
        public virtual DbSet<UserRight> UserRights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433; Database=CheckPlus_235; User Id=sa; Password=Joni1501");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(x => new { x.BankId, x.AccountId });

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .HasColumnName("Account_ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(70)
                    .HasColumnName("Account_Name");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Account_Number");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(10)
                    .HasColumnName("BranchID");

                entity.Property(e => e.CheckType).HasMaxLength(10);

                entity.Property(e => e.CheckTypf).HasMaxLength(10);

                entity.Property(e => e.CheckbookId).HasMaxLength(15);

                entity.Property(e => e.Filler1)
                    .HasMaxLength(8)
                    .HasColumnName("filler1");

                entity.Property(e => e.Filler2)
                    .HasMaxLength(10)
                    .HasColumnName("FILLER2");

                entity.Property(e => e.FirstCheckNo)
                    .HasColumnType("smallmoney")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.FontId)
                    .HasMaxLength(10)
                    .HasColumnName("FontID");

                entity.Property(e => e.Laguage).HasMaxLength(15);

                entity.Property(e => e.Line2).HasMaxLength(30);

                entity.Property(e => e.Line3).HasMaxLength(30);

                entity.Property(e => e.Line4).HasMaxLength(30);

                entity.Property(e => e.LineAddr1).HasMaxLength(30);

                entity.Property(e => e.Mask).HasMaxLength(24);

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID");
            });

            modelBuilder.Entity<AchbatchCntrlRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACHBatch_cntrl_rec");

                entity.Property(e => e.BatchNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(10)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EntryAddendaCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryHash)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.MessageAuthCd)
                    .HasMaxLength(19)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginatingDfiId)
                    .HasMaxLength(8)
                    .HasColumnName("OriginatingDFI_Id")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Reserved)
                    .HasMaxLength(6)
                    .HasColumnName("RESERVED")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServiceClassCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotCreditAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotDebitAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<AchbatchDetail>(entity =>
            {
                entity.HasKey(x => x.BatchId);

                entity.ToTable("ACHBatchDetails");

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("Batch_ID");

                entity.Property(e => e.AchwhileProcessingFl)
                    .HasColumnName("ACHwhileProcessingFL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllAchGeneratedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.AllChecksPrintedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Alpha12)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AutorizedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchImportDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.BatchPostedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.BatchPurgeDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchPurgedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Date1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler15)
                    .HasMaxLength(15)
                    .HasColumnName("FILLER15")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ImportDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logical1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Numeric10)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.OtherInfo)
                    .HasMaxLength(78)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password1)
                    .HasMaxLength(10)
                    .HasColumnName("password1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password2)
                    .HasMaxLength(10)
                    .HasColumnName("password2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(10)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Posted2AchbookQ)
                    .HasColumnName("Posted2ACHbookQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerRefresedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Time1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Time2).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAcknowledged)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotalAmountValue)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotalChecksInBatch).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserBatchId)
                    .HasMaxLength(14)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Batch)
                    .WithOne(p => p.AchbatchDetail)
                    .HasForeignKey<AchbatchDetail>(x => x.BatchId)
                    .HasConstraintName("FK_ACHBatchDetails_ACHBatchDetails");
            });

            modelBuilder.Entity<AchbatchHeadRec>(entity =>
            {
                entity.HasKey(x => x.BatchNumber);

                entity.ToTable("ACHbatch_head_rec");

                entity.HasIndex(x => x.BatchNumber, "key0")
                    .IsUnique()
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BatchNumber).ValueGeneratedNever();

                entity.Property(e => e.CompanyDescriptiveDa)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyDiscretionary)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyEntryDescript)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyIdentificatio)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EffectiveEntryDate)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginatingDfiIdent)
                    .HasMaxLength(8)
                    .HasColumnName("OriginatingDFI_Ident")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginatorStatusCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServiceClassCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.SettlementDateJulia)
                    .HasColumnName("SettlementDate(Julia")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StandardEntryClassCo)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<AchfileCntrlRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACHFile_Cntrl_rec");

                entity.Property(e => e.BatchCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BlockCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryAddendaCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryHash)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.RecordTypeCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Reserved)
                    .HasMaxLength(39)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TopCreditAmnt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotDebitAmnt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");
            });

            modelBuilder.Entity<AchfileHeadRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACHfile_head_rec");

                entity.Property(e => e.BlockingFactor)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FileCreationDate)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FileCreationTime)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FileIdmodifier)
                    .HasMaxLength(1)
                    .HasColumnName("FileIDModifier")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FormatCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateDestination)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateDestinatioo)
                    .HasMaxLength(23)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateOrigin)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateOriginName)
                    .HasMaxLength(23)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PriorityCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordSize)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReferenceCode)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Achqueue>(entity =>
            {
                entity.HasKey(x => new { x.BatchId, x.RecordNo });

                entity.ToTable("ACHQueue");

                entity.Property(e => e.BatchId).HasColumnName("Batch_ID");

                entity.Property(e => e.RecordNo).HasColumnName("Record_No");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Account_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(35)
                    .HasColumnName("Account_Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchStdEntryClassCode)
                    .HasMaxLength(3)
                    .HasColumnName("achStdEntryClassCode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchTranCode)
                    .HasMaxLength(2)
                    .HasColumnName("achTranCode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchTypeAcct)
                    .HasMaxLength(1)
                    .HasColumnName("achTypeAcct")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchaddendaQ)
                    .HasColumnName("ACHAddendaQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Achq)
                    .HasColumnName("ACHQ")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.AchreEnableQ)
                    .HasColumnName("ACHRe_EnableQ")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.AchroutingCdv)
                    .HasMaxLength(1)
                    .HasColumnName("ACHroutingCDV")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AdditionalUserId)
                    .HasMaxLength(10)
                    .HasColumnName("AdditionalUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankAddr1)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankAddr2)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankName)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BatchIdr)
                    .HasColumnName("BatchIDR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cdv2)
                    .HasMaxLength(2)
                    .HasColumnName("CDV2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CdvAccountNo)
                    .HasMaxLength(2)
                    .HasColumnName("CDV_Account_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CheckAmountAlpha)
                    .HasMaxLength(120)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckDateAlpha)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckDateYear).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(22)
                    .HasColumnName("Check_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckPrintedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1))")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.CheckType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClaimOrPurchaseOrde)
                    .HasColumnName("Claim_orPurchaseOrde")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept1)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept2)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept3)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept4)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsecutiveNumber)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Contact)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CopyPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenter4Sign)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Counter).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateAlphaY2k)
                    .HasMaxLength(30)
                    .HasColumnName("DateAlphaY2K")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DfiacctNo)
                    .HasMaxLength(17)
                    .HasColumnName("DFIacctNo")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DirectDepositAccNumb)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DirectDepositBankNam)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Discounttotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.DontSendEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.EarnDeductAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EncryptAmount).HasMaxLength(100);

                entity.Property(e => e.EncryptCheckNo).HasMaxLength(100);

                entity.Property(e => e.EncryptPayee).HasMaxLength(140);

                entity.Property(e => e.ExportQ).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Filler15)
                    .HasMaxLength(33)
                    .HasColumnName("filler15")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ForTheAccountOf)
                    .HasMaxLength(75)
                    .HasColumnName("For_the_account_of")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GlCredit)
                    .HasColumnType("money")
                    .HasColumnName("GL_Credit")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.GlDebit)
                    .HasColumnType("money")
                    .HasColumnName("GL_Debit")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.GlacctReference)
                    .HasMaxLength(40)
                    .HasColumnName("GLAcctReference")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Grosstotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ImportDate)
                    .HasColumnName("Import_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Irscode)
                    .HasMaxLength(6)
                    .HasColumnName("IRScode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NumberofSignatures).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayeeAddr1)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr2)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr3)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr4)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr5)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeId)
                    .HasMaxLength(22)
                    .HasColumnName("PayeeID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeName)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("('VOID VOID')");

                entity.Property(e => e.PayeeName2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorName)
                    .HasMaxLength(70)
                    .HasColumnName("Payor_Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Pdfname)
                    .HasMaxLength(100)
                    .HasColumnName("PDFName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PdfuniqueNameQ)
                    .HasColumnName("PDFUniqueNameQ")
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.PositivePayQ).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Printed).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedBy)
                    .HasMaxLength(5)
                    .HasColumnName("Printed_By")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedDate)
                    .HasColumnName("Printed_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedDateAlpha)
                    .HasMaxLength(8)
                    .HasColumnName("Printed_DateAlpha")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedTime)
                    .HasMaxLength(8)
                    .HasColumnName("Printed_Time")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedType)
                    .HasMaxLength(1)
                    .HasColumnName("Printed_Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProcessTime)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(8)
                    .HasColumnName("Program_Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrintDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(N'getdate()')")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.RePrintReason)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrintUserId)
                    .HasMaxLength(10)
                    .HasColumnName("RePrintUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceivingDfi)
                    .HasMaxLength(9)
                    .HasColumnName("ReceivingDFI")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReconcDate)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReconciledQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordNoR).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReprintCount).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RequesterUser)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RoutingNumberMicr)
                    .HasMaxLength(12)
                    .HasColumnName("RoutingNumberMICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature1)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature2)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SpecialLongDescripti)
                    .HasMaxLength(180)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .HasColumnName("SSN")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.State)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StringAmount2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StringAmount3)
                    .HasMaxLength(27)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ToBePrinted)
                    .HasColumnName("To_Be_Printed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transit1)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Transit2)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us1200)
                    .HasMaxLength(200)
                    .HasColumnName("US1200")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us2100)
                    .HasMaxLength(100)
                    .HasColumnName("US2100")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us3100)
                    .HasMaxLength(100)
                    .HasColumnName("US3100")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us4200)
                    .HasMaxLength(200)
                    .HasColumnName("US4200")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserFieldMicr)
                    .HasMaxLength(15)
                    .HasColumnName("UserFieldMICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr10).HasMaxLength(100);

                entity.Property(e => e.UserStr11).HasMaxLength(50);

                entity.Property(e => e.UserStr12).HasMaxLength(50);

                entity.Property(e => e.UserStr13).HasMaxLength(50);

                entity.Property(e => e.UserStr14).HasMaxLength(50);

                entity.Property(e => e.UserStr15).HasMaxLength(50);

                entity.Property(e => e.UserStr16)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr17)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr18)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr19)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr20)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr5).HasMaxLength(100);

                entity.Property(e => e.UserStr6).HasMaxLength(100);

                entity.Property(e => e.UserStr7).HasMaxLength(100);

                entity.Property(e => e.UserStr8).HasMaxLength(100);

                entity.Property(e => e.UserStr9).HasMaxLength(100);

                entity.Property(e => e.UserVal13)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal14)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal15)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserbatchId)
                    .HasMaxLength(24)
                    .HasColumnName("UserbatchID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Userval1)
                    .HasColumnType("money")
                    .HasColumnName("USERval1")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval10)
                    .HasColumnType("money")
                    .HasColumnName("USERval10")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval11)
                    .HasColumnType("money")
                    .HasColumnName("USERval11")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval12)
                    .HasColumnType("money")
                    .HasColumnName("USERval12")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval16)
                    .HasColumnType("money")
                    .HasColumnName("USERval16")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval17)
                    .HasColumnType("money")
                    .HasColumnName("USERval17")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval18)
                    .HasColumnType("money")
                    .HasColumnName("USERval18")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval2)
                    .HasColumnType("money")
                    .HasColumnName("USERval2")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval3)
                    .HasColumnType("money")
                    .HasColumnName("USERval3")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval4)
                    .HasColumnType("money")
                    .HasColumnName("USERval4")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval5)
                    .HasColumnType("money")
                    .HasColumnName("USERval5")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval6)
                    .HasColumnType("money")
                    .HasColumnName("USERval6")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval7)
                    .HasColumnType("money")
                    .HasColumnName("USERval7")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval8)
                    .HasColumnType("money")
                    .HasColumnName("USERval8")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval9)
                    .HasColumnType("money")
                    .HasColumnName("USERval9")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.VendorRedundant)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_Redundant")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Void)
                    .HasColumnName("VOID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VoidDate)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VoucherOrPurOrder)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WhileProcessingVoi)
                    .HasColumnName("While_Processing_Voi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhileSigningFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.Achqueues)
                    .HasForeignKey(x => x.BatchId)
                    .HasConstraintName("FK_ACHQueue_BtchDet");
            });

            modelBuilder.Entity<Achtemplate>(entity =>
            {
                entity.HasKey(x => new { x.StdEntryClassCode5, x.ProjectKey });

                entity.ToTable("ACHTemplate");

                entity.Property(e => e.StdEntryClassCode5)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Achmanager)
                    .HasMaxLength(3)
                    .HasColumnName("ACHManager")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BatchCount9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchNumber5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchNumber8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BentryAddendaCount8)
                    .HasColumnName("BEntryAddendaCount8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BlockCount9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BlockingFactor4)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckDigit6).HasMaxLength(1);

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column6)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyDescriptiveDa)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyDiscretionary)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyEntryDescript)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyIdent5)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyIdentificatio)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyName5)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DfiaccountNumber6)
                    .HasMaxLength(17)
                    .HasColumnName("DFIaccountNumber6");

                entity.Property(e => e.DiscretionaryData6).HasMaxLength(2);

                entity.Property(e => e.EffectiveEntryDate5)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EncrDailyProcedureNa).HasMaxLength(10);

                entity.Property(e => e.EncrFiller).HasMaxLength(48);

                entity.Property(e => e.EncrInitProcedureNam).HasMaxLength(10);

                entity.Property(e => e.EncrLog).HasMaxLength(16);

                entity.Property(e => e.EncrPath).HasMaxLength(80);

                entity.Property(e => e.EncrUseridPgp)
                    .HasMaxLength(40)
                    .HasColumnName("EncrUseridPGP");

                entity.Property(e => e.EntryHash8).HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryHash9).HasDefaultValueSql("((0))");

                entity.Property(e => e.FentryAddendaCount9)
                    .HasColumnName("FEntryAddendaCount9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FileCreationDate4)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FileCreationTime4)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FileFormatCode)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FileIdmodifier4)
                    .HasMaxLength(1)
                    .HasColumnName("FileIDmodifier4")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerCompanyBatchco)
                    .HasMaxLength(48)
                    .HasColumnName("fillerCompanyBATCHco")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerCompanyBatchhe)
                    .HasMaxLength(48)
                    .HasColumnName("fillerCompanyBATCHhe")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerCtxaddendaRec7)
                    .HasMaxLength(48)
                    .HasColumnName("fillerCTXaddendaRec7");

                entity.Property(e => e.FillerCtxentryDetail)
                    .HasMaxLength(48)
                    .HasColumnName("fillerCTXentryDetail")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerEncriptionSect)
                    .HasMaxLength(46)
                    .HasColumnName("fillerEncriptionSect");

                entity.Property(e => e.FillerFilecontrolRec)
                    .HasMaxLength(48)
                    .HasColumnName("FillerFILEcontrolRec")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerFileheaderReco)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerFtpsection)
                    .HasMaxLength(128)
                    .HasColumnName("FillerFTPsection");

                entity.Property(e => e.Fillercnt)
                    .HasMaxLength(132)
                    .HasColumnName("FILLERcnt");

                entity.Property(e => e.FormatCode4)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FtpCommandName)
                    .HasMaxLength(16)
                    .HasColumnName("ftpCommandName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FtpFile2receive)
                    .HasMaxLength(80)
                    .HasColumnName("ftpFile2receive")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FtpFile2send)
                    .HasMaxLength(80)
                    .HasColumnName("ftpFile2send")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FtpLogname)
                    .HasMaxLength(16)
                    .HasColumnName("ftpLogname")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FtpPacingDelay)
                    .HasColumnName("ftpPacingDelay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FtpPassword)
                    .HasMaxLength(24)
                    .HasColumnName("ftpPassword");

                entity.Property(e => e.FtpScriptName)
                    .HasMaxLength(16)
                    .HasColumnName("ftpScriptName");

                entity.Property(e => e.FtpServerName)
                    .HasMaxLength(64)
                    .HasColumnName("ftpServerName");

                entity.Property(e => e.FtpStartAt)
                    .HasColumnName("ftpStartAt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FtpUserId)
                    .HasMaxLength(20)
                    .HasColumnName("ftpUserId");

                entity.Property(e => e.IdentNumber6).HasMaxLength(15);

                entity.Property(e => e.InmediateDestination)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateDestinatioo)
                    .HasMaxLength(23)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateOrigin4)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateOriginName4)
                    .HasMaxLength(23)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastFiller)
                    .HasMaxLength(298)
                    .HasColumnName("lastFILLER")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MsgAuthenticCode8)
                    .HasMaxLength(19)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginatDfiident8)
                    .HasMaxLength(8)
                    .HasColumnName("OriginatDFIident8")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginatingDfiident5)
                    .HasMaxLength(8)
                    .HasColumnName("OriginatingDFIident5")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginatorStatusCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Path4outputFile).HasMaxLength(80);

                entity.Property(e => e.PaymentRelatedInfo7).HasMaxLength(80);

                entity.Property(e => e.PickRoutingAcctValue).HasMaxLength(1);

                entity.Property(e => e.PriorityCode4)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PublicKey4PaymentsGa)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'(N'')0')");

                entity.Property(e => e.ReceivingDfiident6)
                    .HasMaxLength(8)
                    .HasColumnName("ReceivingDFIident6")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecevingCompanyNameI).HasMaxLength(16);

                entity.Property(e => e.RecordSize4)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode4)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode5)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode6)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode7).HasMaxLength(1);

                entity.Property(e => e.RecordTypeCode8)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordTypeCode9)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReferenceCode4)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Reserved6).HasMaxLength(2);

                entity.Property(e => e.Reserved8)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Reserved9)
                    .HasMaxLength(39)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServiceClassCode5)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServiceClassCode8)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SettlementDateJulian)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TotCreditAmtFile9)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotDebitAmtFile9)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotalAmount6)
                    .HasColumnType("money")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotalCreditAmount8)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TotalDebitAmount8)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TraceNumber6)
                    .HasColumnType("money")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TransactionCode6)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransmitterId)
                    .HasColumnName("TransmitterID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AsaltSignat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ASAltSignat");

                entity.Property(e => e.AltSignatoryalt).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssignedQalt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtendedAmountLimita)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.FillerAs)
                    .HasMaxLength(13)
                    .HasColumnName("fillerAs")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.SignatureFontIdalt)
                    .HasColumnName("SignatureFontIDalt")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasKey(x => x.AtransactNo);

                entity.ToTable("Audit");

                entity.HasIndex(x => x.AuditDateTime, "AuditDate")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.AtransactNo).HasColumnName("ATransactNo");

                entity.Property(e => e.Adate)
                    .HasColumnName("ADate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AeditType)
                    .HasMaxLength(20)
                    .HasColumnName("AEditType")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AobjectId)
                    .HasColumnName("AObjectID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArecordId)
                    .HasMaxLength(15)
                    .HasColumnName("ARecordID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Atime)
                    .HasColumnName("ATime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Audit_DateTime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.AuserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldChangeString).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<AuthSignBank>(entity =>
            {
                entity.HasKey(x => new { x.FontId, x.BankId });

                entity.Property(e => e.FontId).HasColumnName("FontID");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID");

                entity.Property(e => e.AcoountId)
                    .HasMaxLength(16)
                    .HasColumnName("Acoount_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AssignedQbnk).HasDefaultValueSql("((0))");

                entity.Property(e => e.Filler1)
                    .HasMaxLength(31)
                    .HasColumnName("filler1")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<AuthSignCompany>(entity =>
            {
                entity.HasKey(x => new { x.FontId, x.PayorId });

                entity.Property(e => e.FontId).HasColumnName("FontID");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID");

                entity.Property(e => e.AssignedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Filler1)
                    .HasMaxLength(35)
                    .HasColumnName("filler1")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<AuthSignature>(entity =>
            {
                entity.HasKey(x => x.FontId);

                entity.HasIndex(x => new { x.ActiveQ, x.LowValueRange, x.HighValueRange }, "AuthSig_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.FontId)
                    .ValueGeneratedNever()
                    .HasColumnName("FontID");

                entity.Property(e => e.ActivationChars)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("(N'A')");

                entity.Property(e => e.ActiveQ).HasDefaultValueSql("((1))");

                entity.Property(e => e.HighValueRange)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Initials)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LowValueRange)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PrimaryOrSecondary)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordCreatedModifie).HasDefaultValueSql("((0))");

                entity.Property(e => e.SignatureAccompanyMe)
                    .HasMaxLength(65)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SignatureDescription)
                    .HasMaxLength(65)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Spare1)
                    .HasMaxLength(51)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Waiting4ReplicationQ).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AutoNum>(entity =>
            {
                entity.ToTable("AutoNum");

                entity.Property(e => e.AutonumId)
                    .ValueGeneratedNever()
                    .HasColumnName("autonumID");

                entity.Property(e => e.AutoDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("autoDescription")
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.NextNumber).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasIndex(x => new { x.BankName, x.FontId, x.AddendaYesNo }, "Banks_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID");

                entity.Property(e => e.AddendaNoLines)
                    .HasColumnName("Addenda_No_Lines")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddendaYesNo)
                    .HasColumnName("Addenda_YesNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Address1)
                    .HasMaxLength(70)
                    .HasColumnName("Address_1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Address2)
                    .HasMaxLength(70)
                    .HasColumnName("Address_2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Address3)
                    .HasMaxLength(70)
                    .HasColumnName("Address_3")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Address4)
                    .HasMaxLength(70)
                    .HasColumnName("Address_4")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(3)
                    .HasColumnName("Bank_Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankName)
                    .HasMaxLength(70)
                    .HasColumnName("Bank_Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BranchOfficeCode)
                    .HasMaxLength(3)
                    .HasColumnName("Branch_Office_Code")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DefAccountMask)
                    .HasMaxLength(24)
                    .HasColumnName("Def_Account_Mask")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DefTransitMicr)
                    .HasMaxLength(9)
                    .HasColumnName("Def_Transit_MICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DefUserMicrValue)
                    .HasMaxLength(15)
                    .HasColumnName("Def_User_Micr_Value")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DutyStampFontId)
                    .HasColumnName("Duty_Stamp_FontID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Filler1)
                    .HasMaxLength(30)
                    .HasColumnName("filler1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler2)
                    .HasMaxLength(16)
                    .HasColumnName("filler2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FontId)
                    .HasColumnName("FontID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastCheckNo)
                    .HasColumnName("Last_Check_No")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MicrFont)
                    .HasMaxLength(1)
                    .HasColumnName("MICR_Font")
                    .HasDefaultValueSql("(N'E')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.StampDuty)
                    .HasColumnName("Stamp_Duty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactFraction1)
                    .HasMaxLength(10)
                    .HasColumnName("Transact_Fraction_1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransactFraction2)
                    .HasMaxLength(10)
                    .HasColumnName("Transact_Fraction_2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransactFraction3)
                    .HasMaxLength(10)
                    .HasColumnName("Transact_Fraction_3")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<BatchSignatory>(entity =>
            {
                entity.HasKey(x => new { x.BatchId, x.RecordNo, x.UserId });

                entity.HasIndex(x => x.FontId, "BatchSign_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BatchId).HasColumnName("Batch_ID");

                entity.Property(e => e.RecordNo).HasColumnName("Record_No");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID");

                entity.Property(e => e.DateBs)
                    .HasColumnName("DateBS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableOrDisable).HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerBs)
                    .HasMaxLength(28)
                    .HasColumnName("fillerBS")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FontId)
                    .HasColumnName("fontID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrimaryOrSecondary)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TimeBs)
                    .HasColumnName("TimeBS")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.BatchSignatories)
                    .HasForeignKey(x => x.BatchId)
                    .HasConstraintName("FK_BatchSignatories_BtchDet1");
            });

            modelBuilder.Entity<BtchDet>(entity =>
            {
                entity.HasKey(x => x.BatchId);

                entity.ToTable("BtchDet");

                entity.HasIndex(x => new { x.BatchImportDateTime, x.BatchPostedDateTime, x.Description, x.AllChecksBatchPrinte }, "BtchDet_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("Batch_ID");

                entity.Property(e => e.AchGeneratedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.AchwhileprocessingFl)
                    .HasColumnName("ACHwhileprocessingFL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllChecksBatchPrinte).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutorizedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchImportDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.BatchPostedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.BatchPurgeDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchPurgedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.CopyprintedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.DatePosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.DatePostedReptPrinte).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler9915)
                    .HasMaxLength(15)
                    .HasColumnName("FILLER99_15")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GpbatchId)
                    .HasMaxLength(22)
                    .HasColumnName("GPBatchId")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Gpdate)
                    .HasColumnName("GPDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherInfo)
                    .HasMaxLength(78)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password1)
                    .HasMaxLength(10)
                    .HasColumnName("password1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password2)
                    .HasMaxLength(10)
                    .HasColumnName("password2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PostedTobookQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostingGroupId)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ServerRefresedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimePosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimePostedReportPrin).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalChecksinBatch).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalacknowledged)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Totalamountvalue)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TypeofBatch)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Userbatchid)
                    .HasMaxLength(14)
                    .HasColumnName("userbatchid")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CbooksBankFin>(entity =>
            {
                entity.HasKey(x => x.BankId);

                entity.ToTable("CBooks_BankFin");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BankID");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ApplF)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankName)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BranchOfficeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DefaultCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FontId)
                    .HasColumnName("FontID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransitFraccion1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransitFraccion2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransitFraccion3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransitMicr)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TransitMICR")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CbooksBranchesFin>(entity =>
            {
                entity.HasKey(x => new { x.BankId, x.BranchId });

                entity.ToTable("CBooks_BranchesFin");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BankID");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BranchID");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Brtransit1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRtransit1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Brtransit2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRtransit2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Brtransit3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRtransit3")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BrtransitMicr)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("BRtransitMICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckSeqNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Fillerb)
                    .HasMaxLength(170)
                    .IsUnicode(false)
                    .HasColumnName("fillerb")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FontId)
                    .HasColumnName("FontID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CbooksCbooksPrint>(entity =>
            {
                entity.HasKey(x => x.BatchId);

                entity.ToTable("CBooks_CBooksPrint");

                entity.HasIndex(x => new { x.CustName1, x.BankId, x.Checks2Print, x.TypeAccount, x.CheckStatus, x.CurrencyId }, "IDX2")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Applicat)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CBook')");

                entity.Property(e => e.BankId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BankID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BaseCurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("BaseCurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BaseCurrencyPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BranchID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckBookPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CheckLayoutNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ChkbookDescript)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chkbookDescript")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreationDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.CurrencyId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyIdexchange)
                    .HasColumnType("money")
                    .HasColumnName("CurrencyIDExchange")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CustName1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustName2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustNameLegal)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerName3)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EndCheckNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndChkNoCompute)
                    .HasColumnName("EndChkNo_Compute")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Filler)
                    .HasMaxLength(113)
                    .IsUnicode(false)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FlgprintNotAllowed)
                    .HasColumnName("flgprintNotAllowed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InhibitPrintFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.InitialCheckNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.LayoutId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OperationDateTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PriceStyle1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PriceStyle2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PriceStyle3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PrintedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Processtime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.RecordNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReprintControlFlag)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestTimeUsrAlph5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RoutingTransitInfo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SelectedStyle)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.Property(e => e.Source)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TypeAccount)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserAlpah432)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserAlpha164)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserAlpha264)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserAlpha336)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserVal1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal4)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal5)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");
            });

            modelBuilder.Entity<CbooksCbooksReq>(entity =>
            {
                entity.HasKey(x => x.AccountNo);

                entity.ToTable("CBooks_CBooksReq");

                entity.HasIndex(x => new { x.CustName1, x.TypeAccount, x.BankId, x.CurrencyId }, "Idx_2")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccessedTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Addr4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Applicat)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CBook')");

                entity.Property(e => e.BankId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BankID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BaseCurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("BaseCurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BaseCurrencyPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BranchID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckBookPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CheckLayoutNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ChkbookDescript)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("chkbookDescript")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreationDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.CurrencyId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyIdexchange)
                    .HasColumnType("money")
                    .HasColumnName("CurrencyIDExchange")
                    .HasDefaultValueSql("((1))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CustName1)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustName2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustNameLegal)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerName3)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EndCheckNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndChkNoCompute)
                    .HasColumnName("EndChkNo_Compute")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Filler)
                    .HasMaxLength(113)
                    .IsUnicode(false)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FlgprintNotAllowed)
                    .HasColumnName("flgprintNotAllowed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InhibitPrintFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.InitialCheckNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.LayoutId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OperationDateTime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PriceStyle1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PriceStyle2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PriceStyle3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PrintedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Processtime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.RecordNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReprintControlFlag)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestTimeUsrAlph5)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingTransitInfo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SelectedStyle)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.Property(e => e.Source)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Trtype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeAccount)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserVal1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal4)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal5)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");
            });

            modelBuilder.Entity<CbooksChkBooksEntry>(entity =>
            {
                entity.HasKey(x => x.AccountNo)
                    .HasName("PK_ChkBooks");

                entity.ToTable("CBooks_ChkBooksEntries");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BankID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerCb)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("fillerCB")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FlagprintNotAllowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(50)
                    .HasColumnName("LocationID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NoChecks2Print).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoutingTransitInfo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StatusofCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TypeAccount)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CbooksImportHeader>(entity =>
            {
                entity.HasKey(x => x.BatchId);

                entity.ToTable("CBooks_ImportHeader");

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("Batch_ID");

                entity.Property(e => e.Filefilter)
                    .HasMaxLength(12)
                    .HasColumnName("filefilter")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filenameih)
                    .HasMaxLength(80)
                    .HasColumnName("FILENAMEih")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filesizeih)
                    .HasColumnType("money")
                    .HasColumnName("FILESIZEih")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Filler)
                    .HasMaxLength(135)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Importdate)
                    .HasColumnName("IMPORTDATE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importtime)
                    .HasColumnName("IMPORTTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Recordcode)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CbooksMicrline>(entity =>
            {
                entity.HasKey(x => new { x.BankId, x.LayoutId })
                    .HasName("PK_CBooks_MICRLine_1");

                entity.ToTable("CBooks_MICRLine");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BankID");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.AccNoEffectiveLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctNoMask)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Acctoff).HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column0)
                    .HasColumnName("column0")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FillerM)
                    .HasMaxLength(11)
                    .HasColumnName("fillerM")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Micrline)
                    .HasMaxLength(63)
                    .HasColumnName("MICRLine")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Notused)
                    .HasColumnName("notused")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactLength).HasDefaultValueSql("((9))");

                entity.Property(e => e.ZeroFillacctL).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZeroFillcheckNumberL).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CbooksSynonym>(entity =>
            {
                entity.HasKey(x => x.TypeOfAccount);

                entity.ToTable("CBooks_Synonyms");

                entity.Property(e => e.TypeOfAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckLayoutNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EndLayout)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fillerS")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HorizMicrmicroAdjust)
                    .HasColumnName("HorizMICRmicroAdjust")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Layout1)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Layout2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.SetLastCheckNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.SynonymId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SynonymID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VertMicrmicroAdjust)
                    .HasColumnName("VertMICRmicroAdjust")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CbooksTypeOfAccount>(entity =>
            {
                entity.HasKey(x => new { x.RecordNo, x.CheckLayoutNo })
                    .HasName("PK_CBooks_TypeOfAccount_1");

                entity.ToTable("CBooks_TypeOfAccount");

                entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();

                entity.Property(e => e.CheckLayoutNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ApplF)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CBook')");

                entity.Property(e => e.FillerT)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fillerT")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LayoutId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PageNumbering)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'P')")
                    .IsFixedLength(true);

                entity.Property(e => e.PriceStyle1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PriceStyle2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PriceStyle3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.SelectedStyle)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.Property(e => e.TotalsChecksPerCbook)
                    .HasColumnName("TotalsChecksPerCBook")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeOfaccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TypeOFAccount")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ChecksD1>(entity =>
            {
                entity.HasKey(x => new { x.BatchId, x.RecordNo, x.SeqNoThisDoc });

                entity.ToTable("ChecksD1");

                entity.HasIndex(x => new { x.BatchId, x.RecordNo, x.OperationType, x.SeqNoThisDoc }, "key0")
                    .IsUnique()
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BatchId).HasColumnName("Batch_ID");

                entity.Property(e => e.RecordNo).HasColumnName("Record_No");

                entity.Property(e => e.AditionalRefGl)
                    .HasMaxLength(40)
                    .HasColumnName("AditionalRefGL")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CalculateNetAmount)
                    .HasColumnType("money")
                    .HasComputedColumnSql("([GrossAmount]-[DiscountTaken]/(100))", false)
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CheckDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(22)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConceptOrdescription)
                    .HasMaxLength(100)
                    .HasColumnName("conceptORdescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreditGl)
                    .HasColumnType("money")
                    .HasColumnName("CreditGL")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DebitGl)
                    .HasColumnType("money")
                    .HasColumnName("DebitGL")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Descript1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript10)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript11)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript12)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript13)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript14)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript15)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript5)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript6)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript7)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript8)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descript9)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DiscountTaken)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.EarnDeductiRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.EarnedDeductAmtMtd)
                    .HasColumnType("money")
                    .HasColumnName("EarnedDeductAmtMTD")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.EarnedDeductedAmtYtd)
                    .HasColumnType("money")
                    .HasColumnName("EarnedDeductedAmtYTD")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.GrossAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.InvoiceDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NetAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProllPreTxLog).HasDefaultValueSql("((0))");

                entity.Property(e => e.StubDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.StubDate1)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.TriggerMultistub)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TypeOfAccount)
                    .HasMaxLength(35)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UnitsHoursQ)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.UserString122)
                    .HasMaxLength(22)
                    .HasColumnName("UserString1_22")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Value1)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value10)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value11)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value12)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value13)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value14)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value15)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value16)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value17)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value18)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value19)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value2)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value20)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value3)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value4)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value5)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Value6)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Value7)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value8)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Value9)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("(N'0')")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Voucherdate).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.ChecksD1s)
                    .HasForeignKey(x => x.BatchId)
                    .HasConstraintName("FK_ChecksD1_BtchDet");
            });

            modelBuilder.Entity<ChecksH3>(entity =>
            {
                entity.HasKey(x => new { x.BatchId, x.RecordNo });

                entity.ToTable("ChecksH3");

                entity.HasIndex(x => new { x.CheckPrintedDateTime, x.BankId, x.AccountId, x.PayorId, x.CheckType, x.PayeeName, x.CheckAmount }, "ChecksH3_Index")
                    .HasFillFactor((byte)30);

                entity.HasIndex(x => new { x.BatchId, x.CheckPrintedDateTime, x.RecordNo, x.CheckNo, x.BankId, x.AccountId, x.PayeeName }, "IDX_ChecksH3")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BatchId).HasColumnName("Batch_ID");

                entity.Property(e => e.RecordNo).HasColumnName("Record_No");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Account_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(35)
                    .HasColumnName("Account_Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchStdEntryClassCode)
                    .HasMaxLength(3)
                    .HasColumnName("achStdEntryClassCode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchTranCode)
                    .HasMaxLength(2)
                    .HasColumnName("achTranCode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchTypeAcct)
                    .HasMaxLength(1)
                    .HasColumnName("achTypeAcct")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchaddendaQ)
                    .HasColumnName("ACHAddendaQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Achq)
                    .HasColumnName("ACHQ")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.AchreEnableQ)
                    .HasColumnName("ACHRe_EnableQ")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.AchroutingCdv)
                    .HasMaxLength(1)
                    .HasColumnName("ACHroutingCDV")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AdditionalUserId)
                    .HasMaxLength(10)
                    .HasColumnName("AdditionalUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankAddr1)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankAddr2)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankName)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BatchIdr)
                    .HasColumnName("BatchIDR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cdv2)
                    .HasMaxLength(2)
                    .HasColumnName("CDV2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CdvAccountNo)
                    .HasMaxLength(2)
                    .HasColumnName("CDV_Account_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CheckAmountAlpha)
                    .HasMaxLength(120)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckDateAlpha)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckDateYear).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(22)
                    .HasColumnName("Check_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckPrintedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1))")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.CheckType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClaimOrPurchaseOrde)
                    .HasColumnName("Claim_orPurchaseOrde")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept1)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept2)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept3)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept4)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsecutiveNumber)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Contact)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CopyPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenter4Sign)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Counter).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateAlphaY2k)
                    .HasMaxLength(30)
                    .HasColumnName("DateAlphaY2K")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DfiacctNo)
                    .HasMaxLength(17)
                    .HasColumnName("DFIacctNo")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DirectDepositAccNumb)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DirectDepositBankNam)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Discounttotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.DontSendEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.EarnDeductAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EncryptAmount).HasMaxLength(100);

                entity.Property(e => e.EncryptCheckNo).HasMaxLength(100);

                entity.Property(e => e.EncryptPayee).HasMaxLength(140);

                entity.Property(e => e.ExportQ).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Filler15)
                    .HasMaxLength(33)
                    .HasColumnName("filler15")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ForTheAccountOf)
                    .HasMaxLength(75)
                    .HasColumnName("For_the_account_of")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GlCredit)
                    .HasColumnType("money")
                    .HasColumnName("GL_Credit")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.GlDebit)
                    .HasColumnType("money")
                    .HasColumnName("GL_Debit")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.GlacctReference)
                    .HasMaxLength(40)
                    .HasColumnName("GLAcctReference")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Grosstotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ImportDate)
                    .HasColumnName("Import_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Irscode)
                    .HasMaxLength(6)
                    .HasColumnName("IRScode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NumberofSignatures).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayeeAddr1)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr2)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr3)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr4)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr5)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeId)
                    .HasMaxLength(22)
                    .HasColumnName("PayeeID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeName)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("('VOID VOID')");

                entity.Property(e => e.PayeeName2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorName)
                    .HasMaxLength(70)
                    .HasColumnName("Payor_Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Pdfname)
                    .HasMaxLength(100)
                    .HasColumnName("PDFName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PdfuniqueNameQ)
                    .HasColumnName("PDFUniqueNameQ")
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.PositivePayQ).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Printed).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedBy)
                    .HasMaxLength(5)
                    .HasColumnName("Printed_By")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedDate)
                    .HasColumnName("Printed_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedDateAlpha)
                    .HasMaxLength(8)
                    .HasColumnName("Printed_DateAlpha")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedTime)
                    .HasMaxLength(8)
                    .HasColumnName("Printed_Time")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedType)
                    .HasMaxLength(1)
                    .HasColumnName("Printed_Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProcessTime)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(8)
                    .HasColumnName("Program_Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrintDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(N'getdate()')")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.RePrintReason)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrintUserId)
                    .HasMaxLength(10)
                    .HasColumnName("RePrintUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason1).HasMaxLength(50);

                entity.Property(e => e.Reason2).HasMaxLength(50);

                entity.Property(e => e.RecBatchPurgeQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecCheckNo)
                    .HasMaxLength(22)
                    .HasColumnName("RecCheck_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReceivingDfi)
                    .HasMaxLength(9)
                    .HasColumnName("ReceivingDFI")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReconcDate)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReconciledQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordNoR).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReprintCount).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RequesterUser)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RoutingNumberMicr)
                    .HasMaxLength(12)
                    .HasColumnName("RoutingNumberMICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature1)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature2)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SpecialLongDescripti)
                    .HasMaxLength(180)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .HasColumnName("SSN")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.State)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StringAmount2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StringAmount3)
                    .HasMaxLength(27)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ToBePrinted)
                    .HasColumnName("To_Be_Printed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transit1)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Transit2)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us1200)
                    .HasMaxLength(200)
                    .HasColumnName("US1200")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us2100)
                    .HasMaxLength(100)
                    .HasColumnName("US2100")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us3100)
                    .HasMaxLength(100)
                    .HasColumnName("US3100")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us4200)
                    .HasMaxLength(200)
                    .HasColumnName("US4200")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserFieldMicr)
                    .HasMaxLength(15)
                    .HasColumnName("UserFieldMICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr10)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr11)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr12)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr13)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr14)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr15)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr16)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr17)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr18)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr19)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr20)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr5)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr6)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr7)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr8)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr9)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserVal13)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal14)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal15)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserbatchId)
                    .HasMaxLength(24)
                    .HasColumnName("UserbatchID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Userval1)
                    .HasColumnType("money")
                    .HasColumnName("USERval1")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval10)
                    .HasColumnType("money")
                    .HasColumnName("USERval10")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval11)
                    .HasColumnType("money")
                    .HasColumnName("USERval11")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval12)
                    .HasColumnType("money")
                    .HasColumnName("USERval12")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval16)
                    .HasColumnType("money")
                    .HasColumnName("USERval16")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval17)
                    .HasColumnType("money")
                    .HasColumnName("USERval17")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval18)
                    .HasColumnType("money")
                    .HasColumnName("USERval18")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval2)
                    .HasColumnType("money")
                    .HasColumnName("USERval2")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval3)
                    .HasColumnType("money")
                    .HasColumnName("USERval3")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval4)
                    .HasColumnType("money")
                    .HasColumnName("USERval4")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval5)
                    .HasColumnType("money")
                    .HasColumnName("USERval5")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval6)
                    .HasColumnType("money")
                    .HasColumnName("USERval6")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval7)
                    .HasColumnType("money")
                    .HasColumnName("USERval7")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval8)
                    .HasColumnType("money")
                    .HasColumnName("USERval8")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval9)
                    .HasColumnType("money")
                    .HasColumnName("USERval9")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.VendorRedundant)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_Redundant")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Void)
                    .HasColumnName("VOID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VoidDate)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VoidReason).HasMaxLength(150);

                entity.Property(e => e.VoucherOrPurOrder)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WhileProcessingVoi)
                    .HasColumnName("While_Processing_Voi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhileSigningFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.ChecksH3s)
                    .HasForeignKey(x => x.BatchId)
                    .HasConstraintName("FK_ChecksH3_BtchDet");
            });

            modelBuilder.Entity<ClientLocation>(entity =>
            {
                entity.HasKey(x => x.Code);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CsRefreshTime)
                    .HasColumnName("csRefreshTime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CsTimeOut)
                    .HasColumnName("csTimeOut")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Csreplicated)
                    .HasColumnName("CSReplicated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrinterId)
                    .HasColumnName("PrinterID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrinterName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Selected).HasDefaultValueSql("((1))");

                entity.Property(e => e.Template)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DescriptionAddl)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((1))")
                    .HasAnnotation("Relational:ColumnType", "smallmoney");

                entity.Property(e => e.Filler)
                    .HasMaxLength(38)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FractionName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CustomFont>(entity =>
            {
                entity.HasKey(x => new { x.CfeEntity, x.ProjectKey });

                entity.Property(e => e.CfeEntity).HasColumnName("cfeEntity");

                entity.Property(e => e.CfeData)
                    .HasMaxLength(40)
                    .HasColumnName("cfeData")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CfeFiller)
                    .HasMaxLength(29)
                    .HasColumnName("cfeFILLER")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CfeKeyCode)
                    .HasColumnName("cfeKeyCode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfeOperand1Entity)
                    .HasColumnName("cfeOperand1Entity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CfeOperator)
                    .HasMaxLength(2)
                    .HasColumnName("cfeOperator")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CfeRecType)
                    .HasMaxLength(1)
                    .HasColumnName("cfeRecType")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FontId)
                    .HasColumnName("FontID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DatabasesC>(entity =>
            {
                entity.HasKey(x => x.DatabaseId);

                entity.ToTable("DatabasesC");

                entity.Property(e => e.DatabaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("DatabaseID");

                entity.Property(e => e.DatabaseNameC)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<EAlertAuditLog>(entity =>
            {
                entity.HasKey(x => x.Idnumber);

                entity.ToTable("eAlertAuditLog");

                entity.Property(e => e.Idnumber).HasColumnName("IDNumber");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.DatabaseName).HasMaxLength(50);

                entity.Property(e => e.EventMenu).HasMaxLength(100);
            });

            modelBuilder.Entity<EAlertCustom>(entity =>
            {
                entity.ToTable("eAlertCustom");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount1)
                    .HasColumnType("money")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Amount2)
                    .HasColumnType("money")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.AmountOver)
                    .HasColumnType("money")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Date2)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.EmailFrom).HasMaxLength(500);

                entity.Property(e => e.Entity1).HasMaxLength(50);

                entity.Property(e => e.Entity1Text).HasMaxLength(250);

                entity.Property(e => e.Entity2).HasMaxLength(50);

                entity.Property(e => e.Entity2Text).HasMaxLength(250);

                entity.Property(e => e.Entity3).HasMaxLength(50);

                entity.Property(e => e.Entity3Text).HasMaxLength(250);

                entity.Property(e => e.Entity4).HasMaxLength(50);

                entity.Property(e => e.Entity4Text).HasMaxLength(250);

                entity.Property(e => e.Entity5).HasMaxLength(50);

                entity.Property(e => e.Entity5Text).HasMaxLength(250);

                entity.Property(e => e.NameId)
                    .HasMaxLength(500)
                    .HasColumnName("NameID");
            });

            modelBuilder.Entity<EAlertEmail>(entity =>
            {
                entity.HasKey(x => new { x.DatabaseId, x.IdentityId, x.EMail });

                entity.ToTable("eAlertEmails");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.IdentityId).HasColumnName("IdentityID");

                entity.Property(e => e.EMail)
                    .HasMaxLength(150)
                    .HasColumnName("eMail")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EAlertEvent>(entity =>
            {
                entity.HasKey(x => x.IdentityId);

                entity.ToTable("eAlertEvents");

                entity.Property(e => e.IdentityId).HasColumnName("IdentityID");

                entity.Property(e => e.AuditPattern)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AuditTrailBypassQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.DatabaseId)
                    .HasColumnName("DatabaseID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EfillerW)
                    .HasMaxLength(28)
                    .HasColumnName("efillerW")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PurgeBypassQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<EAlertWildcard>(entity =>
            {
                entity.HasKey(x => x.IdentityId)
                    .HasName("PK_eAlertWildcards_1");

                entity.ToTable("eAlertWildcards");

                entity.Property(e => e.IdentityId)
                    .ValueGeneratedNever()
                    .HasColumnName("IdentityID");

                entity.Property(e => e.AuditTrailBypassQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.DatabaseId)
                    .HasColumnName("DatabaseID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EfillerW)
                    .HasMaxLength(28)
                    .HasColumnName("efillerW")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MatchPattern)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PurgeBypassQ).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EalertsSamplePatern>(entity =>
            {
                entity.HasKey(x => new { x.DatabaseId, x.EventName });

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.EventName).HasMaxLength(30);

                entity.Property(e => e.Efiller3)
                    .HasMaxLength(32)
                    .HasColumnName("efiller3")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ElegiblePrinter>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AssignedPrinter)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AvailablePrinters).HasDefaultValueSql("((0))");

                entity.Property(e => e.InitString)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LoadBalanceQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarginName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OmitInitQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orientation)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaperSize)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.PrinterId).HasColumnName("PrinterID");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((1))");

                entity.Property(e => e.SecurePrinterQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedQ).HasDefaultValueSql("((1))");

                entity.Property(e => e.TrayNumber).HasDefaultValueSql("((5))");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<EmailCustomization>(entity =>
            {
                entity.HasKey(x => x.Category);

                entity.ToTable("EmailCustomization");

                entity.Property(e => e.Category).HasMaxLength(16);

                entity.Property(e => e.AccountReference)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Account Reference:')");

                entity.Property(e => e.AtCurrentDateTime).HasMaxLength(50);

                entity.Property(e => e.Bit1).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit21).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit22).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit23).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit24).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit25).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit26).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit27).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit28).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit3).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit31).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit32).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit33).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit34).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit35).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit36).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit37).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit4).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit41).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit42).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit43).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit5).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bit6).HasDefaultValueSql("((1))");

                entity.Property(e => e.Confidentiality)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'CONFIDENTIALITY NOTE')");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Description')");

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Desc')");

                entity.Property(e => e.Description3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Desc')");

                entity.Property(e => e.Description4).HasMaxLength(50);

                entity.Property(e => e.Description5).HasMaxLength(50);

                entity.Property(e => e.Description6).HasMaxLength(50);

                entity.Property(e => e.Description7).HasMaxLength(50);

                entity.Property(e => e.Description8).HasMaxLength(50);

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'DISCOUNT')");

                entity.Property(e => e.FormatCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Format Code =')");

                entity.Property(e => e.GrossAmount)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'GROSS AMOUNT')");

                entity.Property(e => e.MessageLine1)
                    .HasMaxLength(1050)
                    .HasDefaultValueSql("(N'If you have receive this communication in error please delete or destroy it and notify the sender immediately. Thanks.')");

                entity.Property(e => e.MessageLine2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NetAmount)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'NET AMOUNT')");

                entity.Property(e => e.Notifiedby)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Email notified by CheckPlus Software')");

                entity.Property(e => e.PayeeName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Name: ')");

                entity.Property(e => e.PaymentAmount)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Payment Amount:')");

                entity.Property(e => e.PaymentDate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Payment Date:')");

                entity.Property(e => e.PaymentDetails1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Payment Details')");

                entity.Property(e => e.PaymentReference)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Payment Reference:')");

                entity.Property(e => e.ProcessedbyUserId)
                    .HasMaxLength(50)
                    .HasColumnName("ProcessedbyUserID")
                    .HasDefaultValueSql("(N'Processed by:')");

                entity.Property(e => e.ReferenceDate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'REF/INV DATE')");

                entity.Property(e => e.ReferenceInvoice)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'REFER/INV')");

                entity.Property(e => e.Remittance)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'REMITTANCE/DESCRIPTION')");

                entity.Property(e => e.Withholding)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'WITHHOLDING')");
            });

            modelBuilder.Entity<EmailPref>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmailPref");

                entity.Property(e => e.AttachmentE)
                    .HasMaxLength(1984)
                    .HasColumnName("attachmentE")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BlattOptions)
                    .HasMaxLength(260)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CategoryE)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DefaultValueE).HasDefaultValueSql("(N'')");

                entity.Property(e => e.DigitsDisclose).HasDefaultValueSql("((0))");

                entity.Property(e => e.FromE)
                    .HasMaxLength(260)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MessageE)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PacingTimer).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmptServer)
                    .HasMaxLength(260)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SubjectE)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ToE)
                    .HasMaxLength(3000)
                    .HasColumnName("toE")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<EventsSource>(entity =>
            {
                entity.HasKey(x => x.DatabaseId);

                entity.ToTable("Events_Sources");

                entity.Property(e => e.DatabaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("DatabaseID");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<FeesTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountOrpercent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AmountORPercent")
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Fee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.FeeCurrency)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FromAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.PercentComm)
                    .HasColumnType("money")
                    .HasColumnName("Percent_Comm")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ToAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");
            });

            modelBuilder.Entity<FieldsList>(entity =>
            {
                entity.HasKey(x => new { x.DatabaseId, x.FieldNoC });

                entity.ToTable("FieldsList");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.FieldNameC)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Fontlist>(entity =>
            {
                entity.HasKey(x => new { x.ProjectKey, x.FontId });

                entity.ToTable("Fontlist");

                entity.Property(e => e.FontId).HasColumnName("FontID");

                entity.Property(e => e.ActivationChar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.AdditionalActivation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.Description)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.Filler1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.FontSymbolName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.Fspec1)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.Fspec2)
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.PdfQ)
                    .HasColumnName("pdfQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedQ)
                    .HasColumnName("selectedQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SystemOrUser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FormItemEntity>(entity =>
            {
                entity.HasKey(x => x.EntityId);

                entity.Property(e => e.EntityId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(28)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Relationship).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Format>(entity =>
            {
                entity.HasKey(x => x.LayoutId);

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.Appearance)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinesStub).HasDefaultValueSql("((0))");

                entity.Property(e => e.OverflowQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedQ).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FtptransProf>(entity =>
            {
                entity.HasKey(x => x.ProfileId);

                entity.ToTable("FTPTransProf");

                entity.Property(e => e.ProfileId)
                    .HasMaxLength(4)
                    .HasColumnName("ProfileID");

                entity.Property(e => e.CommandName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CryFilePath)
                    .HasMaxLength(64)
                    .HasColumnName("cryFilePath")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CryInitProcedure)
                    .HasMaxLength(64)
                    .HasColumnName("cryInitProcedure")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CryLogFileName)
                    .HasMaxLength(64)
                    .HasColumnName("cryLogFileName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CryRunProcedure)
                    .HasMaxLength(64)
                    .HasColumnName("cryRunProcedure")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CryUserId)
                    .HasMaxLength(64)
                    .HasColumnName("cryUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateStampM)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.File2Receive)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.File2Send)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerEncryptionSect)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerFtpsection)
                    .HasMaxLength(32)
                    .HasColumnName("FillerFTPsection")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastProcessingDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logname)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PacingDelay)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password1)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StartAt).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStampM)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(32)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<GenParBlank>(entity =>
            {
                entity.HasKey(x => x.StyleDescriptiongpb);

                entity.ToTable("GenParBlank");

                entity.Property(e => e.StyleDescriptiongpb)
                    .HasMaxLength(35)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(16)
                    .HasColumnName("Account_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CostCentergpb)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateDefgpb).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fillergpb)
                    .HasMaxLength(103)
                    .HasColumnName("fillergpb")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FormIdgpb)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("formIDgpb")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeId)
                    .HasMaxLength(22)
                    .HasColumnName("PayeeID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserMicrvaluegpb)
                    .HasMaxLength(15)
                    .HasColumnName("UserMICRValuegpb")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<GenParamManCheck>(entity =>
            {
                entity.HasKey(x => x.DescriptTypegpm);

                entity.ToTable("GenParamManCheck");

                entity.Property(e => e.DescriptTypegpm)
                    .HasMaxLength(35)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(16)
                    .HasColumnName("Account_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ApplicationTitleRi)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Cdv1gpm)
                    .HasMaxLength(2)
                    .HasColumnName("CDV1gpm")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Cdv2gpm)
                    .HasMaxLength(2)
                    .HasColumnName("CDV2gpm")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckAmountLimitgpm)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ClientLocgpm)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CostCentergpm)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateUsedgpm)
                    .HasColumnName("dateUsedgpm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fillergpm)
                    .HasMaxLength(71)
                    .HasColumnName("fillergpm")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FormIdgpm)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("FormIDgpm")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeId)
                    .HasMaxLength(22)
                    .HasColumnName("PayeeID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScreenCodegpm)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserMicrvaluegpm)
                    .HasMaxLength(15)
                    .HasColumnName("UserMICRValuegpm")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<GenSysPar>(entity =>
            {
                entity.HasKey(x => x.ProjectKey);

                entity.ToTable("GenSysPar");

                entity.Property(e => e.ProjectKey).ValueGeneratedNever();

                entity.Property(e => e.AchManager)
                    .HasMaxLength(3)
                    .HasColumnName("ACH_Manager")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Achq)
                    .HasColumnName("ACHQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchschedulingQ)
                    .HasColumnName("ACHSchedulingQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ActivationRequestStr).HasMaxLength(30);

                entity.Property(e => e.AddressFormat)
                    .HasMaxLength(3)
                    .HasColumnName("Address_Format")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AllowCheckRangesQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Application2run).HasMaxLength(2);

                entity.Property(e => e.BaseCurrency).HasMaxLength(5);

                entity.Property(e => e.BlankChecksQ)
                    .HasColumnName("Blank_ChecksQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckPrintingOrder)
                    .HasColumnName("Check_Printing_Order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CityOfIssue)
                    .HasMaxLength(30)
                    .HasColumnName("City_of_Issue")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClientModuleQ)
                    .HasColumnName("Client_ModuleQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyAddr2).HasMaxLength(35);

                entity.Property(e => e.CompanyAddr3).HasMaxLength(35);

                entity.Property(e => e.CompanyAddr4).HasMaxLength(35);

                entity.Property(e => e.CompanyName).HasMaxLength(40);

                entity.Property(e => e.CompanyName2).HasMaxLength(35);

                entity.Property(e => e.CompanyName3).HasMaxLength(35);

                entity.Property(e => e.CompanyNameLogo).HasMaxLength(35);

                entity.Property(e => e.CsRefreshRate)
                    .HasColumnName("CS_Refresh_Rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DefApplicationQ).HasDefaultValueSql("((1))");

                entity.Property(e => e.DefaultAccount).HasMaxLength(16);

                entity.Property(e => e.DefaultBank).HasMaxLength(10);

                entity.Property(e => e.DefaultCurrency).HasMaxLength(5);

                entity.Property(e => e.DefaultMicrLineLayou).HasMaxLength(63);

                entity.Property(e => e.DefaultTypeOfcheck).HasMaxLength(2);

                entity.Property(e => e.DiskSerialNumber)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Dummy1)
                    .HasMaxLength(22)
                    .HasColumnName("dummy1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Dummy3)
                    .HasMaxLength(2)
                    .HasColumnName("dummy3");

                entity.Property(e => e.Dummy5)
                    .HasMaxLength(2)
                    .HasColumnName("dummy5");

                entity.Property(e => e.Dummy6)
                    .HasMaxLength(3)
                    .HasColumnName("dummy6");

                entity.Property(e => e.Dummy7)
                    .HasMaxLength(10)
                    .HasColumnName("dummy7");

                entity.Property(e => e.EmailErrors)
                    .HasColumnName("email_errors")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncryptExpirationDate).HasMaxLength(50);

                entity.Property(e => e.EncryptLicense).HasMaxLength(100);

                entity.Property(e => e.EncryptLicenseStr).HasMaxLength(200);

                entity.Property(e => e.EncryptServerName).HasMaxLength(100);

                entity.Property(e => e.EncryptTempLicense).HasMaxLength(50);

                entity.Property(e => e.ExpirationDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiration_Date")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Filler2)
                    .HasMaxLength(65)
                    .HasColumnName("filler2");

                entity.Property(e => e.FloatingSignatureLoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.HoldingFontId)
                    .HasMaxLength(10)
                    .HasColumnName("Holding_FontID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ImportFileNameEditin).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportLog)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IntegratedPrintEngin).HasDefaultValueSql("((1))");

                entity.Property(e => e.Language).HasMaxLength(3);

                entity.Property(e => e.LinkedBankAccountQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoginAttemptsAllowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatchPayorAccountQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Message2customers).HasMaxLength(70);

                entity.Property(e => e.MicrFontString)
                    .HasMaxLength(57)
                    .HasColumnName("micr_font_string")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MicrModePrefix)
                    .HasMaxLength(30)
                    .HasColumnName("Micr_mode_Prefix");

                entity.Property(e => e.MicrModeSuffix)
                    .HasMaxLength(30)
                    .HasColumnName("Micr_mode_suffix");

                entity.Property(e => e.Micrfont)
                    .HasMaxLength(1)
                    .HasColumnName("MICRfont");

                entity.Property(e => e.NetworkDiskSerialNum).HasMaxLength(30);

                entity.Property(e => e.OutputXtemplateQ).HasColumnName("OutputXTemplateQ");

                entity.Property(e => e.PasswordSecurityFeat).HasMaxLength(10);

                entity.Property(e => e.PdfgenerationQ).HasColumnName("PDFgenerationQ");

                entity.Property(e => e.PermanentFontsQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.PollingModeQ)
                    .HasMaxLength(1)
                    .HasColumnName("Polling_ModeQ")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrinterPoolingAutoMo).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrinterPoolingQ)
                    .HasColumnName("Printer_PoolingQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrinterSecurityFeatu).HasMaxLength(1);

                entity.Property(e => e.PrinterStyle)
                    .HasMaxLength(30)
                    .HasColumnName("Printer_Style");

                entity.Property(e => e.PrinterTimeoutAllowe).HasDefaultValueSql("((0))");

                entity.Property(e => e.PurgePayeeFileQ)
                    .HasColumnName("Purge_Payee_FileQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResourcesPassword).HasMaxLength(10);

                entity.Property(e => e.RigorousPrinterSta)
                    .HasColumnName("Rigorous_Printer_Sta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialStamp).HasMaxLength(30);

                entity.Property(e => e.SignatureAssigning)
                    .HasColumnName("Signature_Assigning_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignatureCatergoryDe)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SignatureCombosQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SimultaneousVisualSi).HasDefaultValueSql("((0))");

                entity.Property(e => e.SingleCheckBatchesQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SortRequestsB4Pri)
                    .HasColumnName("Sort_requests_b4_pri")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Spare)
                    .HasMaxLength(11)
                    .HasColumnName("SPARE");

                entity.Property(e => e.StatusImportedChec)
                    .HasColumnName("Status_Imported_Chec")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Style).HasMaxLength(1);

                entity.Property(e => e.TypeChecksLimithighX)
                    .HasMaxLength(1)
                    .HasColumnName("TypeChecksLIMIThighX");

                entity.Property(e => e.UniqueCheckNumbers)
                    .HasColumnName("Unique_Check_Numbers")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GenSysUser>(entity =>
            {
                entity.HasKey(x => x.NumberOfUsers);

                entity.Property(e => e.NumberOfUsers).HasMaxLength(50);

                entity.Property(e => e.LicenseDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.GroupId)
                    .HasMaxLength(10)
                    .HasColumnName("GroupID");

                entity.Property(e => e.GDescription)
                    .HasMaxLength(30)
                    .HasColumnName("gDescription")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<GroupRight>(entity =>
            {
                entity.HasKey(x => new { x.GroupId, x.RightId });

                entity.Property(e => e.GroupId)
                    .HasMaxLength(10)
                    .HasColumnName("GroupID");

                entity.Property(e => e.RightId)
                    .HasMaxLength(10)
                    .HasColumnName("RightID");

                entity.Property(e => e.GrAssignedQ)
                    .HasColumnName("grAssignedQ")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<IeScreenDet>(entity =>
            {
                entity.HasKey(x => new { x.GenCode, x.RecType, x.IeidFieldCode });

                entity.ToTable("ieScreenDet");

                entity.Property(e => e.GenCode).HasMaxLength(4);

                entity.Property(e => e.RecType).HasMaxLength(1);

                entity.Property(e => e.IeidFieldCode)
                    .HasMaxLength(4)
                    .HasColumnName("ieidFieldCode");

                entity.Property(e => e.IeidDescription)
                    .HasMaxLength(30)
                    .HasColumnName("ieidDescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeidLengthInFile)
                    .HasColumnName("ieidLengthInFile")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeidPosition)
                    .HasColumnName("ieidPosition")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ieidtype)
                    .HasMaxLength(20)
                    .HasColumnName("ieidtype")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IesdFiller)
                    .HasMaxLength(43)
                    .HasColumnName("iesdFILLER")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IesdKey)
                    .HasColumnName("iesdKey")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IesdMask)
                    .HasMaxLength(20)
                    .HasColumnName("iesdMask")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<IeScreenHead>(entity =>
            {
                entity.HasKey(x => new { x.IeihPurpose, x.GenCode, x.RecType });

                entity.ToTable("ieScreenHead");

                entity.Property(e => e.IeihPurpose)
                    .HasMaxLength(1)
                    .HasColumnName("ieihPurpose");

                entity.Property(e => e.GenCode).HasMaxLength(4);

                entity.Property(e => e.RecType).HasMaxLength(1);

                entity.Property(e => e.IehPaddingChar4Expor)
                    .HasColumnName("iehPaddingChar4Expor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihAppl2run)
                    .HasMaxLength(2)
                    .HasColumnName("ieihAppl2run")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihDivideAmountsBy)
                    .HasColumnName("ieihDivideAmountsBy")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihEngineVersion)
                    .HasColumnName("ieihEngineVersion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihFieldSeparatorDe)
                    .HasMaxLength(3)
                    .HasColumnName("ieihFieldSeparatorDe")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihGenCheckNumberQ)
                    .HasColumnName("ieihGenCheckNumberQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihGenDescript)
                    .HasMaxLength(57)
                    .HasColumnName("ieihGenDescript")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihModeVertHoriz)
                    .HasMaxLength(1)
                    .HasColumnName("ieihModeVertHoriz")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihOmitBlanksQ)
                    .HasColumnName("ieihOmitBlanksQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihSelectedQ)
                    .HasColumnName("ieihSelectedQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IeihSpare)
                    .HasColumnName("ieihSpare")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ieihfilter)
                    .HasMaxLength(12)
                    .HasColumnName("ieihfilter")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ieihpath)
                    .HasMaxLength(80)
                    .HasColumnName("ieihpath")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeshFiller)
                    .HasMaxLength(81)
                    .HasColumnName("ieshFILLER")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeshTimer)
                    .HasColumnName("ieshTimer")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Iedetail>(entity =>
            {
                entity.HasKey(x => new { x.GeneralCode, x.RecordType, x.FieldCode });

                entity.ToTable("IEdetail");

                entity.Property(e => e.GeneralCode).HasMaxLength(4);

                entity.Property(e => e.RecordType).HasMaxLength(1);

                entity.Property(e => e.FieldCode).HasMaxLength(4);

                entity.Property(e => e.ColDet1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ColDet2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ColDet3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IedKey)
                    .HasColumnName("iedKey")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IedRealQ)
                    .HasColumnName("iedRealQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IeidDescription)
                    .HasMaxLength(29)
                    .HasColumnName("ieidDescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeidFieldLengh)
                    .HasColumnName("ieidFieldLengh")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeidOffset)
                    .HasColumnName("ieidOffset")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeidType)
                    .HasMaxLength(20)
                    .HasColumnName("ieidType")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Ieheader>(entity =>
            {
                entity.HasKey(x => new { x.Purpose, x.GeneralCode, x.RecordType });

                entity.ToTable("IEheader");

                entity.Property(e => e.Purpose).HasMaxLength(1);

                entity.Property(e => e.GeneralCode).HasMaxLength(4);

                entity.Property(e => e.RecordType).HasMaxLength(1);

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column6)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column7)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Column8)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IehPaddingChar4Expor)
                    .HasColumnName("iehPaddingChar4Expor")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihAppl2run)
                    .HasMaxLength(2)
                    .HasColumnName("ieihAppl2run")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihDivideMultiplyAm)
                    .HasColumnName("ieihDivideMultiplyAm")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IeihEngineVersion)
                    .HasColumnName("ieihEngineVersion")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.IeihFilter)
                    .HasMaxLength(30)
                    .HasColumnName("ieihFilter")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihGeneralDescripti)
                    .HasMaxLength(70)
                    .HasColumnName("ieihGeneralDescripti")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihGenerateCheckNum)
                    .HasColumnName("ieihGenerateCheckNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihModeManAuto)
                    .HasMaxLength(1)
                    .HasColumnName("ieihModeManAuto")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihOmitBlanksQ)
                    .HasColumnName("ieihOmitBlanksQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihSingleRecDetailH)
                    .HasColumnName("ieihSingleRecDetailH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeihfieldDelimiter)
                    .HasMaxLength(3)
                    .HasColumnName("ieihfieldDelimiter")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ieihpath)
                    .HasMaxLength(120)
                    .HasColumnName("ieihpath")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeihselectedQ)
                    .HasColumnName("ieihselectedQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.Timer).HasDefaultValueSql("((5))");
            });

            modelBuilder.Entity<IelayoutLineItemX>(entity =>
            {
                entity.HasKey(x => new { x.GeneralCode, x.FieldCode, x.IeXkey, x.IeXparentCode });

                entity.ToTable("IElayoutLineItemX");

                entity.Property(e => e.GeneralCode).HasMaxLength(4);

                entity.Property(e => e.FieldCode).HasMaxLength(4);

                entity.Property(e => e.IeXkey).HasColumnName("ieXKey");

                entity.Property(e => e.IeXparentCode)
                    .HasMaxLength(4)
                    .HasColumnName("ieXParentCode");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeXdescription)
                    .HasMaxLength(30)
                    .HasColumnName("ieXDescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeXlength)
                    .HasColumnName("ieXLength")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeXoffset)
                    .HasColumnName("ieXOFFSET")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeXoperatorX)
                    .HasMaxLength(1)
                    .HasColumnName("ieXOperatorX")
                    .HasDefaultValueSql("(N'I')");

                entity.Property(e => e.IeXtype)
                    .HasMaxLength(20)
                    .HasColumnName("ieXtype")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.XFiller)
                    .HasMaxLength(26)
                    .HasColumnName("xFILLER")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.XdataOperand)
                    .HasMaxLength(32)
                    .HasColumnName("XDataOperand")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<IelayoutLineheader>(entity =>
            {
                entity.HasKey(x => new { x.GeneralCode, x.RecordType, x.IeidLinecode });

                entity.ToTable("IElayoutLineheader");

                entity.Property(e => e.GeneralCode).HasMaxLength(4);

                entity.Property(e => e.RecordType).HasMaxLength(1);

                entity.Property(e => e.IeidLinecode)
                    .HasMaxLength(4)
                    .HasColumnName("ieidLINEcode");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler)
                    .HasMaxLength(88)
                    .HasColumnName("FILLER")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeidDescription)
                    .HasMaxLength(30)
                    .HasColumnName("ieidDescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeidOperation)
                    .HasMaxLength(1)
                    .HasColumnName("ieidOperation")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<IelayoutlineItem>(entity =>
            {
                entity.HasKey(x => new { x.GeneralCode, x.RecordType, x.FieldCode, x.Kkey, x.KparentCode });

                entity.ToTable("IElayoutlineItem");

                entity.Property(e => e.GeneralCode).HasMaxLength(4);

                entity.Property(e => e.RecordType).HasMaxLength(1);

                entity.Property(e => e.FieldCode).HasMaxLength(4);

                entity.Property(e => e.Kkey).HasColumnName("KKey");

                entity.Property(e => e.KparentCode)
                    .HasMaxLength(4)
                    .HasColumnName("KParentCode");

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Constant)
                    .HasMaxLength(59)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeidDescription)
                    .HasMaxLength(30)
                    .HasColumnName("ieidDescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IeidLength)
                    .HasColumnName("ieidLength")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeidOffsetpos)
                    .HasColumnName("ieidOFFSETpos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeidType)
                    .HasMaxLength(20)
                    .HasColumnName("ieidType")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<IesortDefinit>(entity =>
            {
                entity.HasKey(x => new { x.IesGenCode, x.IesRecType, x.IesFieldCode });

                entity.ToTable("IESortDefinit");

                entity.Property(e => e.IesGenCode)
                    .HasMaxLength(4)
                    .HasColumnName("iesGenCode");

                entity.Property(e => e.IesRecType)
                    .HasMaxLength(1)
                    .HasColumnName("iesRecType");

                entity.Property(e => e.IesFieldCode)
                    .HasMaxLength(4)
                    .HasColumnName("iesFieldCode");

                entity.Property(e => e.IeFieldLength)
                    .HasColumnName("ieFieldLength")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IesCharPosition)
                    .HasColumnName("iesCharPosition")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IesDataType)
                    .HasMaxLength(1)
                    .HasColumnName("iesDataType")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IesDescript)
                    .HasMaxLength(30)
                    .HasColumnName("iesDescript")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IesFiller)
                    .HasMaxLength(61)
                    .HasColumnName("iesFILLER")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IesKey)
                    .HasColumnName("iesKey")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IesMask)
                    .HasMaxLength(20)
                    .HasColumnName("iesMASK")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IesOmitPauseOnChange)
                    .HasColumnName("iesOmitPauseOnChange")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IesSortType)
                    .HasMaxLength(10)
                    .HasColumnName("iesSortType");
            });

            modelBuilder.Entity<Ietemplate>(entity =>
            {
                entity.HasKey(x => new { x.Tapplication2run, x.TrecordType, x.Tkey });

                entity.ToTable("IETemplate");

                entity.Property(e => e.Tapplication2run)
                    .HasMaxLength(2)
                    .HasColumnName("TApplication2run");

                entity.Property(e => e.TrecordType)
                    .HasMaxLength(1)
                    .HasColumnName("TRecordType");

                entity.Property(e => e.Tkey).HasColumnName("TKey");

                entity.Property(e => e.Tclassifier)
                    .HasMaxLength(20)
                    .HasColumnName("TClassifier");

                entity.Property(e => e.Tdescription)
                    .HasMaxLength(30)
                    .HasColumnName("TDescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TessentialQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tlength)
                    .HasColumnName("TLength")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TselectedQ).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ImpCheckLog>(entity =>
            {
                entity.HasKey(x => new { x.BatchId, x.AccountId, x.BankId });

                entity.ToTable("ImpCheckLog");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(16)
                    .HasColumnName("Account_ID");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(22)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintTime).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ImportHeader>(entity =>
            {
                entity.HasKey(x => x.BatchId);

                entity.ToTable("ImportHeader");

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("Batch_ID");

                entity.Property(e => e.Filefilter)
                    .HasMaxLength(12)
                    .HasColumnName("filefilter")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filenameih)
                    .HasMaxLength(80)
                    .HasColumnName("FILENAMEih")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filesizeih)
                    .HasColumnType("money")
                    .HasColumnName("FILESIZEih")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Filler)
                    .HasMaxLength(135)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Importdate)
                    .HasColumnName("IMPORTDATE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importtime)
                    .HasColumnName("IMPORTTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Recordcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.English)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.France).HasMaxLength(500);

                entity.Property(e => e.Language1).HasMaxLength(500);

                entity.Property(e => e.Language2).HasMaxLength(500);

                entity.Property(e => e.Language3).HasMaxLength(500);

                entity.Property(e => e.Language4).HasMaxLength(500);

                entity.Property(e => e.Language5).HasMaxLength(500);

                entity.Property(e => e.Spanish).HasMaxLength(500);
            });

            modelBuilder.Entity<MicrlineLayout>(entity =>
            {
                entity.HasKey(x => x.BankId);

                entity.ToTable("MICRLineLayout");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID");

                entity.Property(e => e.AccountLeftJustifyQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dummy1)
                    .HasColumnName("dummy1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dummy2)
                    .HasColumnName("dummy2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Filler1)
                    .HasMaxLength(37)
                    .HasColumnName("filler1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Micrline)
                    .HasMaxLength(63)
                    .HasColumnName("MICRLine")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserFieldLeftJustify).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserLength).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Bank)
                    .WithOne(p => p.MicrlineLayout)
                    .HasForeignKey<MicrlineLayout>(x => x.BankId)
                    .HasConstraintName("FK_MICRLineLayout_Banks");
            });

            modelBuilder.Entity<OutDataMapMaindet>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.FomrItemId, x.Seq2Print, x.DetSequence });

                entity.ToTable("outDataMapMAINDet");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FomrItemId).HasColumnName("fomrItemID");

                entity.Property(e => e.PropValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PropertyId)
                    .HasMaxLength(20)
                    .HasColumnName("PropertyID");
            });

            modelBuilder.Entity<OutDataMapMainhead>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.Group1, x.ProjectKey, x.Seq2Print });

                entity.ToTable("outDataMapMAINHead");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.Description2Print)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EntityId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flags)
                    .HasMaxLength(16)
                    .HasColumnName("flags")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Mask)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Note)
                    .HasMaxLength(52)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OutMapDetailsStub>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.PrintSequences, x.Sequenceds });

                entity.ToTable("outMapDetailsSTUB");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.Sequenceds).HasColumnName("sequenceds");

                entity.Property(e => e.EntityIdds)
                    .HasColumnName("entityIDds")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PropValueDs)
                    .HasColumnName("propValueDs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PropertyIdds)
                    .HasMaxLength(20)
                    .HasColumnName("propertyIDds")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OutMapHeadStub>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.Groups, x.ProjectKey, x.PrintSequences });

                entity.ToTable("outMapHeadSTUB");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.EntityIds).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flags)
                    .HasMaxLength(16)
                    .HasColumnName("flags")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Masks)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(52)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StaticValue2Print)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Payee>(entity =>
            {
                entity.ToTable("Payee");

                entity.HasIndex(x => x.Name1, "Payee_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.PayeeId)
                    .HasMaxLength(22)
                    .HasColumnName("PayeeID");

                entity.Property(e => e.AdditionalRef)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Address5)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyZip)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Contact)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CountryPhone)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DefaultDiscretionary)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DfiaccountNumber)
                    .HasMaxLength(17)
                    .HasColumnName("DFIAccountNumber")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler1)
                    .HasMaxLength(312)
                    .HasColumnName("filler1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FontId)
                    .HasColumnName("FontID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name1)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Name2)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReceivingCompanyName)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReceivingDfiid)
                    .HasMaxLength(9)
                    .HasColumnName("ReceivingDFIid")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Spare1)
                    .HasMaxLength(10)
                    .HasColumnName("spare1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TypeOfAccount)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Payor>(entity =>
            {
                entity.HasKey(x => new { x.ProjectKey, x.Payorid });

                entity.ToTable("Payor");

                entity.HasIndex(x => x.Name1, "Payor_Index")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.Payorid).HasMaxLength(22);

                entity.Property(e => e.Achtype7DetailsNumbers)
                    .HasColumnName("ACHType7DetailsNumbers")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.Achtype7Q)
                    .HasColumnName("ACHType7Q")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CompanyZip)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Desc1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Desc2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Desc3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Dfiachcdv)
                    .HasMaxLength(1)
                    .HasColumnName("DFIACHcdv")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler2)
                    .HasMaxLength(525)
                    .HasColumnName("filler2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Font1).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Font2).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Font3).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Font4).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.FontId)
                    .HasColumnName("FontID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FtpProfile)
                    .HasMaxLength(4)
                    .HasColumnName("ftpProfile")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InmediateOrigin)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Irscode)
                    .HasMaxLength(30)
                    .HasColumnName("IRScode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MerchantId)
                    .HasColumnName("MerchantID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name1)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Name2)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OdfiInmediateName)
                    .HasMaxLength(23)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OriginatingDfiid)
                    .HasMaxLength(8)
                    .HasColumnName("originatingDFIid")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayAddress4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PclCheck>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.Group1, x.Order2Print });

                entity.ToTable("pclCHECK");

                entity.HasIndex(x => x.LineProperties, "pclCheck_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EntityId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flags)
                    .HasMaxLength(16)
                    .HasColumnName("flags")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LineProperties)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Mask)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Note)
                    .HasMaxLength(52)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PclStub>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pclSTUB");

                entity.HasIndex(x => new { x.LayoutId, x.GroupS, x.Order2PrintS }, "pclStub_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.DescriptionS)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EntityIdS).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlagsS)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LayoutId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinePropertiesS)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MaskS)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NoteS)
                    .HasMaxLength(52)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PosPayProf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PosPayProf");

                entity.HasIndex(x => new { x.BatchOrdate, x.SeqId }, "PosPay_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.AccountId)
                    .HasMaxLength(16)
                    .HasColumnName("Account_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AdditionalDescriptio)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Application)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BatchOrdate)
                    .HasMaxLength(4)
                    .HasColumnName("batchOrdate")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DefinitionCode)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExternalFunctionQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ftpprofile)
                    .HasMaxLength(4)
                    .HasColumnName("FTPprofile")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastDefaultValue)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Mode)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(10)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedDocumentsQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SchedulerQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedBatch).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedDateFrom).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedDateTo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedQ).HasDefaultValueSql("((1))");

                entity.Property(e => e.SentDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.SentTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeqId)
                    .HasMaxLength(2)
                    .HasColumnName("SeqID")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PropertyPcl>(entity =>
            {
                entity.HasKey(x => x.PropertyId);

                entity.ToTable("PropertyPCL");

                entity.Property(e => e.PropertyId)
                    .HasMaxLength(20)
                    .HasColumnName("PropertyID");

                entity.Property(e => e.PrefixCommand)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PtyDefaultSequence).HasDefaultValueSql("((0))");

                entity.Property(e => e.SuffixCommand)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ReconcBtchDet>(entity =>
            {
                entity.HasKey(x => x.BatchId);

                entity.ToTable("Reconc_BtchDet");

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("Batch_ID");

                entity.Property(e => e.AchGeneratedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.AchwhileprocessingFl)
                    .HasColumnName("ACHwhileprocessingFL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllChecksBatchPrinte).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutorizedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchImportDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.BatchPostedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.BatchPurgeDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.BatchPurgedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.CopyprintedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.DatePosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.DatePostedReptPrinte).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler9915)
                    .HasMaxLength(15)
                    .HasColumnName("FILLER99_15")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GpbatchId)
                    .HasMaxLength(22)
                    .HasColumnName("GPBatchId")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Gpdate)
                    .HasColumnName("GPDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherInfo)
                    .HasMaxLength(78)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password1)
                    .HasMaxLength(10)
                    .HasColumnName("password1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password2)
                    .HasMaxLength(10)
                    .HasColumnName("password2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PostedTobookQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostingGroupId)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ServerRefresedQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimePosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimePostedReportPrin).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalChecksinBatch).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalacknowledged)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Totalamountvalue)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.TypeofBatch)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Userbatchid)
                    .HasMaxLength(14)
                    .HasColumnName("userbatchid")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ReconcChecksH3>(entity =>
            {
                entity.HasKey(x => new { x.BatchId, x.RecordNo });

                entity.ToTable("Reconc_ChecksH3");

                entity.HasIndex(x => new { x.BatchId, x.CheckPrintedDateTime, x.AccountId, x.BankId, x.PayeeName, x.CheckAmount }, "Non-Clustered")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.BatchId).HasColumnName("Batch_ID");

                entity.Property(e => e.RecordNo).HasColumnName("Record_No");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Account_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(35)
                    .HasColumnName("Account_Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchStdEntryClassCode)
                    .HasMaxLength(3)
                    .HasColumnName("achStdEntryClassCode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchTranCode)
                    .HasMaxLength(2)
                    .HasColumnName("achTranCode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchTypeAcct)
                    .HasMaxLength(1)
                    .HasColumnName("achTypeAcct")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AchaddendaQ)
                    .HasColumnName("ACHAddendaQ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Achq)
                    .HasColumnName("ACHQ")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.AchreEnableQ)
                    .HasColumnName("ACHRe_EnableQ")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.AchroutingCdv)
                    .HasMaxLength(1)
                    .HasColumnName("ACHroutingCDV")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AdditionalUserId)
                    .HasMaxLength(10)
                    .HasColumnName("AdditionalUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankAddr1)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankAddr2)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankId)
                    .HasMaxLength(10)
                    .HasColumnName("Bank_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BankName)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BatchIdr)
                    .HasColumnName("BatchIDR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cdv2)
                    .HasMaxLength(2)
                    .HasColumnName("CDV2")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CdvAccountNo)
                    .HasMaxLength(2)
                    .HasColumnName("CDV_Account_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.CheckAmountAlpha)
                    .HasMaxLength(120)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckDateAlpha)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckDateYear).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(22)
                    .HasColumnName("Check_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CheckPrintedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1))")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.CheckType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClaimOrPurchaseOrde)
                    .HasColumnName("Claim_orPurchaseOrde")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClientLocation)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept1)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept2)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept3)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Concept4)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsecutiveNumber)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Contact)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CopyPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenter4Sign)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Counter).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(5)
                    .HasColumnName("CurrencyID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DateAlphaY2k)
                    .HasMaxLength(30)
                    .HasColumnName("DateAlphaY2K")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DfiacctNo)
                    .HasMaxLength(17)
                    .HasColumnName("DFIacctNo")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DirectDepositAccNumb)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DirectDepositBankNam)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Discounttotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.DontSendEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.EarnDeductAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EncryptAmount).HasMaxLength(100);

                entity.Property(e => e.EncryptCheckNo).HasMaxLength(100);

                entity.Property(e => e.EncryptPayee).HasMaxLength(140);

                entity.Property(e => e.ExportQ).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Filler15)
                    .HasMaxLength(33)
                    .HasColumnName("filler15")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ForTheAccountOf)
                    .HasMaxLength(75)
                    .HasColumnName("For_the_account_of")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GlCredit)
                    .HasColumnType("money")
                    .HasColumnName("GL_Credit")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.GlDebit)
                    .HasColumnType("money")
                    .HasColumnName("GL_Debit")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.GlacctReference)
                    .HasMaxLength(40)
                    .HasColumnName("GLAcctReference")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Grosstotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ImportDate)
                    .HasColumnName("Import_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Irscode)
                    .HasMaxLength(6)
                    .HasColumnName("IRScode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NumberofSignatures).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayeeAddr1)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr2)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr3)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr4)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeAddr5)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeId)
                    .HasMaxLength(22)
                    .HasColumnName("PayeeID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayeeName)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("('VOID VOID')");

                entity.Property(e => e.PayeeName2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PayorName)
                    .HasMaxLength(70)
                    .HasColumnName("Payor_Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Pdfname)
                    .HasMaxLength(100)
                    .HasColumnName("PDFName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PdfuniqueNameQ)
                    .HasColumnName("PDFUniqueNameQ")
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.PositivePayQ).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.Printed).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedBy)
                    .HasMaxLength(5)
                    .HasColumnName("Printed_By")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedDate)
                    .HasColumnName("Printed_Date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedDateAlpha)
                    .HasMaxLength(8)
                    .HasColumnName("Printed_DateAlpha")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedTime)
                    .HasMaxLength(8)
                    .HasColumnName("Printed_Time")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintedType)
                    .HasMaxLength(1)
                    .HasColumnName("Printed_Type")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProcessTime)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(8)
                    .HasColumnName("Program_Name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrintDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(N'getdate()')")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.RePrintReason)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrintUserId)
                    .HasMaxLength(10)
                    .HasColumnName("RePrintUserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RePrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecBatchPurgeQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecCheckNo)
                    .HasMaxLength(22)
                    .HasColumnName("RecCheck_No")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReceivingDfi)
                    .HasMaxLength(9)
                    .HasColumnName("ReceivingDFI")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReconcDate)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ReconciledQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordNoR).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReprintCount).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RequesterUser)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RoutingNumberMicr)
                    .HasMaxLength(12)
                    .HasColumnName("RoutingNumberMICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature1)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Signature2)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SpecialLongDescripti)
                    .HasMaxLength(180)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(11)
                    .HasColumnName("SSN")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.State)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StringAmount2)
                    .HasMaxLength(48)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StringAmount3)
                    .HasMaxLength(27)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ToBePrinted)
                    .HasColumnName("To_Be_Printed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transit1)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Transit2)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us1200)
                    .HasMaxLength(200)
                    .HasColumnName("US1200")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us2100)
                    .HasMaxLength(100)
                    .HasColumnName("US2100")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us3100)
                    .HasMaxLength(100)
                    .HasColumnName("US3100")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Us4200)
                    .HasMaxLength(200)
                    .HasColumnName("US4200")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserFieldMicr)
                    .HasMaxLength(15)
                    .HasColumnName("UserFieldMICR")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr10)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr11)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr12)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr13)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr14)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr15)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr16)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr17)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr18)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr19)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr20)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserStr5)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr6)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr7)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr8)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserStr9)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserVal13)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal14)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserVal15)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.UserbatchId)
                    .HasMaxLength(24)
                    .HasColumnName("UserbatchID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Userval1)
                    .HasColumnType("money")
                    .HasColumnName("USERval1")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval10)
                    .HasColumnType("money")
                    .HasColumnName("USERval10")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval11)
                    .HasColumnType("money")
                    .HasColumnName("USERval11")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval12)
                    .HasColumnType("money")
                    .HasColumnName("USERval12")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval16)
                    .HasColumnType("money")
                    .HasColumnName("USERval16")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval17)
                    .HasColumnType("money")
                    .HasColumnName("USERval17")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval18)
                    .HasColumnType("money")
                    .HasColumnName("USERval18")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval2)
                    .HasColumnType("money")
                    .HasColumnName("USERval2")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval3)
                    .HasColumnType("money")
                    .HasColumnName("USERval3")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval4)
                    .HasColumnType("money")
                    .HasColumnName("USERval4")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval5)
                    .HasColumnType("money")
                    .HasColumnName("USERval5")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval6)
                    .HasColumnType("money")
                    .HasColumnName("USERval6")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval7)
                    .HasColumnType("money")
                    .HasColumnName("USERval7")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval8)
                    .HasColumnType("money")
                    .HasColumnName("USERval8")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Userval9)
                    .HasColumnType("money")
                    .HasColumnName("USERval9")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.VendorRedundant)
                    .HasMaxLength(30)
                    .HasColumnName("Vendor_Redundant")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Void)
                    .HasColumnName("VOID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VoidDate)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VoucherOrPurOrder)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WhileProcessingVoi)
                    .HasColumnName("While_Processing_Voi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhileSigningFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ReconcImportHeader>(entity =>
            {
                entity.HasKey(x => x.BatchId);

                entity.ToTable("Reconc_ImportHeader");

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("Batch_ID");

                entity.Property(e => e.Filefilter)
                    .HasMaxLength(12)
                    .HasColumnName("filefilter")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filenameih)
                    .HasMaxLength(80)
                    .HasColumnName("FILENAMEih")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filesizeih)
                    .HasColumnType("money")
                    .HasColumnName("FILESIZEih")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Filler)
                    .HasMaxLength(135)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Importdate)
                    .HasColumnName("IMPORTDATE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importtime)
                    .HasColumnName("IMPORTTIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Recordcode)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ReportsXright>(entity =>
            {
                entity.HasKey(x => x.RightId);

                entity.Property(e => e.RightId)
                    .HasMaxLength(10)
                    .HasColumnName("RightID");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExProg2Call)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExternalRepQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.Filler)
                    .HasMaxLength(17)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.Property(e => e.RightId)
                    .HasMaxLength(10)
                    .HasColumnName("RightID");

                entity.Property(e => e.DescrptMainMenu)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DescrptSubMenu)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descrption1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Descrption2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RDescription)
                    .HasMaxLength(28)
                    .HasColumnName("rDescription")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RDisableAlertsL)
                    .HasColumnName("rDisableAlertsL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RReqAuth)
                    .HasColumnName("rReqAuth")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SignComboD>(entity =>
            {
                entity.HasKey(x => new { x.SeqNo, x.FontId });

                entity.ToTable("SignComboD");

                entity.Property(e => e.FontId).HasColumnName("FontID");

                entity.Property(e => e.FillerCd)
                    .HasMaxLength(14)
                    .HasColumnName("fillerCd")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<SignComboH>(entity =>
            {
                entity.HasKey(x => new { x.SeqNo, x.PayorId });

                entity.ToTable("SignComboH");

                entity.Property(e => e.PayorId)
                    .HasMaxLength(22)
                    .HasColumnName("PayorID");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerCh)
                    .HasMaxLength(10)
                    .HasColumnName("fillerCh")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FromAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.Reference)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SuggestedFromValue)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.SuggestedToValue)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))")
                    .HasAnnotation("Relational:ColumnType", "money");

                entity.Property(e => e.ToAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))")
                    .HasAnnotation("Relational:ColumnType", "money");
            });

            modelBuilder.Entity<SignatCostCenter>(entity =>
            {
                entity.HasKey(x => new { x.TypeOfAccount, x.FontId, x.ProjectKey });

                entity.ToTable("signatCostCenters");

                entity.Property(e => e.TypeOfAccount).HasMaxLength(12);

                entity.Property(e => e.FontId).HasColumnName("FontID");

                entity.Property(e => e.Filler)
                    .HasMaxLength(38)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MaxValue)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasAnnotation("Relational:ColumnType", "money");
            });

            modelBuilder.Entity<SynLinkChildDoc>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.SlUsePurpose, x.ProjectKey });

                entity.ToTable("SynLinkChildDoc");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.SlUsePurpose)
                    .HasMaxLength(5)
                    .HasColumnName("slUsePurpose");

                entity.Property(e => e.Desc1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Desc2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Desc3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlAdditionalFlags)
                    .HasMaxLength(34)
                    .HasColumnName("slAdditionalFlags")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlAppl)
                    .HasMaxLength(2)
                    .HasColumnName("slAppl")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlDocsXpage)
                    .HasColumnName("slDocsXpage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SlExportId)
                    .HasMaxLength(4)
                    .HasColumnName("slExportID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlInitString)
                    .HasMaxLength(39)
                    .HasColumnName("slInitString")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlLinesXdoc)
                    .HasColumnName("slLinesXdoc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SlMode)
                    .HasMaxLength(2)
                    .HasColumnName("slMode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlOmitInit)
                    .HasColumnName("slOmitInit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SlOrientation)
                    .HasMaxLength(1)
                    .HasColumnName("slOrientation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SlPaperSize)
                    .HasMaxLength(2)
                    .HasColumnName("slPaperSize")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.SlPrinterSecFeature)
                    .HasMaxLength(1)
                    .HasColumnName("slPrinterSecFeature")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlTempFile)
                    .HasMaxLength(10)
                    .HasColumnName("slTempFile")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SlTray)
                    .HasMaxLength(1)
                    .HasColumnName("slTray")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.SlformId)
                    .HasMaxLength(10)
                    .HasColumnName("slformID")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Synonym>(entity =>
            {
                entity.HasKey(x => new { x.UserCodeDocType, x.LayoutId, x.ProjectKey });

                entity.Property(e => e.UserCodeDocType).HasMaxLength(10);

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.Application).HasMaxLength(2);

                entity.Property(e => e.Col1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Col3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DescripSyn)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DetailStyle)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DocsXpage).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndofBatchPathS)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EobName)
                    .HasMaxLength(30)
                    .HasColumnName("eobName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExportFileCode)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Filler)
                    .HasMaxLength(247)
                    .HasColumnName("filler")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HorizMicradj)
                    .HasColumnName("HorizMICRadj")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IntegratedPrintEngin).HasDefaultValueSql("((1))");

                entity.Property(e => e.PostProcessing)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PrintEnginePath)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ScreenCode)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VertMicradj)
                    .HasColumnName("VertMICRadj")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sysdiagram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<TemplatesxPrinter>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.ProjectKey });

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(25)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.AssignedPrinter).HasMaxLength(100);

                entity.Property(e => e.Col1).HasMaxLength(50);

                entity.Property(e => e.Col2).HasMaxLength(50);

                entity.Property(e => e.Col3).HasMaxLength(50);

                entity.Property(e => e.InitString).HasMaxLength(100);

                entity.Property(e => e.Initializ).HasMaxLength(100);

                entity.Property(e => e.MarginName).HasMaxLength(100);

                entity.Property(e => e.Orientation).HasMaxLength(1);

                entity.Property(e => e.PaperSize).HasMaxLength(2);

                entity.Property(e => e.PrinterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PrinterID");

                entity.Property(e => e.PrinterSecurityFeatu).HasMaxLength(1);
            });

            modelBuilder.Entity<TemplatesxPrintersAll>(entity =>
            {
                entity.ToTable("TemplatesxPrintersALL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PrinterName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShareName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UpdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WindowsPc)
                    .HasMaxLength(150)
                    .HasColumnName("WindowsPC")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WindowsUser)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<TemplatesxPrintersByUsersCheckBook>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.UserId });

                entity.ToTable("TemplatesxPrinters_ByUsersCheckBooks");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(25)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID");

                entity.Property(e => e.DateTimeEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<TemplatesxPrintersByUsersManageCheck>(entity =>
            {
                entity.HasKey(x => new { x.LayoutId, x.UserId });

                entity.ToTable("TemplatesxPrinters_ByUsersManageChecks");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(25)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID");

                entity.Property(e => e.DateTimeEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<TemplatesxPrintersPcsNetwork>(entity =>
            {
                entity.HasKey(x => x.Idindex);

                entity.ToTable("TemplatesxPrintersPCsNetwork");

                entity.Property(e => e.Idindex).HasColumnName("IDIndex");

                entity.Property(e => e.Col1).HasMaxLength(50);

                entity.Property(e => e.Col2).HasMaxLength(50);

                entity.Property(e => e.Col3).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Pcname)
                    .HasMaxLength(300)
                    .HasColumnName("PCName");
            });

            modelBuilder.Entity<TemplatesxPrintersSplit>(entity =>
            {
                entity.HasKey(x => x.SplitId);

                entity.ToTable("TemplatesxPrintersSplit");

                entity.Property(e => e.SplitId).HasColumnName("SplitID");

                entity.Property(e => e.AssignedPrinter).HasMaxLength(100);

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(25)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.LayoutPrinterLocation).HasMaxLength(25);

                entity.Property(e => e.PrinterDescription).HasMaxLength(100);

                entity.Property(e => e.PrinterId).HasColumnName("PrinterID");

                entity.Property(e => e.PrinterShareName).HasMaxLength(50);

                entity.Property(e => e.ServerName).HasMaxLength(50);
            });

            modelBuilder.Entity<TemplxPrinterSecurityFeat>(entity =>
            {
                entity.HasKey(x => x.PrinterSecurityFeatu);

                entity.ToTable("TemplxPrinterSecurityFeat");

                entity.Property(e => e.PrinterSecurityFeatu).HasMaxLength(1);

                entity.Property(e => e.AmtPrefix)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AmtSufix)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Micrprefix)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("MICRPrefix")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Micrsufix)
                    .HasMaxLength(50)
                    .HasColumnName("MICRSufix")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Pclinitialization)
                    .HasMaxLength(200)
                    .HasColumnName("PCLInitialization")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Pclprefix)
                    .HasMaxLength(200)
                    .HasColumnName("PCLPrefix")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Pclsuffix)
                    .HasMaxLength(150)
                    .HasColumnName("PCLSuffix")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<TraysXlayoutPool>(entity =>
            {
                entity.HasKey(x => x.LayoutId);

                entity.ToTable("traysXlayoutPool");

                entity.Property(e => e.LayoutId)
                    .HasMaxLength(10)
                    .HasColumnName("LayoutID");

                entity.Property(e => e.AssignedPrinterP)
                    .HasMaxLength(39)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InitStringP)
                    .HasMaxLength(39)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MarginNameP)
                    .HasMaxLength(29)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OmitInitializationQp).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNumberP).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrientationP)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaperSizeP)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedQp).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrayNumberP).HasDefaultValueSql("((5))");
            });

            modelBuilder.Entity<TypesAccount>(entity =>
            {
                entity.HasKey(x => new { x.TypeofAccount, x.ProjectKey });

                entity.Property(e => e.TypeofAccount).HasMaxLength(12);

                entity.Property(e => e.AccountId)
                    .HasMaxLength(16)
                    .HasColumnName("Account_ID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Description)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FillerTa)
                    .HasMaxLength(50)
                    .HasColumnName("fillerTA")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MaxValueDefault)
                    .HasColumnType("money")
                    .HasDefaultValueSql("(N'')")
                    .HasAnnotation("Relational:ColumnType", "money");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(x => new { x.LastPasscodeChange, x.EncryptPassword }, "Users_Idx")
                    .HasFillFactor((byte)30);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID");

                entity.Property(e => e.Desc1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Desc2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EncryptPassword).HasMaxLength(50);

                entity.Property(e => e.ExpiredPasscodeQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.InactiveQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPasscodeChange)
                    .HasColumnName("lastPasscodeChange")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoofLogin).HasDefaultValueSql("((0))");

                entity.Property(e => e.UPasscode)
                    .HasMaxLength(10)
                    .HasColumnName("uPasscode")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ufrist)
                    .HasMaxLength(35)
                    .HasColumnName("UFrist")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ulast)
                    .HasMaxLength(35)
                    .HasColumnName("ULast")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserInfo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Utitle)
                    .HasMaxLength(30)
                    .HasColumnName("UTitle")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(x => new { x.GroupId, x.UserId });

                entity.Property(e => e.GroupId)
                    .HasMaxLength(10)
                    .HasColumnName("GroupID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID");

                entity.Property(e => e.UgAssignedQ)
                    .HasColumnName("ugAssignedQ")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroups)
                    .HasForeignKey(x => x.UserId)
                    .HasConstraintName("FK_UserGroups_Users");
            });

            modelBuilder.Entity<UserPassHistory>(entity =>
            {
                entity.HasKey(x => x.IdentityId)
                    .HasName("PK_User_PassHistory_1");

                entity.ToTable("User_PassHistory");

                entity.Property(e => e.IdentityId).HasColumnName("IdentityID");

                entity.Property(e => e.PassDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<UserRight>(entity =>
            {
                entity.HasKey(x => new { x.UserId, x.RightId });

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .HasColumnName("UserID");

                entity.Property(e => e.RightId)
                    .HasMaxLength(10)
                    .HasColumnName("RightID");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(10)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UrAssigned)
                    .HasColumnName("urAssigned")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(x => x.UserId)
                    .HasConstraintName("FK_UserRights_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
