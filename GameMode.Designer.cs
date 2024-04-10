namespace _24PointGame
{
    partial class GameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMode));
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label_gameTime = new Label();
            label_gameLevel = new Label();
            label_gameCorrect = new Label();
            label_gameError = new Label();
            txtAnswer = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnDivide = new Button();
            btnMulti = new Button();
            btnRight = new Button();
            btnNumber4 = new Button();
            btnMinus = new Button();
            btnNext = new Button();
            btnAnswer = new Button();
            btnEnter = new Button();
            btnLeft = new Button();
            btnNumber3 = new Button();
            btnAdd = new Button();
            btnNumber2 = new Button();
            btnNumber1 = new Button();
            lblInput = new Label();
            lblResult = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label_gameTimeUse = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(495, 80);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 120);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(366, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 120);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(237, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 120);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(108, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 120);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label_gameTime
            // 
            label_gameTime.AutoSize = true;
            label_gameTime.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_gameTime.Location = new Point(669, 91);
            label_gameTime.Name = "label_gameTime";
            label_gameTime.Size = new Size(112, 27);
            label_gameTime.TabIndex = 7;
            label_gameTime.Text = "所用时间：";
            // 
            // label_gameLevel
            // 
            label_gameLevel.AutoSize = true;
            label_gameLevel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_gameLevel.Location = new Point(669, 137);
            label_gameLevel.Name = "label_gameLevel";
            label_gameLevel.Size = new Size(112, 27);
            label_gameLevel.TabIndex = 7;
            label_gameLevel.Text = "当前关卡：";
            // 
            // label_gameCorrect
            // 
            label_gameCorrect.AutoSize = true;
            label_gameCorrect.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_gameCorrect.Location = new Point(669, 183);
            label_gameCorrect.Name = "label_gameCorrect";
            label_gameCorrect.Size = new Size(72, 27);
            label_gameCorrect.TabIndex = 7;
            label_gameCorrect.Text = "正确：";
            // 
            // label_gameError
            // 
            label_gameError.AutoSize = true;
            label_gameError.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_gameError.Location = new Point(669, 229);
            label_gameError.Name = "label_gameError";
            label_gameError.Size = new Size(72, 27);
            label_gameError.TabIndex = 7;
            label_gameError.Text = "错误：";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(520, 293);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ScrollBars = ScrollBars.Vertical;
            txtAnswer.Size = new Size(435, 464);
            txtAnswer.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(520, 263);
            label1.Name = "label1";
            label1.Size = new Size(52, 27);
            label1.TabIndex = 7;
            label1.Text = "答案";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnDivide);
            groupBox1.Controls.Add(btnMulti);
            groupBox1.Controls.Add(btnRight);
            groupBox1.Controls.Add(btnNumber4);
            groupBox1.Controls.Add(btnMinus);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnAnswer);
            groupBox1.Controls.Add(btnEnter);
            groupBox1.Controls.Add(btnLeft);
            groupBox1.Controls.Add(btnNumber3);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnNumber2);
            groupBox1.Controls.Add(btnNumber1);
            groupBox1.Controls.Add(lblInput);
            groupBox1.Location = new Point(54, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 464);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "键盘输入区";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(338, 246);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 52);
            btnClear.TabIndex = 1;
            btnClear.Text = "清零";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(236, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 52);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "del";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.Location = new Point(338, 165);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(67, 52);
            btnDivide.TabIndex = 1;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMulti.Location = new Point(236, 165);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(67, 52);
            btnMulti.TabIndex = 1;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnRight
            // 
            btnRight.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRight.Location = new Point(134, 246);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(67, 52);
            btnRight.TabIndex = 1;
            btnRight.Text = ")";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnNumber4
            // 
            btnNumber4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumber4.Location = new Point(338, 87);
            btnNumber4.Name = "btnNumber4";
            btnNumber4.Size = new Size(67, 52);
            btnNumber4.TabIndex = 1;
            btnNumber4.Text = "a";
            btnNumber4.UseVisualStyleBackColor = true;
            btnNumber4.Click += btnNumber4_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(134, 165);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(67, 52);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(292, 327);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(114, 52);
            btnNext.TabIndex = 1;
            btnNext.Text = "下一关";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer.Location = new Point(162, 327);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(114, 52);
            btnAnswer.TabIndex = 1;
            btnAnswer.Text = "查看";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Location = new Point(32, 327);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(114, 52);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "确定";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeft.Location = new Point(32, 246);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(67, 52);
            btnLeft.TabIndex = 1;
            btnLeft.Text = "(";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnNumber3
            // 
            btnNumber3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumber3.Location = new Point(236, 87);
            btnNumber3.Name = "btnNumber3";
            btnNumber3.Size = new Size(67, 52);
            btnNumber3.TabIndex = 1;
            btnNumber3.Text = "a";
            btnNumber3.UseVisualStyleBackColor = true;
            btnNumber3.Click += btnNumber3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(32, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNumber2
            // 
            btnNumber2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumber2.Location = new Point(134, 87);
            btnNumber2.Name = "btnNumber2";
            btnNumber2.Size = new Size(67, 52);
            btnNumber2.TabIndex = 1;
            btnNumber2.Text = "a";
            btnNumber2.UseVisualStyleBackColor = true;
            btnNumber2.Click += btnNumber2_Click;
            // 
            // btnNumber1
            // 
            btnNumber1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNumber1.Location = new Point(32, 87);
            btnNumber1.Name = "btnNumber1";
            btnNumber1.Size = new Size(67, 52);
            btnNumber1.TabIndex = 1;
            btnNumber1.Text = "a";
            btnNumber1.UseVisualStyleBackColor = true;
            btnNumber1.Click += btnNumber1_Click;
            // 
            // lblInput
            // 
            lblInput.BackColor = Color.Transparent;
            lblInput.BorderStyle = BorderStyle.FixedSingle;
            lblInput.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInput.Location = new Point(64, 34);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(293, 44);
            lblInput.TabIndex = 0;
            lblInput.Text = "表达式输入框";
            lblInput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(59, 229);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(423, 39);
            lblResult.TabIndex = 10;
            lblResult.Text = "<<---恭喜您，答对了！--->>";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label_gameTimeUse
            // 
            label_gameTimeUse.AutoSize = true;
            label_gameTimeUse.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_gameTimeUse.Location = new Point(669, 51);
            label_gameTimeUse.Name = "label_gameTimeUse";
            label_gameTimeUse.Size = new Size(112, 27);
            label_gameTimeUse.TabIndex = 7;
            label_gameTimeUse.Text = "可用时间：";
            // 
            // GameMode
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 785);
            Controls.Add(lblResult);
            Controls.Add(groupBox1);
            Controls.Add(txtAnswer);
            Controls.Add(label1);
            Controls.Add(label_gameError);
            Controls.Add(label_gameCorrect);
            Controls.Add(label_gameLevel);
            Controls.Add(label_gameTimeUse);
            Controls.Add(label_gameTime);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameMode";
            StartPosition = FormStartPosition.CenterParent;
            Text = "闯关模式";
            Load += GameMode_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label_gameTime;
        private Label label_gameLevel;
        private Label label_gameCorrect;
        private Label label_gameError;
        private TextBox txtAnswer;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnDivide;
        private Button btnMulti;
        private Button btnRight;
        private Button btnNumber4;
        private Button btnMinus;
        private Button btnLeft;
        private Button btnNumber3;
        private Button btnAdd;
        private Button btnNumber2;
        private Button btnNumber1;
        private Label lblInput;
        private Button btnNext;
        private Button btnAnswer;
        private Button btnEnter;
        private Label lblResult;
        private System.Windows.Forms.Timer timer1;
        private Label label_gameTimeUse;
    }
}