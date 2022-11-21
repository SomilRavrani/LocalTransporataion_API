using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LocalTranspotaion_API.Models
{
    public partial class LocalTransportationContext : DbContext
    {
        public LocalTransportationContext()
        {
        }

        public LocalTransportationContext(DbContextOptions<LocalTransportationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LtBusMaster> LtBusMasters { get; set; }
        public virtual DbSet<LtCityMaster> LtCityMasters { get; set; }
        public virtual DbSet<LtCountryMaster> LtCountryMasters { get; set; }
        public virtual DbSet<LtDriverMaster> LtDriverMasters { get; set; }
        public virtual DbSet<LtGenderMaster> LtGenderMasters { get; set; }
        public virtual DbSet<LtRouteMaster> LtRouteMasters { get; set; }
        public virtual DbSet<LtRouteWiseBusWiseDiverTxn> LtRouteWiseBusWiseDiverTxns { get; set; }
        public virtual DbSet<LtStandardMaster> LtStandardMasters { get; set; }
        public virtual DbSet<LtStateMaster> LtStateMasters { get; set; }
        public virtual DbSet<LtStopMaster> LtStopMasters { get; set; }
        public virtual DbSet<LtStopWiseStudentWiseBusWiseTxn> LtStopWiseStudentWiseBusWiseTxns { get; set; }
        public virtual DbSet<LtStudentMaster> LtStudentMasters { get; set; }
        public virtual DbSet<GetStopBusStudent_Sp> GetStopBusStudent_Sp { get; set; }
        public virtual DbSet<RouteWiseBusWiseDiver_SP> RouteWiseBusWiseDiverSP { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-7UKS0IV;Database=LocalTransportation;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LtBusMaster>(entity =>
            {
                entity.HasKey(e => e.BmId);

                entity.ToTable("LT_BusMaster");

                entity.Property(e => e.BmId).HasColumnName("BM_ID");

                entity.Property(e => e.BmCreateBy).HasColumnName("BM_CreateBy");

                entity.Property(e => e.BmCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BM_CreateDate");

                entity.Property(e => e.BmModifyBy).HasColumnName("BM_ModifyBy");

                entity.Property(e => e.BmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BM_ModifyDate");

                entity.Property(e => e.BmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BM_Name");

                entity.Property(e => e.BmNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BM_Number");

                entity.Property(e => e.BmStatus).HasColumnName("BM_Status");

                entity.Property(e => e.DvmId).HasColumnName("DVM_ID");

                entity.HasOne(d => d.Dvm)
                    .WithMany(p => p.LtBusMasters)
                    .HasForeignKey(d => d.DvmId)
                    .HasConstraintName("FK_LT_BusMaster_LT_DriverMaster");
            });

            modelBuilder.Entity<LtCityMaster>(entity =>
            {
                entity.HasKey(e => e.CtmId);

                entity.ToTable("LT_CityMaster");

                entity.Property(e => e.CtmId).HasColumnName("CTM_ID");

                entity.Property(e => e.CtmCreateBy).HasColumnName("CTM_CreateBy");

                entity.Property(e => e.CtmCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CTM_CreateDate");

                entity.Property(e => e.CtmModifyBy).HasColumnName("CTM_ModifyBy");

                entity.Property(e => e.CtmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CTM_ModifyDate");

                entity.Property(e => e.CtmName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CTM_Name");

                entity.Property(e => e.CtmStatus).HasColumnName("CTM_Status");

                entity.Property(e => e.StmId).HasColumnName("STM_ID");

                entity.HasOne(d => d.Stm)
                    .WithMany(p => p.LtCityMasters)
                    .HasForeignKey(d => d.StmId)
                    .HasConstraintName("FK_LT_CityMaster_LT_StateMaster");
            });

            modelBuilder.Entity<LtCountryMaster>(entity =>
            {
                entity.HasKey(e => e.CmId);

                entity.ToTable("LT_CountryMaster");

                entity.Property(e => e.CmId).HasColumnName("CM_ID");

                entity.Property(e => e.CmCreateBy).HasColumnName("CM_CreateBy");

                entity.Property(e => e.CmCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CM_CreateDate");

                entity.Property(e => e.CmModifyBy).HasColumnName("CM_ModifyBy");

                entity.Property(e => e.CmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CM_ModifyDate");

                entity.Property(e => e.CmName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CM_Name");

                entity.Property(e => e.CmStatus).HasColumnName("CM_Status");
            });

            modelBuilder.Entity<LtDriverMaster>(entity =>
            {
                entity.HasKey(e => e.DvmId);

                entity.ToTable("LT_DriverMaster");

                entity.Property(e => e.DvmId).HasColumnName("DVM_ID");

                entity.Property(e => e.DvmCreateBy).HasColumnName("DVM_CreateBy");

                entity.Property(e => e.DvmCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DVM_CreateDate");

                entity.Property(e => e.DvmModifyBy).HasColumnName("DVM_ModifyBy");

                entity.Property(e => e.DvmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DVM_ModifyDate");

                entity.Property(e => e.DvmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DVM_Name");

                entity.Property(e => e.DvmStatus).HasColumnName("DVM_Status");
            });

            modelBuilder.Entity<LtGenderMaster>(entity =>
            {
                entity.HasKey(e => e.GmId);

                entity.ToTable("LT_GenderMaster");

                entity.Property(e => e.GmId).HasColumnName("GM_ID");

                entity.Property(e => e.GmCreateBy).HasColumnName("GM_CreateBy");

                entity.Property(e => e.GmCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GM_CreateDate");

                entity.Property(e => e.GmModifyBy).HasColumnName("GM_ModifyBy");

                entity.Property(e => e.GmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GM_ModifyDate");

                entity.Property(e => e.GmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GM_Name");

                entity.Property(e => e.GmStatus).HasColumnName("GM_Status");
            });

            modelBuilder.Entity<LtRouteMaster>(entity =>
            {
                entity.HasKey(e => e.RtId);

                entity.ToTable("LT_RouteMaster");

                entity.Property(e => e.RtId).HasColumnName("RT_ID");

                entity.Property(e => e.RtCreateBy).HasColumnName("RT_CreateBy");

                entity.Property(e => e.RtCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RT_CreateDate");

                entity.Property(e => e.RtModifyBy).HasColumnName("RT_ModifyBy");

                entity.Property(e => e.RtModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RT_ModifyDate");

                entity.Property(e => e.RtName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RT_Name");

                entity.Property(e => e.RtStatus).HasColumnName("RT_Status");
            });

            modelBuilder.Entity<LtRouteWiseBusWiseDiverTxn>(entity =>
            {
                entity.HasKey(e => e.RbdId)
                    .HasName("PK_LT_RouteWiseBusWiseDiver");

                entity.ToTable("LT_RouteWiseBusWiseDiver_TXN");

                entity.Property(e => e.RbdId).HasColumnName("RBD_Id");

                entity.Property(e => e.BmId).HasColumnName("BM_ID");

                entity.Property(e => e.DvmId).HasColumnName("DVM_ID");

                entity.Property(e => e.RbdCreateBy).HasColumnName("RBD_CreateBy");

                entity.Property(e => e.RbdCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RBD_CreateDate");

                entity.Property(e => e.RbdModifyBy).HasColumnName("RBD_modifyBy");

                entity.Property(e => e.RbdModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RBD_ModifyDate");

                entity.Property(e => e.RbdStatus).HasColumnName("RBD_Status");

                entity.Property(e => e.RtId).HasColumnName("RT_ID");

                entity.HasOne(d => d.Bm)
                    .WithMany(p => p.LtRouteWiseBusWiseDiverTxns)
                    .HasForeignKey(d => d.BmId)
                    .HasConstraintName("FK_LT_RouteWiseBusWiseDiver_LT_BusMaster");

                entity.HasOne(d => d.Dvm)
                    .WithMany(p => p.LtRouteWiseBusWiseDiverTxns)
                    .HasForeignKey(d => d.DvmId)
                    .HasConstraintName("FK_LT_RouteWiseBusWiseDiver_LT_DriverMaster");

                entity.HasOne(d => d.Rt)
                    .WithMany(p => p.LtRouteWiseBusWiseDiverTxns)
                    .HasForeignKey(d => d.RtId)
                    .HasConstraintName("FK_LT_RouteWiseBusWiseDiver_LT_RouteMaster");
            });

            modelBuilder.Entity<LtStandardMaster>(entity =>
            {
                entity.HasKey(e => e.StdId);

                entity.ToTable("LT_StandardMaster");

                entity.Property(e => e.StdId).HasColumnName("STD_ID");

                entity.Property(e => e.StdCreateBy).HasColumnName("STD_CreateBy");

                entity.Property(e => e.StdCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("STD_CreateDate");

                entity.Property(e => e.StdModifyBy).HasColumnName("STD_ModifyBy");

                entity.Property(e => e.StdModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("STD_ModifyDate");

                entity.Property(e => e.StdName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STD_Name");

                entity.Property(e => e.StdStatus).HasColumnName("STD_Status");
            });

            modelBuilder.Entity<LtStateMaster>(entity =>
            {
                entity.HasKey(e => e.StmId);

                entity.ToTable("LT_StateMaster");

                entity.Property(e => e.StmId)
                    .ValueGeneratedNever()
                    .HasColumnName("STM_ID");

                entity.Property(e => e.CmId).HasColumnName("CM_ID");

                entity.Property(e => e.StmCreateBy).HasColumnName("STM_CreateBy");

                entity.Property(e => e.StmCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("STM_CreateDate");

                entity.Property(e => e.StmModifyBy).HasColumnName("STM_ModifyBy");

                entity.Property(e => e.StmModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("STM_ModifyDate");

                entity.Property(e => e.StmName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STM_Name");

                entity.Property(e => e.StmStatus).HasColumnName("STM_Status");

                entity.HasOne(d => d.Cm)
                    .WithMany(p => p.LtStateMasters)
                    .HasForeignKey(d => d.CmId)
                    .HasConstraintName("FK_LT_StateMaster_LT_CountryMaster");
            });

            modelBuilder.Entity<LtStopMaster>(entity =>
            {
                entity.HasKey(e => e.StpId);

                entity.ToTable("LT_StopMaster");

                entity.Property(e => e.StpId)
                    .ValueGeneratedNever()
                    .HasColumnName("STP_ID");

                entity.Property(e => e.CtmId).HasColumnName("CTM_ID");

                entity.Property(e => e.StpCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("STP_CreateDate");

                entity.Property(e => e.StpCreateby).HasColumnName("STP_Createby");

                entity.Property(e => e.StpModifyBy).HasColumnName("STP_ModifyBy");

                entity.Property(e => e.StpModifydate)
                    .HasColumnType("datetime")
                    .HasColumnName("STP_Modifydate");

                entity.Property(e => e.StpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STP_Name");

                entity.Property(e => e.StpStatus).HasColumnName("STP_Status");

                entity.HasOne(d => d.Ctm)
                    .WithMany(p => p.LtStopMasters)
                    .HasForeignKey(d => d.CtmId)
                    .HasConstraintName("FK_LT_StopMaster_LT_CityMaster");
            });

            modelBuilder.Entity<LtStopWiseStudentWiseBusWiseTxn>(entity =>
            {
                entity.HasKey(e => e.SwsId);

                entity.ToTable("LT_StopWiseStudentWiseBusWise_TXN");

                entity.Property(e => e.SwsId).HasColumnName("SWS_ID");

                entity.Property(e => e.BmId).HasColumnName("BM_ID");

                entity.Property(e => e.SmId).HasColumnName("SM_ID");

                entity.Property(e => e.StpId).HasColumnName("STP_ID");

                entity.HasOne(d => d.Bm)
                    .WithMany(p => p.LtStopWiseStudentWiseBusWiseTxns)
                    .HasForeignKey(d => d.BmId)
                    .HasConstraintName("FK_LT_StopWiseStudentWiseBusWise_TXN_LT_BusMaster");

                entity.HasOne(d => d.Sm)
                    .WithMany(p => p.LtStopWiseStudentWiseBusWiseTxns)
                    .HasForeignKey(d => d.SmId)
                    .HasConstraintName("FK_LT_StopWiseStudentWiseBusWise_TXN_LT_StudentMaster");

                entity.HasOne(d => d.Stp)
                    .WithMany(p => p.LtStopWiseStudentWiseBusWiseTxns)
                    .HasForeignKey(d => d.StpId)
                    .HasConstraintName("FK_LT_StopWiseStudentWiseBusWise_TXN_LT_StopMaster");
            });

            modelBuilder.Entity<LtStudentMaster>(entity =>
            {
                entity.HasKey(e => e.SmId);

                entity.ToTable("LT_StudentMaster");

                entity.Property(e => e.SmId).HasColumnName("SM_ID");

                entity.Property(e => e.GmId).HasColumnName("GM_ID");

                entity.Property(e => e.SmAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SM_Address");

                entity.Property(e => e.SmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SM_Name");

                entity.Property(e => e.SmPhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SM_PhoneNumber");

                entity.Property(e => e.StdId).HasColumnName("STD_ID");

                entity.HasOne(d => d.Gm)
                    .WithMany(p => p.LtStudentMasters)
                    .HasForeignKey(d => d.GmId)
                    .HasConstraintName("FK_LT_StudentMaster_LT_GenderMaster");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.LtStudentMasters)
                    .HasForeignKey(d => d.StdId)
                    .HasConstraintName("FK_LT_StudentMaster_LT_StandardMaster");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
