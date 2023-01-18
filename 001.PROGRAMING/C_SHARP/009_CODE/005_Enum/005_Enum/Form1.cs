using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum enumDay
        {
            Monday, // 0
            Tuesday, // 1
            Wednesday, // 2
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        private enum enumTime
        {
            Morning,
            Afternoon,
            Evening,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday.ToString());
            lboxDay.Items.Add(enumDay.Wednesday.ToString());
            lboxDay.Items.Add(enumDay.Thursday.ToString());
            lboxDay.Items.Add(enumDay.Friday.ToString());
            lboxDay.Items.Add(enumDay.Saturday.ToString());
            lboxDay.Items.Add(enumDay.Sunday.ToString());

            lboxTime.Items.Add(enumTime.Morning);
            lboxTime.Items.Add(enumTime.Afternoon);
            lboxTime.Items.Add(enumTime.Evening);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string strResult = tboxName.Text + "와 " + 
                lboxDay.SelectedItem.ToString() + "(요일) " + 
                lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";
            
            tboxResult.Text = strResult;

            
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            string strResult = TextLoad(tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            tboxResult.Text = strResult;
        }

        /// <summary>
        /// "{0}와 {1}요일 {2}에 보기로 했습니다." 문자열을 생성해 줍니다.
        /// </summary>
        /// <param name="strName">이름</param>
        /// <param name="strday">날짜</param>
        /// <param name="strTime">시간</param>
        /// <returns>이름와 날짜요일 시간에 보기로 했습니다.</returns>
        private string TextLoad(string strName, string strday, string strTime)
        {
            string strText = String.Format("{0}와 {1}요일 {2}에 보기로 했습니다.", tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());

            return strText;
        }
    }
}
