﻿// <auto-generated />
using System;
using DccsTeamsEstimate.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DccsTeamsEstimate.Migrations
{
    [DbContext(typeof(EstimateDbContext))]
    [Migration("20200528101155_add username")]
    partial class addusername
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("DccsTeamsEstimate.DataAccess.DataModel.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateUtc")
                        .HasColumnType("TEXT");

                    b.Property<int>("EstimationMode")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Handle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("DccsTeamsEstimate.DataAccess.DataModel.Estimate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Vote")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("Estimates");
                });

            modelBuilder.Entity("DccsTeamsEstimate.DataAccess.DataModel.Estimate", b =>
                {
                    b.HasOne("DccsTeamsEstimate.DataAccess.DataModel.Card", "Card")
                        .WithMany("Estimates")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
