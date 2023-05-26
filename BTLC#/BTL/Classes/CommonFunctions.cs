using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL.Classes
{
    internal class CommonFunctions
    {
        BTL.Classes.ConnectData dtbase = new BTL.Classes.ConnectData();
        public void FillComboBox(ComboBox comboName, DataTable data, string displayMember, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }
        public void FillComboBox(string sql, ComboBox comboName, string displayMember, string valueMember)
        {
            DataTable table = new DataTable();
            table = dtbase.DataReader(sql);
            comboName.DataSource = table;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }
        public void loadtextboxchiso(TextBox cb, string strselect, byte chiso)
        {
            SqlDataReader sqldr = dtbase.DocTD(strselect);
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
        }
        public bool checkkeysexists(string input, string strselect)
        {
            SqlDataReader sqldr = dtbase.DocTD(strselect);
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == input.ToLower())
                {
                    return true;
                }                   
            }
            return false;
        }
    }
}