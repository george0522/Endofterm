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
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace midtterm
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        static int mon, lv, exp , mon_l = 2, mon_h = 5;
        int mon_add = 100, mon_add_h = 1000;
        string mon_str;
        public Form1()
        {
            mon = midtterm.Properties.Settings.Default.MONEY;         //讀取上次紀錄
            lv = midtterm.Properties.Settings.Default.lv;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)         //設定
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

        #region 網路圖片抓取 程式
        private resp GetImages(string albumHash, string clientId)
        {
            resp result = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.imgur.com/3/album/{albumHash}/images");
                //Add Header 
                WebHeaderCollection webHeaderCollection = request.Headers;
                webHeaderCollection.Add("Authorization", $"Client-ID {clientId}");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string json = readStream.ReadToEnd();

                result = JsonConvert.DeserializeObject<resp>(json);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }

        public class resp
        {
            public List<img> data { get; set; }
        }

        public class img
        {
            public string link { get; set; }
        }
        #endregion

        #region 生錢 課金

        private void btnUP_Click(object sender, EventArgs e)            //生錢按鍵
        {
            mon = mon + mon_add;
            mon_str = Convert.ToString(mon);
            MON.Text = mon_str;
        }
        private void btnUP2_Click(object sender, EventArgs e)
        {
            String cnum = Interaction.InputBox("請輸入信用卡號", "", "", -1, -1);
            int cnum_int = int.Parse(cnum);
            bool telcheck = Regex.IsMatch(cnum, @"^[0-9]{16}$");
            if (telcheck)
            {
                MessageBox.Show("卡號正確");
                mon = mon + (mon_add_h);
                mon_str = Convert.ToString(mon);
                MON.Text = mon_str;
            }
            else
            {
                MessageBox.Show("卡號錯誤  請再輸入一次", "警告");
            }

 
        }


        #endregion
        #region 抽卡
        private void btnpump_h_Click(object sender, EventArgs e)        //高階卡池
        {
            #region 抽在地資料
            /*
            int randomNum = new Random().Next(9); //0-100
            int index = randomNum + 11;//模擬隨機產生 一個值;
            if (mon >= mon_h)
            {
                picResult2.Image = list[index];
                mon = mon - mon_h;
                mon_rest();
                rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index + 91) + "神奇寶貝\n ";
                exp = exp + 3;
                Console.WriteLine($"hi....{index}");
            }
            else
            {
                MessageBox.Show("金額不足", "警告");
            }*/
            #endregion
            #region 抽網路資料
            if (mon >= mon_h)
            {              
                
                int randomNum = new Random().Next(9); //0-100
                int index = randomNum;//模擬隨機產生 一個值;

                var m = GetImages("BKgJt2J", "8cdcd3a197e0eb7");

                Console.WriteLine(m.data.Count);

                // download 一張照片下來  
                string url = m.data[index].link;                                                    //決定輸出結果
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                var image = System.Drawing.Image.FromStream(receiveStream);
                Console.WriteLine(image.Width);
                ////////////////////////////////////// 顯示訊息
                picResult2.Image = image;
                rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index + 91) + "神奇寶貝\n ";
                Console.WriteLine($"hi....{index}");

                exp = exp + 3;
                mon = mon - 5;
            }
            else
            {
                MessageBox.Show("金額不足", "警告");
            }   
            #endregion
        }
        private void btnpump_l_Click(object sender, EventArgs e)            ////低階卡池
        {
            #region 抽在地資料
            /*
            int randomNum = new Random().Next(9); //0-100
            int index = randomNum + 1;//模擬隨機產生 一個值;
            if (mon >= mon_l)
            {
                picResult.Image = list[index];
                mon = mon - mon_l;
                mon_rest();
                rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index + 1) + "神奇寶貝\n ";
                exp++;
                Console.WriteLine($"hi....{index}");
            }
            else
            {
                MessageBox.Show("金額不足", "警告");
            }*/
            #endregion
            #region 抽網路資料
            int randomNum = new Random().Next(9); //0-100
            int index = randomNum;//模擬隨機產生 一個值;

            var m = GetImages("M04CeWi", "8cdcd3a197e0eb7");

            Console.WriteLine(m.data.Count);

            // download 一張照片下來  
            string url = m.data[index].link;                                                    //決定輸出結果
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            var image = System.Drawing.Image.FromStream(receiveStream);
            rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index + 1) + "神奇寶貝\n ";
            Console.WriteLine(image.Width);
            // 顯示照片
            picResult.Image = image;
            Console.WriteLine($"hi....{index}");

            mon = mon - mon_l;
            exp++;
            #endregion
        }

        private void btnpump_l_10_Click(object sender, EventArgs e)
        {
            if (mon >= mon_l * 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomNum = new Random().Next(9); //0-100
                    int index = randomNum + 1;//模擬隨機產生 一個值;
                    picResult.Image = list[index];
                    //Thread.Sleep(500);
                    delay(5);
                    mon = mon - mon_l;
                    m_rest();
                    rtbLog.Text = rtbLog.Text + "恭喜抽中 編號" + Convert.ToString(index + 1) + "神奇寶貝\n ";
                    exp++;
                    Console.WriteLine($"hi....{index}");

                }
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
            mon = 0;
            lv = 1;
        }
        #endregion
        #region 網路抓圖測試
        private void button1_Click(object sender, EventArgs e)                              //網路抓圖測試
        {
            int randomNum = new Random().Next(9); //0-100
            int index = randomNum;//模擬隨機產生 一個值;

            var m = GetImages("BKgJt2J", "8cdcd3a197e0eb7");

            Console.WriteLine(m.data.Count);


            // download 一張照片下來  
            string url = m.data[index].link;                                                    //決定輸出結果
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            var image = System.Drawing.Image.FromStream(receiveStream);

            Console.WriteLine(image.Width);


            // 顯示照片
            picResult.Image = image;

            Console.WriteLine($"hi....{index}");
        }
        #endregion
        #region Menu設定
        private void 資料清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mon = 0;
            lv = 1;
            rtbLog.Text = "";
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)                  //打怪
        {
            mon++;
            mon_str = Convert.ToString(mon);
            MON.Text = mon_str;
        }

        private void timer1_Tick(object sender, EventArgs e)            //計時器動作
        {
            mon++;
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
            midtterm.Properties.Settings.Default.MONEY = mon;                     //另外存起來下次使用
            midtterm.Properties.Settings.Default.lv = lv;
            midtterm.Properties.Settings.Default.Save();
        }

        private void m_rest()                                           //重整金額數量
        {
            mon_str = Convert.ToString(mon);
            MON.Text = mon_str;
            return;
        }

        void delay(int x)
        {
            int i;
            for (i = 0; i < x * 100000000; i++) ;
        }
    }
}
