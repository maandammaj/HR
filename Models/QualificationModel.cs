using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class QualificationModel
    {
    } 
    public class QUALIFICATION_TYPE
    {
        [Key]
        public int Qualification_Type_Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم نوع المؤهل ")]
        [Display(Name = "Qualification Type Name")]

        public string Qualification_Type_Name { get; set; }
    }  

    public class SPECIALTIE
    {
        [Key]
        public int Specialties_Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم التخصص ")]
        [Display(Name = "Specialties Name")]

        public string Specialties_Name { get; set; }

        [Required(ErrorMessage = "الرجاء ادخال اسم نوع المؤهل  ")]
        [Display(Name = "QUALIFICTIONS_LEVELEid")]
        public int QUALIFICTIONS_LEVELEid { get; set; }
        public QUALIFICATION_TYPE QUALIFICTIONS_LEVEL { get; set; }

    }  
    public class SPECIALTIES_DETAIL
    {
        [Key]
        public int Specialties_Detail_Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم التخصص الفرعي ")]
        [Display(Name = "Specialties Detail Name")]

        public string Specialties_Detail_Name { get; set; }

        [Required(ErrorMessage = "الرجاء ادخال اسم التخصص  ")]
        [Display(Name = "SPECIALTIEid")]
        public int SPECIALTIEid { get; set; }
        public SPECIALTIE SPECIALTIE { get; set; }

    }


    public class QUALIFICTIONS_LEVEL
    {
        [Key]
        public int Qualification_Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم درجة المؤهل ")]
        [Display(Name = "Qualification Name")]

        public string Qualification_Name { get; set; }
    }  
    public class ESTIMATE
    {
        [Key]
        public int Estimates_Id { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "الرجاء ادخال اسم التقدير ")]
        [Display(Name = "Estimates  Name")]

        public string Estimates_Name { get; set; }
    }
}
