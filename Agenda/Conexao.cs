using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Agenda
{
    class Conexao
    {
        public static SqlConnection Conectar()
        {
            return new SqlConnection(@"Server=GLERYSTON-PC;uid=sa;pwd=123;DataBase=Agenda;");
        }
 
    }
}
