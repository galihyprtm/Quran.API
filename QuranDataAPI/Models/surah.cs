using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "surah")]
    public class surah
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "totalayah")]
        public int totalayah { get; set; }

        [Column(Name = "name")]
        public string name { get; set; }

        [Column(Name = "latin")]
        public string latin { get; set; }

        [Column(Name = "place")]
        public string place { get; set; }
    }
}
