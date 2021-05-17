using RealEstateApp.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RealEstateApp.Api.Controllers
{
    public class BaseController : ApiController
    {
        protected readonly RealEstateDbEntities db;

        public BaseController()
        {
            db = new RealEstateDbEntities();
        }
    }
}
