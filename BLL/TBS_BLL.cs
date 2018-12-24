using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TBS_BLL
    {
        public DataTable getAll()
        {
            string query = "select * from TBS";
            DAL.DAL dal = new DAL.DAL();
            DataSet res = dal.excutedata(query, null, CommandType.Text);
            DataTable data = res.Tables[0];
            return data;
        }
    }
}
