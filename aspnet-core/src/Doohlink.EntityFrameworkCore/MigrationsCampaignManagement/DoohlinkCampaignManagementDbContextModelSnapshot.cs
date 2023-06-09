﻿// <auto-generated />
using System;
using Doohlink.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace Doohlink.MigrationsCampaignManagement
{
    [DbContext(typeof(DoohlinkCampaignManagementDbContext))]
    partial class DoohlinkCampaignManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Doohlink.CampaignManagement.Screens.Screen", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<double>("AspectRatio")
                        .HasColumnType("double precision")
                        .HasColumnName("AspectRatio");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<int>("Height")
                        .HasMaxLength(10000)
                        .HasColumnType("integer")
                        .HasColumnName("Height");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("TenantId");

                    b.Property<int>("Width")
                        .HasMaxLength(10000)
                        .HasColumnType("integer")
                        .HasColumnName("Width");

                    b.HasKey("Id");

                    b.ToTable("CampaignManagementScreens", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
