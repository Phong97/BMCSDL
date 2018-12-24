using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Role_BLL
    {
        public DataTable getAll()
        {
            string query = "select * from role";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getUserOfRole(string role)
        {
            string query = "select grantee from DBA_ROLE_PRIVS where granted_role='"+role.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getName()
        {
            string query = "select name from role";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public void insert(string username, string password)
        {
            string query = "call ROLE_CREATE('" + username + "','" + password + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
            query = "call ROLE_INSERT('" + username + "','" + password + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public void delete(string name)
        {
            string query = "call ROLE_DELETE('" + name + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public void update(string username, string password)
        {
            string query = "call ROLE_CHANGEPASS('" + username + "','" + password + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
    }
}
