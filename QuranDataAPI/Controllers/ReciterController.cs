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
    public class ReciterController : ApiController
    {


        [SwaggerOperation("GetReciters")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IEnumerable<reciter> GetReciters()
        {
            return QFE.BLL.quran_data.getReciters();
        }

        [SwaggerOperation("GetReciterByIndex")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public reciter GetReciterByIndex(int Index)
        {
            if (Index >= 0 )
            {
                return QFE.BLL.quran_data.getReciter(Index);
            }

            return null;
        }
        

    }
}
