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
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btn_clr = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpump_h
            // 
            this.btnpump_h.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpump_h.Location = new System.Drawing.Point(643, 16);
            this.btnpump_h.Name = "btnpump_h";
            this.btnpump_h.Size = new System.Drawing.Size(129, 125);
            this.btnpump_h.TabIndex = 13;
            this.btnpump_h.Text = "高階卡片";
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
            this.btnUP.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUP.Location = new System.Drawing.Point(339, 16);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(146, 125);
            this.btnUP.TabIndex = 11;
            this.btnUP.Text = "錢";
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
            this.btnpump_l.Location = new System.Drawing.Point(491, 16);
            this.btnpump_l.Name = "btnpump_l";
            this.btnpump_l.Size = new System.Drawing.Size(146, 126);
            this.btnpump_l.TabIndex = 7;
            this.btnpump_l.Text = "低階卡片";
            this.btnpump_l.UseVisualStyleBackColor = true;
            this.btnpump_l.Click += new System.EventHandler(this.btnpump_l_Click);
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(402, 178);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(322, 357);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 8;
            this.picResult.TabStop = false;
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(257, 541);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(58, 34);
            this.btn_clr.TabIndex = 14;
            this.btn_clr.Text = "清空";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 590);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btnpump_h);
            this.Controls.Add(this.MON);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.labLog);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnpump_l);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
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
    }
}

