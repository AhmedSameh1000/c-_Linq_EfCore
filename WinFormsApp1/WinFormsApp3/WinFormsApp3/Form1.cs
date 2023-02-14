namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public float data = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = data.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                float.TryParse(textBox1.Text,out float  value);
                data = value/1000;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                float.TryParse(textBox1.Text, out float value);
                data = value * 1000;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                float.TryParse(textBox1.Text, out float value);
                data = value / 1609;
            }
        }

       
    }
}