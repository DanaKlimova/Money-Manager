using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MoneyManager.DAL.Models
{
    public class CashVoucher
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public bool Type { get; set; }

        public double Amount { get; set; }

        [ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }

        //[ManyToOne]
        //[ForeignKey(typeof(Category))]
        [ManyToOne]
        public Category Category { get; set; }
    }
}
