using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class EntitiesContext
    {
        private static CharitiesDBEntities _context;

        public static CharitiesDBEntities GetContext()
        {
            if (_context == null)
            {
                _context = new CharitiesDBEntities();
            }
            return _context;
        }
    }
}