using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebApp.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options){ }
        public DbSet<Dept> Dept { get; set; }
        public DbSet<Emp> Emp { get; set; }
        public DbSet<Loc> Loc { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dept>().HasData(
                new Dept
                {
                    DeptID=1,
                    Dname = "CSE",
                    LocID=2
                 },
                 new Dept
                 {
                     DeptID = 2,
                     Dname = "IT",
                     LocID = 1
                 }

            );



            modelBuilder.Entity<Emp>().HasData(
                new Emp
                {
                    EmpID = 1,
                    Ename = "jihad",
                    Job = "Eng",
                    Sal=2000,
                    DeptID=1
                },
                new Emp
                {
                    EmpID = 2,
                    Ename = "Ali",
                    Job = "Eng",
                    Sal = 4000,
                    DeptID = 2
                }



            );




            modelBuilder.Entity<Loc>().HasData(
                new Loc
                {
                    LocID = 1,
                    City = "Nablus",
                    Street="a1"
                    }, 
                new Loc
                    {
                        LocID = 2,
                        City = "jenin",
                        Street = "b3"
                    }

            );

        }


    }
}
