namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                this.label3.Visible = true;
            }
            else
            {
                this.label3.Visible = false;
            }
        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Contains("@"))
            {
                this.label4.Visible = false;
            }
            else
            {
                this.label4.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked is false&&checkBox2.Checked is false &&checkBox3.Checked is false)
            {
                this.label7.Visible = true;
            }
            else
            {
                this.label7.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
        }
    }
}