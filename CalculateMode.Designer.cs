namespace _24PointGame
{
    partial class CalculateMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateMode));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            label1 = new Label();
            button_Handin = new Button();
            tabPage2 = new TabPage();
            button_Random = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtAnswer = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(295, 267);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button_Handin);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(287, 234);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "手动输入";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(56, 16);
            label1.Name = "label1";
            label1.Size = new Size(166, 53);
            label1.TabIndex = 1;
            label1.Text = "    请输入四个数字：\r\n（请使用空格分隔开）";
            // 
            // button_Handin
            // 
            button_Handin.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button_Handin.Location = new Point(102, 150);
            button_Handin.Name = "button_Handin";
            button_Handin.Size = new Size(76, 36);
            button_Handin.TabIndex = 0;
            button_Handin.Text = "确定";
            button_Handin.UseVisualStyleBackColor = true;
            button_Handin.Click += button_Handin_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button_Random);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(287, 234);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "随机生成";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Random
            // 
            button_Random.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Random.Location = new Point(83, 83);
            button_Random.Name = "button_Random";
            button_Random.Size = new Size(115, 67);
            button_Random.TabIndex = 0;
            button_Random.Text = "随机生成";
            button_Random.UseVisualStyleBackColor = true;
            button_Random.Click += button_Random_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAnswer);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(341, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 570);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "计算界面";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 182);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 2;
            label2.Text = "答案";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(14, 208);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ScrollBars = ScrollBars.Vertical;
            txtAnswer.Size = new Size(481, 356);
            txtAnswer.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(401, 44);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 120);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(272, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 120);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(143, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 120);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CalculateMode
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 645);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculateMode";
            StartPosition = FormStartPosition.CenterParent;
            Text = "计算模式";
            Load += CalculateMode_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button_Handin;
        private Button button_Random;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtAnswer;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}