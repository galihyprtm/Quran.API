using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "bookmark")]
    public class bookmark
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "title")]
        public string title { get; set; }

        [Column(Name = "surah")]
        public int surah { get; set; }

        [Column(Name = "juz")]
        public int juz { get; set; }

        [Column(Name = "ayah")]
        public int ayah { get; set; }

        
    }
}
