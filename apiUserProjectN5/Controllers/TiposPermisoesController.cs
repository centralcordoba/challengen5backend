
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using apiUserProjectN5.Models;

namespace apiUserProjectN5.Controllers
{
    public class TiposPermisoesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/TiposPermisoes
        public IQueryable<TiposPermiso> GetTiposPermisos()
        {
            return db.TiposPermisos;
        }

        // GET: api/TiposPermisoes/5
        [ResponseType(typeof(TiposPermiso))]
        public IHttpActionResult GetTiposPermiso(int id)
        {
            TiposPermiso tiposPermiso = db.TiposPermisos.Find(id);
            if (tiposPermiso == null)
            {
                return NotFound();
            }

            return Ok(tiposPermiso);
        }

        // PUT: api/TiposPermisoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTiposPermiso(int id, TiposPermiso tiposPermiso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tiposPermiso.Id)
            {
                return BadRequest();
            }

            db.Entry(tiposPermiso).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposPermisoExists(id))
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

        // POST: api/TiposPermisoes
        [ResponseType(typeof(TiposPermiso))]
        public IHttpActionResult PostTiposPermiso(TiposPermiso tiposPermiso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TiposPermisos.Add(tiposPermiso);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tiposPermiso.Id }, tiposPermiso);
        }

        // DELETE: api/TiposPermisoes/5
        [ResponseType(typeof(TiposPermiso))]
        public IHttpActionResult DeleteTiposPermiso(int id)
        {
            TiposPermiso tiposPermiso = db.TiposPermisos.Find(id);
            if (tiposPermiso == null)
            {
                return NotFound();
            }

            db.TiposPermisos.Remove(tiposPermiso);
            db.SaveChanges();

            return Ok(tiposPermiso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TiposPermisoExists(int id)
        {
            return db.TiposPermisos.Count(e => e.Id == id) > 0;
        }
    }
}