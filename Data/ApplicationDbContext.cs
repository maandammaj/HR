using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR.Models;

namespace HR.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<SECTOR> SECTORS { get; set; }
        public DbSet<MANAGMENT> MANAGMENTS { get; set; }
        public DbSet<SUB_MANAGMENT> SUB_MANAGMENTS { get; set; }



        public DbSet<QUALIFICATION_TYPE> QUALIFICATION_TYPES { get; set; }

        public DbSet<SPECIALTIE> SPECIALTIES { get; set; }
        public DbSet<SPECIALTIES_DETAIL> SPECIALTIES_DETAILS { get; set; }
        public DbSet<QUALIFICTIONS_LEVEL> QUALIFICTIONS_LEVELS { get; set; }
        public DbSet<ESTIMATE> ESTIMATES { get; set; }




        public DbSet<JOB_TYPE> JOB_TYPES { get; set; }
        public DbSet<JOB_LEVEL> JOB_LEVELS { get; set; }
        public DbSet<JOB_CATEGORY> JOB_CATEGORYS { get; set; }
        public DbSet<JOB_RANK> JOB_RANKS { get; set; }
        public DbSet<POSITION> POSITIONS { get; set; }
        public DbSet<EMPLOYEE_CASE> EMPLOYEE_CASES { get; set; }




        public DbSet<DECISION_NATURAL> DECISION_NATURALS { get; set; }
        public DbSet<DECISION_TYPE> DECISION_TYPES { get; set; }
        public DbSet<CARDS_TYPE> CARDS_TYPES { get; set; }
        public DbSet<COUNTRIE> COUNTRIES { get; set; }
        public DbSet<CITIE> CITIES { get; set; }
        public DbSet<DIRECTORATE> DIRECTORATES { get; set; }
        public DbSet<HOLIDAY> HOLIDAYS { get; set; }
        public DbSet<LANGUAGE> LANGUAGES { get; set; }
        public DbSet<OVERTIMES_TYPE> OVERTIMES_TYPES { get; set; }



        public DbSet<DUE> DUES { get; set; }
        public DbSet<DISCIPLINE> DISCIPLINES { get; set; }
        public DbSet<ALLOWANCE> ALLOWANCES { get; set; }
        public DbSet<SCREEN> SCREENS { get; set; }

       





    }
}
