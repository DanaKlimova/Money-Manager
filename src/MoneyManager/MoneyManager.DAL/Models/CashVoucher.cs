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

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Category> Categories { get; set; }
    }
}
