using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Projet_Achraf
{
    class db
    {
        public static MySqlConnection cn = new MySqlConnection("server=localhost;uid=root;pwd=;database=mydata;CHARSET=utf8");
        public static string userid;
    }
}
