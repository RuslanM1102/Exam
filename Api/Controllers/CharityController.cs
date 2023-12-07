using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class CharityController : ApiController
    {
        private CharitiesDBEntities _context = EntitiesContext.GetContext();
        // GET api/Charity
        public IQueryable<Charity> GetCharity()
        {
            return _context.Charity;
        }
    }
}