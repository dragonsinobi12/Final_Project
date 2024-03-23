namespace Final_Project
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
            head1 = new Label();
            head2 = new Label();
            tpyebox = new CheckedListBox();
            addtpye = new Button();
            inputtext1 = new TextBox();
            removetpye = new Button();
            brandbox = new CheckedListBox();
            inputtext2 = new TextBox();
            addtpye2 = new Button();
            removetpye2 = new Button();
            head3 = new Label();
            head4 = new Label();
            nitb = new TextBox();
            splitter1 = new Splitter();
            head5 = new Label();
            itemAmount = new TextBox();
            button1 = new Button();
            label1 = new Label();
            itemId = new TextBox();
            dataGridView1 = new DataGridView();
            checkstock = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // head1
            // 
            head1.AutoSize = true;
            head1.Font = new Font("Segoe UI", 16F);
            head1.Location = new Point(23, 21);
            head1.Name = "head1";
            head1.Size = new Size(191, 30);
            head1.TabIndex = 0;
            head1.Text = "เพิ่มของเข้าคลังสินค้า";
            // 
            // head2
            // 
            head2.AutoSize = true;
            head2.Location = new Point(37, 70);
            head2.Name = "head2";
            head2.Size = new Size(71, 15);
            head2.TabIndex = 2;
            head2.Text = "ชนิดของสินค้า";
            head2.Click += head2_Click;
            // 
            // tpyebox
            // 
            tpyebox.CheckOnClick = true;
            tpyebox.FormattingEnabled = true;
            tpyebox.Items.AddRange(new object[] { "Bass", "Drum", "Guitar", "Speaker" });
            tpyebox.Location = new Point(23, 102);
            tpyebox.Name = "tpyebox";
            tpyebox.Size = new Size(97, 76);
            tpyebox.TabIndex = 3;
            tpyebox.SelectedIndexChanged += tpyebox_SelectedIndexChanged;
            // 
            // addtpye
            // 
            addtpye.BackColor = SystemColors.ButtonHighlight;
            addtpye.Location = new Point(160, 131);
            addtpye.Name = "addtpye";
            addtpye.Size = new Size(86, 23);
            addtpye.TabIndex = 4;
            addtpye.Text = "เพิ่มชนิดสินค้า";
            addtpye.UseVisualStyleBackColor = false;
            addtpye.Click += addtpye_Click;
            // 
            // inputtext1
            // 
            inputtext1.Location = new Point(126, 102);
            inputtext1.Name = "inputtext1";
            inputtext1.Size = new Size(162, 23);
            inputtext1.TabIndex = 5;
            inputtext1.Text = "เขียนชนิดที่ต้องการเพิ่มหรือลบที่นี้";
            inputtext1.TextChanged += inputtext1_TextChanged;
            // 
            // removetpye
            // 
            removetpye.BackColor = SystemColors.ButtonHighlight;
            removetpye.Location = new Point(160, 155);
            removetpye.Name = "removetpye";
            removetpye.Size = new Size(86, 23);
            removetpye.TabIndex = 6;
            removetpye.Text = "ลบชนิดสินค้า";
            removetpye.UseVisualStyleBackColor = false;
            removetpye.Click += removetpye_Click;
            // 
            // brandbox
            // 
            brandbox.CheckOnClick = true;
            brandbox.ForeColor = SystemColors.WindowText;
            brandbox.FormattingEnabled = true;
            brandbox.Items.AddRange(new object[] { "Yamaha", "Pearl", "Fender", "Squier" });
            brandbox.Location = new Point(23, 228);
            brandbox.Name = "brandbox";
            brandbox.Size = new Size(97, 76);
            brandbox.TabIndex = 7;
            brandbox.SelectedIndexChanged += brand_SelectedIndexChanged;
            // 
            // inputtext2
            // 
            inputtext2.Location = new Point(126, 228);
            inputtext2.Name = "inputtext2";
            inputtext2.Size = new Size(162, 23);
            inputtext2.TabIndex = 8;
            inputtext2.Text = "เขียนเเบรนที่ต้องการเพิ่มหรือลบที่นี้";
            inputtext2.TextChanged += inputtext2_TextChanged;
            // 
            // addtpye2
            // 
            addtpye2.BackColor = SystemColors.ButtonHighlight;
            addtpye2.Location = new Point(160, 257);
            addtpye2.Name = "addtpye2";
            addtpye2.Size = new Size(86, 23);
            addtpye2.TabIndex = 9;
            addtpye2.Text = "เพิ่มเเบรนสินค้า";
            addtpye2.UseVisualStyleBackColor = false;
            addtpye2.Click += addtpye2_Click;
            // 
            // removetpye2
            // 
            removetpye2.BackColor = SystemColors.ButtonHighlight;
            removetpye2.Location = new Point(160, 281);
            removetpye2.Name = "removetpye2";
            removetpye2.Size = new Size(86, 23);
            removetpye2.TabIndex = 10;
            removetpye2.Text = "ลบเเบรนสินค้า";
            removetpye2.UseVisualStyleBackColor = false;
            removetpye2.Click += removetpye2_Click;
            // 
            // head3
            // 
            head3.AutoSize = true;
            head3.Location = new Point(33, 197);
            head3.Name = "head3";
            head3.Size = new Size(75, 15);
            head3.TabIndex = 11;
            head3.Text = "แบรนของสินค้า";
            // 
            // head4
            // 
            head4.AutoSize = true;
            head4.Location = new Point(54, 326);
            head4.Name = "head4";
            head4.Size = new Size(45, 15);
            head4.TabIndex = 12;
            head4.Text = "ชื่อสินค้า";
            // 
            // nitb
            // 
            nitb.Location = new Point(23, 357);
            nitb.Name = "nitb";
            nitb.Size = new Size(100, 23);
            nitb.TabIndex = 13;
            nitb.Text = "ใส่ชื่อสินค้าที่นี้";
            nitb.TextChanged += nitb_TextChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 450);
            splitter1.TabIndex = 14;
            splitter1.TabStop = false;
            // 
            // head5
            // 
            head5.AutoSize = true;
            head5.Location = new Point(54, 397);
            head5.Name = "head5";
            head5.Size = new Size(37, 15);
            head5.TabIndex = 15;
            head5.Text = "จำนวน";
            // 
            // itemAmount
            // 
            itemAmount.Location = new Point(23, 415);
            itemAmount.Name = "itemAmount";
            itemAmount.Size = new Size(100, 23);
            itemAmount.TabIndex = 16;
            itemAmount.Text = "ใส่จำนวนลงที่นี้";
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(138, 386);
            button1.Name = "button1";
            button1.Size = new Size(139, 53);
            button1.TabIndex = 17;
            button1.Text = "ยืนยันการเพิ่มสินค้า";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 326);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 18;
            label1.Text = "รหัสสินค้า";
            // 
            // itemId
            // 
            itemId.Location = new Point(138, 357);
            itemId.Name = "itemId";
            itemId.Size = new Size(139, 23);
            itemId.TabIndex = 19;
            itemId.Text = "ใส่รหัสสินค้าที่นี้";
            itemId.TextChanged += itemId_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(326, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(694, 310);
            dataGridView1.TabIndex = 20;
            // 
            // checkstock
            // 
            checkstock.BackColor = SystemColors.HighlightText;
            checkstock.Location = new Point(326, 21);
            checkstock.Name = "checkstock";
            checkstock.Size = new Size(163, 55);
            checkstock.TabIndex = 21;
            checkstock.Text = "คลิกเพื่อโชว์คลังสินค้า";
            checkstock.UseVisualStyleBackColor = false;
            checkstock.Click += checkstock_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 450);
            Controls.Add(checkstock);
            Controls.Add(dataGridView1);
            Controls.Add(itemId);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(itemAmount);
            Controls.Add(head5);
            Controls.Add(splitter1);
            Controls.Add(nitb);
            Controls.Add(head4);
            Controls.Add(head3);
            Controls.Add(removetpye2);
            Controls.Add(addtpye2);
            Controls.Add(inputtext2);
            Controls.Add(brandbox);
            Controls.Add(removetpye);
            Controls.Add(inputtext1);
            Controls.Add(addtpye);
            Controls.Add(tpyebox);
            Controls.Add(head2);
            Controls.Add(head1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label head1;
        private Label head2;
        private CheckedListBox tpyebox;
        private Button addtpye;
        private TextBox inputtext1;
        private Button removetpye;
        private CheckedListBox brandbox;
        private TextBox inputtext2;
        private Button addtpye2;
        private Button removetpye2;
        private Label head3;
        private Label head4;
        private TextBox nitb;
        private Splitter splitter1;
        private Label head5;
        private TextBox itemAmount;
        private Button button1;
        private Label label1;
        private TextBox itemId;
        private DataGridView dataGridView1;
        private Button checkstock;
    }
}
