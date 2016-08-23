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
    public class JuzController : ApiController
    {   
        [SwaggerOperation("GetJuz")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<juz> GetJuz()
        {
            return QFE.BLL.quran_data.getJuz();
        }

        [SwaggerOperation("GetJuzByIndex")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public juz GetJuzByIndex(int Index)
        {
            if (Index > 0 && Index <= 30)
            {
                return QFE.BLL.quran_data.getJuz(Index);
            }

            return null;
        }

        [SwaggerOperation("GetJuzBySurahAyah")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public juz GetJuzBySurahAyah(int Surah,int Ayah)
        {
            if (Surah > 0 && Surah <= 114)
            {
                return QFE.BLL.quran_data.getJuz(Surah,Ayah);
            }
            
            return null;
        }

     

    }
}
