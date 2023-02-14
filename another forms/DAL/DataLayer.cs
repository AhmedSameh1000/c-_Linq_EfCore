using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataLayer
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public DataLayer()
        {
            sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Company_SD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlCommand = new SqlCommand();//("Select * From Employee",sqlConnection);
            sqlCommand.Connection = sqlConnection;
            
        }
        public DataTable GetEmplooyees()
        {
            sqlCommand.CommandText = "Select * From Employee";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetDepartments()
        {
            sqlCommand.CommandText = "Select * From Departments";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int InsertEmployee(string fname,string lname,decimal salary,int dno,int SSN)
        {
            sqlCommand.CommandText = $"INSERT INTO [dbo].[Employee] ([Fname],[Lname] ,[Salary],[Dno],[SSN] ) VALUES('{fname}','{lname}',{salary},{dno},{SSN})";
            sqlConnection.Open();
            int count = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }

        public int InsertDepartment(int Dnom,string Dname)
        {
            sqlCommand.CommandText = $"INSERT INTO [dbo].[Departments] ([Dnum] ,[Dname]  ) VALUES('{Dnom}','{Dname}')";
            sqlConnection.Open();
            int count = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }

        public int UpdateEmployee(string Fname, string Lname, decimal salary,int ssn)
        {
            sqlCommand.CommandText = $"update Employee set Fname='{Fname}',Lname='{Lname}',Salary={salary} where SSN={ssn}";
            sqlConnection.Open();
            int count = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }
    }
}
