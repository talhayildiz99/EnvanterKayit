﻿// <auto-generated />
using System;
using EnvanterKayit.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnvanterKayit.DataLayer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230526120218_DataAnnotationsEklendi")]
    partial class DataAnnotationsEklendi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnvanterKayit.Entities.Cihaz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EkranKartı")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<int>("ModelYili")
                        .HasColumnType("int");

                    b.Property<string>("Modeli")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notlar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Renk")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("SatistaMi")
                        .HasColumnType("bit");

                    b.Property<string>("SeriNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TurId")
                        .HasColumnType("int");

                    b.Property<string>("İslemcisi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MarkaId");

                    b.HasIndex("TurId");

                    b.ToTable("Cihazlar");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EklenmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Admin",
                            AktifMi = true,
                            EklenmeTarihi = new DateTime(2023, 5, 26, 15, 2, 17, 957, DateTimeKind.Local).AddTicks(7350),
                            Email = "admin@envanterkayit.tc",
                            KullaniciAdi = "admin",
                            RolId = 1,
                            Sifre = "123456",
                            Soyadi = "admin",
                            Telefon = "0850"
                        });
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Markalar");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Ogretmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CihazId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TcNo")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CihazId");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roller");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Admin"
                        });
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Satis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CihazId")
                        .HasColumnType("int");

                    b.Property<string>("Notlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SatisFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("SatisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CihazId");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Servis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cihaz")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CihazSorunu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GarantiKapsamindaMi")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notlar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("ServisAcilisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ServisUcreti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ServistenCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yapılanİslemler")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servisler");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Tur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Turler");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Cihaz", b =>
                {
                    b.HasOne("EnvanterKayit.Entities.Marka", "Marka")
                        .WithMany()
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterKayit.Entities.Tur", "Tur")
                        .WithMany()
                        .HasForeignKey("TurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marka");

                    b.Navigation("Tur");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Kullanici", b =>
                {
                    b.HasOne("EnvanterKayit.Entities.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Ogretmen", b =>
                {
                    b.HasOne("EnvanterKayit.Entities.Cihaz", "Cihaz")
                        .WithMany()
                        .HasForeignKey("CihazId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cihaz");
                });

            modelBuilder.Entity("EnvanterKayit.Entities.Satis", b =>
                {
                    b.HasOne("EnvanterKayit.Entities.Cihaz", "Cihaz")
                        .WithMany()
                        .HasForeignKey("CihazId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cihaz");
                });
#pragma warning restore 612, 618
        }
    }
}
