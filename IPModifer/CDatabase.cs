﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace IPModifer
{
    class CDatabase
    {
        string dbfn;
        private OleDbConnection conn;
        private static CDatabase s;
        public static CDatabase S
        {
            get
            {
                if (s == null)
                    s = new CDatabase();
                return s;
            }
        }

        public void init(string dbfn)
        {
            this.dbfn = dbfn;
            string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbfn;//";Jet OLEDB:Database  Password=haoren";
            conn = new OleDbConnection(connstr);
        }

        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            System.Data.OleDb.OleDbDataAdapter myAd = new OleDbDataAdapter(sql,conn);
            myAd.Fill(dt);
            return dt;
        }

        public DataTable SelectAllData()
        {
            string sql = "select * from ipset";
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            System.Data.OleDb.OleDbDataAdapter myAd = new OleDbDataAdapter(sql, conn);
            myAd.Fill(dt);
            return dt;
        }

        public bool Execute(string sql)
        {
            bool f = true;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            OleDbCommand sc = new OleDbCommand(sql,conn);
            sc.ExecuteNonQuery();
            return f;
        }



        public bool del(string id)
        {
            bool f = true;
            string sql = "delete from ipset where id=" + id;
            f  = this.Execute(sql);
            return f;
        }

    }
}
