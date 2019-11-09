﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaceAnnouncer.Schema;

namespace RaceAnnouncer.Schema.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Announcement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<long>("ChannelId")
                        .HasColumnName("fk_t_disc_channel")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("MessageCreatedAt")
                        .HasColumnName("msg_created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("MessageUpdatedAt")
                        .HasColumnName("msg_updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("RaceId")
                        .HasColumnName("fk_t_race")
                        .HasColumnType("bigint");

                    b.Property<ulong>("Snowflake")
                        .HasColumnName("snowflake")
                        .HasColumnType("bigint unsigned");

                    b.Property<long>("TrackerId")
                        .HasColumnName("fk_t_tracker")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Snowflake");

                    b.HasIndex("ChannelId");

                    b.HasIndex("RaceId");

                    b.HasIndex("TrackerId");

                    b.ToTable("t_announcement");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Channel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("display_name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<long>("GuildId")
                        .HasColumnName("fk_t_disc_guild")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("is_active")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<ulong>("Snowflake")
                        .HasColumnName("snowflake")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Snowflake");

                    b.HasIndex("GuildId");

                    b.ToTable("t_disc_channel");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Entrant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("longtext");

                    b.Property<int?>("Place")
                        .HasColumnName("place")
                        .HasColumnType("int");

                    b.Property<long>("RaceId")
                        .HasColumnName("fk_t_race")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnName("state")
                        .HasColumnType("longtext");

                    b.Property<int?>("Time")
                        .HasColumnName("time")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("t_entrant");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnName("abbreviation")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("SrlId")
                        .HasColumnName("srl_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Abbreviation");

                    b.HasAlternateKey("SrlId");

                    b.ToTable("t_game");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Guild", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("display_name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("is_active")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<ulong>("Snowflake")
                        .HasColumnName("snowflake")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Snowflake");

                    b.ToTable("t_disc_guild");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Race", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("GameId")
                        .HasColumnName("fk_t_game")
                        .HasColumnType("bigint");

                    b.Property<string>("Goal")
                        .IsRequired()
                        .HasColumnName("goal")
                        .HasColumnType("longtext")
                        .HasMaxLength(2048);

                    b.Property<bool>("IsActive")
                        .HasColumnName("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("SrlId")
                        .IsRequired()
                        .HasColumnName("srl_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnName("state")
                        .HasColumnType("longtext");

                    b.Property<int>("Time")
                        .HasColumnName("time")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("t_race");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Tracker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<long>("ChannelId")
                        .HasColumnName("fk_t_disc_channel")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("GameId")
                        .HasColumnName("fk_t_game")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnName("state")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("GameId");

                    b.ToTable("t_tracker");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Update", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FinishedAt")
                        .HasColumnName("finished_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnName("started_at")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Success")
                        .HasColumnName("success")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Announcement", b =>
                {
                    b.HasOne("RaceAnnouncer.Schema.Models.Channel", "Channel")
                        .WithMany("Announcements")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RaceAnnouncer.Schema.Models.Race", "Race")
                        .WithMany("Announcements")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RaceAnnouncer.Schema.Models.Tracker", "Tracker")
                        .WithMany("Announcements")
                        .HasForeignKey("TrackerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Channel", b =>
                {
                    b.HasOne("RaceAnnouncer.Schema.Models.Guild", "Guild")
                        .WithMany("Channels")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Entrant", b =>
                {
                    b.HasOne("RaceAnnouncer.Schema.Models.Race", "Race")
                        .WithMany("Entrants")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Race", b =>
                {
                    b.HasOne("RaceAnnouncer.Schema.Models.Game", "Game")
                        .WithMany("Races")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RaceAnnouncer.Schema.Models.Tracker", b =>
                {
                    b.HasOne("RaceAnnouncer.Schema.Models.Channel", "Channel")
                        .WithMany("Trackers")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RaceAnnouncer.Schema.Models.Game", "Game")
                        .WithMany("Trackers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
