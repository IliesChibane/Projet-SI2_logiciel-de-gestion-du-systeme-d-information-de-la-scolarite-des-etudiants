using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSI2.Classe
{
    class BDConnect
    {
        public static MySqlConnection conect = DBconnect();

        private static MySqlConnection DBconnect()
        {
            String MySQLConnection = "datasource=bczf6bse7wkirofegzrb-mysql.services.clever-cloud.com;port=3306;username=ubccztlll2vcvmge1;password=bczf6bse7wkirofegzrb;database=bczf6bse7wkirofegzrb";
            //String MySQLConnection = "datasource=127.0.0.1;port=3306;username=root;password=Ilies.10.10.20.00;database=tp1";
            MySqlConnection dbc = new MySqlConnection(MySQLConnection);
            if (dbc != null)
                Console.WriteLine("reussie");
            return dbc;
        }
    }
}
