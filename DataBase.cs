using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DiplAlina
{
    class DataBase
    {
        MySqlConnection connect = new MySqlConnection("server=localhost");
    }
}
