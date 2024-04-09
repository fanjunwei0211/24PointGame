namespace _24PointGame
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            label1 = new Label();
            button_calculate = new Button();
            button_trick = new Button();
            button_data = new Button();
            button_about = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(185, 41);
            label1.Name = "label1";
            label1.Size = new Size(162, 45);
            label1.TabIndex = 0;
            label1.Text = "24点游戏";
            // 
            // button_calculate
            // 
            button_calculate.BackColor = SystemColors.Control;
            button_calculate.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button_calculate.Location = new Point(169, 107);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(198, 75);
            button_calculate.TabIndex = 1;
            button_calculate.Text = "计算模式";
            button_calculate.UseVisualStyleBackColor = false;
            button_calculate.Click += button_calculate_Click;
            // 
            // button_trick
            // 
            button_trick.BackColor = SystemColors.Control;
            button_trick.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button_trick.Location = new Point(169, 206);
            button_trick.Name = "button_trick";
            button_trick.Size = new Size(198, 75);
            button_trick.TabIndex = 1;
            button_trick.Text = "闯关模式";
            button_trick.UseVisualStyleBackColor = false;
            // 
            // button_data
            // 
            button_data.BackColor = SystemColors.Control;
            button_data.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button_data.Location = new Point(169, 305);
            button_data.Name = "button_data";
            button_data.Size = new Size(198, 75);
            button_data.TabIndex = 1;
            button_data.Text = "闯关记录";
            button_data.UseVisualStyleBackColor = false;
            // 
            // button_about
            // 
            button_about.BackColor = SystemColors.Control;
            button_about.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button_about.Location = new Point(169, 404);
            button_about.Name = "button_about";
            button_about.Size = new Size(198, 75);
            button_about.TabIndex = 1;
            button_about.Text = "游戏说明";
            button_about.UseVisualStyleBackColor = false;
            button_about.Click += button_about_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(544, 520);
            Controls.Add(button_about);
            Controls.Add(button_data);
            Controls.Add(button_trick);
            Controls.Add(button_calculate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "24Point";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_calculate;
        private Button button_trick;
        private Button button_data;
        private Button button_about;
    }
}