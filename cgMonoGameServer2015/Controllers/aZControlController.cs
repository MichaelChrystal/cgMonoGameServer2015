﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace cgMonoGameServer2015.Controllers
{
    [RoutePrefix("api/aZControl")]
    public class aZControlController : ApiController
    {
        [Route("getDate")]
        public DateTime getDate()
        {
            //IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            return DateTime.Now;
        }
    }
}
