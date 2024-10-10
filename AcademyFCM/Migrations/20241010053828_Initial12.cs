﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AcademyFCM.Migrations
{
    /// <inheritdoc />
    public partial class Initial12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 6, 1 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 6, 2 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 7, 3 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 7, 4 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 8, 5 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 8, 6 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 9, 7 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 9, 8 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 10, 9 });

             migrationBuilder.DeleteData(
                 table: "Enrollments",
                 keyColumns: new[] { "SectionId", "StudentId" },
                 keyValues: new object[] { 10, 10 });

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 1);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 2);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 3);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 4);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 5);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 11);

             migrationBuilder.DeleteData(
                 table: "Courses",
                 keyColumn: "Id",
                 keyValue: 1);

             migrationBuilder.DeleteData(
                 table: "Courses",
                 keyColumn: "Id",
                 keyValue: 2);

             migrationBuilder.DeleteData(
                 table: "Instructors",
                 keyColumn: "Id",
                 keyValue: 1);

             migrationBuilder.DeleteData(
                 table: "Instructors",
                 keyColumn: "Id",
                 keyValue: 2);

             migrationBuilder.DeleteData(
                 table: "Schedules",
                 keyColumn: "Id",
                 keyValue: 1);

             migrationBuilder.DeleteData(
                 table: "Schedules",
                 keyColumn: "Id",
                 keyValue: 5);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 6);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 7);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 8);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 9);

             migrationBuilder.DeleteData(
                 table: "Sections",
                 keyColumn: "Id",
                 keyValue: 10);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 1);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 2);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 3);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 4);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 5);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 6);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 7);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 8);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 9);

             migrationBuilder.DeleteData(
                 table: "Students",
                 keyColumn: "Id",
                 keyValue: 10);

             migrationBuilder.DeleteData(
                 table: "Courses",
                 keyColumn: "Id",
                 keyValue: 3);

             migrationBuilder.DeleteData(
                 table: "Courses",
                 keyColumn: "Id",
                 keyValue: 4);

             migrationBuilder.DeleteData(
                 table: "Courses",
                 keyColumn: "Id",
                 keyValue: 5);

             migrationBuilder.DeleteData(
                 table: "Instructors",
                 keyColumn: "Id",
                 keyValue: 3);

             migrationBuilder.DeleteData(
                 table: "Instructors",
                 keyColumn: "Id",
                 keyValue: 4);

             migrationBuilder.DeleteData(
                 table: "Instructors",
                 keyColumn: "Id",
                 keyValue: 5);

             migrationBuilder.DeleteData(
                 table: "Offices",
                 keyColumn: "Id",
                 keyValue: 1);

             migrationBuilder.DeleteData(
                 table: "Offices",
                 keyColumn: "Id",
                 keyValue: 2);

             migrationBuilder.DeleteData(
                 table: "Schedules",
                 keyColumn: "Id",
                 keyValue: 2);

             migrationBuilder.DeleteData(
                 table: "Schedules",
                 keyColumn: "Id",
                 keyValue: 3);

             migrationBuilder.DeleteData(
                 table: "Schedules",
                 keyColumn: "Id",
                 keyValue: 4);

             migrationBuilder.DeleteData(
                 table: "Offices",
                 keyColumn: "Id",
                 keyValue: 3);

             migrationBuilder.DeleteData(
                 table: "Offices",
                 keyColumn: "Id",
                 keyValue: 4);

             migrationBuilder.DeleteData(
                 table: "Offices",
                 keyColumn: "Id",
                 keyValue: 5);*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.InsertData(
                 table: "Courses",
                 columns: new[] { "Id", "CourseName", "Price" },
                 values: new object[,]
                 {
                     { 1, "Mathematics", 1000m },
                     { 2, "Physics", 2000m },
                     { 3, "Chemistry", 1500m },
                     { 4, "Biology", 1200m },
                     { 5, "Computer Sciences", 3000m }
                 });

             migrationBuilder.InsertData(
                 table: "Offices",
                 columns: new[] { "Id", "OfficeLocation", "OfficeName" },
                 values: new object[,]
                 {
                     { 1, "building A", "Off_05" },
                     { 2, "building B", "Off_12" },
                     { 3, "Adminstration", "Off_32" },
                     { 4, "IT Department", "Off_44" },
                     { 5, "IT Department", "Off_43" }
                 });

             migrationBuilder.InsertData(
                 table: "Schedules",
                 columns: new[] { "Id", "FRI", "MON", "SAT", "SUN", "THU", "TUE", "Title", "WED" },
                 values: new object[,]
                 {
                     { 1, false, true, false, true, true, true, "Daily", true },
                     { 2, false, false, false, true, true, true, "DayAfterDay", false },
                     { 3, false, true, false, false, false, false, "TwiceAWeek", true },
                     { 4, true, false, true, false, false, false, "Weekend", false },
                     { 5, true, true, true, true, false, true, "Compact", true }
                 });

             migrationBuilder.InsertData(
                 table: "Students",
                 columns: new[] { "Id", "FName", "LName" },
                 values: new object[,]
                 {
                     { 1, "Fatima  ", "Ali    " },
                     { 2, "Noor    ", "Saleh  " },
                     { 3, "Omar    ", "Youssef" },
                     { 4, "Huda    ", "Ahmed  " },
                     { 5, "Amira   ", "Tariq  " },
                     { 6, "Zainab  ", "Ismail " },
                     { 7, "Yousef  ", "Farid  " },
                     { 8, "Layla   ", "Mustafa" },
                     { 9, "Mohammed", "Adel   " },
                     { 10, "Samira ", "Nabil  " }
                 });

             migrationBuilder.InsertData(
                 table: "Instructors",
                 columns: new[] { "Id", "FName", "LName", "OfficeId" },
                 values: new object[,]
                 {
                     { 1, "Ahmed  ", " Abdullah", 1 },
                     { 2, "Yasmeen", " Mohammed", 2 },
                     { 3, "Khalid ", " Hassan", 3 },
                     { 4, "Nadia  ", " Ali", 4 },
                     { 5, "Omar   ", " Ibrahim", 5 }
                 });

             migrationBuilder.InsertData(
                 table: "Sections",
                 columns: new[] { "Id", "CourseId", "EndTime", "InstructorId", "ScheduleId", "SectionName", "StartTime" },
                 values: new object[,]
                 {
                     { 1, 1, new TimeSpan(0, 10, 0, 0, 0), 1, 1, "S_MA1", new TimeSpan(0, 8, 0, 0, 0) },
                     { 2, 1, new TimeSpan(0, 18, 0, 0, 0), 2, 3, "S_MA2", new TimeSpan(0, 14, 0, 0, 0) },
                     { 3, 2, new TimeSpan(0, 15, 0, 0, 0), 1, 4, "S_PH1", new TimeSpan(0, 10, 0, 0, 0) },
                     { 4, 2, new TimeSpan(0, 12, 0, 0, 0), 3, 1, "S_PH2", new TimeSpan(0, 10, 0, 0, 0) },
                     { 5, 3, new TimeSpan(0, 18, 0, 0, 0), 2, 1, "S_CH1", new TimeSpan(0, 16, 0, 0, 0) },
                     { 6, 3, new TimeSpan(0, 10, 0, 0, 0), 3, 2, "S_CH2", new TimeSpan(0, 8, 0, 0, 0) },
                     { 7, 4, new TimeSpan(0, 14, 0, 0, 0), 4, 3, "S_BI1", new TimeSpan(0, 11, 0, 0, 0) },
                     { 8, 4, new TimeSpan(0, 14, 0, 0, 0), 5, 4, "S_BI2", new TimeSpan(0, 10, 0, 0, 0) },
                     { 9, 5, new TimeSpan(0, 18, 0, 0, 0), 4, 4, "S_CS1", new TimeSpan(0, 16, 0, 0, 0) },
                     { 10, 5, new TimeSpan(0, 15, 0, 0, 0), 5, 3, "S_CS2", new TimeSpan(0, 12, 0, 0, 0) },
                     { 11, 5, new TimeSpan(0, 11, 0, 0, 0), 4, 5, "S_CS3", new TimeSpan(0, 9, 0, 0, 0) }
                 });

             migrationBuilder.InsertData(
                 table: "Enrollments",
                 columns: new[] { "SectionId", "StudentId" },
                 values: new object[,]
                 {
                     { 6, 1 },
                     { 6, 2 },
                     { 7, 3 },
                     { 7, 4 },
                     { 8, 5 },
                     { 8, 6 },
                     { 9, 7 },
                     { 9, 8 },
                     { 10, 9 },
                     { 10, 10 }
                 });*/
        }
    }
}
