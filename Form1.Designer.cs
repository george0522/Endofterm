namespace midtterm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnpump_h = new System.Windows.Forms.Button();
            this.MON = new System.Windows.Forms.Label();
            this.btnUP = new System.Windows.Forms.Button();
            this.labLog = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnpump_l = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGO = new System.Windows.Forms.Button();
            this.tabcost = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnpump_l_10 = new System.Windows.Forms.Button();
            this.tabpump2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.prs = new System.Windows.Forms.TabPage();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picResult2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUP2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabcost.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabpump2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.prs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpump_h
            // 
            this.btnpump_h.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpump_h.Location = new System.Drawing.Point(3, 3);
            this.btnpump_h.Name = "btnpump_h";
            this.btnpump_h.Size = new System.Drawing.Size(129, 125);
            this.btnpump_h.TabIndex = 13;
            this.btnpump_h.Text = "單抽";
            this.btnpump_h.UseVisualStyleBackColor = true;
            this.btnpump_h.Click += new System.EventHandler(this.btnpump_h_Click);
            // 
            // MON
            // 
            this.MON.AutoSize = true;
            this.MON.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MON.Location = new System.Drawing.Point(229, 37);
            this.MON.Name = "MON";
            this.MON.Size = new System.Drawing.Size(58, 64);
            this.MON.TabIndex = 12;
            this.MON.Text = "0";
            // 
            // btnUP
            // 
            this.btnUP.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnUP.Location = new System.Drawing.Point(6, 56);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(262, 125);
            this.btnUP.TabIndex = 11;
            this.btnUP.TabStop = false;
            this.btnUP.Text = "普通課長";
            this.btnUP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // labLog
            // 
            this.labLog.AutoSize = true;
            this.labLog.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLog.Location = new System.Drawing.Point(67, 37);
            this.labLog.Name = "labLog";
            this.labLog.Size = new System.Drawing.Size(156, 64);
            this.labLog.TabIndex = 10;
            this.labLog.Text = "金幣";
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbLog.Location = new System.Drawing.Point(53, 178);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(263, 357);
            this.rtbLog.TabIndex = 9;
            this.rtbLog.Text = "";
            // 
            // btnpump_l
            // 
            this.btnpump_l.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpump_l.Location = new System.Drawing.Point(6, 3);
            this.btnpump_l.Name = "btnpump_l";
            this.btnpump_l.Size = new System.Drawing.Size(146, 126);
            this.btnpump_l.TabIndex = 7;
            this.btnpump_l.Text = "單抽";
            this.btnpump_l.UseVisualStyleBackColor = true;
            this.btnpump_l.Click += new System.EventHandler(this.btnpump_l_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(240, 541);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 34);
            this.btn_clr.TabIndex = 14;
            this.btn_clr.Text = "紀錄清空";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(84, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "等級:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.資料清除ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 資料清除ToolStripMenuItem
            // 
            this.資料清除ToolStripMenuItem.Name = "資料清除ToolStripMenuItem";
            this.資料清除ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.資料清除ToolStripMenuItem.Text = "資料清除";
            this.資料清除ToolStripMenuItem.Click += new System.EventHandler(this.資料清除ToolStripMenuItem_Click);
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(1175, 541);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(94, 69);
            this.btnGO.TabIndex = 18;
            this.btnGO.Text = "button1";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabcost
            // 
            this.tabcost.Controls.Add(this.tabPage1);
            this.tabcost.Controls.Add(this.tabpump2);
            this.tabcost.Controls.Add(this.tabPage2);
            this.tabcost.Controls.Add(this.prs);
            this.tabcost.Font = new System.Drawing.Font("新細明體", 19F);
            this.tabcost.Location = new System.Drawing.Point(374, 37);
            this.tabcost.Name = "tabcost";
            this.tabcost.SelectedIndex = 0;
            this.tabcost.Size = new System.Drawing.Size(686, 538);
            this.tabcost.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnpump_l_10);
            this.tabPage1.Controls.Add(this.btnpump_l);
            this.tabPage1.Controls.Add(this.picResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "低階卡池";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnpump_l_10
            // 
            this.btnpump_l_10.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpump_l_10.Location = new System.Drawing.Point(6, 135);
            this.btnpump_l_10.Name = "btnpump_l_10";
            this.btnpump_l_10.Size = new System.Drawing.Size(146, 126);
            this.btnpump_l_10.TabIndex = 9;
            this.btnpump_l_10.Text = "十連";
            this.btnpump_l_10.UseVisualStyleBackColor = true;
            this.btnpump_l_10.Click += new System.EventHandler(this.btnpump_l_10_Click);
            // 
            // tabpump2
            // 
            this.tabpump2.Controls.Add(this.picResult2);
            this.tabpump2.Controls.Add(this.tabControl2);
            this.tabpump2.Controls.Add(this.btnpump_h);
            this.tabpump2.Location = new System.Drawing.Point(4, 35);
            this.tabpump2.Name = "tabpump2";
            this.tabpump2.Padding = new System.Windows.Forms.Padding(3);
            this.tabpump2.Size = new System.Drawing.Size(678, 499);
            this.tabpump2.TabIndex = 1;
            this.tabpump2.Text = "高階卡池";
            this.tabpump2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(78, 29);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnUP2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnUP);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 499);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "儲值";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // prs
            // 
            this.prs.Controls.Add(this.pictureBox1);
            this.prs.Location = new System.Drawing.Point(4, 35);
            this.prs.Name = "prs";
            this.prs.Padding = new System.Windows.Forms.Padding(3);
            this.prs.Size = new System.Drawing.Size(678, 499);
            this.prs.TabIndex = 3;
            this.prs.Text = "打怪";
            this.prs.UseVisualStyleBackColor = true;
            // 
            // picResult
            // 
            this.picResult.Image = global::midtterm.Properties.Resources.K18ScKr;
            this.picResult.Location = new System.Drawing.Point(167, 6);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(505, 487);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 8;
            this.picResult.TabStop = false;
            // 
            // picResult2
            // 
            this.picResult2.Image = global::midtterm.Properties.Resources.F7iuv5Y;
            this.picResult2.Location = new System.Drawing.Point(149, 3);
            this.picResult2.Name = "picResult2";
            this.picResult2.Size = new System.Drawing.Size(523, 490);
            this.picResult2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult2.TabIndex = 20;
            this.picResult2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::midtterm.Properties.Resources.a78ef7434044993428f85cb71dfba6a15a987b7a;
            this.pictureBox1.Location = new System.Drawing.Point(-28, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "100金幣";
            // 
            // btnUP2
            // 
            this.btnUP2.Font = new System.Drawing.Font("新細明體", 36F);
            this.btnUP2.Location = new System.Drawing.Point(6, 198);
            this.btnUP2.Name = "btnUP2";
            this.btnUP2.Size = new System.Drawing.Size(262, 125);
            this.btnUP2.TabIndex = 13;
            this.btnUP2.TabStop = false;
            this.btnUP2.Text = "超級課長";
            this.btnUP2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUP2.UseVisualStyleBackColor = true;
            this.btnUP2.Click += new System.EventHandler(this.btnUP2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "10000金幣";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 624);
            this.Controls.Add(this.tabcost);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.MON);
            this.Controls.Add(this.labLog);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabcost.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabpump2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.prs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpump_h;
        private System.Windows.Forms.Label MON;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Label labLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnpump_l;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.ToolStripMenuItem 資料清除ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabcost;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabpump2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picResult2;
        private System.Windows.Forms.Button btnpump_l_10;
        private System.Windows.Forms.TabPage prs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUP2;
        private System.Windows.Forms.Label label2;
    }
}

