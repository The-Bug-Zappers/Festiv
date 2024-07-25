﻿// <auto-generated />
using System;
using Festiv.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Festiv.Migrations
{
    [DbContext(typeof(FestivDbContext))]
<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
    [Migration("20240723191955_InitialMigration7")]
    partial class InitialMigration7
========
    [Migration("20240722164236_VDoopyMigration")]
    partial class VDoopyMigration
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Festiv.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GameName")
                        .HasColumnType("longtext");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<int>("MinPlayers")
                        .HasColumnType("int");

<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                    b.Property<int?>("PartyDetailsId")
                        .HasColumnType("int");

                    b.Property<int>("PartyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartyDetailsId");

                    b.HasIndex("PartyId");

                    b.ToTable("Games");
                });

========
                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Festiv.Models.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PartyId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("UserId");

                    b.ToTable("Gifts");
                });

>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
            modelBuilder.Entity("Festiv.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PartyDetailsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartyDetailsId");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("Festiv.Models.GuestRespond", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PartyId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("UserId");

                    b.ToTable("GuestResponds");
                });

            modelBuilder.Entity("Festiv.Models.Host", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Host");
                });

            modelBuilder.Entity("Festiv.Models.Party", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("Festiv.Models.PartyDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("PartyHostId")
                        .HasColumnType("int");

                    b.Property<int>("PartyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("PartyHostId");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("PartyDetails");
                });

            modelBuilder.Entity("Festiv.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                            Id = new Guid("f8552327-e778-4d92-aeb2-dcdace8bf163"),
========
                            Id = new Guid("c731ed30-620d-45e3-92c3-613db7c55c2c"),
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                            Id = new Guid("fc981214-ba7d-4e62-9cbc-6908db40d3d0"),
========
                            Id = new Guid("ac24df23-20d0-4dfc-99ea-4d26322040c3"),
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Festiv.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Festiv.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("UserType")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                            Id = new Guid("e2808e24-7d57-4cc6-8b0d-81642d13a89e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e8e99c9b-2645-43f2-90e5-fb52d3b92830",
========
                            Id = new Guid("d4fba812-68d2-48de-b019-c1e2c57aa5b4"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bde752a3-9bdd-423b-8503-08eeeedac71f",
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                            Email = "admin@festiv.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@FESTIV.COM",
                            NormalizedUserName = "ADMIN@FESTIV.COM",
<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                            PasswordHash = "AQAAAAIAAYagAAAAEAgvo6cHJc6KDfsXYFXHqUHgY4A42xMJLQlcJwWBSNGuk4bvuAkVLxhK4HJ6cniF3g==",
========
                            PasswordHash = "AQAAAAIAAYagAAAAEPLkY/e3f1nIiVQzFNyV9LI3G7rk0rAtHRGAARQvWuMhQwectkXMdkpkRG9sRmawGQ==",
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                            PhoneNumberConfirmed = false,
                            Rating = 0,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin@festiv.com",
                            UserType = true
                        });
                });

<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
            modelBuilder.Entity("GameCurrentPlayer", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("GameId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("GameCurrentPlayer");
                });

            modelBuilder.Entity("GameWaitingPlayer", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("GameId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("GameWaitingPlayer");
========
            modelBuilder.Entity("GameUser", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("char(36)");

                    b.HasKey("GamesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("GamePlayers", (string)null);
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                            UserId = new Guid("e2808e24-7d57-4cc6-8b0d-81642d13a89e"),
                            RoleId = new Guid("f8552327-e778-4d92-aeb2-dcdace8bf163")
========
                            UserId = new Guid("d4fba812-68d2-48de-b019-c1e2c57aa5b4"),
                            RoleId = new Guid("c731ed30-620d-45e3-92c3-613db7c55c2c")
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
            modelBuilder.Entity("TeamMember", b =>
                {
                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("TeamId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("TeamMember");
                });

            modelBuilder.Entity("Festiv.Models.Game", b =>
                {
                    b.HasOne("Festiv.Models.PartyDetails", null)
                        .WithMany("Games")
                        .HasForeignKey("PartyDetailsId");

                    b.HasOne("Festiv.Models.Party", "Party")
                        .WithMany("Games")
========
            modelBuilder.Entity("Festiv.Models.Gift", b =>
                {
                    b.HasOne("Festiv.Models.Party", "Party")
                        .WithMany("Gifts")
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                    b.Navigation("Party");
========
                    b.HasOne("Festiv.Models.User", "User")
                        .WithMany("Gifts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Party");

                    b.Navigation("User");
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                });

            modelBuilder.Entity("Festiv.Models.Guest", b =>
                {
                    b.HasOne("Festiv.Models.PartyDetails", null)
                        .WithMany("GuestList")
                        .HasForeignKey("PartyDetailsId");
                });

            modelBuilder.Entity("Festiv.Models.GuestRespond", b =>
                {
                    b.HasOne("Festiv.Models.Party", "Party")
                        .WithMany("GuestResponds")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Festiv.Models.User", "User")
                        .WithMany("GuestResponds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Party");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Festiv.Models.PartyDetails", b =>
                {
                    b.HasOne("Festiv.Models.Host", "PartyHost")
                        .WithMany()
                        .HasForeignKey("PartyHostId");

                    b.HasOne("Festiv.Models.Party", "Party")
                        .WithOne("Details")
                        .HasForeignKey("Festiv.Models.PartyDetails", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Party");

                    b.Navigation("PartyHost");
                });

<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
            modelBuilder.Entity("Festiv.Models.Team", b =>
                {
                    b.HasOne("Festiv.Models.Game", "Game")
                        .WithMany("Teams")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameCurrentPlayer", b =>
                {
                    b.HasOne("Festiv.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
========
            modelBuilder.Entity("GameUser", b =>
                {
                    b.HasOne("Festiv.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Festiv.Models.User", null)
                        .WithMany()
<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameWaitingPlayer", b =>
                {
                    b.HasOne("Festiv.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Festiv.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
========
                        .HasForeignKey("UsersId")
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Festiv.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Festiv.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Festiv.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Festiv.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Festiv.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Festiv.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamMember", b =>
                {
                    b.HasOne("Festiv.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Festiv.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Festiv.Models.Game", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Festiv.Models.Party", b =>
                {
                    b.Navigation("Details");

<<<<<<<< HEAD:Festiv/Migrations/20240723191955_InitialMigration7.Designer.cs
                    b.Navigation("Games");
========
                    b.Navigation("Gifts");

                    b.Navigation("GuestResponds");
>>>>>>>> development:Festiv/Migrations/20240722164236_VDoopyMigration.Designer.cs
                });

            modelBuilder.Entity("Festiv.Models.PartyDetails", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("GuestList");
                });

            modelBuilder.Entity("Festiv.Models.User", b =>
                {
                    b.Navigation("Gifts");

                    b.Navigation("GuestResponds");
                });
#pragma warning restore 612, 618
        }
    }
}
