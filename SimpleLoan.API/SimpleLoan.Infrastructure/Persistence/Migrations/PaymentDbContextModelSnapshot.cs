﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleLoan.Infrastructure.Persistence;

#nullable disable

namespace SimpleLoan.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(PaymentDbContext))]
    partial class PaymentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("SimpleLoan.Domain.Entities.PaymentPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("InterestPayment")
                        .HasColumnType("REAL");

                    b.Property<int>("PaymentPlanId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PeriodNo")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PrincipalPayment")
                        .HasColumnType("REAL");

                    b.Property<decimal>("RemainingLoan")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PaymentPlanId");

                    b.ToTable("PaymentPeriods");
                });

            modelBuilder.Entity("SimpleLoan.Domain.Entities.PaymentPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoanType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PaymentPlans");
                });

            modelBuilder.Entity("SimpleLoan.Domain.Entities.PaymentPeriod", b =>
                {
                    b.HasOne("SimpleLoan.Domain.Entities.PaymentPlan", "PaymentPlan")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentPlan");
                });

            modelBuilder.Entity("SimpleLoan.Domain.Entities.PaymentPlan", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
