using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BookService.Models;
using BookService.Models.Base;

namespace BookService.Controllers
{
    public class BaseCustomerTypesController : ApiController
    {
        private BookServiceContext db = new BookServiceContext();

        // GET: api/BaseCustomerTypes
        public IQueryable<BaseCustomerType> GetBaseCustomerTypes()
        {
            return db.BaseCustomerTypes;
        }

        // GET: api/BaseCustomerTypes/5
        [ResponseType(typeof(BaseCustomerType))]
        public async Task<IHttpActionResult> GetBaseCustomerType(int id)
        {
            BaseCustomerType baseCustomerType = await db.BaseCustomerTypes.FindAsync(id);
            if (baseCustomerType == null)
            {
                return NotFound();
            }

            return Ok(baseCustomerType);
        }

        // PUT: api/BaseCustomerTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBaseCustomerType(int id, BaseCustomerType baseCustomerType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != baseCustomerType.Id)
            {
                return BadRequest();
            }

            db.Entry(baseCustomerType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BaseCustomerTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/BaseCustomerTypes
        [ResponseType(typeof(BaseCustomerType))]
        public async Task<IHttpActionResult> PostBaseCustomerType(BaseCustomerType baseCustomerType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BaseCustomerTypes.Add(baseCustomerType);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = baseCustomerType.Id }, baseCustomerType);
        }

        // DELETE: api/BaseCustomerTypes/5
        [ResponseType(typeof(BaseCustomerType))]
        public async Task<IHttpActionResult> DeleteBaseCustomerType(int id)
        {
            BaseCustomerType baseCustomerType = await db.BaseCustomerTypes.FindAsync(id);
            if (baseCustomerType == null)
            {
                return NotFound();
            }

            db.BaseCustomerTypes.Remove(baseCustomerType);
            await db.SaveChangesAsync();

            return Ok(baseCustomerType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BaseCustomerTypeExists(int id)
        {
            return db.BaseCustomerTypes.Count(e => e.Id == id) > 0;
        }
    }
}