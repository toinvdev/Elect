﻿// <auto-generated />
using System;
using Elect.Sample.Data.EF.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DbContext = Elect.Sample.Data.EF.Services.DbContext;

namespace Elect.Sample.Data.EF.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Elect.Sample.Data.EF.Models.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<Guid?>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedTime");

                    b.Property<Guid?>("LastUpdatedBy");

                    b.Property<DateTimeOffset>("LastUpdatedTime");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("DeletedTime");

                    b.HasIndex("Id");

                    b.HasIndex("UserName");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Elect.Sample.Data.EF.Models.UserProfileEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedTime");

                    b.Property<Guid?>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedTime");

                    b.Property<Guid?>("LastUpdatedBy");

                    b.Property<DateTimeOffset>("LastUpdatedTime");

                    b.Property<string>("Phone");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Elect.Sample.Data.EF.Models.UserProfileEntity", b =>
                {
                    b.HasOne("Elect.Sample.Data.EF.Models.UserEntity", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
