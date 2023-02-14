using Microsoft.EntityFrameworkCore;

namespace EF_core_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Update_data();
        }

        public void Update_data()
        {
            using (var context = new CompanySdContext())
            {
                var datasource = context.Employees.Select(x => x).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = datasource;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var context = new CompanySdContext())
            {
                context.Employees.Add(new Employee {Fname=textBox1.Text,Lname=textBox2.Text,Ssn=int.Parse(textBox3.Text)});
                context.SaveChanges();
                Update_data();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new CompanySdContext())
            {
                var employee = context.Employees.SingleOrDefault(x => x.Ssn ==int.Parse(textBox3.Text));
                context.Employees.Remove(employee);
                context.SaveChanges();
                Update_data();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new CompanySdContext())
            {
                var employee = context.Employees.SingleOrDefault(x => x.Ssn == int.Parse(textBox3.Text));
                employee.Fname=textBox1.Text;
                employee.Lname=textBox2.Text;
                context.SaveChanges();
                Update_data();
            }
        }
    }
}