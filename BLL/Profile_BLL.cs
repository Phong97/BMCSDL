using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Profile_BLL
    {
        public DataTable getAll()
        {
            string query = "select * from profile";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getDetailProfile(string profile)
        {
            string query = "select dba_profiles.resource_name,dba_users.username " +
                "from dba_profiles inner join dba_users on dba_profiles.profile = dba_users.profile " +
                "where dba_profiles.profile = '"+profile.ToUpper()+"'";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public DataTable getOne(string name)
        {
            name = name.ToUpper();
            string query = "select resource_name,limit from DBA_PROFILES " +
                "where profile='"+name+"' and (resource_name='SESSIONS_PER_USER' " +
                "or resource_name = 'CONNECT_TIME' or " +
                "resource_name = 'IDLE_TIME')";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
        public void insert(string name, string session, string connect, string idle)
        {
            string query = "call PROFILE_CREATE('"+name+"','"+session+"','"+connect+"','"+idle+"')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
            query= "call PROFILE_INSERT('" + name + "')";
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public void update(string name, string session, string connect, string idle)
        {
            string query = "call PROFILE_UPDATE('"+name+"','"+session+"','"+connect+"','"+idle+"')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
        public void delete(string name)
        {
            string query = "call PROFILE_DELETE('" + name + "')";
            DAL.DAL dal = new DAL.DAL();
            dal.excuteUpdate(query, null, CommandType.Text);
        }
    }
}
