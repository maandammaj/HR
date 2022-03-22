using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Opportunities_And_LocationModel
    {
    }
    public class SECTOR
    {
        [Key]
        public int Sector_Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الجهة القضائية ")]
        [Display(Name = "Sector Name")]

        public string Sector_Name { get; set; }

    } 
    public class MANAGMENT
    {
        [Key]
        public int Managment_id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = " الرجاء ادخال اسم الموقع القضائي الأساسي ")]
        [Display(Name = "Managment Name")]

        public string Managment_Name { get; set; }

        public int SECTORId { get; set; }
        public SECTOR SECTOR { get; set; }
    } 
    public class SUB_MANAGMENT
    {
        [Key]
        public int Sub_Managment_Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "الرجاء ادخال اسم الموقع القضائي الفرعي ")]
        [Display(Name = "Sector Name")]

        public string Sub_Managment_Name { get; set; }
        [Required(ErrorMessage = "الرجاء ادخال حاله الموقع القضائي الفرعي ")]
        [Display(Name = "Sub Managment State ")]
        public bool Sub_Managment_State { get; set; }
        [Required(ErrorMessage = "الرجاء ادخال اسم الموقع القضائي  ")]
        [Display(Name = "MANAGMENTid")]
        public int MANAGMENTid { get; set; }
        public MANAGMENT MANAGMENT { get; set; }
    }
}
