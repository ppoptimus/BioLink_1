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
using Biolink_Api.Models;

namespace Biolink_Api.Controllers
{
    public class GetDataController : ApiController
    {
        private ModelContext db = new ModelContext();

        // GET: api/GetData
        public IQueryable<t_text_file> GetTextFile()
        {
            return db.t_text_file;
        }

        // GET: api/GetData/5
        [ResponseType(typeof(t_text_file))]
        public async Task<IHttpActionResult> Gett_text_file(int id)
        {
            t_text_file t_text_file = await db.t_text_file.FindAsync(id);
            if (t_text_file == null)
            {
                return NotFound();
            }

            return Ok(t_text_file);
        }

        // PUT: api/GetData/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putt_text_file(int id, t_text_file t_text_file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t_text_file.ID)
            {
                return BadRequest();
            }

            db.Entry(t_text_file).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!t_text_fileExists(id))
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

        // POST: api/GetData
        [ResponseType(typeof(t_text_file))]
        public async Task<IHttpActionResult> Postt_text_file(t_text_file t_text_file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.t_text_file.Add(t_text_file);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (t_text_fileExists(t_text_file.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = t_text_file.ID }, t_text_file);
        }

        // DELETE: api/GetData/5
        [ResponseType(typeof(t_text_file))]
        public async Task<IHttpActionResult> Deletet_text_file(int id)
        {
            t_text_file t_text_file = await db.t_text_file.FindAsync(id);
            if (t_text_file == null)
            {
                return NotFound();
            }

            db.t_text_file.Remove(t_text_file);
            await db.SaveChangesAsync();

            return Ok(t_text_file);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool t_text_fileExists(int id)
        {
            return db.t_text_file.Count(e => e.ID == id) > 0;
        }
    }
}