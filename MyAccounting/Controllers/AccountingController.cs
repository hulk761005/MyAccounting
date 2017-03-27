using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAccounting.Models;
using MyAccounting.Repositories;
using PagedList;

namespace MyAccounting.Controllers
{
    public class AccountingController : Controller
    {

        private readonly AccountingService _accountService;

        public AccountingController()
        {
            var unitOfWork = new EFUnitOfWork();
            _accountService = new AccountingService(unitOfWork);
        }
        // GET: Accounting
        public ActionResult Index(int page = 1)
        {
            var AccountingList = _accountService
                .Lookup()
                .Select(a => new AccountingViewModels {
                    price = (decimal)a.Amounttt,
                    Type = a.Categoryyy == 1 ? "收入" : "支出",
                    date = a.Dateee,
                    Note = a.Remarkkk
                }).OrderBy(a => a.date).ToPagedList(page, 10);

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
                    _accountService.Add(model);
                    _accountService.Save();
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
