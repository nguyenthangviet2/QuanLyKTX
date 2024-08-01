namespace QL_KTX
{
    partial class DangKy
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
            labelHoTenDK = new Label();
            labelMatKhauDK = new Label();
            labelNhapLaiMK = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonDangKy = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelHoTenDK
            // 
            labelHoTenDK.AutoSize = true;
            labelHoTenDK.Location = new Point(41, 37);
            labelHoTenDK.Name = "labelHoTenDK";
            labelHoTenDK.Size = new Size(57, 20);
            labelHoTenDK.TabIndex = 0;
            labelHoTenDK.Text = "Họ tên:";
            // 
            // labelMatKhauDK
            // 
            labelMatKhauDK.AutoSize = true;
            labelMatKhauDK.Location = new Point(41, 104);
            labelMatKhauDK.Name = "labelMatKhauDK";
            labelMatKhauDK.Size = new Size(70, 20);
            labelMatKhauDK.TabIndex = 1;
            labelMatKhauDK.Text = "Mật khẩu";
            // 
            // labelNhapLaiMK
            // 
            labelNhapLaiMK.AutoSize = true;
            labelNhapLaiMK.Location = new Point(41, 169);
            labelNhapLaiMK.Name = "labelNhapLaiMK";
            labelNhapLaiMK.Size = new Size(133, 20);
            labelNhapLaiMK.TabIndex = 2;
            labelNhapLaiMK.Text = "Nhập lại mật khẩu:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 27);
            textBox3.TabIndex = 5;
            // 
            // buttonDangKy
            // 
            buttonDangKy.Location = new Point(246, 246);
            buttonDangKy.Name = "buttonDangKy";
            buttonDangKy.Size = new Size(94, 29);
            buttonDangKy.TabIndex = 6;
            buttonDangKy.Text = "Đăng Ký";
            buttonDangKy.UseVisualStyleBackColor = true;
            buttonDangKy.Click += buttonDangKy_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 246);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 298);
            Controls.Add(button2);
            Controls.Add(buttonDangKy);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelNhapLaiMK);
            Controls.Add(labelMatKhauDK);
            Controls.Add(labelHoTenDK);
            Name = "DangKy";
            Text = "DangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHoTenDK;
        private Label labelMatKhauDK;
        private Label labelNhapLaiMK;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonDangKy;
        private Button button2;
    }
}