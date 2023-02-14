using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day8_Form
{
    public partial class Form2 : Form
    {

        BusinessLayer BusinessLayer = new BusinessLayer();
        public Form2()
        {
            InitializeComponent();           
            dataGridView1.DataSource = BusinessLayer.GetDepartments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dnum =int.Parse(textBox1.Text);
            string Dname = textBox2.Text.ToString();
            BusinessLayer.InsertDepartment(Dnum, Dname);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BusinessLayer.GetDepartments();
        }
    }
}
