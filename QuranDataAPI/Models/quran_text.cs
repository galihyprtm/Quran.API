using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "quran_text")]
    public class quran_text
    {
        [Column(Name = "index")]
        public int index { get; set; }
        [Column(Name = "sura")]
        public int sura { get; set; }
        [Column(Name = "aya")]
        public int aya { get; set; }
        [Column(Name = "text")]
        public string text { get; set; }
    }
}
