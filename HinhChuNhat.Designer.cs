namespace Csharp_TinhChuViDienTich_WinForm
{
    partial class HinhChuNhat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dai = new TextBox();
            rong = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            tcv = new Button();
            tdt = new Button();
            button3 = new Button();
            label3 = new Label();
            kqcv = new TextBox();
            kqdt = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbodt = new RadioButton();
            rbocv = new RadioButton();
            lbtnew = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            chkcv = new CheckBox();
            chkdt = new CheckBox();
            lbtnew2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dai
            // 
            dai.Location = new Point(302, 106);
            dai.Name = "dai";
            dai.Size = new Size(192, 38);
            dai.TabIndex = 0;
            // 
            // rong
            // 
            rong.Location = new Point(302, 196);
            rong.Name = "rong";
            rong.Size = new Size(192, 38);
            rong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 106);
            label1.Name = "label1";
            label1.Size = new Size(49, 30);
            label1.TabIndex = 2;
            label1.Text = "Dài";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 199);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 3;
            label2.Text = "Rộng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 192, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(236, 22);
            label5.Name = "label5";
            label5.Size = new Size(434, 30);
            label5.TabIndex = 8;
            label5.Text = "Tính Chu Vi, Diện Tích Hình Chữ Nhật";
            label5.Click += label5_Click;
            // 
            // tcv
            // 
            tcv.Location = new Point(19, 443);
            tcv.Name = "tcv";
            tcv.Size = new Size(200, 38);
            tcv.TabIndex = 9;
            tcv.Text = "Tính Chu Vi";
            tcv.UseVisualStyleBackColor = true;
            tcv.Click += tcv_Click;
            // 
            // tdt
            // 
            tdt.Location = new Point(236, 443);
            tdt.Name = "tdt";
            tdt.Size = new Size(200, 38);
            tdt.TabIndex = 10;
            tdt.Text = "Tính Diện Tích";
            tdt.UseVisualStyleBackColor = true;
            tdt.Click += tdt_Click;
            // 
            // button3
            // 
            button3.Location = new Point(682, 443);
            button3.Name = "button3";
            button3.Size = new Size(200, 38);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 298);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 12;
            label3.Text = "Chu vi là";
            // 
            // kqcv
            // 
            kqcv.Location = new Point(302, 290);
            kqcv.Name = "kqcv";
            kqcv.Size = new Size(192, 38);
            kqcv.TabIndex = 13;
            // 
            // kqdt
            // 
            kqdt.Location = new Point(302, 363);
            kqdt.Name = "kqdt";
            kqdt.Size = new Size(192, 38);
            kqdt.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 371);
            label4.Name = "label4";
            label4.Size = new Size(145, 30);
            label4.TabIndex = 15;
            label4.Text = "Diện Tích là";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbodt);
            groupBox1.Controls.Add(rbocv);
            groupBox1.Location = new Point(648, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn chức năng";
            // 
            // rbodt
            // 
            rbodt.AutoSize = true;
            rbodt.Location = new Point(6, 91);
            rbodt.Name = "rbodt";
            rbodt.Size = new Size(132, 34);
            rbodt.TabIndex = 18;
            rbodt.TabStop = true;
            rbodt.Text = "Diện tích";
            rbodt.UseVisualStyleBackColor = true;
            rbodt.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbocv
            // 
            rbocv.AutoSize = true;
            rbocv.Location = new Point(6, 53);
            rbocv.Name = "rbocv";
            rbocv.Size = new Size(106, 34);
            rbocv.TabIndex = 17;
            rbocv.TabStop = true;
            rbocv.Text = "Chu Vi";
            rbocv.UseVisualStyleBackColor = true;
            rbocv.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lbtnew
            // 
            lbtnew.Location = new Point(470, 442);
            lbtnew.Name = "lbtnew";
            lbtnew.Size = new Size(178, 39);
            lbtnew.TabIndex = 17;
            lbtnew.Text = "Tính New";
            lbtnew.UseMnemonic = false;
            lbtnew.UseVisualStyleBackColor = true;
            lbtnew.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(536, 107);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 38);
            numericUpDown1.TabIndex = 18;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(536, 191);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(76, 38);
            numericUpDown2.TabIndex = 19;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(536, 363);
            trackBar1.Minimum = -10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(346, 56);
            trackBar1.TabIndex = 20;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkdt);
            groupBox2.Controls.Add(chkcv);
            groupBox2.Location = new Point(648, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // chkcv
            // 
            chkcv.AutoSize = true;
            chkcv.Location = new Point(11, 37);
            chkcv.Name = "chkcv";
            chkcv.Size = new Size(107, 34);
            chkcv.TabIndex = 0;
            chkcv.Text = "Chu Vi";
            chkcv.UseVisualStyleBackColor = true;
            // 
            // chkdt
            // 
            chkdt.AutoSize = true;
            chkdt.Location = new Point(11, 74);
            chkdt.Name = "chkdt";
            chkdt.Size = new Size(140, 34);
            chkdt.TabIndex = 1;
            chkdt.Text = "Diện Tích";
            chkdt.UseVisualStyleBackColor = false;
            // 
            // lbtnew2
            // 
            lbtnew2.Location = new Point(904, 442);
            lbtnew2.Name = "lbtnew2";
            lbtnew2.Size = new Size(178, 39);
            lbtnew2.TabIndex = 22;
            lbtnew2.Text = "Tính New 2";
            lbtnew2.UseMnemonic = false;
            lbtnew2.UseVisualStyleBackColor = true;
            lbtnew2.Click += lbtnew2_Click;
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 553);
            Controls.Add(lbtnew2);
            Controls.Add(groupBox2);
            Controls.Add(trackBar1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(lbtnew);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(kqdt);
            Controls.Add(kqcv);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(tdt);
            Controls.Add(tcv);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rong);
            Controls.Add(dai);
            Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "HinhChuNhat";
            Text = "Hình Chữ Nhật";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dai;
        private TextBox rong;
        private Label label1;
        private Label label2;
        private Label label5;
        private Button tcv;
        private Button tdt;
        private Button button3;
        private Label label3;
        private TextBox kqcv;
        private TextBox kqdt;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbodt;
        private RadioButton rbocv;
        private Button lbtnew;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TrackBar trackBar1;
        private GroupBox groupBox2;
        private CheckBox chkcv;
        private CheckBox chkdt;
        private Button lbtnew2;
    }
}
