using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManager.DAL.Interfaces
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
