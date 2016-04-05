using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietoja
{
    public class Tietoja
    {
        OleDbConnection connection;
        OleDbCommand command;

        // nyt perkele mene gittiin
        private void ConnectTo()
        {
            connection = new OleDbConnection("");
            command = connection.CreateCommand();
        }
    }
}
