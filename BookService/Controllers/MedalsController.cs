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

namespace BookService.Controllers
{
    public class MedalsController : ApiController
    {
        private BookServiceContext db = new BookServiceContext();

        // GET: api/Medals
        public IQueryable<Medal> GetMedals()
        {
            return db.Medals;
        }

        // GET: api/Medals/5
        [ResponseType(typeof(Medal))]
        public async Task<IHttpActionResult> GetMedal(int id)
        {
            Medal medal = await db.Medals.FindAsync(id);
            if (medal == null)
            {
                return NotFound();
            }

            return Ok(medal);
        }

        // PUT: api/Medals/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMedal(int id, Medal medal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != medal.Id)
            {
                return BadRequest();
            }

            db.Entry(medal).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedalExists(id))
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

        // POST: api/Medals
        [ResponseType(typeof(Medal))]
        public async Task<IHttpActionResult> PostMedal(Medal medal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Medals.Add(medal);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = medal.Id }, medal);
        }

        // DELETE: api/Medals/5
        [ResponseType(typeof(Medal))]
        public async Task<IHttpActionResult> DeleteMedal(int id)
        {
            Medal medal = await db.Medals.FindAsync(id);
            if (medal == null)
            {
                return NotFound();
            }

            db.Medals.Remove(medal);
            await db.SaveChangesAsync();

            return Ok(medal);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MedalExists(int id)
        {
            return db.Medals.Count(e => e.Id == id) > 0;
        }
    }
}