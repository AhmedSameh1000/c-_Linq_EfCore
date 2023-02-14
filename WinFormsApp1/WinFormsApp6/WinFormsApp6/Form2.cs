using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {    
         ColorDialog colorDialog = new ColorDialog();
        public Form2()
        {
            InitializeComponent();            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }
        public event EventHandler show;

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> fonts = new List<string>();
            foreach (FontFamily item in FontFamily.Families)
            {
                fonts.Add(item.Name);
            }
            comboBox1.DataSource = fonts;
        }
        public Color _color 
        { 
            get
            {
                if (radioButton1.Checked)
                    return Color.Red;
                else if (radioButton2.Checked) return Color.Blue;
                else return colorDialog.Color;
            }
        }
        public Font _font { get { return new Font(comboBox1.Text, float.Parse(textBox2.Text)); } }

        private void button1_Click(object sender, EventArgs e)
        {
            if(show is not null)
            {
                show.Invoke(sender, null);
            }   
        }
    }
}
