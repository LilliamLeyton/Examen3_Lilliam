using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen3_Lilliam.BDLilliam
{
    public class BDconec
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        BDconec.open();
        return BDconec;
    }
}