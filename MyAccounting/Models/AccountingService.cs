using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyAccounting.Repositories;

namespace MyAccounting.Models
{
    public class AccountingService
    {
        private readonly IRepository<AccountBook> _accountRep;
        private readonly IUnitOfWork _unitOfWork;

        public AccountingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _accountRep = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<AccountBook> Lookup()
        {
            return _accountRep.LookupAll();
        }

        public AccountBook GetSingle(Guid id)
        {
            return _accountRep.GetSingle(d => d.Id == id);
        }

        public void Add(CreateAccountingViewModel model)
        {
            var newAccounting = new AccountBook()
            {
                Id = Guid.NewGuid(),
                Categoryyy = model.Type == "收入" ? 1 : 0,
                Amounttt = Convert.ToInt32(model.price),
                Dateee = model.date,
                Remarkkk = model.Note
            };
            _accountRep.Create(newAccounting);
        }

        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}