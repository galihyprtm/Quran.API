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
    public class SurahController : ApiController
    {
       
       
        [SwaggerOperation("GetSurah")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<surah> GetSurah()
        {
            return LoadSurah(0);
        }

        [SwaggerOperation("GetSurahByIndex")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public surah GetSurahByIndex(int Index)
        {
            if(Index>0 && Index <= 114)
            {
                return QFE.BLL.quran_data.getSurah(Index);
            }

            return null;
        }

        [SwaggerOperation("GetSurahByJuz")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<surah> GetSurahByJuz(int Juz)
        {
            return LoadSurah(Juz);
        }

        private IEnumerable<surah> LoadSurah(int Juz = 0)
        {
            IList<QFE.DAL.surah> data = null;
            if (Juz <= 0)
            {
                data = QFE.BLL.quran_data.getSurahNames();
            }
            else
            {
                data = QFE.BLL.quran_data.getSurahFromJuz(Juz);
            }
            return data;
        }

    }
}
