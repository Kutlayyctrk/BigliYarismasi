namespace BigliYarışması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbldogru = new Label();
            lblsoruno = new Label();
            lblyanlıs = new Label();
            btnnext = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(550, 170);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(65, 232);
            btnA.Name = "btnA";
            btnA.Size = new Size(126, 31);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(212, 232);
            btnB.Name = "btnB";
            btnB.Size = new Size(126, 31);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(65, 269);
            btnC.Name = "btnC";
            btnC.Size = new Size(126, 31);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(212, 269);
            btnD.Name = "btnD";
            btnD.Size = new Size(126, 31);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(586, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(586, 53);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 6;
            label2.Text = "Dogru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 88);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // lbldogru
            // 
            lbldogru.AutoSize = true;
            lbldogru.Location = new Point(670, 53);
            lbldogru.Name = "lbldogru";
            lbldogru.Size = new Size(20, 23);
            lbldogru.TabIndex = 8;
            lbldogru.Text = "0";
            // 
            // lblsoruno
            // 
            lblsoruno.AutoSize = true;
            lblsoruno.Location = new Point(670, 18);
            lblsoruno.Name = "lblsoruno";
            lblsoruno.Size = new Size(20, 23);
            lblsoruno.TabIndex = 9;
            lblsoruno.Text = "0";
            lblsoruno.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblyanlıs
            // 
            lblyanlıs.AutoSize = true;
            lblyanlıs.Location = new Point(670, 88);
            lblyanlıs.Name = "lblyanlıs";
            lblyanlıs.Size = new Size(20, 23);
            lblyanlıs.TabIndex = 10;
            lblyanlıs.Text = "0";
            // 
            // btnnext
            // 
            btnnext.Location = new Point(595, 151);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(126, 31);
            btnnext.TabIndex = 11;
            btnnext.Text = "Başlat";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(564, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(659, 213);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 240);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 14;
            label4.Text = "Soru No:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 273);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 15;
            label5.Text = "Soru No:";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(786, 328);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnnext);
            Controls.Add(lblyanlıs);
            Controls.Add(lblsoruno);
            Controls.Add(lbldogru);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbldogru;
        private Label lblsoruno;
        private Label lblyanlıs;
        private Button btnnext;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}