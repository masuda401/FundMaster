using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FundMaster
{
    static class DBUtil
    {

        public static void DbConnect()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();

            //con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
            //                     + "Data Source=C:\\Users\\masuda\\Desktop\\投信銘柄情報管理DB構想\\FundMaster.accdb";

            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
                                 + "Data Source=C:\\Users\\masuda\\Desktop\\Database1.mdb";

            try
            {
                con.Open();
                MessageBox.Show("接続しました。", "通知");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "通知");
            }
        }

    }
}
