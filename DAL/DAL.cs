using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DAL
{
    public class DAL
    {
        string host = "localhost";
        int port = 1521;
        string sid = "orclpdp";
        string user = "emp";
        string password = "emp";
        OracleConnection conn;
        public DAL()
        {
            conn = DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
        //thực hiện query để trả về DataSet
        public DataSet excutedata(string query, OracleParameter[] sqlParameters, CommandType commandType)
        {
            conn.Open();
            DataSet data = new DataSet();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = commandType;
                if (sqlParameters != null)
                {
                    foreach (OracleParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(data);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }
        //thực hiện updatedate dữ liệu inser/delete/update
        public void excuteUpdate(string query, OracleParameter[] sqlParameters, CommandType commandType)
        {
            conn.Open();
            try
            {
                //OracleParameter gradeParam = new OracleParameter("@grade", SqlDbType.Int);
                //gradeParam.Value = 3;
                //cmd.Parameters.Add(gradeParam);
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = commandType;
                if (sqlParameters != null)
                {
                    foreach (OracleParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally{
                conn.Close();
            }
        }
        //tra ve gia tri don
        public string excutescalar(string query, OracleParameter[] sqlParameters, OracleDbType oracleDbType , CommandType commandType)
        {
            conn.Open();
            string result = "";
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = commandType;
                if (sqlParameters != null)
                {
                    foreach (OracleParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                OracleParameter resultParam = new OracleParameter("@Result", OracleDbType.Varchar2, 50);
                // ReturnValue
                resultParam.Direction = ParameterDirection.ReturnValue;
                // Thêm vào danh sách tham số.
                cmd.Parameters.Add(resultParam);
                cmd.ExecuteNonQuery();
                if (resultParam.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultParam.Value;
                   result = ret.ToString();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
