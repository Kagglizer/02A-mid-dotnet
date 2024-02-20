using System;
using System.Collections.Generic;
using Kagglizer_Dotnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Kagglizer_Dotnet.Data
{
    public partial class KagglizerContext : DbContext
    {
        public virtual DbSet<Events> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = tcp:sb-sql-database-server.database.windows.net,1433; Initial Catalog = sb-sql; User Id = kagglizer-sa@sb-sql-database-server; Password = sbndeveloper!1",
                    options => options.EnableRetryOnFailure());
            }
        }
    }
}





//{
//    public partial class KagglizerContext : DbContext
//    {
//        //public KagglizerContext()
//        //{
//        //}

//        //public KagglizerContext(DbContextOptions<KagglizerContext> options)
//        //    : base(options)
//        //{
//        //}

//        public virtual DbSet<Events> Events { get; set; }

//        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        //{
//        //    if (!optionsBuilder.IsConfigured)
//        //    {
//        //        optionsBuilder.UseSqlServer("Server=sb-sql-database-server.database.window.net;Database=sb-sql;User Id=kagglizer-sa;Password=sbndeveloper!1;TrustServerCertificate=True;");
//        //    }
//        //}


//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {

//            optionsBuilder.UseSqlServer("Data Source = tcp:sb - sql - database - server.database.windows.net,1433; Initial Catalog = sb - sql; User Id = kagglizer - sa@sb - sql - database - server; Password = sbndeveloper!1");
//            //optionsBuilder.UseSqlServer("Server=sb-sql-database-server.database.window.net;Database=sb-sql;User Id=kagglizer-sa;Password=sbndeveloper!1;TrustServerCertificate=True;");
//        }
//        //Data Source = tcp:sb-sql-database-server.database.windows.net,1433;Initial Catalog = sb - sql; User Id = kagglizer - sa@sb-sql-database-server;Password=sbndeveloper!1
//    }
//        //protected override void OnModelCreating(ModelBuilder modelBuilder)
//        //{
//        //    modelBuilder.Entity<Events>(entity =>
//        //    {
//        //        entity.ToTable("Events");

//        //        // You might want to use appropriate data types instead of MaxLength
//        //        entity.Property(e => e.startDate).HasColumnType("datetime2(7)");
//        //        entity.Property(e => e.endDate).HasColumnType("datetime2(7)");
//        //        entity.Property(e => e.title).HasMaxLength(255);
//        //        entity.Property(e => e.location).HasMaxLength(255);
//        //        entity.Property(e => e.description).HasMaxLength(255);
//        //        entity.Property(e => e.createDate).HasColumnType("datetime2(7)");
//        //        entity.Property(e => e.createId).HasColumnType("int");
//        //        entity.Property(e => e.modifyDate).HasColumnType("datetime2(7)");
//        //        entity.Property(e => e.modifyId).HasColumnType("int");
//        //    });

//        //    OnModelCreatingPartial(modelBuilder);
//        //}

//    //    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    //}
//}
