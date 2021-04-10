using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_Reservation_Manager.Models;

namespace Hotel_Reservation_Manager.Controllers
{
    public class RoomUsagesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RoomUsages
        public async Task<ActionResult> Index()
        {
            return View(await db.RoomUsages.ToListAsync());
        }

        // GET: RoomUsages/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservations roomUsage = await db.RoomUsages.FindAsync(id);
            if (roomUsage == null)
            {
                return HttpNotFound();
            }
            return View(roomUsage);
        }

        // GET: RoomUsages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomUsages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,RoomId,GuestId,IsActive,Date")] Reservations roomUsage)
        {
            if (ModelState.IsValid)
            {
                db.RoomUsages.Add(roomUsage);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(roomUsage);
        }

        // GET: RoomUsages/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservations roomUsage = await db.RoomUsages.FindAsync(id);
            if (roomUsage == null)
            {
                return HttpNotFound();
            }
            return View(roomUsage);
        }

        // POST: RoomUsages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,RoomId,GuestId,IsActive,Date")] Reservations roomUsage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roomUsage).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(roomUsage);
        }

        // GET: RoomUsages/Delete/5
        [Authorize(Roles = "Администратор")]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservations roomUsage = await db.RoomUsages.FindAsync(id);
            if (roomUsage == null)
            {
                return HttpNotFound();
            }
            return View(roomUsage);
        }

        // POST: RoomUsages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Администратор")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Reservations roomUsage = await db.RoomUsages.FindAsync(id);
            db.RoomUsages.Remove(roomUsage);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
