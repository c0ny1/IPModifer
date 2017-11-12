using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPModifer
{
    class ConfigMannager
    {
        string mdbPath;
        MdbMannager mdb;

        public ConfigMannager(string mdbPath)
        {
            this.mdbPath = mdbPath;
            this.mdb = new MdbMannager(mdbPath);
        }

        /// <summary>
        /// 查询所有配置方案
        /// </summary>
        /// <returns>所有配置方案</returns>
        public DataTable selectAllConfig()
        {
            String sql = "select * from ipset";
            DataTable dt = new DataTable();
            dt = mdb.Select(sql);
            return dt;
        }

        /// <summary>
        /// 添加配置方案
        /// </summary>
        /// <param name="cfg">Config对象</param>
        /// <returns>是否添加成功</returns>
        public bool addConfig(Config cfg)
        {
            bool f = false;
            string sql = string.Format("insert into ipset(name,ip,mask,gateway,dns1,dns2,end_time) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cfg.Name,cfg.Ip,cfg.Mask,cfg.Gateway,cfg.Dns1,cfg.Dns2, DateTime.Now.ToString());
            Console.WriteLine(sql);
            f = mdb.Execute(sql);
            return f;
        }

        /// <summary>
        /// 通过id删除配置方案
        /// </summary>
        /// <param name="id">配置方案id</param>
        /// <returns>是否删除成功</returns>
        public bool delConfigById(int id)
        {
            string sql = string.Format("delete from ipset where id={0}", id);
            bool f = false;
            f = mdb.Execute(sql);
            return f;
        }

        /// <summary>
        /// 修改配置方案
        /// </summary>
        /// <param name="cfg">Config对象</param>
        /// <returns>是否修改成功</returns>
        public bool modifyConfig(Config cfg)
        {
            bool f = false;
            string sql = String.Format("update ipset set name='{0}',ip='{1}',mask='{2}',gateway='{3}',dns1='{4}',dns2='{5}',end_time='{6}' where id={7}",cfg.Name,cfg.Ip,cfg.Mask, cfg.Gateway, cfg.Dns1, cfg.Dns2, DateTime.Now.ToString(), cfg.Id1);
            f = mdb.Execute(sql);
            return f;
        }
    }
}
