using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyAccounting.Models
{
    public class AccountingViewModels
    {
        public string Type { get; set; }

        [DataType(DataType.Currency)]
        public decimal price { get; set; }

        public System.DateTime date { get; set; }

        public string Note { get; set; }
    }

    public class CreateAccountingViewModel
    {
        [Display(Name = "類別")]
        public string Type { get; set; }

        [Display(Name = "金額")]
        [DataType(DataType.Currency)]
        public string price { get; set; }

        [Display(Name = "日期")]
        public System.DateTime date { get; set; }

        [Display(Name = "備註")]
        [MaxLength(100)]
        public string Note { get; set; }

        public string Message { get; set; }
    }

    public enum EnumType
    {
        支出,
        收入
    }
}