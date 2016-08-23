using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "transliteration")]
    public class transliteration
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "surahidx")]
        public int surahidx { get; set; }

        [Column(Name = "ayahidx")]
        public int ayahidx { get; set; }

        [Column(Name = "langid")]
        public int langid { get; set; }

        [Column(Name = "content")]
        public string content { get; set; }
    }
}
