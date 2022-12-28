using System;
using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public partial class ContractorFindingProContext : DbContext
{
    public ContractorFindingProContext()
    {
    }

    public ContractorFindingProContext(DbContextOptions<ContractorFindingProContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ContractorDetail> ContractorDetails { get; set; }

    public virtual DbSet<ContractorView> ContractorViews { get; set; }

    public virtual DbSet<CustomerView> CustomerViews { get; set; }

    public virtual DbSet<ServiceProviding> ServiceProvidings { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<TbBuilding> TbBuildings { get; set; }

    public virtual DbSet<TbCustomer> TbCustomers { get; set; }

    public virtual DbSet<TbGender> TbGenders { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<Userview> Userviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Contractor_FindingPRO;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContractorDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Contractor_details");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.License)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("license");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
        });

        modelBuilder.Entity<ContractorView>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContractorView");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GenderType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.License)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("license");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerView>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerView");

            entity.Property(e => e.Building)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LandSqft).HasColumnName("Land_sqft");
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ServiceProviding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Service_providing");

            entity.Property(e => e.ServiceName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sysdiagrams");

            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<TbBuilding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tb_Building");

            entity.Property(e => e.Building)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TbCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tb_Customer");

            entity.Property(e => e.BuildingType).HasColumnName("Building_Type");
            entity.Property(e => e.LandSqft).HasColumnName("Land_sqft");
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbGender>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tb_Gender");

            entity.Property(e => e.GenderType)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tb_User");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("User_Type");

            entity.Property(e => e.TypeId).HasColumnName("typeId");
            entity.Property(e => e.Usertype1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usertype");
        });

        modelBuilder.Entity<Userview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Userview");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Usertype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usertype");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
