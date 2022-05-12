namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        { 
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
          double sB, iR, dArs, dAfp, sN;
            sB = double.Parse(TextSalario.Text);
            dArs = sB * 0.0304;
            dAfp = sB * 0.0287;
            if (sB > 34685)
            {
            if (sB > 52027)
            {
            if (sB > 72260)
            {
            iR = (sB - 72260) * 0.25 + 6648;
            }
            else { iR = (sB - 52027) * 0.20 + 2600; }
            }
            else { iR = (sB - 34685) * 0.15; }
            }
            else { iR = 0; }
            sN = sB - iR - dArs - dAfp;
            label7.Text = "$" + dArs.ToString();
            label5.Text = "$" + dAfp.ToString();
            label4.Text = "$" + iR.ToString();
            NetSalary.Text = "$" + sN.ToString();
        }
        private void NetSalary_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}