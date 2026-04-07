using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccesses;

public partial class AppDBContext : DbContext
{
    public AppDBContext()
    {
    }

    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<الأدوار> الأدوارs { get; set; }

    public virtual DbSet<التصنيفات> التصنيفاتs { get; set; }

    public virtual DbSet<العملاء> العملاءs { get; set; }

    public virtual DbSet<المستخدمون> المستخدمونs { get; set; }

    public virtual DbSet<المنتجات> المنتجاتs { get; set; }

    public virtual DbSet<الموردون> الموردونs { get; set; }

    public virtual DbSet<تفاصيلفاتورةالبيع> تفاصيلفاتورةالبيعs { get; set; }

    public virtual DbSet<تفاصيلفاتورةالشراء> تفاصيلفاتورةالشراءs { get; set; }

    public virtual DbSet<فواتيرالبيع> فواتيرالبيعs { get; set; }

    public virtual DbSet<فواتيرالشراء> فواتيرالشراءs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = Inventory & Sales Management System; Integrated Security = SSPI; TrustServerCertificate = True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<الأدوار>(entity =>
        {
            entity.HasKey(e => e.رقمالدور).HasName("PK__الأدوار__2F885C5E84C2FCC7");

            entity.ToTable("الأدوار");

            entity.Property(e => e.رقمالدور).HasColumnName("رقم_الدور");
            entity.Property(e => e.اسمالدور)
                .HasMaxLength(50)
                .HasColumnName("اسم_الدور");
        });

