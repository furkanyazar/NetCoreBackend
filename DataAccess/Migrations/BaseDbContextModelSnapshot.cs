﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Name");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("UpdatedDate");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Value");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "UK_OperationClaims_Name")
                        .IsUnique();

                    b.HasIndex(new[] { "Value" }, "UK_OperationClaims_Value")
                        .IsUnique();

                    b.ToTable("OperationClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            Status = false,
                            Value = "admin"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("CreatedByIp");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletedDate");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Expires");

                    b.Property<string>("ReasonRevoked")
                        .HasColumnType("longtext")
                        .HasColumnName("ReasonRevoked");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("longtext")
                        .HasColumnName("ReplacedByToken");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Revoked");

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("longtext")
                        .HasColumnName("RevokedByIp");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Token");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("LastName");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob")
                        .HasColumnName("PasswordSalt");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "UK_Users_Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "contact@furkanyazar.dev",
                            FirstName = "Furkan",
                            LastName = "Yazar",
                            PasswordHash = new byte[] { 149, 100, 222, 11, 60, 173, 209, 3, 30, 42, 111, 78, 58, 41, 221, 78, 54, 116, 170, 252, 52, 161, 229, 84, 80, 97, 123, 44, 104, 13, 151, 113, 253, 195, 108, 112, 10, 216, 123, 189, 147, 84, 2, 101, 53, 59, 250, 254, 223, 18, 141, 242, 120, 233, 90, 102, 161, 42, 168, 38, 81, 39, 200, 6 },
                            PasswordSalt = new byte[] { 30, 211, 48, 184, 193, 89, 67, 222, 222, 14, 46, 160, 200, 254, 236, 40, 105, 208, 55, 221, 203, 72, 155, 252, 1, 149, 18, 3, 222, 228, 236, 87, 146, 75, 229, 149, 204, 54, 50, 211, 57, 58, 204, 76, 177, 241, 21, 5, 222, 108, 201, 108, 129, 163, 229, 156, 10, 100, 133, 189, 64, 171, 245, 46, 68, 32, 95, 201, 137, 249, 100, 30, 159, 145, 189, 192, 102, 49, 8, 191, 156, 192, 202, 226, 142, 81, 67, 172, 148, 70, 83, 156, 41, 46, 21, 227, 189, 29, 206, 202, 97, 94, 155, 107, 196, 182, 175, 22, 143, 235, 45, 70, 197, 30, 193, 156, 94, 65, 71, 99, 110, 100, 31, 81, 221, 99, 112, 218 },
                            Status = false
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletedDate");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int")
                        .HasColumnName("OperationClaimId");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex(new[] { "UserId", "OperationClaimId" }, "UK_UserOperationClaims_UserId_OperationClaimId")
                        .IsUnique();

                    b.ToTable("UserOperationClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OperationClaimId = 1,
                            Status = false,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Name");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("UnitPrice");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("smallint")
                        .HasColumnName("UnitsInStock");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId", "Name" }, "UK_Products_UserId_Name")
                        .IsUnique();

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Concrete.RefreshToken", b =>
                {
                    b.HasOne("Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.HasOne("Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });
#pragma warning restore 612, 618
        }
    }
}
