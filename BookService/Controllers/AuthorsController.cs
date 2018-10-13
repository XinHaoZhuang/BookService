// <copyright file="AuthorsController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Controllers
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Description;
    using BookService.Models;

    public class AuthorsController : ApiController
    {
        private BookServiceContext db = new BookServiceContext();

        // GET: api/Authors
        public IQueryable<Author> GetAuthors()
        {
            return this.db.Authors;
        }

        // GET: api/Authors/5
        [ResponseType(typeof(Author))]
        public async Task<IHttpActionResult> GetAuthor(int id)
        {
            Author author = await this.db.Authors.FindAsync(id);
            if (author == null)
            {
                return this.NotFound();
            }

            return this.Ok(author);
        }

        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAuthor(int id, Author author)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != author.Id)
            {
                return this.BadRequest();
            }

            this.db.Entry(author).State = EntityState.Modified;

            try
            {
                await this.db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.AuthorExists(id))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Authors
        [ResponseType(typeof(Author))]
        public async Task<IHttpActionResult> PostAuthor(Author author)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.db.Authors.Add(author);
            await this.db.SaveChangesAsync();

            return this.CreatedAtRoute("DefaultApi", new { id = author.Id }, author);
        }

        // DELETE: api/Authors/5
        [ResponseType(typeof(Author))]
        public async Task<IHttpActionResult> DeleteAuthor(int id)
        {
            Author author = await this.db.Authors.FindAsync(id);
            if (author == null)
            {
                return this.NotFound();
            }

            this.db.Authors.Remove(author);
            await this.db.SaveChangesAsync();

            return this.Ok(author);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }

        private bool AuthorExists(int id)
        {
            return this.db.Authors.Count(e => e.Id == id) > 0;
        }
    }
}