// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TutorialEntityFrameWorkCore.Models;

namespace TutorialEntityFrameWorkCore.Migrations
{
    [DbContext(typeof(SchoolDBContext))]
    partial class SchoolDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("GradeName")
                        .HasColumnType("text");

                    b.Property<string>("Section")
                        .HasColumnType("text");

                    b.HasKey("GradeId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Height")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("Weight_");

                    b.HasKey("StudentId");

                    b.HasIndex("GradeId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.StudentAddress", b =>
                {
                    b.Property<int>("StudentAddressId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("Address_");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text")
                        .HasColumnName("State_");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentAddressId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAddress");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<decimal?>("Height")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("Weight_");

                    b.HasKey("TeacherId");

                    b.HasIndex("CourseId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Student", b =>
                {
                    b.HasOne("TutorialEntityFrameWorkCore.Models.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .HasConstraintName("FK__Student__GradeId__145C0A3F");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.StudentAddress", b =>
                {
                    b.HasOne("TutorialEntityFrameWorkCore.Models.Student", "Student")
                        .WithMany("StudentAddresses")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__StudentAd__Stude__173876EA");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.StudentCourse", b =>
                {
                    b.HasOne("TutorialEntityFrameWorkCore.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__StudentCo__Cours__1B0907CE");

                    b.HasOne("TutorialEntityFrameWorkCore.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__StudentCo__Stude__1A14E395");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Teacher", b =>
                {
                    b.HasOne("TutorialEntityFrameWorkCore.Models.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__Teacher__CourseI__1DE57479");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Grade", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("TutorialEntityFrameWorkCore.Models.Student", b =>
                {
                    b.Navigation("StudentAddresses");

                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
