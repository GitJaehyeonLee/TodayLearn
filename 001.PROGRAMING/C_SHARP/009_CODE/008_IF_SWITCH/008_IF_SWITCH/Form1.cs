using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_IF_SWITCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void switchTest()
        {
            int iRet = 3;

            string strResult = string.Empty;

            switch (iRet)
            {
                case 2:
                case 3:
                    strResult = "2 나 3";
                    break;
                case 4:
                    strResult = "4";
                    break;

                default:
                    {
                        strResult = "모름";
                    }
                    break;
            }
        }


        private void ifTest()
        {
            int ia = 20;
            int ib = 20;

            string strResult = string.Empty;

            if (ia > ib)
            {
                strResult = "ia 가 크다";
            }
            else if (ib > ia)
            {
                strResult = "ib 가 크다.";
            }
            else
            {
                strResult = "ia와 ib는 동일하다.";
            }

            // 3항 연산자
            //strResult = (ia > ib) ? "ia가 크다" : "같다";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIfResult_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblIfResult.Text = string.Format("- Number1이 Number 2 보다 {0} 만큼 더 큽니다.", iNumber1 - iNumber2);
            }
            else if (iNumber2 > iNumber1)
            {
                lblIfResult.Text = string.Format("- Number2이 Number 1 보다 {0} 만큼 더 큽니다.", iNumber2 - iNumber1);
            }
            else
            {
                lblIfResult.Text = string.Format("두 숫자는 같습니다. {0}", iNumber1);
            }
        }

        private void btnSwtichResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "월":
                    lblSwitchResult.Text = "- 선택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    lblSwitchResult.Text = "- 선택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    lblSwitchResult.Text = "- 선택 날짜는 수요일 입니다.";
                    break;
                case "목":
                case "금":
                    lblSwitchResult.Text = "- 선택 날짜는 목요일 혹은 금요일 입니다.";
                    break;
                default:
                    lblSwitchResult.Text = "- 선택 날짜는 주말 입니다.";
                    break;
            }
        }
    }
}
