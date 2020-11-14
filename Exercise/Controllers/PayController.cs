using System.Data;
using System;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entites;
using Dto.Payment;
using Microsoft.AspNetCore.Mvc;
using ViewModel;
using ZarinPal.Class;

namespace Exercise.Controllers {
    public class PayController : Controller {
        private readonly dbcontext _db;
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        public static int id, amount;
        public static string msg;
        public PayController (dbcontext db) {
            var expose = new Expose ();
            _payment = expose.CreatePayment ();
            _authority = expose.CreateAuthority ();
            _transactions = expose.CreateTransactions ();
            _db = db;
        }
        public IActionResult Index () {

            if (msg != null) {
                ViewBag.msg = msg;
                msg = null;
            }
            return View ();
        }
        /////////////////////////////////////////////////request
        public async Task<IActionResult> Request (Vm_Tran T) {
            Tran tb = new Tran () {

                Name = T.Name,
                Tel = T.Tel,
                Email = T.Email,
                Date = DateTime.Today,
                Amount = T.Amount,

                Status = false

            };
            _db.Trans.Add (tb);
            _db.SaveChanges ();
            id = _db.Trans.OrderByDescending (a => a.Id).Take (1).SingleOrDefault ().Id;
            amount = Convert.ToInt32 (T.Amount);

            var result = await _payment.Request (new DtoRequest () {
                Mobile = T.Tel,
                    CallbackUrl = "https://localhost:5001/Pay/validate",
                    Description = T.Name,
                    Email = T.Email,
                    Amount = Convert.ToInt32 (T.Amount),
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
            }, ZarinPal.Class.Payment.Mode.sandbox);
            return Redirect ($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
        }
        /////////////////////////////////////////////////////////////////////////////اعتبار سنجی

        public async Task<IActionResult> Validate (string authority, string status) {
            var verification = await _payment.Verification (new DtoVerification {
                Amount = amount,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                    Authority = authority
            }, Payment.Mode.sandbox);

            if (verification.Status == 100) {
                var W = _db.Trans.Where (a => a.Id == id).SingleOrDefault ();
                W.Status = true;
                _db.Trans.Update (W);
                _db.SaveChanges ();

                msg = "s";
                return RedirectToAction ("index");
            } else {
                var W = _db.Trans.Where (a => a.Id == id).SingleOrDefault ();
                W.Status = false;
                _db.Trans.Update (W);
                _db.SaveChanges ();
                msg = "e";
                return RedirectToAction ("index");
            }

        }
        public IActionResult list () {

            if (msg != null) {

                ViewBag.m = msg;
                msg = null;
            }

            ViewBag.list = _db.Trans.OrderByDescending (a => a.Id).ToList ();
            return View ();
        }
         public IActionResult del (int id) {

            var E  = _db.Trans.Where (a => a.Id == id).SingleOrDefault ();
            _db.Trans.Remove (E);
          _db.SaveChanges ();
            msg = "حذف باموفقیت انجام شد";
            return RedirectToAction ("list");

        }
    }
    
    
}