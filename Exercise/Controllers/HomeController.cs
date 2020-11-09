using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entites;
using Exercise.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace test.Controllers {
    public class HomeController : Controller {

        public static string msg, error, NewFileName, NewFileName2;

        private readonly dbcontext db;
        [Obsolete]
        private readonly IHostingEnvironment _env;

        [Obsolete]
        public HomeController (dbcontext _db, IHostingEnvironment env) {
            db = _db;
            _env = env;
        }

        public IActionResult Index () {
            if (msg != null) {

                ViewBag.m = msg;
                msg = null;
            }

            return View ();
        }

        public IActionResult list () {

            if (msg != null) {

                ViewBag.m = msg;
                msg = null;
            }

            ViewBag.list = db.Tbl_Users.OrderByDescending (a => a.Id).ToList ();
            return View ();
        }

        [Obsolete]
        public async Task<IActionResult> Add (Vm_User bt) {

            if (db.Tbl_Users.Any (a => a.Name == bt.Name))

            {
                msg = "کدملی قبلا ثبت شده است";
                return RedirectToAction ("index");
            }

            ///////////////////////////////////////////////////////////upload image
            string FileExtension1 = Path.GetExtension (bt.file.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{_env.WebRootPath}\\upload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {

                await bt.file.CopyToAsync (stream);

            }
            ///////////////upload file
            string FileExtension2 = Path.GetExtension (bt.FileUpload.FileName);
            NewFileName2 = String.Concat (Guid.NewGuid ().ToString (), FileExtension2);
            var path2 = $"{_env.WebRootPath}\\upload\\{NewFileName2}";
            using (var stream = new FileStream (path2, FileMode.Create)) {

                await bt.FileUpload.CopyToAsync (stream);

            }
            ///////////////end upload file

            Tbl_User tb = new Tbl_User () {

                Name = bt.Name,
                Family = bt.Family,
                Address = bt.Address,
                Codemeli = bt.Codemeli,
                image = NewFileName,
                FileName = NewFileName2

            };
            db.Tbl_Users.Add (tb);
            db.SaveChanges ();
            msg = "ثبت با موققیت انجام شد";

            return RedirectToAction ("index");

        }
        public IActionResult del (int id) {

            var quser = db.Tbl_Users.Where (a => a.Id == id).SingleOrDefault ();
            db.Tbl_Users.Remove (quser);
            db.SaveChanges ();
            msg = "حذف باموفقیت انجام شد";
            return RedirectToAction ("list");

        }

        [HttpGet]
        public IActionResult update (int id) {

            var q = db.Tbl_Users.Where (a => a.Id == id).SingleOrDefault ();
            Vm_User bt = new Vm_User () {
                Id = q.Id,
                Name = q.Name,
                Family = q.Family,
                Address = q.Address,
                Codemeli = q.Codemeli,
                image = q.image

            };
            return View (bt);

        }

        private string GetBaseDir () {
            throw new NotImplementedException ();
        }

        private byte[] GetFile (string fullName) {
            throw new NotImplementedException ();
        }

        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> update (Vm_User bt) {

            var q = db.Tbl_Users.Where (a => a.Id == bt.Id).SingleOrDefault ();

            q.Name = bt.Name;
            q.Family = bt.Family;
            q.Address = bt.Address;
            q.Codemeli = bt.Codemeli;
            if (bt.file != null) {
                string FileExtension1 = Path.GetExtension (bt.file.FileName);
                NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                var path = $"{_env.WebRootPath}\\upload\\{NewFileName}";
                using (var stream = new FileStream (path, FileMode.Create)) {

                    await bt.file.CopyToAsync (stream);

                }
                //////////////////////////end upload file 
            }
            q.image = NewFileName;

            //////////




  if (bt.FileUpload != null) {
                string FileExtension1 = Path.GetExtension (bt.FileUpload.FileName);
                NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                var path = $"{_env.WebRootPath}\\upload\\{NewFileName}";
                using (var stream = new FileStream (path, FileMode.Create)) {

                    await bt.FileUpload.CopyToAsync (stream);

                }
                //////////////////////////end upload file 
            }
            q.FileName = NewFileName;


            ///////////

            db.Tbl_Users.Update (q);
            db.SaveChanges ();
            msg = "بروزرسانی انجام شد";

            return RedirectToAction ("list");

        }
    }
}