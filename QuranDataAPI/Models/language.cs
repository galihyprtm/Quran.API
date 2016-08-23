using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "language")]
    public class language
    {
        [Column(Name = "langid")]
        public int langid { get; set; }

        [Column(Name = "lang")]
        public string lang { get; set; }

        [Column(Name = "dir")]
        public string dir { get; set; }
    }
}
