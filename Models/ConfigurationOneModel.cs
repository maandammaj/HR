using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class ConfigurationOneModel
    {
    }
    public class JOB_TYPE
    {
        [Key]
        public int Job_type_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال نوع الوظيفة ")]
        [Display(Name = "Job type Name")]

        public string Job_type_Name { get; set; }


    }  
    public class JOB_LEVEL
    {
        [Key]
        public int Job_Level_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال الدرجة الوظيفية ")]
        [Display(Name = "Job Level Name")]

        public string Job_Level_Name { get; set; }


    }  
    public class JOB_CATEGORY
    {
        [Key]
        public int Job_Category_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال الفئة الوظيفية ")]
        [Display(Name = "Job Category Name")]

        public string Job_Category_Name { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال التفاصيل الوظيفية ")]
        [Display(Name = "Job Category Description ")]

        public string Job_Category_Description { get; set; }
        [Required(ErrorMessage = "الرجاء ادخال الدرجة الوظيفية ")]
        [Display(Name = "JOB LEVELid  ")]

        public int JOB_LEVELid { get; set; }
        public JOB_LEVEL JOB_LEVEL { get; set; }

    }  
    public class JOB_RANK
    {
        [Key]
        public int Job_Rank_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال المرتبة الوظيفية ")]
        [Display(Name = "Job Rank Name")]

        public string Job_Rank_Name { get; set; }
        [StringLength(18)]
        [Required(ErrorMessage = "الرجاء ادخال الراتب ")]
        [Display(Name = "Job Rank Salary")]

        public string Job_Rank_Salary { get; set; } 

        [StringLength(30)]
        [Required(ErrorMessage = "الرجاء ادخال  ")]
        [Display(Name = "Job Rank Premium")]

        public string Job_Rank_Premium { get; set; }

        [Required(ErrorMessage = "الرجاء ادخال اسم الفئة الوظيفية ")]
        [Display(Name = "Job Category Id")]

        public int JOB_CATEGORYId { get; set; }
        public JOB_CATEGORY JOB_CATEGORY { get; set; }


    }  



    public class POSITION
    {
        [Key]
        public int Positions_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم المنصب ")]
        [Display(Name = "Job Level Name")]

        public string Positions_Name { get; set; }


    }
    public class EMPLOYEE_CASE
    {
        [Key]
        public int Employee_Cases_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الحالة ")]
        [Display(Name = "Employee Cases Name")]

        public string Employee_Cases_Name { get; set; }


    }
}
