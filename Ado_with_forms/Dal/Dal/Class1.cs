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
            sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Company_SD;Persist Security Info=True;User ID=sa;Password=123456");
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
        public int InsertEmployee(string fname, string lname, decimal salary, int dno)
        {
            sqlCommand.CommandText = $"INSERT INTO [dbo].[Employee] ([Fname]  ,[Lname] ,[Salary],[Dno] ) VALUES('{fname}','{lname}',{salary},{dno})";
            sqlConnection.Open();
            int count = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }
    }
}
