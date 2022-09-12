namespace _1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text)) //IsNullOrWhiteSpace - �������� �� ������ �������
            {
                MessageBox.Show("������� ��������� ��� ����!");
                return;
            }

            try
            {

                double L = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double V = Convert.ToDouble(textBox2.Text.Replace('.', ','));
                double T = Convert.ToDouble(textBox3.Text.Replace('.', ','));
                double v0 = (L / T) + V;
                label5.Text = $"�������� ������:{v0}";

            } catch 
            {
                MessageBox.Show("����� ������������ ������ ������ �� �����!");
            }

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',') && e.KeyChar != (char) Keys.Back) // �������� �� ��������� �������� (��������)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (textBox.Text.IndexOf('.') > -1 || textBox.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

           if (e.KeyChar == ',' && (textBox.Text.IndexOf(',') > -1 || textBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


    }
}