﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GBSistemas.DAO
{
    class ConexaoDAO
    {
        public static MySqlConnection conexaoBanco()
        {            
                return new MySqlConnection("server = localhost; user = root; password= root; database = gbsistema");
        }
    }
}
