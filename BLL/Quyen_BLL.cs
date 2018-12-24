using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Quyen_BLL
    {
        public DataTable getByType1()
        {
            string query = "select name from quyen where type=1";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getByType2()
        {
            string query = "select name from quyen where type=2";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getQuyenHT(string role)
        {
            string query = "select privilege,admin_option from	ROLE_SYS_PRIVS where role='"+role.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getQuyenHT_USER(string user)
        {
            string query = "select privilege,admin_option from DBA_SYS_PRIVS " +
                "where grantee='"+user.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getQuyenRole_USER(string user)
        {
            string query = "select granted_role,admin_option from DBA_ROLE_PRIVS " +
                "where grantee='"+user.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public void removeQuyenHT(string name, string role)
        {
            string query = "call REQUYENHETHONG_ROLE_USER('" + name + "','" + role + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public DataTable getQuyenTable(string username)
        {
            string query = "select table_name,privilege,grantable from	DBA_TAB_PRIVS " +
                "where grantee='"+ username.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getQuyenTableRole(string username)
        {
            string query = "select table_name,privilege,grantable from	 ROLE_TAB_PRIVS " +
                "where role='" + username.ToUpper() + "'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public void removeQuyenTable(string table, string role)
        {
            string query = "call requyenobject_all('" + role + "','" + table + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public DataTable getTable()
        {
            string query = "SELECT table_name FROM user_tables";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public void updateHT(string role,string name, string grant)
        {
            string query = "call QUYENHETHONG_ROLE_USER('" + name + "','" + role + "','" + grant + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public void updateTable(string username, string name, string grant, string table)
        {
            string query = "call QUYENOBJECT_USER_ROLE('" + name + "','" + table + "','" + username + "','" + grant + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
    }
}
