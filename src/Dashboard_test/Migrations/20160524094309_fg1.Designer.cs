using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Dashboard_test.Models;

namespace Dashboard_test.Migrations
{
    [DbContext(typeof(DashboardContext))]
    [Migration("20160524094309_fg1")]
    partial class fg1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dashboard_test.Models.Dashboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name");

                    b.Property<string>("UserName");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Dashboard_test.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GroupName");

                    b.HasKey("GroupId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("TableId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Dashboard_test.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TeacherId");

                    b.Property<string>("Text");

                    b.HasKey("NoteId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<int>("SubjectId");

                    b.Property<int>("TeacherId");

                    b.Property<int>("TimeTableId");

                    b.HasKey("ScheduleId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GroupId");

                    b.Property<string>("StudentCard");

                    b.HasKey("StudentId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("SubjectId");
                });

            modelBuilder.Entity("Dashboard_test.Models.SubjectGroups", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<int>("SubjectId");

                    b.HasKey("GroupId", "SubjectId");
                });

            modelBuilder.Entity("Dashboard_test.Models.SubjectTeacher", b =>
                {
                    b.Property<int>("TeacherId");

                    b.Property<int>("SubjectId");

                    b.Property<int?>("SubjectSubjectId");

                    b.HasKey("TeacherId", "SubjectId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("DashboardId");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Dashboard_test.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("TeacherId");
                });

            modelBuilder.Entity("Dashboard_test.Models.TeacherGroup", b =>
                {
                    b.Property<int>("TeacherId");

                    b.Property<int>("GroupId");

                    b.HasKey("TeacherId", "GroupId");
                });

            modelBuilder.Entity("Dashboard_test.Models.TimeTable", b =>
                {
                    b.Property<int>("TimeTableId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<DateTime>("StartDateTime");

                    b.HasKey("TimeTableId");
                });

            modelBuilder.Entity("Dashboard_test.Models.User", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<DateTime>("Birth");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("StudentId");

                    b.Property<string>("Surname");

                    b.Property<int?>("TeacherId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "Discriminator");

                    b.HasAnnotation("Relational:DiscriminatorValue", "User");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "Discriminator");

                    b.HasAnnotation("Relational:DiscriminatorValue", "IdentityRole");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("Dashboard_test.Models.Admin", b =>
                {
                    b.HasBaseType("Dashboard_test.Models.User");


                    b.HasAnnotation("Relational:DiscriminatorValue", "Admin");
                });

            modelBuilder.Entity("Dashboard_test.Models.UserRoles", b =>
                {
                    b.HasBaseType("Microsoft.AspNet.Identity.EntityFramework.IdentityRole");

                    b.Property<string>("Description");

                    b.HasAnnotation("Relational:DiscriminatorValue", "UserRoles");
                });

            modelBuilder.Entity("Dashboard_test.Models.Issue", b =>
                {
                    b.HasOne("Dashboard_test.Models.Table")
                        .WithMany()
                        .HasForeignKey("TableId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Schedule", b =>
                {
                    b.HasOne("Dashboard_test.Models.Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Dashboard_test.Models.Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.HasOne("Dashboard_test.Models.Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.HasOne("Dashboard_test.Models.TimeTable")
                        .WithMany()
                        .HasForeignKey("TimeTableId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Student", b =>
                {
                    b.HasOne("Dashboard_test.Models.Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("Dashboard_test.Models.SubjectGroups", b =>
                {
                    b.HasOne("Dashboard_test.Models.Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Dashboard_test.Models.Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Dashboard_test.Models.SubjectTeacher", b =>
                {
                    b.HasOne("Dashboard_test.Models.Teacher")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.HasOne("Dashboard_test.Models.Subject")
                        .WithMany()
                        .HasForeignKey("SubjectSubjectId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Table", b =>
                {
                    b.HasOne("Dashboard_test.Models.Dashboard")
                        .WithMany()
                        .HasForeignKey("DashboardId");
                });

            modelBuilder.Entity("Dashboard_test.Models.TeacherGroup", b =>
                {
                    b.HasOne("Dashboard_test.Models.Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Dashboard_test.Models.Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("Dashboard_test.Models.User", b =>
                {
                    b.HasOne("Dashboard_test.Models.Student")
                        .WithOne()
                        .HasForeignKey("Dashboard_test.Models.User", "StudentId");

                    b.HasOne("Dashboard_test.Models.Teacher")
                        .WithOne()
                        .HasForeignKey("Dashboard_test.Models.User", "TeacherId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Dashboard_test.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Dashboard_test.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Dashboard_test.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Dashboard_test.Models.Admin", b =>
                {
                });
        }
    }
}