using System;
using System.Collections.Generic;
using Kagglizer_Dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace Kagglizer_Dotnet.Data;

public partial class SbSqlContext : DbContext
{
    public SbSqlContext()
    {
    }

    public SbSqlContext(DbContextOptions<SbSqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Approach> Approaches { get; set; }

    public virtual DbSet<ApproachesCategory> ApproachesCategories { get; set; }

    public virtual DbSet<ApproachesStep> ApproachesSteps { get; set; }

    public virtual DbSet<ArchiveOfProblemSolvingDesign> ArchiveOfProblemSolvingDesigns { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Qapair> Qapairs { get; set; }

    public virtual DbSet<QapairsCategory> QapairsCategories { get; set; }

    public virtual DbSet<StoryLine> StoryLines { get; set; }

    public virtual DbSet<StoryMarc> StoryMarcs { get; set; }

    public virtual DbSet<StoryQuestionCategory> StoryQuestionCategories { get; set; }

    public virtual DbSet<UserStudentAnswer> UserStudentAnswers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = tcp:sb-sql-database-server.database.windows.net,1433; Initial Catalog = sb-sql; User Id = kagglizer-sa@sb-sql-database-server; Password = sbndeveloper!1");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Approach>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ApproachesCategory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ApproachesStep>(entity =>
        {
            entity.Property(e => e.ApproachName).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.StepName).HasMaxLength(50);
        });

        modelBuilder.Entity<ArchiveOfProblemSolvingDesign>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Approach).HasMaxLength(255);
            entity.Property(e => e.Plan).HasMaxLength(255);
            entity.Property(e => e.Problem).HasMaxLength(255);
            entity.Property(e => e.StateCurrent).HasMaxLength(255);
            entity.Property(e => e.StateDesired).HasMaxLength(255);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnName("createDate");
            entity.Property(e => e.CreateId).HasColumnName("createId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("endDate");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .HasColumnName("location");
            entity.Property(e => e.ModifyDate).HasColumnName("modifyDate");
            entity.Property(e => e.ModifyId).HasColumnName("modifyId");
            entity.Property(e => e.StartDate).HasColumnName("startDate");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Qapair>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QAPairs");

            entity.Property(e => e.Answer).HasMaxLength(2000);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Question).HasMaxLength(255);
        });

        modelBuilder.Entity<QapairsCategory>(entity =>
        {
            entity.ToTable("QAPairsCategories");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<StoryLine>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");
            entity.Property(e => e.StepCcssreference)
                .HasMaxLength(50)
                .HasColumnName("StepCCSSReference");
            entity.Property(e => e.StoryId).HasColumnName("StoryID");
        });

        modelBuilder.Entity<StoryMarc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Stories");

            entity.ToTable("StoryMARC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Authors).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.StoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<StoryQuestionCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QuestionTypes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<UserStudentAnswer>(entity =>
        {
            entity.HasNoKey();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
