namespace Cafe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBORDER = new System.Windows.Forms.ListBox();
            this.CBMENU1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBPR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBTP1 = new System.Windows.Forms.CheckBox();
            this.CBTP2 = new System.Windows.Forms.CheckBox();
            this.CBTP3 = new System.Windows.Forms.CheckBox();
            this.CBTP4 = new System.Windows.Forms.CheckBox();
            this.BTADD = new System.Windows.Forms.Button();
            this.BTDL = new System.Windows.Forms.Button();
            this.BTCC = new System.Windows.Forms.Button();
            this.CBTP5 = new System.Windows.Forms.CheckBox();
            this.CBTP6 = new System.Windows.Forms.CheckBox();
            this.CBTP7 = new System.Windows.Forms.CheckBox();
            this.CBTP8 = new System.Windows.Forms.CheckBox();
            this.CBTP9 = new System.Windows.Forms.CheckBox();
            this.CBTP10 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBMENU2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBMENU3 = new System.Windows.Forms.ComboBox();
            this.CBNUM1 = new System.Windows.Forms.ComboBox();
            this.CBNUM2 = new System.Windows.Forms.ComboBox();
            this.CBNUM3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBORDER
            // 
            this.LBORDER.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBORDER.FormattingEnabled = true;
            this.LBORDER.ItemHeight = 16;
            this.LBORDER.Location = new System.Drawing.Point(534, 37);
            this.LBORDER.Name = "LBORDER";
            this.LBORDER.Size = new System.Drawing.Size(320, 420);
            this.LBORDER.TabIndex = 0;
            this.LBORDER.SelectedIndexChanged += new System.EventHandler(this.LBORDER_SelectedIndexChanged);
            // 
            // CBMENU1
            // 
            this.CBMENU1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMENU1.FormattingEnabled = true;
            this.CBMENU1.Items.AddRange(new object[] {
            "รสมะนาว",
            "รสเผือก",
            "รสชาเขียว",
            "รสช็อก ช็อก ชิป",
            "รสสตรอเบอร์รี่",
            "รสช็อกโกแลตชิป",
            "รสมิลค์ช็อกโกแลต",
            "รสวานิลลา",
            "รสคาปูชิโน",
            "รสเรนโบว์",
            "รสคุกกี้แอนด์ครีม",
            "รสกะทิ",
            "รสทุเรียน",
            "รสมะม่วง",
            "รสรวมมิตร"});
            this.CBMENU1.Location = new System.Drawing.Point(12, 37);
            this.CBMENU1.Name = "CBMENU1";
            this.CBMENU1.Size = new System.Drawing.Size(195, 24);
            this.CBMENU1.TabIndex = 1;
            this.CBMENU1.SelectedIndexChanged += new System.EventHandler(this.CBMENU_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "รสไอศกรีม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ราคา";
            // 
            // LBPR
            // 
            this.LBPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBPR.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBPR.Location = new System.Drawing.Point(329, 37);
            this.LBPR.Name = "LBPR";
            this.LBPR.Size = new System.Drawing.Size(81, 21);
            this.LBPR.TabIndex = 4;
            this.LBPR.Text = "0";
            this.LBPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBPR.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "ท็อปปิ้ง";
            // 
            // CBTP1
            // 
            this.CBTP1.AutoSize = true;
            this.CBTP1.Location = new System.Drawing.Point(12, 185);
            this.CBTP1.Name = "CBTP1";
            this.CBTP1.Size = new System.Drawing.Size(59, 17);
            this.CBTP1.TabIndex = 14;
            this.CBTP1.Text = "วิปครีม";
            this.CBTP1.UseVisualStyleBackColor = true;
            this.CBTP1.CheckedChanged += new System.EventHandler(this.CBTP1_CheckedChanged);
            // 
            // CBTP2
            // 
            this.CBTP2.AutoSize = true;
            this.CBTP2.Location = new System.Drawing.Point(12, 208);
            this.CBTP2.Name = "CBTP2";
            this.CBTP2.Size = new System.Drawing.Size(76, 17);
            this.CBTP2.TabIndex = 15;
            this.CBTP2.Text = "ข้าวเหนียว";
            this.CBTP2.UseVisualStyleBackColor = true;
            this.CBTP2.CheckedChanged += new System.EventHandler(this.CBTP2_CheckedChanged);
            // 
            // CBTP3
            // 
            this.CBTP3.AutoSize = true;
            this.CBTP3.Location = new System.Drawing.Point(12, 231);
            this.CBTP3.Name = "CBTP3";
            this.CBTP3.Size = new System.Drawing.Size(39, 17);
            this.CBTP3.TabIndex = 16;
            this.CBTP3.Text = "ถั่ว";
            this.CBTP3.UseVisualStyleBackColor = true;
            this.CBTP3.CheckedChanged += new System.EventHandler(this.CBTP3_CheckedChanged);
            // 
            // CBTP4
            // 
            this.CBTP4.AutoSize = true;
            this.CBTP4.Location = new System.Drawing.Point(12, 254);
            this.CBTP4.Name = "CBTP4";
            this.CBTP4.Size = new System.Drawing.Size(51, 17);
            this.CBTP4.TabIndex = 17;
            this.CBTP4.Text = "เผือก";
            this.CBTP4.UseVisualStyleBackColor = true;
            this.CBTP4.CheckedChanged += new System.EventHandler(this.CBTP4_CheckedChanged);
            // 
            // BTADD
            // 
            this.BTADD.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTADD.Location = new System.Drawing.Point(12, 425);
            this.BTADD.Name = "BTADD";
            this.BTADD.Size = new System.Drawing.Size(87, 32);
            this.BTADD.TabIndex = 18;
            this.BTADD.Text = "เพิ่มออเดอร์";
            this.BTADD.UseVisualStyleBackColor = true;
            this.BTADD.Click += new System.EventHandler(this.BTF_Click);
            // 
            // BTDL
            // 
            this.BTDL.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDL.Location = new System.Drawing.Point(169, 425);
            this.BTDL.Name = "BTDL";
            this.BTDL.Size = new System.Drawing.Size(87, 32);
            this.BTDL.TabIndex = 19;
            this.BTDL.Text = "ลบออเดอร์";
            this.BTDL.UseVisualStyleBackColor = true;
            this.BTDL.Click += new System.EventHandler(this.BTDL_Click);
            // 
            // BTCC
            // 
            this.BTCC.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCC.Location = new System.Drawing.Point(323, 425);
            this.BTCC.Name = "BTCC";
            this.BTCC.Size = new System.Drawing.Size(87, 32);
            this.BTCC.TabIndex = 20;
            this.BTCC.Text = "ยกเลิก";
            this.BTCC.UseVisualStyleBackColor = true;
            this.BTCC.Click += new System.EventHandler(this.BTCC_Click);
            // 
            // CBTP5
            // 
            this.CBTP5.AutoSize = true;
            this.CBTP5.Location = new System.Drawing.Point(12, 277);
            this.CBTP5.Name = "CBTP5";
            this.CBTP5.Size = new System.Drawing.Size(50, 17);
            this.CBTP5.TabIndex = 21;
            this.CBTP5.Text = "เยลลี่";
            this.CBTP5.UseVisualStyleBackColor = true;
            this.CBTP5.CheckedChanged += new System.EventHandler(this.CBTP5_CheckedChanged);
            // 
            // CBTP6
            // 
            this.CBTP6.AutoSize = true;
            this.CBTP6.Location = new System.Drawing.Point(87, 185);
            this.CBTP6.Name = "CBTP6";
            this.CBTP6.Size = new System.Drawing.Size(50, 17);
            this.CBTP6.TabIndex = 22;
            this.CBTP6.Text = "เชอรี่";
            this.CBTP6.UseVisualStyleBackColor = true;
            this.CBTP6.CheckedChanged += new System.EventHandler(this.CBTP6_CheckedChanged);
            // 
            // CBTP7
            // 
            this.CBTP7.AutoSize = true;
            this.CBTP7.Location = new System.Drawing.Point(87, 208);
            this.CBTP7.Name = "CBTP7";
            this.CBTP7.Size = new System.Drawing.Size(47, 17);
            this.CBTP7.TabIndex = 23;
            this.CBTP7.Text = "ผักชี";
            this.CBTP7.UseVisualStyleBackColor = true;
            this.CBTP7.CheckedChanged += new System.EventHandler(this.CBTP7_CheckedChanged);
            // 
            // CBTP8
            // 
            this.CBTP8.AutoSize = true;
            this.CBTP8.Location = new System.Drawing.Point(87, 231);
            this.CBTP8.Name = "CBTP8";
            this.CBTP8.Size = new System.Drawing.Size(53, 17);
            this.CBTP8.TabIndex = 24;
            this.CBTP8.Text = "ลูกชิด";
            this.CBTP8.UseVisualStyleBackColor = true;
            this.CBTP8.CheckedChanged += new System.EventHandler(this.CBTP8_CheckedChanged);
            // 
            // CBTP9
            // 
            this.CBTP9.AutoSize = true;
            this.CBTP9.Location = new System.Drawing.Point(87, 254);
            this.CBTP9.Name = "CBTP9";
            this.CBTP9.Size = new System.Drawing.Size(59, 17);
            this.CBTP9.TabIndex = 25;
            this.CBTP9.Text = "ขนมปัง";
            this.CBTP9.UseVisualStyleBackColor = true;
            this.CBTP9.CheckedChanged += new System.EventHandler(this.CBTP9_CheckedChanged);
            // 
            // CBTP10
            // 
            this.CBTP10.AutoSize = true;
            this.CBTP10.Location = new System.Drawing.Point(87, 277);
            this.CBTP10.Name = "CBTP10";
            this.CBTP10.Size = new System.Drawing.Size(64, 17);
            this.CBTP10.TabIndex = 26;
            this.CBTP10.Text = "เฉาก๊วย";
            this.CBTP10.UseVisualStyleBackColor = true;
            this.CBTP10.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "รสไอศกรีม";
            // 
            // CBMENU2
            // 
            this.CBMENU2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMENU2.FormattingEnabled = true;
            this.CBMENU2.Items.AddRange(new object[] {
            "รสมะนาว",
            "รสเผือก",
            "รสชาเขียว",
            "รสช็อก ช็อก ชิป",
            "รสสตรอเบอร์รี่",
            "รสช็อกโกแลตชิป",
            "รสมิลค์ช็อกโกแลต",
            "รสวานิลลา",
            "รสคาปูชิโน",
            "รสเรนโบว์",
            "รสคุกกี้แอนด์ครีม",
            "รสกะทิ",
            "รสทุเรียน",
            "รสมะม่วง",
            "รสรวมมิตร"});
            this.CBMENU2.Location = new System.Drawing.Point(12, 80);
            this.CBMENU2.Name = "CBMENU2";
            this.CBMENU2.Size = new System.Drawing.Size(195, 24);
            this.CBMENU2.TabIndex = 27;
            this.CBMENU2.SelectedIndexChanged += new System.EventHandler(this.CBMENU2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "รสไอศกรีม";
            // 
            // CBMENU3
            // 
            this.CBMENU3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMENU3.FormattingEnabled = true;
            this.CBMENU3.Items.AddRange(new object[] {
            "รสมะนาว",
            "รสเผือก",
            "รสชาเขียว",
            "รสช็อก ช็อก ชิป",
            "รสสตรอเบอร์รี่",
            "รสช็อกโกแลตชิป",
            "รสมิลค์ช็อกโกแลต",
            "รสวานิลลา",
            "รสคาปูชิโน",
            "รสเรนโบว์",
            "รสคุกกี้แอนด์ครีม",
            "รสกะทิ",
            "รสทุเรียน",
            "รสมะม่วง",
            "รสรวมมิตร"});
            this.CBMENU3.Location = new System.Drawing.Point(12, 127);
            this.CBMENU3.Name = "CBMENU3";
            this.CBMENU3.Size = new System.Drawing.Size(195, 24);
            this.CBMENU3.TabIndex = 31;
            this.CBMENU3.SelectedIndexChanged += new System.EventHandler(this.CBMENU3_SelectedIndexChanged);
            // 
            // CBNUM1
            // 
            this.CBNUM1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNUM1.FormattingEnabled = true;
            this.CBNUM1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBNUM1.Location = new System.Drawing.Point(230, 37);
            this.CBNUM1.Name = "CBNUM1";
            this.CBNUM1.Size = new System.Drawing.Size(59, 24);
            this.CBNUM1.TabIndex = 33;
            this.CBNUM1.SelectedIndexChanged += new System.EventHandler(this.CBNUM1_SelectedIndexChanged);
            // 
            // CBNUM2
            // 
            this.CBNUM2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNUM2.FormattingEnabled = true;
            this.CBNUM2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBNUM2.Location = new System.Drawing.Point(230, 80);
            this.CBNUM2.Name = "CBNUM2";
            this.CBNUM2.Size = new System.Drawing.Size(59, 24);
            this.CBNUM2.TabIndex = 34;
            this.CBNUM2.SelectedIndexChanged += new System.EventHandler(this.CBNUM2_SelectedIndexChanged);
            // 
            // CBNUM3
            // 
            this.CBNUM3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNUM3.FormattingEnabled = true;
            this.CBNUM3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBNUM3.Location = new System.Drawing.Point(230, 127);
            this.CBNUM3.Name = "CBNUM3";
            this.CBNUM3.Size = new System.Drawing.Size(59, 24);
            this.CBNUM3.TabIndex = 35;
            this.CBNUM3.SelectedIndexChanged += new System.EventHandler(this.CBNUM3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "จำนวน";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBNUM3);
            this.Controls.Add(this.CBNUM2);
            this.Controls.Add(this.CBNUM1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBMENU3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBMENU2);
            this.Controls.Add(this.CBTP10);
            this.Controls.Add(this.CBTP9);
            this.Controls.Add(this.CBTP8);
            this.Controls.Add(this.CBTP7);
            this.Controls.Add(this.CBTP6);
            this.Controls.Add(this.CBTP5);
            this.Controls.Add(this.BTCC);
            this.Controls.Add(this.BTDL);
            this.Controls.Add(this.BTADD);
            this.Controls.Add(this.CBTP4);
            this.Controls.Add(this.CBTP3);
            this.Controls.Add(this.CBTP2);
            this.Controls.Add(this.CBTP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBPR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBMENU1);
            this.Controls.Add(this.LBORDER);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBORDER;
        private System.Windows.Forms.ComboBox CBMENU1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBPR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CBTP1;
        private System.Windows.Forms.CheckBox CBTP2;
        private System.Windows.Forms.CheckBox CBTP3;
        private System.Windows.Forms.CheckBox CBTP4;
        private System.Windows.Forms.Button BTADD;
        private System.Windows.Forms.Button BTDL;
        private System.Windows.Forms.Button BTCC;
        private System.Windows.Forms.CheckBox CBTP5;
        private System.Windows.Forms.CheckBox CBTP6;
        private System.Windows.Forms.CheckBox CBTP7;
        private System.Windows.Forms.CheckBox CBTP8;
        private System.Windows.Forms.CheckBox CBTP9;
        private System.Windows.Forms.CheckBox CBTP10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBMENU2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBMENU3;
        private System.Windows.Forms.ComboBox CBNUM1;
        private System.Windows.Forms.ComboBox CBNUM2;
        private System.Windows.Forms.ComboBox CBNUM3;
        private System.Windows.Forms.Label label3;
    }
}

