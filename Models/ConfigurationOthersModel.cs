using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class ConfigurationOthersModel
    {
    }
    public class DUE
    {
        [Key]
        public int Dues_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الاستحقاق ")]
        [Display(Name = "Dues Name")]

 
        public string Dues_Name { get; set; }
       
        [StringLength(10)]
        [Required(ErrorMessage = "الرجاء ادخال نسبة الاستحقاق ")]
        [Display(Name = "Dues Rate")]
        public string Dues_Rate { get; set; }
    }
    public class DISCIPLINE
    {
        [Key]
        public int Discipline_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الاستقطاع ")]
        [Display(Name = "Discipline Name")]


        public string Discipline_Name { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "الرجاء ادخال نسبة الاستقطاع ")]
        [Display(Name = "Discipline Rate")]
        public string Discipline_Rate { get; set; }
    }
    public class ALLOWANCE
    {
        [Key]
        public int Allowance_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم البدلة ")]
        [Display(Name = "Allowance Name")]


        public string Allowance_Name { get; set; }


    }
    public class SCREEN
    {
        [Key]
        public int Screen_id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الشاشة ")]
        [Display(Name = "Screen Name")]

        public string Screen_Name { get; set; }


    } 
 

}
