using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int numberA = int.Parse(tboxNumber1.Text);
            int numberB = int.Parse(tboxNumber2.Text);

            tboxResult.Text = fPlus(numberA, numberB).ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int numberA = int.Parse(tboxNumber1.Text);
            int numberB = int.Parse(tboxNumber2.Text);

            tboxResult.Text = fMinus(numberA, numberB).ToString();
        }

        private void btnGop_Click(object sender, EventArgs e)
        {
            int numberA = int.Parse(tboxNumber1.Text);
            int numberB = int.Parse(tboxNumber2.Text);

            //int result = numberA * numberB;

            //tboxResult.Text = result.ToString();
            tboxResult.Text = fMulti(numberA, numberB).ToString();
        }

        private void btnNanugi_Click(object sender, EventArgs e)
        {
            int numberA = int.Parse(tboxNumber1.Text);
            int numberB = int.Parse(tboxNumber2.Text);

            //int result = numberA / numberB; // 몫

            //tboxResult.Text = result.ToString();
            tboxResult.Text = fDivision(numberA, numberB).ToString();
        }

        private int fPlus(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA + iB;

            return iResult;
        }

        private int fMinus(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA - iB;

            return iResult;
        }

        private int fMulti(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA * iB;

            return iResult;
        }

        private int fDivision(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA / iB;

            return iResult;
        }
    }
}
