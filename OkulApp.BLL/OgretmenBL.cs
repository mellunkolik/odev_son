using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogrt.Ad),
                             new SqlParameter("@Soyad",ogrt.Soyad),
                             new SqlParameter("@Tc",ogrt.Tc)
                         };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgretmenler values(@Ad,@Soyad,@Tc)", p) > 0;

        }
    }
}
