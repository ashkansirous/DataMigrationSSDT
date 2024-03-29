﻿// <auto-generated />
using System;
using EFCodeFirst.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCodeFirst.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCodeFirst.Database.ModuleConfiguration", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int?>("CheckLincenses");

                    b.Property<int?>("ModuleLicenses");

                    b.Property<int?>("ProductivityLicenses");

                    b.Property<int?>("TemplafyLicences");

                    b.HasKey("Id");

                    b.ToTable("ModuleConfiguration");
                });

            modelBuilder.Entity("EFCodeFirst.Database.Tenant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Partner");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("EFCodeFirst.Database.ModuleConfiguration", b =>
                {
                    b.HasOne("EFCodeFirst.Database.Tenant", "Tenant")
                        .WithOne("ModuleConfiguration")
                        .HasForeignKey("EFCodeFirst.Database.ModuleConfiguration", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
