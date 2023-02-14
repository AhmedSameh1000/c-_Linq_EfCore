using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BusinessLayer
    {
        DataLayer dataLayer = new DataLayer();
        public List<Employee> GetEmplooyees()
        {

            DataTable dataTable = dataLayer.GetEmplooyees();
            List<Employee> employees = new List<Employee>();
            foreach (DataRow item in dataTable.Rows)
            {
                Employee employee = new Employee();
                int dno;
                int SSN = int.Parse(item["SSN"].ToString());
                employee.SSN = SSN;
                bool res = int.TryParse(item["Dno"].ToString(), out dno);
                employee.dno = res ? dno : 0;
                employee.fname = item["Fname"].ToString();
                employee.lname = item["Lname"].ToString();
                decimal sal;

                res = decimal.TryParse(item["Salary"].ToString(), out sal);
                employee.salary = res ? sal : 0;
                employees.Add(employee);
            }
            return employees;
        }
        public List<Department> GetDepartments()
        {
            DataTable dataTable = dataLayer.GetDepartments();
            List<Department> departments = new List<Department>();
            foreach (DataRow item in dataTable.Rows)
            {
                Department department = new Department();
                department.Dnum = (int)item["Dnum"];
                department.Dname = item["Dname"].ToString();
                departments.Add(department);
            }
            return departments;
        }
        public int InsertEmployee(string fname, string lname, decimal salary, int dno,int SSN)
        {
            int count = dataLayer.InsertEmployee(fname, lname, salary, dno,SSN);
            return count;
        }



        public int InsertDepartment(int Dnom,string Dname)
        {
            int count = dataLayer.InsertDepartment(Dnom, Dname);
            return count;
        }


        public int Update_employee(string fname, string lname, decimal salary,int ssn)
        {
            int count = dataLayer.UpdateEmployee(fname, lname, salary,ssn);
            return count;
        }

    }
}
