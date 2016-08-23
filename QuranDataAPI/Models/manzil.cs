using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "manzil")]
    public class manzil
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "name")]
        public string name { get; set; }

        [Column(Name = "surahfrom")]
        public int surahfrom { get; set; }

        [Column(Name = "surahto")]
        public int surahto { get; set; }
    }
}
