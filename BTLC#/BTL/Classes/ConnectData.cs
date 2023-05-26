using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace BTL.Classes
{
    internal class ConnectData
    {
        //Khai báo biến tàn cục
        string strConnect = @"Data Source=DESKTOP-TQ23O8D\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection sqlConnect = null;
        //phương thức mở kết nối
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }
        //phương thức đóng kết nối 
        void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //phường thức thực thi câu lệnh select trả về một Datatable 
        public DataTable DataReader(string sqlSeclct)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSeclct, sqlConnect);
            sqlData.Fill(tblData);
            return tblData;
        }

        //phương thức thực hiện câu lệnh dạng insert, update, delate
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlcoma = new SqlCommand();
            sqlcoma.Connection = sqlConnect;
            sqlcoma.CommandText = sql;
            sqlcoma.ExecuteNonQuery();
            CloseConnect();

        }

        public SqlDataReader DocTD(string sqlSeclct)
        {
            SqlDataReader sdr;
            OpenConnect();
            SqlCommand sqlData = new SqlCommand(sqlSeclct, sqlConnect);
            sdr = sqlData.ExecuteReader();
            return sdr;
        }
        public void loadtextbox(TextBox cb, string strselect, byte index)
        {
            OpenConnect();
            SqlCommand sqlcom = null;
            SqlDataReader sqldr = null;
            sqlcom = new SqlCommand(strselect, sqlConnect);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[index].ToString();
            }
            CloseConnect();
        }
    }
}
