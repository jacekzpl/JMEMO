using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JMEMO.Models
{
    //[Table("Languages")]
    public class Language
    {
        public int LanguageID { get; set; }
        public LanguageType LanguageCode { get; set; }
    }

    public enum LanguageType
    {
        [Display(Name = "Unknown")]
        Unknown = 0,
        [Display(Name = "polski")]
        PL = 1,
        [Display(Name = "english")]
        EN = 2,
        [Display(Name = "espanol")]
        ES = 3
    }
}
