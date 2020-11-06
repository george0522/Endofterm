using midtterm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midtterm
{


    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        int m,m_add=5;
        string m_str;
        int m_l = 2, m_h = 5;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);
            list.Add(Resources._004);
            list.Add(Resources._005);
            list.Add(Resources._006);
            list.Add(Resources._007);
            list.Add(Resources._008);
            list.Add(Resources._009);
            list.Add(Resources._010);
            list.Add(Resources._100);
            list.Add(Resources._101);
            list.Add(Resources._102);
            list.Add(Resources._103);
            list.Add(Resources._104);
            list.Add(Resources._105);
            list.Add(Resources._106);
            list.Add(Resources._107);
            list.Add(Resources._108);
            list.Add(Resources._109);
            list.Add(Resources._110);
        }


        private void btnUP_Click(object sender, EventArgs e)
        {
            m=m+m_add;
            m_str = Convert.ToString(m);
            MON.Text = m_str;
        }

        private void btnpump_h_Click(object sender, EventArgs e)
        {
            int randomNum = new Random().Next(9); //0-100
            int index = randomNum + 11;//模擬隨機產生 一個值;
            if (m >= m_h)
            {
                picResult.Image = list[index];
                m = m - m_h;
                m_rest();
                rtbLog.Text = rtbLog.Text +"恭喜抽中 編號"+ Convert.ToString(index+91) +"神奇寶貝\n ";
            }
            else
            {
                MessageBox.Show("金額不足", "警告");
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            rtbLog.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m++;
            m_rest();
        }

        private void btnpump_l_Click(object sender, EventArgs e)
        {
            int randomNum = new Random().Next(5); //0-100
            int index = randomNum + 1;//模擬隨機產生 一個值;
            if (m >= m_l)
            {
                picResult.Image = list[index];
                m = m - m_l;
                m_rest();
                rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index+1) + "神奇寶貝\n ";
            }
            else
            {
                MessageBox.Show("金額不足", "警告");
            }
        }

        private void m_rest()
        {
            m_str = Convert.ToString(m);
            MON.Text = m_str;
            return;
        }
    }
}
