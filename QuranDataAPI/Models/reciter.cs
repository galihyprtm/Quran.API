using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "reciter")]
    public class reciter
    {
        [Column(Name = "idx")]
        public int idx { get; set; }
        [Column(Name = "name")]
        public string name { get; set; }
       
        [Column(Name = "mediaurl")]
        public string mediaurl { get; set; }
    }
}
