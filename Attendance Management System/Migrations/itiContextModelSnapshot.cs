﻿// <auto-generated />
using System;
using Attendance_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    [DbContext(typeof(itiContext))]
    partial class itiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Attendance_Management_System.Models.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("Time_in")
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("Time_out")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.AttendanceDegree", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("UntilDate")
                        .HasColumnType("date");

                    b.Property<int>("AbscenceDays")
                        .HasColumnType("int");

                    b.Property<int>("AttendanceDegrees")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "UntilDate");

                    b.ToTable("AttendanceDegrees");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.ITIProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Programs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Professional Training Program",
                            IsActive = true,
                            Name = "PTP"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Intensive Training Program",
                            IsActive = true,
                            Name = "ITP"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Leadership Development Program",
                            IsActive = true,
                            Name = "LDP"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Summer Training",
                            IsActive = true,
                            Name = "ST"
                        });
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Intake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<byte>("Number")
                        .HasColumnType("tinyint");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Intake");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateOnly(2024, 9, 1),
                            Number = (byte)44,
                            StartDate = new DateOnly(2023, 9, 1)
                        });
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Permission", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("BodyOfDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "Date");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Date = new DateOnly(2024, 4, 20),
                            BodyOfDescription = "1",
                            DateCreated = new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7088),
                            ID = 1,
                            Reason = "1",
                            Status = 0
                        },
                        new
                        {
                            StudentId = 2,
                            Date = new DateOnly(2024, 4, 20),
                            BodyOfDescription = "2",
                            DateCreated = new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7333),
                            ID = 2,
                            Reason = "2",
                            Status = 0
                        },
                        new
                        {
                            StudentId = 3,
                            Date = new DateOnly(2024, 4, 20),
                            BodyOfDescription = "3",
                            DateCreated = new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7338),
                            ID = 3,
                            Reason = "3",
                            Status = 0
                        },
                        new
                        {
                            StudentId = 4,
                            Date = new DateOnly(2024, 4, 20),
                            BodyOfDescription = "4",
                            DateCreated = new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7344),
                            ID = 4,
                            Reason = "4",
                            Status = 0
                        },
                        new
                        {
                            StudentId = 5,
                            Date = new DateOnly(2024, 4, 20),
                            BodyOfDescription = "5",
                            DateCreated = new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7349),
                            ID = 5,
                            Reason = "5",
                            Status = 0
                        });
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateOnly(2024, 4, 20),
                            EndTime = new TimeOnly(22, 0, 0),
                            StartTime = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateOnly(2024, 4, 21),
                            EndTime = new TimeOnly(22, 0, 0),
                            StartTime = new TimeOnly(11, 0, 0),
                            TrackId = 2
                        });
                });

            modelBuilder.Entity("Attendance_Management_System.Models.ScheduleEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("ScheduleEvents");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "PD",
                            ProgramId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "OS",
                            ProgramId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            Name = "AI",
                            ProgramId = 2
                        },
                        new
                        {
                            Id = 4,
                            IsActive = true,
                            Name = "MERN",
                            ProgramId = 2
                        },
                        new
                        {
                            Id = 5,
                            IsActive = true,
                            Name = "MEAN",
                            ProgramId = 2
                        });
                });

            modelBuilder.Entity("Attendance_Management_System.Models.TrackIntake", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int>("IntakeId")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "IntakeId");

                    b.HasIndex("IntakeId");

                    b.ToTable("TrackIntakes");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            IntakeId = 1
                        },
                        new
                        {
                            TrackId = 2,
                            IntakeId = 1
                        },
                        new
                        {
                            TrackId = 3,
                            IntakeId = 1
                        },
                        new
                        {
                            TrackId = 4,
                            IntakeId = 1
                        },
                        new
                        {
                            TrackId = 5,
                            IntakeId = 1
                        });
                });

            modelBuilder.Entity("Attendance_Management_System.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UsersRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Instructor", b =>
                {
                    b.HasBaseType("Attendance_Management_System.Models.User");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Student", b =>
                {
                    b.HasBaseType("Attendance_Management_System.Models.User");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("GraduationYear")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrackID")
                        .HasColumnType("int");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasIndex("NationalId")
                        .IsUnique();

                    b.HasIndex("TrackID");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Supervisor", b =>
                {
                    b.HasBaseType("Attendance_Management_System.Models.Instructor");

                    b.Property<int>("SupTrackId")
                        .HasColumnType("int");

                    b.HasIndex("SupTrackId")
                        .IsUnique()
                        .HasFilter("[SupTrackId] IS NOT NULL");

                    b.ToTable("Supervisor");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Attendance", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.Student", null)
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Management_System.Models.AttendanceDegree", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.Student", "Student")
                        .WithMany("AttendanceDegrees")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Permission", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.Student", "Student")
                        .WithMany("Permissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Schedule", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.Track", "Track")
                        .WithMany("Schedules")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.ScheduleEvent", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.Schedule", "Schedule")
                        .WithMany("ScheduleEvents")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Track", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.ITIProgram", "Program")
                        .WithMany("Tracks")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.TrackIntake", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.Intake", "Intake")
                        .WithMany("Tracks")
                        .HasForeignKey("IntakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance_Management_System.Models.Track", "Track")
                        .WithMany("Intakes")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Intake");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance_Management_System.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Instructor", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Attendance_Management_System.Models.Instructor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Student", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Attendance_Management_System.Models.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance_Management_System.Models.Track", "Track")
                        .WithMany("Students")
                        .HasForeignKey("TrackID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Supervisor", b =>
                {
                    b.HasOne("Attendance_Management_System.Models.Instructor", null)
                        .WithOne()
                        .HasForeignKey("Attendance_Management_System.Models.Supervisor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance_Management_System.Models.Track", "Track")
                        .WithOne("Supervisor")
                        .HasForeignKey("Attendance_Management_System.Models.Supervisor", "SupTrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.ITIProgram", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Intake", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Schedule", b =>
                {
                    b.Navigation("ScheduleEvents");
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Track", b =>
                {
                    b.Navigation("Intakes");

                    b.Navigation("Schedules");

                    b.Navigation("Students");

                    b.Navigation("Supervisor")
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Management_System.Models.Student", b =>
                {
                    b.Navigation("AttendanceDegrees");

                    b.Navigation("Attendances");

                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
