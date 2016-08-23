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
    public class LanguageController : ApiController
    {


        [SwaggerOperation("GetLanguage")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<language> GetLanguage()
        {
            return QFE.BLL.quran_data.getLanguage();
        }

        [SwaggerOperation("GetLanguageById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public language GetLanguageById(int Index)
        {
            if (Index >= 0)
            {
                return QFE.BLL.quran_data.getLanguage(Index);
            }

            return null;
        }

      

    }
}
