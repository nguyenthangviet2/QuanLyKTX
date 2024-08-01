namespace QL_KTX
{
    partial class DangNhap
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
            components = new System.ComponentModel.Container();
            labelDN = new Label();
            labelMK = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonThoat = new Button();
            buttonDN = new Button();
            buttonDK = new Button();
            SuspendLayout();
            // 
            // labelDN
            // 
            labelDN.AutoSize = true;
            labelDN.Location = new Point(55, 48);
            labelDN.Name = "labelDN";
            labelDN.Size = new Size(59, 20);
            labelDN.TabIndex = 0;
            labelDN.Text = "Họ Tên:";
            // 
            // labelMK
            // 
            labelMK.AutoSize = true;
            labelMK.Location = new Point(55, 115);
            labelMK.Name = "labelMK";
            labelMK.Size = new Size(75, 20);
            labelMK.TabIndex = 1;
            labelMK.Text = "Mật Khẩu:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 4;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(384, 225);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(94, 29);
            buttonThoat.TabIndex = 5;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonDN
            // 
            buttonDN.Location = new Point(257, 225);
            buttonDN.Name = "buttonDN";
            buttonDN.Size = new Size(94, 29);
            buttonDN.TabIndex = 6;
            buttonDN.Text = "Đăng nhập";
            buttonDN.UseVisualStyleBackColor = true;
            buttonDN.Click += buttonDN_Click;
            // 
            // buttonDK
            // 
            buttonDK.Location = new Point(128, 225);
            buttonDK.Name = "buttonDK";
            buttonDK.Size = new Size(94, 29);
            buttonDK.TabIndex = 7;
            buttonDK.Text = "Đăng ký";
            buttonDK.UseVisualStyleBackColor = true;
            buttonDK.Click += buttonDK_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 266);
            Controls.Add(buttonDK);
            Controls.Add(buttonDN);
            Controls.Add(buttonThoat);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelMK);
            Controls.Add(labelDN);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDN;
        private Label labelMK;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonThoat;
        private Button buttonDN;
        private Button buttonDK;
    }
}