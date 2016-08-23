using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFE.DAL
{
    [Table(Name = "quran")]
    public class quran
    {
        [Column(Name = "idx")]
        public int idx { get; set; }

        [Column(Name = "ayah_id")]
        public int ayah_id { get; set; }

        [Column(Name = "surah_id")]
        public int? surah_id { get; set; }

        [Column(Name = "ayah_location")]
        public string ayah_location { get; set; }

        [Column(Name = "Arabic")]
        public string Arabic { get; set; }

        [Column(Name = "Albanian")]
        public string Albanian { get; set; }

        [Column(Name = "Azerbaijani")]
        public string Azerbaijani { get; set; }

        [Column(Name = "Bangali")]
        public string Bangali { get; set; }

        [Column(Name = "Bosnian")]
        public string Bosnian { get; set; }

        [Column(Name = "Bulgarian")]
        public string Bulgarian { get; set; }

        [Column(Name = "Chinese")]
        public string Chinese { get; set; }

        [Column(Name = "Czech")]
        public string Czech { get; set; }

        [Column(Name = "Divehi")]
        public string Divehi { get; set; }

        [Column(Name = "Dutch")]
        public string Dutch { get; set; }

        [Column(Name = "English")]
        public string English { get; set; }

        [Column(Name = "German")]
        public string German { get; set; }

        [Column(Name = "Hausa")]
        public string Hausa { get; set; }

        [Column(Name = "Hindi")]
        public string Hindi { get; set; }

        [Column(Name = "Indonesian")]
        public string Indonesian { get; set; }

        [Column(Name = "Italian")]
        public string Italian { get; set; }

        [Column(Name = "Japanese")]
        public string Japanese { get; set; }

        [Column(Name = "Korean")]
        public string Korean { get; set; }

        [Column(Name = "Kurdish")]
        public string Kurdish { get; set; }

        [Column(Name = "Malay")]
        public string Malay { get; set; }

        [Column(Name = "Malayalam")]
        public string Malayalam { get; set; }

        [Column(Name = "Norwegian")]
        public string Norwegian { get; set; }

        [Column(Name = "Persian")]
        public string Persian { get; set; }

        [Column(Name = "Polish")]
        public string Polish { get; set; }

        [Column(Name = "Portuguese")]
        public string Portuguese { get; set; }

        [Column(Name = "Romanian")]
        public string Romanian { get; set; }

        [Column(Name = "Russian")]
        public string Russian { get; set; }

        [Column(Name = "Sindhi")]
        public string Sindhi { get; set; }

        [Column(Name = "Somali")]
        public string Somali { get; set; }

        [Column(Name = "Spanish")]
        public string Spanish { get; set; }

        [Column(Name = "Swahili")]
        public string Swahili { get; set; }

        [Column(Name = "Swedish")]
        public string Swedish { get; set; }

        [Column(Name = "Tajik")]
        public string Tajik { get; set; }

        [Column(Name = "Tamil")]
        public string Tamil { get; set; }

        [Column(Name = "Tatar")]
        public string Tatar { get; set; }

        [Column(Name = "Thai")]
        public string Thai { get; set; }

        [Column(Name = "Turkish")]
        public string Turkish { get; set; }

        [Column(Name = "Urdu")]
        public string Urdu { get; set; }

        [Column(Name = "Uzbek")]
        public string Uzbek { get; set; }
    }
}
