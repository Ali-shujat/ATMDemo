﻿// <auto-generated />
using System;
using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ATM.Data.Migrations
{
    [DbContext(typeof(ATMDataContext))]
    partial class ATMDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ATM.Core.Entities.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Balance");

                    b.Property<int>("CSV");

                    b.Property<string>("CardNumber");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<decimal>("Limit");

                    b.Property<string>("PinCode");

                    b.Property<int>("ServiceType");

                    b.Property<int>("Type");

                    b.Property<DateTime>("Updated");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("ATM.Core.Entities.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<decimal>("Balance");

                    b.Property<Guid>("CardId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Dated");

                    b.Property<int>("Type");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ATM.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ATM.Core.Entities.Card", b =>
                {
                    b.HasOne("ATM.Core.Entities.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ATM.Core.Entities.Transaction", b =>
                {
                    b.HasOne("ATM.Core.Entities.Card", "Card")
                        .WithMany("Transactions")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
