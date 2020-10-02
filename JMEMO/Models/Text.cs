using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JMEMO.Models
{
    //[Table("Texts")]
    public class Text
    {
        public Int64 TextID { get; set; }

        [StringLength(500, MinimumLength = 1)]
        public string TextBody { get; set; }

        public Language Language { get; set; }
    }
}
