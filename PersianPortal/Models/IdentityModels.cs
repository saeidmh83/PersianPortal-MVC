﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace PersianPortal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(50, ErrorMessage = "حداکثر طول مجاز برای نام 50 کاراکتر است."), Display(Name = "نام")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "حداکثر طول مجاز برای نام خانوادگی 200 کاراکتر است."), Display(Name = "نام خانوادگی")]
        public string FamilyName { get; set; }
        [Required]
        [DataType(DataType.Date), Display(Name = "تاریخ تولد")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [EmailAddress, Display(Name = "آدرس ایمیل")]
        public string EmailAddress { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Article> Article { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsType> NewsType { get; set; }
        public DbSet<Poem> Poem { get; set; }
        public DbSet<PoemType> PoemType { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<PersianPortal.Models.ApplicationUser> IdentityUsers { get; set; }
    }
}