﻿// <auto-generated />
using System;
using FantasyAppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FantasyAppData.Migrations
{
    [DbContext(typeof(FantasyContext))]
    [Migration("20181208173855_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FantasyAppData.Lineup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DefenseId");

                    b.Property<int?>("FlexId");

                    b.Property<int?>("QBId");

                    b.Property<int?>("RB1Id");

                    b.Property<int?>("RB2Id");

                    b.Property<int?>("TEId");

                    b.Property<int?>("WR1Id");

                    b.Property<int?>("WR2Id");

                    b.HasKey("Id");

                    b.HasIndex("DefenseId");

                    b.HasIndex("FlexId");

                    b.HasIndex("QBId");

                    b.HasIndex("RB1Id");

                    b.HasIndex("RB2Id");

                    b.HasIndex("TEId");

                    b.HasIndex("WR1Id");

                    b.HasIndex("WR2Id");

                    b.ToTable("Lineups");
                });

            modelBuilder.Entity("FantasyAppData.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("salaryCost");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("FantasyAppData.Lineup", b =>
                {
                    b.HasOne("FantasyAppData.Player", "Defense")
                        .WithMany()
                        .HasForeignKey("DefenseId");

                    b.HasOne("FantasyAppData.Player", "Flex")
                        .WithMany()
                        .HasForeignKey("FlexId");

                    b.HasOne("FantasyAppData.Player", "QB")
                        .WithMany()
                        .HasForeignKey("QBId");

                    b.HasOne("FantasyAppData.Player", "RB1")
                        .WithMany()
                        .HasForeignKey("RB1Id");

                    b.HasOne("FantasyAppData.Player", "RB2")
                        .WithMany()
                        .HasForeignKey("RB2Id");

                    b.HasOne("FantasyAppData.Player", "TE")
                        .WithMany()
                        .HasForeignKey("TEId");

                    b.HasOne("FantasyAppData.Player", "WR1")
                        .WithMany()
                        .HasForeignKey("WR1Id");

                    b.HasOne("FantasyAppData.Player", "WR2")
                        .WithMany()
                        .HasForeignKey("WR2Id");
                });
#pragma warning restore 612, 618
        }
    }
}