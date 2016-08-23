using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "hizb")]
    public class hizb
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "surahfrom")]
        public int surahfrom { get; set; }

        [Column(Name = "ayahfrom")]
        public int ayahfrom { get; set; }

        [Column(Name = "surahto")]
        public int surahto { get; set; }

        [Column(Name = "ayahto")]
        public int ayahto { get; set; }
    }
}
