﻿namespace QL_KTX
{
    partial class TinhTrangPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhTrangPhong));
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            comboBox4 = new ComboBox();
            btthoat = new Button();
            textBox5 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btkiemtra = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(374, 288);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(374, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(374, 214);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(176, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(210, 9);
            label3.Name = "label3";
            label3.Size = new Size(170, 39);
            label3.TabIndex = 13;
            label3.Text = "Tình trạng";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(btkiemtra);
            groupBox1.Controls.Add(btthoat);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 264);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "B1", "B3" });
            comboBox4.Location = new Point(285, 40);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(178, 23);
            comboBox4.TabIndex = 13;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // btthoat
            // 
            btthoat.BackColor = Color.FromArgb(255, 255, 128);
            btthoat.BackgroundImage = Properties.Resources.icons8_logout_26;
            btthoat.BackgroundImageLayout = ImageLayout.None;
            btthoat.Cursor = Cursors.Hand;
            btthoat.FlatStyle = FlatStyle.Flat;
            btthoat.ForeColor = Color.Black;
            btthoat.Location = new Point(524, 40);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(99, 38);
            btthoat.TabIndex = 12;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = false;
            btthoat.Click += btthoat_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(286, 122);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 23);
            textBox5.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Full", "Chưa full" });
            comboBox3.Location = new Point(287, 204);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(177, 23);
            comboBox3.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nợ", "Đã đóng" });
            comboBox2.Location = new Point(286, 163);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 23);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(287, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 128);
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(72, 43);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 8;
            label6.Text = "Tòa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 128);
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(72, 203);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 8;
            label5.Text = "Tình trạng số người";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 128);
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(72, 163);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 8;
            label4.Text = "Tình trạng tiền phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(72, 123);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 8;
            label1.Text = "Số người";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Số phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 340);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(649, 161);
            dataGridView1.TabIndex = 15;
            // 
            // btkiemtra
            // 
            btkiemtra.BackColor = Color.FromArgb(255, 255, 128);
            btkiemtra.BackgroundImage = Properties.Resources.icons8_test_26;
            btkiemtra.BackgroundImageLayout = ImageLayout.None;
            btkiemtra.Cursor = Cursors.Hand;
            btkiemtra.FlatStyle = FlatStyle.Flat;
            btkiemtra.ForeColor = Color.Black;
            btkiemtra.Location = new Point(524, 189);
            btkiemtra.Name = "btkiemtra";
            btkiemtra.Size = new Size(99, 38);
            btkiemtra.TabIndex = 12;
            btkiemtra.Text = "Kiểm tra";
            btkiemtra.UseVisualStyleBackColor = false;
            btkiemtra.Click += btthoat_Click;
            // 
            // TinhTrangPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_01671;
            ClientSize = new Size(650, 499);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TinhTrangPhong";
            Text = "Tình Trạng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private Button btthoat;
        private ComboBox comboBox4;
        private Button btkiemtra;
    }
}