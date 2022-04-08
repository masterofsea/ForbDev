﻿// <auto-generated />
using System;
using ForbexDAL.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Forbex.Migrations
{
    [DbContext(typeof(ForbexDbContext))]
    [Migration("20220408182459_TemplateUpdated")]
    partial class TemplateUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ForbexDAL.Data.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ConclusionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ContractNumber")
                        .HasColumnType("text");

                    b.Property<int>("ContractState")
                        .HasColumnType("integer");

                    b.Property<bool>("DocumentsStorage")
                        .HasColumnType("boolean");

                    b.Property<string>("Ifts")
                        .HasColumnType("text");

                    b.Property<bool>("IsReturnableCopy")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LeaseEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LeaseStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("LeaseTerm")
                        .HasColumnType("integer");

                    b.Property<int>("LesseeId")
                        .HasColumnType("integer");

                    b.Property<int?>("MailContractId")
                        .HasColumnType("integer");

                    b.Property<bool>("MonthlyActs")
                        .HasColumnType("boolean");

                    b.Property<bool>("Paid")
                        .HasColumnType("boolean");

                    b.Property<int?>("PartnerId")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentForm")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Penalty")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Price1")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Price2")
                        .HasColumnType("numeric");

                    b.Property<bool>("Receipt")
                        .HasColumnType("boolean");

                    b.Property<int>("RegistrationType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LesseeId");

                    b.HasIndex("MailContractId");

                    b.HasIndex("PartnerId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("ForbexDAL.Data.Correspondence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ReceiverName")
                        .HasColumnType("text");

                    b.Property<string>("ReceivingAddress")
                        .HasColumnType("text");

                    b.Property<string>("SenderName")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Correspondences");
                });

            modelBuilder.Entity("ForbexDAL.Data.Lessee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalContacts")
                        .HasColumnType("text");

                    b.Property<string>("Bank")
                        .HasColumnType("text");

                    b.Property<string>("Bic")
                        .HasColumnType("text");

                    b.Property<string>("CheckingAccount")
                        .HasColumnType("text");

                    b.Property<string>("ContactName")
                        .HasColumnType("text");

                    b.Property<string>("ContactNamePosition")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Inn")
                        .HasColumnType("text");

                    b.Property<string>("Kpp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ogrn")
                        .HasColumnType("text");

                    b.Property<int>("OrganizationLegalFormShort")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Lessees");
                });

            modelBuilder.Entity("ForbexDAL.Data.MailContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ConclusionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ControlDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("HasProxy")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LeaseBeginDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LeaseEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("LeaseTerm")
                        .HasColumnType("integer");

                    b.Property<string>("MailContractNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("Price1")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Price2")
                        .HasColumnType("numeric");

                    b.Property<string>("Responsible")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MailContracts");
                });

            modelBuilder.Entity("ForbexDAL.Data.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactName")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("ForbexDAL.Data.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("ForbexDAL.Data.Contract", b =>
                {
                    b.HasOne("ForbexDAL.Data.Lessee", "Lessee")
                        .WithMany()
                        .HasForeignKey("LesseeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForbexDAL.Data.MailContract", "MailContract")
                        .WithMany()
                        .HasForeignKey("MailContractId");

                    b.HasOne("ForbexDAL.Data.Partner", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerId");

                    b.Navigation("Lessee");

                    b.Navigation("MailContract");

                    b.Navigation("Partner");
                });
#pragma warning restore 612, 618
        }
    }
}
