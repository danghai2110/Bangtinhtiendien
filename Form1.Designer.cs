namespace Bangtinhtiendien
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtcsc = new TextBox();
            label3 = new Label();
            txtcsm = new TextBox();
            label4 = new Label();
            txtskwtt = new TextBox();
            label5 = new Label();
            txttdm = new TextBox();
            label6 = new Label();
            txtvdm = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txttongtien = new TextBox();
            btntinh = new Button();
            btnxuat = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 35);
            label1.Name = "label1";
            label1.Size = new Size(268, 36);
            label1.TabIndex = 0;
            label1.Text = "Bảng tính tiền điện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(135, 36);
            label2.TabIndex = 1;
            label2.Text = "Chỉ số cũ";
            // 
            // txtcsc
            // 
            txtcsc.Location = new Point(246, 89);
            txtcsc.Name = "txtcsc";
            txtcsc.Size = new Size(209, 44);
            txtcsc.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 162);
            label3.Name = "label3";
            label3.Size = new Size(153, 36);
            label3.TabIndex = 3;
            label3.Text = "Chỉ số mới";
            // 
            // txtcsm
            // 
            txtcsm.Location = new Point(246, 154);
            txtcsm.Name = "txtcsm";
            txtcsm.Size = new Size(209, 44);
            txtcsm.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 229);
            label4.Name = "label4";
            label4.Size = new Size(206, 36);
            label4.TabIndex = 5;
            label4.Text = "Số kw tiêu thụ";
            // 
            // txtskwtt
            // 
            txtskwtt.Location = new Point(247, 221);
            txtskwtt.Name = "txtskwtt";
            txtskwtt.Size = new Size(208, 44);
            txtskwtt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 89);
            label5.Name = "label5";
            label5.Size = new Size(307, 36);
            label5.TabIndex = 7;
            label5.Text = "Số kw trong định mức";
            // 
            // txttdm
            // 
            txttdm.Location = new Point(819, 81);
            txttdm.Name = "txttdm";
            txttdm.Size = new Size(214, 44);
            txttdm.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 157);
            label6.Name = "label6";
            label6.Size = new Size(296, 36);
            label6.TabIndex = 9;
            label6.Text = "Số kw vượt định mức";
            // 
            // txtvdm
            // 
            txtvdm.Location = new Point(818, 149);
            txtvdm.Name = "txtvdm";
            txtvdm.Size = new Size(215, 44);
            txtvdm.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 229);
            label7.Name = "label7";
            label7.Size = new Size(253, 36);
            label7.TabIndex = 11;
            label7.Text = "Định mức là 50kw";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 293);
            label8.Name = "label8";
            label8.Size = new Size(408, 36);
            label8.TabIndex = 12;
            label8.Text = "Trong định mức là: 500đ/1kw";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(502, 351);
            label9.Name = "label9";
            label9.Size = new Size(397, 36);
            label9.TabIndex = 13;
            label9.Text = "Vượt định mức là 1000đ/1kw";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(147, 293);
            label10.Name = "label10";
            label10.Size = new Size(254, 36);
            label10.TabIndex = 14;
            label10.Text = "Tổng tiền phải trả";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(138, 361);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(284, 44);
            txttongtien.TabIndex = 15;
            // 
            // btntinh
            // 
            btntinh.Location = new Point(114, 517);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(178, 47);
            btntinh.TabIndex = 16;
            btntinh.Text = "Tính";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // btnxuat
            // 
            btnxuat.Location = new Point(455, 517);
            btnxuat.Name = "btnxuat";
            btnxuat.Size = new Size(175, 47);
            btnxuat.TabIndex = 17;
            btnxuat.Text = "In";
            btnxuat.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(822, 517);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(153, 47);
            btnthoat.TabIndex = 18;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 1018);
            Controls.Add(btnthoat);
            Controls.Add(btnxuat);
            Controls.Add(btntinh);
            Controls.Add(txttongtien);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtvdm);
            Controls.Add(label6);
            Controls.Add(txttdm);
            Controls.Add(label5);
            Controls.Add(txtskwtt);
            Controls.Add(label4);
            Controls.Add(txtcsm);
            Controls.Add(label3);
            Controls.Add(txtcsc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcsc;
        private Label label3;
        private TextBox txtcsm;
        private Label label4;
        private TextBox txtskwtt;
        private Label label5;
        private TextBox txttdm;
        private Label label6;
        private TextBox txtvdm;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txttongtien;
        private Button btntinh;
        private Button btnxuat;
        private Button btnthoat;
    }
}
