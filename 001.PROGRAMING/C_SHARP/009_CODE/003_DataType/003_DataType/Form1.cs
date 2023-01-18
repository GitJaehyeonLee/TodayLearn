namespace _003_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                ushort sNumber = ushort.Parse(tboxNumber.Text);

                lblShort.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex) {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int iNumber = int.Parse(tboxNumber.Text);

                lblInt.Text = iNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double dNumber = double.Parse(tboxNumber.Text);

                lblDouble.Text = dNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            lblException.Text = "-";

            if (short.TryParse(tboxNumber.Text, out sNumber))
            {
                lblShort.Text = sNumber.ToString();
            }
            else if (int.TryParse(tboxNumber.Text, out iNumber))
            {
                lblInt.Text = iNumber.ToString();
            }
            else if (double.TryParse(tboxNumber.Text, out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "변환 할수 없는 숫자입니다.";
            }
        }
    }
}