// <copyright file="SysMenusController.cs" company="PlaceholderCompany">
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

    public class SysMenusController : ApiController
    {
        private readonly BookServiceContext db = new BookServiceContext();

        // GET: api/SysMenus
        public IQueryable<SysMenus> GetMenus()
        {
            return this.db.SysMenus;
        }

        // GET: api/SysMenus/5
        [ResponseType(typeof(SysMenus))]
        public async Task<IHttpActionResult> GetSysMenu(int id)
        {
            SysMenus sysMenu = await this.db.SysMenus.FindAsync(id);
            if (sysMenu == null)
            {
                return this.NotFound();
            }

            return this.Ok(sysMenu);
        }

        // PUT: api/SysMenus/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSysMenu(int id, SysMenus sysMenu)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != sysMenu.Id)
            {
                return this.BadRequest();
            }

            this.db.Entry(sysMenu).State = EntityState.Modified;

            try
            {
                await this.db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.SysMenuExists(id))
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

        // POST: api/SysMenus
        [ResponseType(typeof(SysMenus))]
        public async Task<IHttpActionResult> PostSysMenu(SysMenus sysMenu)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.db.SysMenus.Add(sysMenu);
            await this.db.SaveChangesAsync();

            return this.CreatedAtRoute("DefaultApi", new { id = sysMenu.Id }, sysMenu);
        }

        // DELETE: api/SysMenus/5
        [ResponseType(typeof(SysMenus))]
        public async Task<IHttpActionResult> DeleteSysMenu(int id)
        {
            SysMenus sysMenu = await this.db.SysMenus.FindAsync(id);
            if (sysMenu == null)
            {
                return this.NotFound();
            }

            this.db.SysMenus.Remove(sysMenu);
            await this.db.SaveChangesAsync();

            return this.Ok(sysMenu);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }

        private bool SysMenuExists(int id)
        {
            return this.db.SysMenus.Count(e => e.Id == id) > 0;
        }
    }
}