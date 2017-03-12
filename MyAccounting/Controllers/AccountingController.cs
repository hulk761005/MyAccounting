using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAccounting.Models;

namespace MyAccounting.Controllers
{
    public class AccountingController : Controller
    {
        // GET: Accounting
        public ActionResult Index()
        {
            var AccountingList = new List<AccountingViewModels>
            {
                new AccountingViewModels{Type = "支出",date = Convert.ToDateTime("2016-01-01"), price = 300 },
                new AccountingViewModels{Type = "支出",date = Convert.ToDateTime("2016-01-02"), price = 16000 },
                new AccountingViewModels{Type = "支出",date = Convert.ToDateTime("2016-01-03"), price = 8000 }
            };

            return View(AccountingList);
        }

        // GET: Accounting/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Accounting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounting/Create
        [HttpPost]
        public ActionResult Create(CreateAccountingViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounting/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accounting/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounting/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accounting/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
