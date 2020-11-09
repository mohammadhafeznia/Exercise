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

        public static string msg, error, NewFileName, NewFileName2, NewFileName3;

        private readonly dbcontext db;
        
        private readonly IHostingEnvironment _env;

    
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

   
        public async Task<IActionResult> Add (Vm_User bt) {

            if (db.Tbl_Users.Any (a => a.Name == bt.Name))

            {
                msg = "کدملی قبلا ثبت شده است";
                return RedirectToAction ("index");
            }

            string FileExtension1 = Path.GetExtension (bt.file.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{_env.WebRootPath}\\upload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {

                await bt.file.CopyToAsync (stream);
            }


            //////////////////upload file

            string FileExtension2 = Path.GetExtension (bt.FileUpload.FileName);
            NewFileName2 = String.Concat (Guid.NewGuid ().ToString (), FileExtension2);
            var path2 = $"{_env.WebRootPath}\\upload\\{NewFileName2}";
            using (var stream = new FileStream (path2, FileMode.Create)) {

                await bt.FileUpload.CopyToAsync (stream);

            }
            ////////////////// end upload file


            //////////////////upload Video
            string FileExtension3 = Path.GetExtension (bt.Video.FileName);
            NewFileName3 = String.Concat (Guid.NewGuid ().ToString (), FileExtension3);
            var path3 = $"{_env.WebRootPath}\\upload\\{NewFileName3}";
            using (var stream = new FileStream (path3, FileMode.Create)) {

                await bt.Video.CopyToAsync (stream);

            }
            ////////////////// end upload Video


            Tbl_User tb = new Tbl_User () {

                Name = bt.Name,
                Family = bt.Family,
                Address = bt.Address,
                Codemeli = bt.Codemeli,
                image = NewFileName,
                FileName = NewFileName2,
                VideoName=NewFileName3

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
                image = q.image,
                VideoName = q.VideoName

            };
            return View (bt);

        }

       
        [HttpPost]
        
        public async Task<IActionResult> update (Vm_User bt) {

            var q = db.Tbl_Users.Where (a => a.Id == bt.Id).SingleOrDefault ();

            q.Name = bt.Name;
            q.Family = bt.Family;
            q.Address = bt.Address;
            q.Codemeli = bt.Codemeli;
            /////////////////////
            if (bt.file != null) {
                string FileExtension1 = Path.GetExtension (bt.file.FileName);
                NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                var path = $"{_env.WebRootPath}\\upload\\{NewFileName}";
                using (var stream = new FileStream (path, FileMode.Create)) {

                    await bt.file.CopyToAsync (stream);

                }

            }
            q.image = NewFileName;
            /////////////////////
            if (bt.FileUpload != null) {
                string FileExtension1 = Path.GetExtension (bt.FileUpload.FileName);
                NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                var path = $"{_env.WebRootPath}\\upload\\{NewFileName}";
                using (var stream = new FileStream (path, FileMode.Create)) {

                    await bt.FileUpload.CopyToAsync (stream);

                }

            }
            q.FileName = NewFileName;
            /////////////////////////
            if (bt.Video != null) {
                string FileExtension1 = Path.GetExtension (bt.Video.FileName);
                NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                var path = $"{_env.WebRootPath}\\upload\\{NewFileName}";
                using (var stream = new FileStream (path, FileMode.Create)) {

                    await bt.Video.CopyToAsync (stream);

                }

            }
            q.VideoName = NewFileName;

            db.Tbl_Users.Update (q);
            db.SaveChanges ();
            msg = "بروزرسانی انجام شد";

            return RedirectToAction ("list");

        }
    }
}