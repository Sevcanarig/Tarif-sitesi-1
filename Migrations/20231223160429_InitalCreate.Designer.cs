﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TarifApp.Data;

#nullable disable

namespace TarifApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231223160429_InitalCreate")]
    partial class InitalCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("TarifApp.Data.Kullanıcı", b =>
                {
                    b.Property<int>("KullanıcıId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("KullanıcıAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("KullanıcıSoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("KullanıcıId");

                    b.ToTable("Kullanıcılar");
                });

            modelBuilder.Entity("TarifApp.Data.Yemek", b =>
                {
                    b.Property<int>("YemekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.HasKey("YemekId");

                    b.ToTable("yemekler");
                });

            modelBuilder.Entity("TarifApp.Data.YemekKayit", b =>
                {
                    b.Property<int>("KayitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("KullanıcıId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YemekId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KayitId");

                    b.HasIndex("KullanıcıId");

                    b.HasIndex("YemekId");

                    b.ToTable("YemekKayitlari");
                });

            modelBuilder.Entity("TarifApp.Data.YemekKayit", b =>
                {
                    b.HasOne("TarifApp.Data.Kullanıcı", "Kullanıcı")
                        .WithMany("yemekKayitları")
                        .HasForeignKey("KullanıcıId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TarifApp.Data.Yemek", "Yemek")
                        .WithMany()
                        .HasForeignKey("YemekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanıcı");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("TarifApp.Data.Kullanıcı", b =>
                {
                    b.Navigation("yemekKayitları");
                });
#pragma warning restore 612, 618
        }
    }
}
