using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemScolarDeInregistrareApp
{
    class Conectare
    {
        SqlConnection conectare;

        public Conectare()
        {
            conectare = new SqlConnection
                ("Data Source=ASUS;Database=SistemScolar;Trusted_Connection=yes;");
        }

        public SqlConnection DeschidereConectare()
        {
            try
            {
                conectare.Open();
            }
            catch (Exception)
            {

            }

            return conectare;
        }

        public void InchidereConectare()
        {
            try
            {
                conectare.Close();
            }
            catch(Exception)
            {

            }
        }


    }
}
