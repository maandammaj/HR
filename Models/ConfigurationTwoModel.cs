using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class ConfigurationTwoModel
    {
    }  
    public class DECISION_NATURAL
    {
        [Key]
        public int DEC_NATURAL_id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم طبيعة القرار ")]
        [Display(Name = "DECISION NATURAL Name")]

        public string DEC_NATURAL_Name { get; set; }
    }
    public class DECISION_TYPE
    {
        [Key]
        public int DEC_TYPE_id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم نوع القرار ")]
        [Display(Name = "DECISION NATURAL Name")]

        public string DEC_TYPE_Name { get; set; }
    }  
    public class CARDS_TYPE
    {
        [Key]
        public int Card_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم نوع الوثيقة ")]
        [Display(Name = "Card Name")]

        public string Card_Name { get; set; }
    }  
    public class COUNTRIE
    {
        [Key]
        public int Country_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الدولة ")]
        [Display(Name = "Country Name")]

        public string Country_Name { get; set; }
    }
    public class CITIE
    {
        [Key]
        public int City_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم المحافظة ")]
        [Display(Name = " City Name")]

        public string City_Name { get; set; }
        [Required(ErrorMessage = "الرجاء ادخال اسم الدولة ")]
        [Display(Name = " COUNTRIE Id ")]
        public int COUNTRIEId { get; set; }
        public COUNTRIE COUNTRIE { get; set; }
    }
    public class DIRECTORATE
    {
        [Key]
        public int Directorates_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم المديرية ")]
        [Display(Name = " Directorates Name")]

        public string Directorates_Name { get; set; }
        [Required(ErrorMessage = "الرجاء ادخال اسم المحافظة ")]
        [Display(Name = " CITIE Id ")]
        public int CITIEId { get; set; }
        public CITIE CITIE { get; set; }
    }
    public class HOLIDAY
    {
        [Key]
        public int Holidays_ID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الاجازة ")]
        [Display(Name = " Holiday Name")]

        public string Holidays_Name { get; set; }
        [Required(ErrorMessage = "الرجاء ادخال رصيد الاجازة ")]
        [Display(Name = " Holidays rate ")]

        public int Holidays_Rate { get; set; }
    }
    public class LANGUAGE
    {
        [Key]
        public int Language_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم اللغة ")]
        [Display(Name = " Language Name")]

        public string Language_Name { get; set; }
      
    } 
    public class OVERTIMES_TYPE
    {
        [Key]
        public int Overtimes_Type_Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال نوع الوقت الإضافي ")]
        [Display(Name = " Overtimes Type Name ")]

        public string Overtimes_Type_Name { get; set; }
        [Required(ErrorMessage = "الرجاء ادخال نسبة للوقت الإضافي ")]
        [Display(Name = " Overtimes Type Rate ")]

        public int Overtimes_Type_Rate { get; set; }
    }

}
