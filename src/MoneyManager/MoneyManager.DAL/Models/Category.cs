using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MoneyManager.DAL.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(typeof(CashVoucher))]
        public int CashVoucherId { get; set; }

        [OneToMany]
        //[OneToOne]
        public CashVoucher CashVoucher { get; set; }
    }
}
