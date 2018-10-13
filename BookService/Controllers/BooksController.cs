// <copyright file="BooksController.cs" company="PlaceholderCompany">
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

    public class BooksController : ApiController
    {
        private readonly BookServiceContext db = new BookServiceContext();

        // GET: api/Books
        public IQueryable<BookDTO> GetBooks()
        {
            var books = from b in this.db.Books
                   select new BookDTO()
                   {
                       Id = b.Id,
                       Title = b.Title,
                       AuthorName = b.Author.Name
                   };
            return books;

            // return db.Books
            //    .Include(b => b.Author);
        }

        // GET: api/Books/5
        [ResponseType(typeof(BookDetailDTO))]
        public async Task<IHttpActionResult> GetBook(int id)
        {
            // Book book = await db.Books.FindAsync(id);
            var book = await this.db.Books.Select(b =>
            new BookDetailDTO()
            {
                Id = b.Id,
                Title = b.Title,
                Year = b.Year,
                Price = b.Price,
                AuthorName = b.Author.Name,
                Genre = b.Genre
            }).SingleOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return this.NotFound();
            }

            return this.Ok(book);
        }

        // PUT: api/Books/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBook(int id, Book book)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != book.Id)
            {
                return this.BadRequest();
            }

            this.db.Entry(book).State = EntityState.Modified;

            try
            {
                await this.db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.BookExists(id))
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

        // POST: api/Books
        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> PostBook(Book book)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.db.Books.Add(book);
            await this.db.SaveChangesAsync();

            return this.CreatedAtRoute("DefaultApi", new { id = book.Id }, book);
        }

        // DELETE: api/Books/5
        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> DeleteBook(int id)
        {
            Book book = await this.db.Books.FindAsync(id);
            if (book == null)
            {
                return this.NotFound();
            }

            this.db.Books.Remove(book);
            await this.db.SaveChangesAsync();

            return this.Ok(book);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }

        private bool BookExists(int id)
        {
            return this.db.Books.Count(e => e.Id == id) > 0;
        }
    }
}