        modelBuilder.Entity<التصنيفات>(entity =>
        {
            entity.HasKey(e => e.رقمالتصنيف).HasName("PK__التصنيفا__ADFEE2B9AC1BBAB8");

            entity.ToTable("التصنيفات");

            entity.Property(e => e.رقمالتصنيف).HasColumnName("رقم_التصنيف");
            entity.Property(e => e.اسمالتصنيف)
                .HasMaxLength(100)
                .HasColumnName("اسم_التصنيف");
            entity.Property(e => e.محذوف).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<العملاء>(entity =>
        {
            entity.HasKey(e => e.رقمالعميل).HasName("PK__العملاء__9742843CD2F4743B");

            entity.ToTable("العملاء");

            entity.Property(e => e.رقمالعميل).HasColumnName("رقم_العميل");
            entity.Property(e => e.اسمالعميل)
                .HasMaxLength(150)
                .HasColumnName("اسم_العميل");
            entity.Property(e => e.العنوان).HasMaxLength(255);
            entity.Property(e => e.الهاتف).HasMaxLength(30);
            entity.Property(e => e.محذوف).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<المستخدمون>(entity =>
        {
            entity.HasKey(e => e.رقمالمستخدم).HasName("PK__المستخدم__F033E7372D1CFFDF");

            entity.ToTable("المستخدمون");

            entity.HasIndex(e => e.اسمالدخول, "UQ__المستخدم__1CDE6125449C44E4").IsUnique();

            entity.Property(e => e.رقمالمستخدم).HasColumnName("رقم_المستخدم");
            entity.Property(e => e.اسمالدخول)
                .HasMaxLength(50)
                .HasColumnName("اسم_الدخول");
            entity.Property(e => e.الاسمالكامل)
                .HasMaxLength(100)
                .HasColumnName("الاسم_الكامل");
            entity.Property(e => e.تاريخالإنشاء)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("تاريخ_الإنشاء");
            entity.Property(e => e.رقمالدور).HasColumnName("رقم_الدور");
            entity.Property(e => e.كلمةالمرور)
                .HasMaxLength(255)
                .HasColumnName("كلمة_المرور");
            entity.Property(e => e.نشط).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.رقمالدورNavigation).WithMany(p => p.المستخدمونs)
                .HasForeignKey(d => d.رقمالدور)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__المستخدمو__رقم_ا__74AE54BC");
        });

        modelBuilder.Entity<المنتجات>(entity =>
        {
            entity.HasKey(e => e.رقمالمنتج).HasName("PK__المنتجات__B45162DE1F47B187");

            entity.ToTable("المنتجات");

            entity.HasIndex(e => e.الباركود, "UQ_Barcode").IsUnique();

            entity.Property(e => e.رقمالمنتج).HasColumnName("رقم_المنتج");
            entity.Property(e => e.اسمالمنتج)
                .HasMaxLength(150)
                .HasColumnName("اسم_المنتج");
            entity.Property(e => e.الباركود).HasMaxLength(50);
            entity.Property(e => e.الكمية).HasDefaultValueSql("((0))");
            entity.Property(e => e.رقمالتصنيف).HasColumnName("رقم_التصنيف");
            entity.Property(e => e.سعرالبيع)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("سعر_البيع");
            entity.Property(e => e.سعرالشراء)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("سعر_الشراء");
            entity.Property(e => e.مسارالصورة)
                .HasMaxLength(255)
                .HasColumnName("مسار_الصورة");
            entity.Property(e => e.نشط).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.رقمالتصنيفNavigation).WithMany(p => p.المنتجاتs)
                .HasForeignKey(d => d.رقمالتصنيف)
                .HasConstraintName("FK__المنتجات__رقم_ال__7C4F7684");
        });

        modelBuilder.Entity<الموردون>(entity =>
        {
            entity.HasKey(e => e.رقمالمورد).HasName("PK__الموردون__ADB537C223B2BE1A");

            entity.ToTable("الموردون");

            entity.Property(e => e.رقمالمورد).HasColumnName("رقم_المورد");
            entity.Property(e => e.اسمالمورد)
                .HasMaxLength(150)
                .HasColumnName("اسم_المورد");
            entity.Property(e => e.العنوان).HasMaxLength(255);
            entity.Property(e => e.الهاتف).HasMaxLength(30);
            entity.Property(e => e.محذوف).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<تفاصيلفاتورةالبيع>(entity =>
        {
            entity.HasKey(e => e.رقمالسطر).HasName("PK__تفاصيل_ف__2C910F62AFCEFA7D");

            entity.ToTable("تفاصيل_فاتورة_البيع", tb => tb.HasTrigger("خصم_الكمية_بعد_البيع"));

            entity.Property(e => e.رقمالسطر).HasColumnName("رقم_السطر");
            entity.Property(e => e.الإجمالي).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.رقمالفاتورة).HasColumnName("رقم_الفاتورة");
            entity.Property(e => e.رقمالمنتج).HasColumnName("رقم_المنتج");
            entity.Property(e => e.سعرالوحدة)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("سعر_الوحدة");

            entity.HasOne(d => d.رقمالفاتورةNavigation).WithMany(p => p.تفاصيلفاتورةالبيعs)
                .HasForeignKey(d => d.رقمالفاتورة)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__تفاصيل_فا__رقم_ا__0C85DE4D");

            entity.HasOne(d => d.رقمالمنتجNavigation).WithMany(p => p.تفاصيلفاتورةالبيعs)
                .HasForeignKey(d => d.رقمالمنتج)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__تفاصيل_فا__رقم_ا__0D7A0286");
        });

        modelBuilder.Entity<تفاصيلفاتورةالشراء>(entity =>
        {
            entity.HasKey(e => e.رقمالسطر).HasName("PK__تفاصيل_ف__2C910F621D5CCD08");

            entity.ToTable("تفاصيل_فاتورة_الشراء", tb => tb.HasTrigger("زيادة_الكمية_بعد_الشراء"));

            entity.Property(e => e.رقمالسطر).HasColumnName("رقم_السطر");
            entity.Property(e => e.رقمالشراء).HasColumnName("رقم_الشراء");
            entity.Property(e => e.رقمالمنتج).HasColumnName("رقم_المنتج");
            entity.Property(e => e.سعرالشراء)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("سعر_الشراء");

            entity.HasOne(d => d.رقمالشراءNavigation).WithMany(p => p.تفاصيلفاتورةالشراءs)
                .HasForeignKey(d => d.رقمالشراء)
                .HasConstraintName("FK__تفاصيل_فا__رقم_ا__14270015");

            entity.HasOne(d => d.رقمالمنتجNavigation).WithMany(p => p.تفاصيلفاتورةالشراءs)
                .HasForeignKey(d => d.رقمالمنتج)
                .HasConstraintName("FK__تفاصيل_فا__رقم_ا__151B244E");
        });

        modelBuilder.Entity<فواتيرالبيع>(entity =>
        {
            entity.HasKey(e => e.رقمالفاتورة).HasName("PK__فواتير_ا__04E5B287EB869523");

            entity.ToTable("فواتير_البيع");

            entity.Property(e => e.رقمالفاتورة).HasColumnName("رقم_الفاتورة");
            entity.Property(e => e.الإجمالي).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.تاريخالفاتورة)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("تاريخ_الفاتورة");
            entity.Property(e => e.رقمالعميل).HasColumnName("رقم_العميل");
            entity.Property(e => e.رقمالمستخدم).HasColumnName("رقم_المستخدم");

            entity.HasOne(d => d.رقمالعميلNavigation).WithMany(p => p.فواتيرالبيعs)
                .HasForeignKey(d => d.رقمالعميل)
                .HasConstraintName("FK__فواتير_ال__رقم_ا__08B54D69");

            entity.HasOne(d => d.رقمالمستخدمNavigation).WithMany(p => p.فواتيرالبيعs)
                .HasForeignKey(d => d.رقمالمستخدم)
                .HasConstraintName("FK__فواتير_ال__رقم_ا__09A971A2");
        });

        modelBuilder.Entity<فواتيرالشراء>(entity =>
        {
            entity.HasKey(e => e.رقمالشراء).HasName("PK__فواتير_ا__0385133EEBD783B8");

            entity.ToTable("فواتير_الشراء");

            entity.Property(e => e.رقمالشراء).HasColumnName("رقم_الشراء");
            entity.Property(e => e.الإجمالي).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.تاريخالشراء)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("تاريخ_الشراء");
            entity.Property(e => e.رقمالمورد).HasColumnName("رقم_المورد");

            entity.HasOne(d => d.رقمالموردNavigation).WithMany(p => p.فواتيرالشراءs)
                .HasForeignKey(d => d.رقمالمورد)
                .HasConstraintName("FK__فواتير_ال__رقم_ا__114A936A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
