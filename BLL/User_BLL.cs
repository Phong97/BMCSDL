using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User_BLL
    {
        public DataTable getAll()
        {
            string query = "select * from users";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getQuyenUser()
        {
            string query = "select grantee,privilege from DBA_SYS_PRIVS";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getDetailUser(string username)
        {
            string query = "select lock_date,created from DBA_USERS where username='"+username.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public int Login(string username, string password)
        {
            string query = "select CHECK_LOGIN('"+ username + "', '"+ password + "') from dual;";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            DataRow row = data.Rows[0];
            int check = int.Parse(row.ItemArray[0].ToString());
            return check;
        }
        public DataTable getOne(string username)
        {
            string query = "select DBA_USERS.default_tablespace,DBA_USERS.profile,DBA_TS_QUOTAS.MAX_BYTES " +
                "from DBA_USERS inner join DBA_TS_QUOTAS " +
                "on DBA_USERS.DEFAULT_TABLESPACE = DBA_TS_QUOTAS.TABLESPACE_NAME " +
                "where DBA_USERS.username = '"+username.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public int checkStatus(string username)
        {
            string query = "select CHECK_USER_LOCKED('" + username + "') from dual;";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            DataRow row = data.Rows[0];
            int check = int.Parse(row.ItemArray[0].ToString());
            return check;
        }
        public void insert(string username, string password, string name, string profile, string tablespace, string quota, string status)
        {
            string query = "call USER_INSERT('" + username + "','" + password + "','" + name + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_PROFILE('" + username + "','" + profile + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_DEFAULT_TAB('" + username + "','" + tablespace + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_QUOTA('" + username + "','" + tablespace + "','"+quota+"')";
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_STATUS('" + username + "','" + status + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public void update(string username, string password, string name, string profile, string tablespace, string quota, string status)
        {
            string query = "call USER_UPDATE('" + username + "','" + password + "','" + name + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_PROFILE('" + username + "','" + profile + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_DEFAULT_TAB('" + username + "','" + tablespace + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_QUOTA('" + username + "','" + tablespace + "','" + quota + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call USER_STATUS('" + username + "','" + status + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public void delete(string username)
        {
            string query = "call USER_DELETE('" + username + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
    }
}
