using RealEstateApp.Api.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RealEstateApp.Api.Controllers
{
    public class ProprietaireController : BaseController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            return Ok(await db.Proprietaires.ToArrayAsync());
        }

        [HttpGet]
        public async Task<IHttpActionResult> Details(int id)
        {
            return Ok(await db.Proprietaires.FindAsync(id));
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] Proprietaire item)
        {
                item.CreatedDate = DateTime.Now;
                db.Proprietaires.Add(item);
                await db.SaveChangesAsync();
                return Ok(item);
        }

        [HttpPut]
        public async Task<IHttpActionResult> Put([FromBody] Proprietaire item)
        {
            var oleItem = await db.Proprietaires.AsNoTracking().FirstOrDefaultAsync(x => x.Id == item.Id);
            if(oleItem != null)
            {
                item.CreatedDate = oleItem.CreatedDate;
                db.Entry(item).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            
            return Ok(item);
        }

        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var item = await db.Proprietaires.FindAsync(id);
            {
                db.Proprietaires.Remove(item);
                await db.SaveChangesAsync();
            }
            return Ok(item);
        }
    }
}
