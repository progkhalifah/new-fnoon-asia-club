using fnoonasiaclub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace fnoonasiaclub.Data
{
    public class ApplicationDbContext : IdentityDbContext<TblRegistrationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public virtual DbSet<AladaNadiWaiting> AladaNadiWaiting { get; set; }
        public virtual DbSet<Alhwodor> Alhwodor { get; set; }
        public virtual DbSet<Almosthdmeen> Almosthdmeen { get; set; }
        public virtual DbSet<HarkatAadaWaiting> HarkatAadaWaiting { get; set; }
        public virtual DbSet<ShehdatEtehad> ShehdatEtehad { get; set; }
        public virtual DbSet<TbAdvert> TbAdvert { get; set; }
        public virtual DbSet<TbAdvertDetails> TbAdvertDetails { get; set; }
        public virtual DbSet<TbBelt> TbBelt { get; set; }
        public virtual DbSet<TbBranch> TbBranch { get; set; }
        public virtual DbSet<TbClass> TbClass { get; set; }
        public virtual DbSet<TbDetails> TbDetails { get; set; }
        public virtual DbSet<TbGames> TbGames { get; set; }
        public virtual DbSet<TbPlayer> TbPlayer { get; set; }
        public virtual DbSet<TbSubscition> TbSubscition { get; set; }
        public virtual DbSet<TbUserName> TbUserName { get; set; }
        public virtual DbSet<TblAccReport> TblAccReport { get; set; }
        public virtual DbSet<TblAccTypes> TblAccTypes { get; set; }
        public virtual DbSet<TblAccounts> TblAccounts { get; set; }
        public virtual DbSet<TblBank> TblBank { get; set; }
        public virtual DbSet<TblBondDetails> TblBondDetails { get; set; }
        public virtual DbSet<TblBondHdr> TblBondHdr { get; set; }
        public virtual DbSet<TblBondTypes> TblBondTypes { get; set; }
        public virtual DbSet<TblCash> TblCash { get; set; }
        public virtual DbSet<TblCategories> TblCategories { get; set; }
        public virtual DbSet<TblCompany> TblCompany { get; set; }
        public virtual DbSet<TblCurrTypes> TblCurrTypes { get; set; }
        public virtual DbSet<TblCurrencies> TblCurrencies { get; set; }
        public virtual DbSet<TblJTypes> TblJTypes { get; set; }
        public virtual DbSet<TblJournalDetails> TblJournalDetails { get; set; }
        public virtual DbSet<TblJournalHdr> TblJournalHdr { get; set; }
        public virtual DbSet<TblKarateCertificate> TblKarateCertificate { get; set; }
        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblOrdersDetails> TblOrdersDetails { get; set; }
        public virtual DbSet<TblProcess> TblProcess { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }
        public virtual DbSet<TblTaekwondoCertificate> TblTaekwondoCertificate { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }
        public virtual DbSet<ToDay> ToDay { get; set; }
        public virtual DbSet<UserName> UserName { get; set; }
        public virtual DbSet<ViewEstmara> ViewEstmara { get; set; }
        public virtual DbSet<ViewInfoUsers> ViewInfoUsers { get; set; }
        public virtual DbSet<ViewTaekwondoCertification> ViewTaekwondoCertification { get; set; }
        public virtual DbSet<ViewUserInformation> ViewUserInformation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AladaNadiWaiting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddAnotherGame)
                    .HasColumnName("Add_another_game")
                    .HasMaxLength(200);

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Cellphone).HasMaxLength(200);

                entity.Property(e => e.Cellphone2).HasMaxLength(200);

                entity.Property(e => e.DateBirth).HasMaxLength(200);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DurationAnotherGame)
                    .HasColumnName("duration_another_game")
                    .HasMaxLength(200);

                entity.Property(e => e.DurationMonth)
                    .HasColumnName("duration_month")
                    .HasMaxLength(200);

                entity.Property(e => e.Game)
                    .HasColumnName("game")
                    .HasMaxLength(200);

                entity.Property(e => e.GuardianWork).HasMaxLength(200);

                entity.Property(e => e.Identification).HasMaxLength(200);

                entity.Property(e => e.ImageTransfer)
                    .HasColumnName("image_transfer")
                    .HasColumnType("image");

                entity.Property(e => e.NameA)
                    .HasColumnName("Name_A")
                    .HasMaxLength(200);

                entity.Property(e => e.Nationality).HasMaxLength(200);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(200);

                entity.Property(e => e.Place).HasMaxLength(200);
            });

            modelBuilder.Entity<Alhwodor>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Idplay, e.Iid, e.Place, e.DateM });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idplay).HasColumnName("IDplay");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Place).HasMaxLength(20);

                entity.Property(e => e.DateM)
                    .HasColumnName("dateM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormN)
                    .HasColumnName("formN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idmostow).HasColumnName("IDmostow");

                entity.Property(e => e.Idmovement).HasColumnName("IDmovement");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.NumberExercises).HasMaxLength(3);

                entity.Property(e => e.RecordingTime).HasColumnType("datetime");

                entity.Property(e => e.Taweeth)
                    .HasColumnName("taweeth")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tcheck).HasColumnName("tcheck");

                entity.Property(e => e.TcheckK).HasColumnName("tcheckK");

                entity.Property(e => e.TmareenMotabake).HasColumnName("tmareenMotabake");

                entity.Property(e => e.ToDay)
                    .HasColumnName("toDay")
                    .HasMaxLength(100);

                entity.Property(e => e.ToT)
                    .HasColumnName("toT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Almosthdmeen>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mos).HasColumnName("mos");

                entity.Property(e => e.NameKaml).HasMaxLength(255);

                entity.Property(e => e.Oma).HasColumnName("oma");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Tak).HasColumnName("tak");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<HarkatAadaWaiting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DurationMonths)
                    .HasColumnName("duration_months")
                    .HasMaxLength(20);

                entity.Property(e => e.Feetype)
                    .HasColumnName("feetype")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Game)
                    .HasColumnName("game")
                    .HasMaxLength(50);

                entity.Property(e => e.IidAladaNadi).HasColumnName("IID_Alada_Nadi");

                entity.Property(e => e.ImageTransfer)
                    .HasColumnName("image_transfer")
                    .HasColumnType("image");

                entity.Property(e => e.NamePlayer)
                    .HasColumnName("name_player")
                    .HasMaxLength(50);

                entity.Property(e => e.Place)
                    .HasColumnName("place")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShehdatEtehad>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alhezam)
                    .HasColumnName("alhezam")
                    .HasMaxLength(15);

                entity.Property(e => e.DateDay)
                    .HasColumnName("dateDay")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateM).HasMaxLength(10);

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.Masdrha).HasMaxLength(50);

                entity.Property(e => e.NamePlay)
                    .HasColumnName("namePlay")
                    .HasMaxLength(12);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(50);

                entity.Property(e => e.NumMsave).HasColumnName("numMsave");

                entity.Property(e => e.NumShehada).HasColumnName("numShehada");

                entity.Property(e => e.Place)
                    .HasColumnName("place")
                    .HasMaxLength(15);

                entity.Property(e => e.TimeDay)
                    .HasColumnName("timeDay")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbAdvert>(entity =>
            {
                entity.ToTable("Tb_Advert");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dh)
                    .HasColumnName("dh")
                    .HasMaxLength(10);

                entity.Property(e => e.Dhh)
                    .HasColumnName("dhh")
                    .HasMaxLength(10);

                entity.Property(e => e.Dm)
                    .HasColumnName("dm")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmm)
                    .HasColumnName("dmm")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormHezam)
                    .HasColumnName("formHezam")
                    .HasMaxLength(15);

                entity.Property(e => e.NameMostow).HasMaxLength(30);

                entity.Property(e => e.NamePlay).HasMaxLength(15);

                entity.Property(e => e.TimeD)
                    .HasColumnName("timeD")
                    .HasMaxLength(20);

                entity.Property(e => e.ToHezam)
                    .HasColumnName("toHezam")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TbAdvertDetails>(entity =>
            {
                entity.HasKey(e => new { e.Iid, e.DateDay, e.Place })
                    .HasName("PK_ELanTB");

                entity.ToTable("Tb_AdvertDetails");

                entity.Property(e => e.Iid).HasColumnName("IID");

                entity.Property(e => e.DateDay)
                    .HasColumnName("dateDay")
                    .HasColumnType("datetime");

                entity.Property(e => e.Place)
                    .HasColumnName("place")
                    .HasMaxLength(20);

                entity.Property(e => e.Dh)
                    .HasColumnName("dh")
                    .HasMaxLength(10);

                entity.Property(e => e.Dhh)
                    .HasColumnName("dhh")
                    .HasMaxLength(10);

                entity.Property(e => e.Dm)
                    .HasColumnName("dm")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dmm)
                    .HasColumnName("dmm")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormHezam).HasColumnName("formHezam");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idplay).HasColumnName("IDplay");

                entity.Property(e => e.NameA)
                    .HasColumnName("nameA")
                    .HasMaxLength(100);

                entity.Property(e => e.NameMostow).HasMaxLength(30);

                entity.Property(e => e.NamePlay).HasMaxLength(15);

                entity.Property(e => e.TimeD)
                    .HasColumnName("timeD")
                    .HasMaxLength(20);

                entity.Property(e => e.ToHezam).HasColumnName("toHezam");
            });

            modelBuilder.Entity<TbBelt>(entity =>
            {
                entity.HasKey(e => e.IdBelt);

                entity.ToTable("Tb_Belt");

                entity.Property(e => e.IdBelt).HasColumnName("ID_Belt");

                entity.Property(e => e.IdPlay).HasColumnName("ID_play");

                entity.Property(e => e.NameBelt).HasMaxLength(10);
            });

            modelBuilder.Entity<TbBranch>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("TB_branch");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchNum)
                    .HasColumnName("branch_num")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TbClass>(entity =>
            {
                entity.HasKey(e => e.IdClass);

                entity.ToTable("TB_class");

                entity.Property(e => e.IdClass).HasColumnName("ID_class");

                entity.Property(e => e.NumClass)
                    .HasColumnName("num_class")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TbDetails>(entity =>
            {
                entity.HasKey(e => e.NumDetails);

                entity.ToTable("TB_Details");

                entity.Property(e => e.NumDetails).HasColumnName("num_details");

                entity.Property(e => e.Arrest).HasColumnName("arrest");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("dateEnd")
                    .HasMaxLength(10);

                entity.Property(e => e.DateStart)
                    .HasColumnName("dateStart")
                    .HasMaxLength(10);

                entity.Property(e => e.IdBelt).HasColumnName("ID_Belt");

                entity.Property(e => e.IdPlay).HasColumnName("ID_play");

                entity.Property(e => e.IdSub).HasColumnName("ID_sub");

                entity.Property(e => e.NumClass)
                    .HasColumnName("num_class")
                    .HasMaxLength(10);

                entity.Property(e => e.NumDay).HasColumnName("num_day");

                entity.Property(e => e.NumExreises).HasColumnName("Num_exreises");

                entity.Property(e => e.RestExercises)
                    .HasColumnName("restExercises")
                    .HasComputedColumnSql("((0))");

                entity.Property(e => e.StatNo).HasColumnName("stat_no");

                entity.Property(e => e.ToDay)
                    .HasColumnName("to_day")
                    .HasMaxLength(50);

                entity.Property(e => e.TxtDetails)
                    .HasColumnName("txt_details")
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbGames>(entity =>
            {
                entity.HasKey(e => e.IdPlay);

                entity.ToTable("Tb_Games");

                entity.Property(e => e.IdPlay).HasColumnName("ID_play");

                entity.Property(e => e.NamePlay)
                    .HasColumnName("namePlay")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TbPlayer>(entity =>
            {
                entity.HasKey(e => e.StatNo);

                entity.Property(e => e.StatNo)
                    .HasColumnName("stat_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.BranchNo).HasColumnName("Branch_No");

                entity.Property(e => e.Cellphone).HasMaxLength(10);

                entity.Property(e => e.Cellphone2).HasMaxLength(10);

                entity.Property(e => e.DateDay).HasMaxLength(10);

                entity.Property(e => e.DurationMonth).HasColumnName("duration_month");

                entity.Property(e => e.GuardianworkNo)
                    .HasColumnName("Guardianwork_No")
                    .HasMaxLength(20);

                entity.Property(e => e.HealthStatus).HasMaxLength(50);

                entity.Property(e => e.Higry)
                    .HasColumnName("higry")
                    .HasMaxLength(10);

                entity.Property(e => e.Identification).HasMaxLength(255);

                entity.Property(e => e.ImagePlayer)
                    .HasColumnName("image_player")
                    .HasColumnType("image");

                entity.Property(e => e.NameA)
                    .HasColumnName("Name_A")
                    .HasMaxLength(100);

                entity.Property(e => e.NameE)
                    .HasColumnName("name_E")
                    .HasMaxLength(100);

                entity.Property(e => e.NameplayNo)
                    .HasColumnName("Nameplay_No")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalityNo)
                    .HasColumnName("Nationality_No")
                    .HasMaxLength(15);

                entity.Property(e => e.OldId).HasColumnName("old_ID");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.PlayerEmail)
                    .HasColumnName("Player_Email")
                    .HasMaxLength(50);

                entity.HasOne(d => d.BranchNoNavigation)
                    .WithMany(p => p.TbPlayer)
                    .HasForeignKey(d => d.BranchNo)
                    .HasConstraintName("FK_TbPlayer_TB_branch");
            });

            modelBuilder.Entity<TbSubscition>(entity =>
            {
                entity.HasKey(e => e.IdSub);

                entity.ToTable("tb_subscition");

                entity.Property(e => e.IdSub).HasColumnName("ID_sub");

                entity.Property(e => e.NameSub)
                    .HasColumnName("Name_sub")
                    .HasMaxLength(10);

                entity.Property(e => e.NumDay).HasColumnName("num_day");

                entity.Property(e => e.NumExreises).HasColumnName("Num_exreises");
            });

            modelBuilder.Entity<TbUserName>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("tb_UserName");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(30);

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(50);

                entity.Property(e => e.IdBranch).HasColumnName("ID_branch");

                entity.Property(e => e.Psw).HasMaxLength(255);
            });

            modelBuilder.Entity<TblAccReport>(entity =>
            {
                entity.HasKey(e => e.AccRepNo)
                    .HasName("PK_tbl_Report");

                entity.ToTable("tbl_Acc_Report");

                entity.Property(e => e.AccRepNo).HasColumnName("acc_Rep_No");

                entity.Property(e => e.AccRepAname)
                    .HasColumnName("acc_Rep_Aname")
                    .HasMaxLength(20);

                entity.Property(e => e.AccRepEname)
                    .HasColumnName("acc_Rep_Ename")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblAccTypes>(entity =>
            {
                entity.HasKey(e => e.AccTypeNo);

                entity.ToTable("tbl_Acc_Types");

                entity.Property(e => e.AccTypeNo).HasColumnName("acc_Type_No");

                entity.Property(e => e.AccTypeAname)
                    .HasColumnName("acc_Type_Aname")
                    .HasMaxLength(10);

                entity.Property(e => e.AccTypeEname)
                    .HasColumnName("acc_Type_Ename")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblAccounts>(entity =>
            {
                entity.HasKey(e => e.AccNo)
                    .HasName("PK_tbl_Account");

                entity.ToTable("tbl_Accounts");

                entity.Property(e => e.AccNo)
                    .HasColumnName("acc_No")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccAname)
                    .HasColumnName("acc_Aname")
                    .HasMaxLength(60);

                entity.Property(e => e.AccBalance)
                    .HasColumnName("acc_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.AccCredit)
                    .HasColumnName("acc_Credit")
                    .HasColumnType("money");

                entity.Property(e => e.AccDebit)
                    .HasColumnName("acc_Debit")
                    .HasColumnType("money");

                entity.Property(e => e.AccLevel).HasColumnName("acc_Level");

                entity.Property(e => e.AccParentNo).HasColumnName("acc_Parent_No");

                entity.Property(e => e.AccReport).HasColumnName("acc_Report");

                entity.Property(e => e.AccType).HasColumnName("acc_Type");
            });

            modelBuilder.Entity<TblBank>(entity =>
            {
                entity.HasKey(e => e.BAccNo);

                entity.ToTable("tbl_Bank");

                entity.Property(e => e.BAccNo)
                    .HasColumnName("b_acc_No")
                    .ValueGeneratedNever();

                entity.Property(e => e.BAccName)
                    .IsRequired()
                    .HasColumnName("b_acc_Name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblBondDetails>(entity =>
            {
                entity.ToTable("tbl_Bond_Details");

                entity.Property(e => e.Id).HasColumnName("_ID");

                entity.Property(e => e.AccNo).HasColumnName("acc_No");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BCurr).HasColumnName("b_Curr");

                entity.Property(e => e.BNo).HasColumnName("b_No");

                entity.Property(e => e.BNote)
                    .HasColumnName("b_Note")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrExch)
                    .HasColumnName("curr_exch")
                    .HasColumnType("money");

                entity.HasOne(d => d.BNoNavigation)
                    .WithMany(p => p.TblBondDetails)
                    .HasForeignKey(d => d.BNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbl_Bond_Details_tbl_Bond_HDR");
            });

            modelBuilder.Entity<TblBondHdr>(entity =>
            {
                entity.HasKey(e => e.BNo);

                entity.ToTable("tbl_Bond_HDR");

                entity.Property(e => e.BNo)
                    .HasColumnName("b_No")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccBalance)
                    .HasColumnName("acc_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.AccBankNo).HasColumnName("acc_Bank_No");

                entity.Property(e => e.AccCashNo).HasColumnName("acc_Cash_No");

                entity.Property(e => e.AddDate)
                    .HasColumnName("add_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BDate)
                    .HasColumnName("b_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BNote)
                    .HasColumnName("b_Note")
                    .HasMaxLength(200);

                entity.Property(e => e.BPost).HasColumnName("b_Post");

                entity.Property(e => e.BType).HasColumnName("b_Type");

                entity.Property(e => e.EditDate)
                    .HasColumnName("edit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JNo).HasColumnName("j_no");

                entity.Property(e => e.UAdd).HasColumnName("u_Add");

                entity.Property(e => e.UEdit).HasColumnName("u_Edit");
            });

            modelBuilder.Entity<TblBondTypes>(entity =>
            {
                entity.HasKey(e => e.BndTypeNo);

                entity.ToTable("tbl_Bond_Types");

                entity.Property(e => e.BndTypeNo).HasColumnName("bnd_Type_No");

                entity.Property(e => e.BndTypeAname)
                    .HasColumnName("bnd_Type_Aname")
                    .HasMaxLength(10);

                entity.Property(e => e.BndTypeEname)
                    .HasColumnName("bnd_Type_Ename")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblCash>(entity =>
            {
                entity.HasKey(e => e.CAccNo);

                entity.ToTable("tbl_Cash");

                entity.Property(e => e.CAccNo)
                    .HasColumnName("c_acc_No")
                    .ValueGeneratedNever();

                entity.Property(e => e.CAccName)
                    .IsRequired()
                    .HasColumnName("c_acc_Name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblCategories>(entity =>
            {
                entity.HasKey(e => e.IdCat)
                    .HasName("PK_tbl_Category");

                entity.ToTable("tbl_Categories");

                entity.Property(e => e.IdCat)
                    .HasColumnName("ID_cat")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescriptionCat)
                    .HasColumnName("description_cat")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.HasKey(e => e.CNo);

                entity.ToTable("tbl_Company");

                entity.Property(e => e.CNo)
                    .HasColumnName("c_No")
                    .ValueGeneratedNever();

                entity.Property(e => e.CAname)
                    .IsRequired()
                    .HasColumnName("c_Aname")
                    .HasMaxLength(200);

                entity.Property(e => e.CApos)
                    .IsRequired()
                    .HasColumnName("c_Apos")
                    .HasMaxLength(200);

                entity.Property(e => e.CEmail)
                    .HasColumnName("c_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.CEname)
                    .HasColumnName("c_Ename")
                    .HasMaxLength(200);

                entity.Property(e => e.CEpos)
                    .HasColumnName("c_Epos")
                    .HasMaxLength(200);

                entity.Property(e => e.CFax)
                    .HasColumnName("c_Fax")
                    .HasMaxLength(20);

                entity.Property(e => e.CLogo)
                    .HasColumnName("c_Logo")
                    .HasColumnType("image");

                entity.Property(e => e.CTel)
                    .IsRequired()
                    .HasColumnName("c_Tel")
                    .HasMaxLength(20);

                entity.Property(e => e.CWebsite)
                    .HasColumnName("c_Website")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCurrTypes>(entity =>
            {
                entity.HasKey(e => e.CurrTypeNo);

                entity.ToTable("tbl_Curr_Types");

                entity.Property(e => e.CurrTypeNo).HasColumnName("curr_Type_No");

                entity.Property(e => e.CurrTypeAname)
                    .HasColumnName("curr_Type_Aname")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrTypeEname)
                    .HasColumnName("curr_Type_Ename")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblCurrencies>(entity =>
            {
                entity.HasKey(e => e.CurrNo)
                    .HasName("PK_tbl_Currences");

                entity.ToTable("tbl_Currencies");

                entity.Property(e => e.CurrNo).HasColumnName("curr_No");

                entity.Property(e => e.CurrEname)
                    .HasColumnName("curr_Ename")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrExch)
                    .HasColumnName("curr_Exch")
                    .HasColumnType("money");

                entity.Property(e => e.CurrName)
                    .IsRequired()
                    .HasColumnName("curr_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrPart)
                    .IsRequired()
                    .HasColumnName("curr_Part")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrSymbol)
                    .IsRequired()
                    .HasColumnName("curr_Symbol")
                    .HasMaxLength(3);

                entity.Property(e => e.CurrType).HasColumnName("curr_Type");
            });

            modelBuilder.Entity<TblJTypes>(entity =>
            {
                entity.HasKey(e => e.JtypeNo);

                entity.ToTable("tbl_jTypes");

                entity.Property(e => e.JtypeNo).HasColumnName("Jtype_No");

                entity.Property(e => e.JtypeAname)
                    .HasColumnName("Jtype_Aname")
                    .HasMaxLength(10);

                entity.Property(e => e.JtypeEname)
                    .HasColumnName("Jtype_Ename")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblJournalDetails>(entity =>
            {
                entity.ToTable("tbl_Journal_Details");

                entity.Property(e => e.Id).HasColumnName("_ID");

                entity.Property(e => e.AccCredit)
                    .HasColumnName("acc_Credit")
                    .HasColumnType("money");

                entity.Property(e => e.AccDebit)
                    .HasColumnName("acc_Debit")
                    .HasColumnType("money");

                entity.Property(e => e.AccNo).HasColumnName("acc_No");

                entity.Property(e => e.AccNote)
                    .HasColumnName("acc_Note")
                    .HasMaxLength(100);

                entity.Property(e => e.JNo).HasColumnName("j_No");

                entity.HasOne(d => d.JNoNavigation)
                    .WithMany(p => p.TblJournalDetails)
                    .HasForeignKey(d => d.JNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbl_Journal_Details_tbl_Journal_HDR");
            });

            modelBuilder.Entity<TblJournalHdr>(entity =>
            {
                entity.HasKey(e => e.JNo);

                entity.ToTable("tbl_Journal_HDR");

                entity.Property(e => e.JNo)
                    .HasColumnName("j_No")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate)
                    .HasColumnName("add_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrExch)
                    .HasColumnName("curr_exch")
                    .HasColumnType("money");

                entity.Property(e => e.CurrNo).HasColumnName("curr_no");

                entity.Property(e => e.EditDate)
                    .HasColumnName("edit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JDate)
                    .HasColumnName("j_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.JNote)
                    .IsRequired()
                    .HasColumnName("j_Note")
                    .HasMaxLength(200);

                entity.Property(e => e.JPost).HasColumnName("j_Post");

                entity.Property(e => e.JType).HasColumnName("j_Type");

                entity.Property(e => e.PNo).HasColumnName("p_no");

                entity.Property(e => e.TBalance)
                    .HasColumnName("t_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.TCredit)
                    .HasColumnName("t_Credit")
                    .HasColumnType("money");

                entity.Property(e => e.TDebit)
                    .HasColumnName("t_Debit")
                    .HasColumnType("money");

                entity.Property(e => e.UAdd).HasColumnName("u_Add");

                entity.Property(e => e.UEdit).HasColumnName("u_Edit");
            });

            modelBuilder.Entity<TblKarateCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_karate_certificate");

                entity.Property(e => e.DateRegister)
                    .HasColumnName("date_register")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KrtBirthday)
                    .HasColumnName("krt_birthday")
                    .HasMaxLength(100);

                entity.Property(e => e.KrtBranchAsia)
                    .HasColumnName("krt_branch_asia")
                    .HasMaxLength(250);

                entity.Property(e => e.KrtFstPhone).HasColumnName("krt_fst_phone");

                entity.Property(e => e.KrtFullNameAr)
                    .HasColumnName("krt_full_name_ar")
                    .HasMaxLength(250);

                entity.Property(e => e.KrtId).HasColumnName("krt_id");

                entity.Property(e => e.KrtIdentification).HasColumnName("krt_identification");

                entity.Property(e => e.KrtImagePlayer)
                    .HasColumnName("krt_image_player")
                    .HasColumnType("image");

                entity.Property(e => e.KrtSedPhone).HasColumnName("krt_sed_phone");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("tbl_Order");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("ID_order")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOrder)
                    .HasColumnName("Date_order")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescriptionOrder).HasColumnName("description_order");

                entity.Property(e => e.SalesMan)
                    .HasColumnName("sales_man")
                    .HasMaxLength(250);

                entity.Property(e => e.StatNoPlayer).HasColumnName("stat_no_player");

                entity.HasOne(d => d.StatNoPlayerNavigation)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.StatNoPlayer)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbl_Order_TbPlayer");
            });

            modelBuilder.Entity<TblOrdersDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Orders_Details");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasMaxLength(100);

                entity.Property(e => e.Dicount).HasColumnName("dicount");

                entity.Property(e => e.IdOrder).HasColumnName("ID_order");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_product")
                    .HasMaxLength(50);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbl_Orders_Details_tbl_Order");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbl_Orders_Details_tbl_Products");
            });

            modelBuilder.Entity<TblProcess>(entity =>
            {
                entity.HasKey(e => e.PNo);

                entity.ToTable("tbl_Process");

                entity.Property(e => e.PNo)
                    .HasColumnName("p_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.PName)
                    .HasColumnName("p_name")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblProducts>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.ToTable("tbl_Products");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("ID_product")
                    .HasMaxLength(50);

                entity.Property(e => e.AddProduct)
                    .HasColumnName("Add_product")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditProduct)
                    .HasColumnName("Edit_product")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IdCat).HasColumnName("ID_cat");

                entity.Property(e => e.ImageProduct)
                    .HasColumnName("Image_product")
                    .HasColumnType("image");

                entity.Property(e => e.LabelProduct)
                    .HasColumnName("Label_product")
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QuantityInStockProduct).HasColumnName("Quantity_inStock_product");

                entity.HasOne(d => d.IdCatNavigation)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.IdCat)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbl_Products_tbl_Categories");
            });

            modelBuilder.Entity<TblTaekwondoCertificate>(entity =>
            {
                entity.HasKey(e => e.TwkId)
                    .HasName("PK_tbl_teakwondo_certificate");

                entity.ToTable("tbl_taekwondo_certificate");

                entity.Property(e => e.TwkId).HasColumnName("twk_id");

                entity.Property(e => e.DateRegister)
                    .HasColumnName("date_register")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TwkBirthday)
                    .HasColumnName("twk_birthday")
                    .HasMaxLength(100);

                entity.Property(e => e.TwkBranchAsia)
                    .HasColumnName("twk_branch_asia")
                    .HasMaxLength(250);

                entity.Property(e => e.TwkFstPhone).HasColumnName("twk_fst_phone");

                entity.Property(e => e.TwkFullNameAr)
                    .HasColumnName("twk_full_name_ar")
                    .HasMaxLength(250);

                entity.Property(e => e.TwkFullNameEn)
                    .HasColumnName("twk_full_name_en")
                    .HasMaxLength(250);

                entity.Property(e => e.TwkIdentification).HasColumnName("twk_identification");

                entity.Property(e => e.TwkImagePlayer)
                    .HasColumnName("twk_image_player")
                    .HasColumnType("image");

                entity.Property(e => e.TwkSedPhone).HasColumnName("twk_sed_phone");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UNo)
                    .HasName("PK_tbl_User");

                entity.ToTable("tbl_Users");

                entity.Property(e => e.UNo).HasColumnName("U_No");

                entity.Property(e => e.UEmail)
                    .HasColumnName("U_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.UFname)
                    .IsRequired()
                    .HasColumnName("U_Fname")
                    .HasMaxLength(60);

                entity.Property(e => e.UImage)
                    .HasColumnName("U_image")
                    .HasColumnType("image");

                entity.Property(e => e.UName)
                    .IsRequired()
                    .HasColumnName("U_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.UPassword)
                    .IsRequired()
                    .HasColumnName("U_Password")
                    .HasMaxLength(20);

                entity.Property(e => e.UTel)
                    .HasColumnName("U_Tel")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ToDay>(entity =>
            {
                entity.HasKey(e => e.Idday);

                entity.Property(e => e.Idday)
                    .HasColumnName("IDday")
                    .ValueGeneratedNever();

                entity.Property(e => e.ToDay1)
                    .HasColumnName("toDay")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserName>(entity =>
            {
                entity.HasKey(e => e.UserName1);

                entity.Property(e => e.UserName1)
                    .HasColumnName("userName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBranch).HasColumnName("ID_branch");

                entity.Property(e => e.Psw)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEstmara>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Estmara");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.BranchNo).HasColumnName("Branch_No");

                entity.Property(e => e.BranchNum)
                    .HasColumnName("branch_num")
                    .HasMaxLength(15);

                entity.Property(e => e.Cellphone).HasMaxLength(10);

                entity.Property(e => e.Cellphone2).HasMaxLength(10);

                entity.Property(e => e.DateDay).HasMaxLength(10);

                entity.Property(e => e.DateEnd)
                    .HasColumnName("dateEnd")
                    .HasMaxLength(10);

                entity.Property(e => e.DateStart)
                    .HasColumnName("dateStart")
                    .HasMaxLength(10);

                entity.Property(e => e.GuardianworkNo)
                    .HasColumnName("Guardianwork_No")
                    .HasMaxLength(20);

                entity.Property(e => e.HealthStatus).HasMaxLength(50);

                entity.Property(e => e.Higry)
                    .HasColumnName("higry")
                    .HasMaxLength(10);

                entity.Property(e => e.IdBelt).HasColumnName("ID_Belt");

                entity.Property(e => e.IdPlay).HasColumnName("ID_play");

                entity.Property(e => e.IdSub).HasColumnName("ID_sub");

                entity.Property(e => e.Identification).HasMaxLength(255);

                entity.Property(e => e.ImagePlayer)
                    .HasColumnName("image_player")
                    .HasColumnType("image");

                entity.Property(e => e.NameA)
                    .HasColumnName("Name_A")
                    .HasMaxLength(100);

                entity.Property(e => e.NameBelt).HasMaxLength(10);

                entity.Property(e => e.NamePlay)
                    .HasColumnName("namePlay")
                    .HasMaxLength(15);

                entity.Property(e => e.NameSub)
                    .HasColumnName("Name_sub")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalityNo)
                    .HasColumnName("Nationality_No")
                    .HasMaxLength(15);

                entity.Property(e => e.NumDay).HasColumnName("num_day");

                entity.Property(e => e.NumExreises).HasColumnName("Num_exreises");

                entity.Property(e => e.StatNo).HasColumnName("stat_no");

                entity.Property(e => e.ToDay)
                    .HasColumnName("to_day")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInfoUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_info_users");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.BranchNum)
                    .HasColumnName("branch_num")
                    .HasMaxLength(15);

                entity.Property(e => e.Cellphone).HasMaxLength(10);

                entity.Property(e => e.Cellphone2).HasMaxLength(10);

                entity.Property(e => e.DateDay).HasMaxLength(10);

                entity.Property(e => e.DurationMonth).HasColumnName("duration_month");

                entity.Property(e => e.GuardianworkNo)
                    .HasColumnName("Guardianwork_No")
                    .HasMaxLength(20);

                entity.Property(e => e.HealthStatus).HasMaxLength(50);

                entity.Property(e => e.Higry)
                    .HasColumnName("higry")
                    .HasMaxLength(10);

                entity.Property(e => e.Identification).HasMaxLength(255);

                entity.Property(e => e.ImagePlayer)
                    .HasColumnName("image_player")
                    .HasColumnType("image");

                entity.Property(e => e.NameA)
                    .HasColumnName("Name_A")
                    .HasMaxLength(100);

                entity.Property(e => e.NameBelt).HasMaxLength(10);

                entity.Property(e => e.NameE)
                    .HasColumnName("name_E")
                    .HasMaxLength(100);

                entity.Property(e => e.NamePlay)
                    .HasColumnName("namePlay")
                    .HasMaxLength(15);

                entity.Property(e => e.NameplayNo)
                    .HasColumnName("Nameplay_No")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalityNo)
                    .HasColumnName("Nationality_No")
                    .HasMaxLength(15);

                entity.Property(e => e.OldId).HasColumnName("old_ID");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.PlayerEmail)
                    .HasColumnName("Player_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.StatNo).HasColumnName("stat_no");
            });

            modelBuilder.Entity<ViewTaekwondoCertification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Taekwondo_Certification");

                entity.Property(e => e.TwkBirthday)
                    .HasColumnName("twk_birthday")
                    .HasMaxLength(100);

                entity.Property(e => e.TwkBranchAsia)
                    .HasColumnName("twk_branch_asia")
                    .HasMaxLength(250);

                entity.Property(e => e.TwkFstPhone).HasColumnName("twk_fst_phone");

                entity.Property(e => e.TwkFullNameAr)
                    .HasColumnName("twk_full_name_ar")
                    .HasMaxLength(250);

                entity.Property(e => e.TwkFullNameEn)
                    .HasColumnName("twk_full_name_en")
                    .HasMaxLength(250);

                entity.Property(e => e.TwkId)
                    .HasColumnName("twk_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TwkIdentification).HasColumnName("twk_identification");

                entity.Property(e => e.TwkSedPhone).HasColumnName("twk_sed_phone");
            });

            modelBuilder.Entity<ViewUserInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_User_Information");

                entity.Property(e => e.Arrest).HasColumnName("arrest");

                entity.Property(e => e.BranchNum)
                    .HasColumnName("branch_num")
                    .HasMaxLength(15);

                entity.Property(e => e.DateDay).HasMaxLength(10);

                entity.Property(e => e.DateEnd)
                    .HasColumnName("dateEnd")
                    .HasMaxLength(10);

                entity.Property(e => e.DateStart)
                    .HasColumnName("dateStart")
                    .HasMaxLength(10);

                entity.Property(e => e.Expr2).HasMaxLength(50);

                entity.Property(e => e.Identification).HasMaxLength(255);

                entity.Property(e => e.ImagePlayer)
                    .HasColumnName("image_player")
                    .HasColumnType("image");

                entity.Property(e => e.NameA)
                    .HasColumnName("Name_A")
                    .HasMaxLength(100);

                entity.Property(e => e.NameBelt).HasMaxLength(10);

                entity.Property(e => e.NamePlay)
                    .HasColumnName("namePlay")
                    .HasMaxLength(15);

                entity.Property(e => e.NameSub)
                    .HasColumnName("Name_sub")
                    .HasMaxLength(10);

                entity.Property(e => e.NumClass)
                    .HasColumnName("num_class")
                    .HasMaxLength(10);

                entity.Property(e => e.NumExreises).HasColumnName("Num_exreises");

                entity.Property(e => e.OldId).HasColumnName("old_ID");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RestExercises).HasColumnName("restExercises");

                entity.Property(e => e.StatNo).HasColumnName("stat_no");

                entity.Property(e => e.TxtDetails)
                    .HasColumnName("txt_details")
                    .HasMaxLength(20);
            });

           /* OnModelCreatingPartial(modelBuilder);*/



        }

        /*partial void OnModelCreatingPartial(ModelBuilder modelBuilder);*/



    }
}
