using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JMEMO.Models
{
    //[Table("Tasks")]
    public class Task
    {
        public Int64 TaskID { get; set; }
        public User User { get; set; }
        public Text PL { get; set; }
        public Text EN { get; set; }
        public Text ES { get; set; }
        public DateTime RepetitionDayPLEN { get; set; }
        public int LevelPLEN { get; set; }
        public DateTime RepetitionDayPLES { get; set; }
        public int LevelPLES { get; set; }
        public DateTime RepetitionDayENPL { get; set; }
        public int LevelENPL { get; set; }
        public DateTime RepetitionDayENES { get; set; }
        public int LevelENES { get; set; }
        public DateTime RepetitionDayESPL { get; set; }
        public int LevelESPL { get; set; }
        public DateTime RepetitionDayESEN { get; set; }
        public int LevelESEN { get; set; }

    }

    //public enum LanguagePair
    //{
    //    [Display(Name = "Unknown")]
    //    Unknown = 0,

    //    [Display(Name = "polski-english")]
    //    PLEN = 1,

    //    [Display(Name = "polski-espanol")]
    //    PLES = 2,

    //    [Display(Name = "english-polski")]
    //    ENPL = 3,

    //    [Display(Name = "english-espanol")]
    //    ENES = 4,

    //    [Display(Name = "espanol-polski")]
    //    ESPL = 5,

    //    [Display(Name = "espanol-english")]
    //    ESEN = 6,
    //}

    //public class TextPair
    //{
    //    LanguagePair Pair;
    //    int Days;
    //}
}
