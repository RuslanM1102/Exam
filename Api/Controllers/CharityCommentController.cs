using Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

namespace Api.Controllers
{
    public class CharityCommentController : ApiController
    {
        private CharitiesDBEntities _context = EntitiesContext.GetContext();

        // GET: api/CharityComments
        public IQueryable<CharityComment> GetCharityComment()
        {
            return _context.CharityComment;
        }

        // POST: api/CharityComments
        [ResponseType(typeof(CharityComment))]
        public IHttpActionResult PostCharityComment(CharityComment charityComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CharityComment.Add(charityComment);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = charityComment.Id }, charityComment);
        }
    }
}