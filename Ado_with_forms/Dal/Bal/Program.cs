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
        public int InsertEmployee(string fname, string lname, decimal salary, int dno)
        {
            int count = dataLayer.InsertEmployee(fname, lname, salary, dno);
            return count;
        }
    }
}

