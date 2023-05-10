using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace SMSApp.Models
{
    public class StudentDAL
    {//CRUD - create(insert),read,update,delete
        private SqlConnection _sqlConn = null;
        private SqlCommand _sqlcmd = null;
        public StudentDAL() {
            _sqlConn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=SMSDV;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public void Insert(String StdName,String Course,String batchid) {
            _sqlConn.Open();
            _sqlcmd = new SqlCommand("INSERT INTO STUDENTS VALUES(@STDNAME,@COURSE,@BATCHID)",_sqlConn);
            _sqlcmd.Parameters.AddWithValue("@STDNAME",StdName);
            _sqlcmd.Parameters.AddWithValue("@COURSE", Course);
            _sqlcmd.Parameters.AddWithValue("@BATCHID", batchid);
            _sqlcmd.ExecuteNonQuery();

            _sqlConn.Close();

        }
        public void Update(int id,String StdName, String Course, String batchid) {
            _sqlConn.Open();
            _sqlcmd = new SqlCommand("UPDATE STUDENTS SET STDNAME =@STDNAME,COURSE=@COURSE,BATCHID=@BATCHID WHERE ID=@ID", _sqlConn);
            _sqlcmd.Parameters.AddWithValue("@STDNAME", StdName);
            _sqlcmd.Parameters.AddWithValue("@COURSE", Course);
            _sqlcmd.Parameters.AddWithValue("@BATCHID", batchid);
            _sqlcmd.Parameters.AddWithValue("@ID", id);
            _sqlcmd.ExecuteNonQuery();
            _sqlConn.Close();

        }
        public void Delete(int id) {
            _sqlConn.Open();
            _sqlcmd = new SqlCommand("DELETE FROM STUDENTS WHERE ID =@ID", _sqlConn);
            _sqlcmd.Parameters.AddWithValue("@ID", id);
            _sqlcmd.ExecuteNonQuery();
            _sqlConn.Close();

        }

        public SqlDataReader ReadAllData() {
            _sqlConn.Open();
            _sqlcmd = new SqlCommand("SELECT * FROM STUDENTS", _sqlConn);
           SqlDataReader _dReader =  _sqlcmd.ExecuteReader();
            return _dReader;
        }

        public SqlDataReader ReadById(int id)
        {
            _sqlConn.Open();
            _sqlcmd = new SqlCommand("SELECT * FROM STUDENTS WHERE ID=@ID", _sqlConn);
            _sqlcmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader _dReader = _sqlcmd.ExecuteReader();
            return _dReader;
        }
    }
}