﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VCPortal.Infra.Data;

namespace VCPortal.Infra.Data.Migrations.Data
{
    [DbContext(typeof(MemberOSContext))]
    partial class MemberOSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VCPortal.Core.Domain.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardType")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ContractNo")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Network")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PolicyNo")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Scheme")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("VC_TemplatesByContract");
                });

            modelBuilder.Entity("VCPortal.Core.Domain.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractNo")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MembershipNo")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Scheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("VC_TemplatesByMembershipNo");
                });

            modelBuilder.Entity("VCPortal.Core.Domain.Scheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SchemeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("VC_TemplatesByScheme");
                });
#pragma warning restore 612, 618
        }
    }
}
