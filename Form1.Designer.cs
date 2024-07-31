namespace CSharp_TinhLaiNganHang
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtGui = new TextBox();
            txtLai = new TextBox();
            button1 = new Button();
            listKQ = new ListBox();
            lblLai = new Label();
            lblNhan = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH LÃI NGÂN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 1;
            label2.Text = "Số tiền gửi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(161, 33);
            label3.TabIndex = 1;
            label3.Text = "Lãi xuất (%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(325, 33);
            label4.TabIndex = 1;
            label4.Text = "Tiền thực nhận trong năm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(100, 33);
            label5.TabIndex = 1;
            label5.Text = "Tiền lãi";
            // 
            // txtGui
            // 
            txtGui.Location = new Point(167, 53);
            txtGui.Name = "txtGui";
            txtGui.Size = new Size(100, 40);
            txtGui.TabIndex = 1;
            // 
            // txtLai
            // 
            txtLai.Location = new Point(167, 97);
            txtLai.Name = "txtLai";
            txtLai.Size = new Size(100, 40);
            txtLai.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 262);
            button1.Name = "button1";
            button1.Size = new Size(142, 39);
            button1.TabIndex = 3;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listKQ
            // 
            listKQ.FormattingEnabled = true;
            listKQ.ItemHeight = 33;
            listKQ.Location = new Point(519, 45);
            listKQ.Name = "listKQ";
            listKQ.Size = new Size(140, 202);
            listKQ.TabIndex = 4;
            // 
            // lblLai
            // 
            lblLai.AutoSize = true;
            lblLai.Location = new Point(167, 150);
            lblLai.Name = "lblLai";
            lblLai.Size = new Size(100, 33);
            lblLai.TabIndex = 1;
            lblLai.Text = "Tiền lãi";
            // 
            // lblNhan
            // 
            lblNhan.AutoSize = true;
            lblNhan.Location = new Point(343, 196);
            lblNhan.Name = "lblNhan";
            lblNhan.Size = new Size(133, 33);
            lblNhan.TabIndex = 1;
            lblNhan.Text = "Tiền nhận";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 485);
            Controls.Add(listKQ);
            Controls.Add(button1);
            Controls.Add(txtLai);
            Controls.Add(txtGui);
            Controls.Add(lblNhan);
            Controls.Add(lblLai);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtGui;
        private TextBox txtLai;
        private Button button1;
        private ListBox listKQ;
        private Label lblLai;
        private Label lblNhan;
    }
}
