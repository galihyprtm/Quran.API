using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using QFE.DAL;
using QFE.BLL;

namespace QuranDataAPI.Controllers
{
    public class AyahController : ApiController
    {
        [SwaggerOperation("GetAyahFromSurah")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<quran_data.AyahData> GetAyahFromSurah(int Surah, int LanguageId)
        {
            if (LanguageId < 0) LanguageId = 11;
            return QFE.BLL.quran_data.getVerses3(Surah, LanguageId);
        }

        [SwaggerOperation("GetAyahByIndex")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public quran_data.AyahData GetAyahByIndex(int Index,int Surah)
        {
            if (Surah > 0 && Surah <= 114)
            {
                return QFE.BLL.quran_data.getVerse(Surah, Index);
            }

            return null;
        }

        [SwaggerOperation("GetAyahCountBySurah")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public int GetAyahCountBySurah(int Surah)
        {
            if (Surah > 0 && Surah <= 114)
            {
                var Cnt =  QFE.BLL.quran_data.getVerses1(Surah);
                return Cnt.Count;
            }

            return 0;
        }

        [SwaggerOperation("GetMediaByAyah")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public MediaItem GetMediaByAyah(int Surah,int Ayah,int ReciterId)
        {
            try
            {
                var rec = QFE.BLL.quran_data.getReciter(ReciterId);
                string _Prefix = rec.mediaurl;
                string SurahKey = Surah.ToString().PadLeft(3, '0');
                string AyahKey = Ayah.ToString().PadLeft(3, '0');
                string MediaUrl = string.Format(_Prefix, SurahKey, AyahKey);
                string NamaFile = string.Format("{0}_{1}.mp3", SurahKey, AyahKey);

                return new MediaItem() { FileName = NamaFile, Url = MediaUrl };
            }
            catch { }
            return null;
        }

    }
}
