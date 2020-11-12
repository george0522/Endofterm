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
        static int m, lv, exp;
        int m_add = 5;
        string m_str;
        int m_l = 2, m_h = 5;
        public Form1()                                      
        {
            m = midtterm.Properties.Settings.Default.MONEY;         //讀取上次紀錄
            lv = midtterm.Properties.Settings.Default.lv;
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

        #region 生錢

        private void btnUP_Click(object sender, EventArgs e)            //生錢按鍵
        {
            m = m + m_add;
            m_str = Convert.ToString(m);
            MON.Text = m_str;
        }

        #endregion
        #region 抽卡
        private void btnpump_h_Click(object sender, EventArgs e)        //高階卡池
        {
            int randomNum = new Random().Next(9); //0-100
            int index = randomNum + 11;//模擬隨機產生 一個值;
            if (m >= m_h)
            {
                picResult.Image = list[index];
                m = m - m_h;
                m_rest();
                rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index + 91) + "神奇寶貝\n ";
                exp = exp + 3;
            }
            else
            {
                MessageBox.Show("金額不足", "警告");
            }
        }
        private void btnpump_l_Click(object sender, EventArgs e)            ////低階卡池
        {
            int randomNum = new Random().Next(5); //0-100
            int index = randomNum + 1;//模擬隨機產生 一個值;
            if (m >= m_l)
            {
                picResult.Image = list[index];
                m = m - m_l;
                m_rest();
                rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index + 1) + "神奇寶貝\n ";
                exp++;
            }
            else
            {
                MessageBox.Show("金額不足", "警告");
            }
        }

        #endregion

        #region 清空

        private void btn_clr_Click(object sender, EventArgs e)          //清空紀錄
        {
            rtbLog.Text = "";
        }

        private void btnCLALL_Click(object sender, EventArgs e)         //清空等級金幣
        {
            m = 0;
            lv = 1;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)            //計時器動作
        {
            m++;
            m_rest();
            if (exp >= 10)                                              //等級提升
            {
                lv++;
                exp = exp - 10;
            }
            label1.Text = "等級" + lv;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)       //關閉視窗時儲存資料
        {
            midtterm.Properties.Settings.Default.MONEY = m;                     //另外存起來下次使用
            midtterm.Properties.Settings.Default.lv = lv;
            midtterm.Properties.Settings.Default.Save();
        }

        private void m_rest()                                           //重整金額數量
        {
            m_str = Convert.ToString(m);
            MON.Text = m_str;
            return;
        }
    }
}
