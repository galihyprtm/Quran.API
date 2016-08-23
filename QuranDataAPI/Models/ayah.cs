using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "ayah")]
    public class ayah
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "arabic")]
        public string arabic { get; set; }
    }
}
