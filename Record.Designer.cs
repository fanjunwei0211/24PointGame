namespace _24PointGame
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            label1 = new Label();
            txtRecord = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 35);
            label1.Name = "label1";
            label1.Size = new Size(228, 65);
            label1.TabIndex = 0;
            label1.Text = "闯关记录";
            // 
            // txtRecord
            // 
            txtRecord.Location = new Point(123, 119);
            txtRecord.Multiline = true;
            txtRecord.Name = "txtRecord";
            txtRecord.ScrollBars = ScrollBars.Vertical;
            txtRecord.Size = new Size(649, 469);
            txtRecord.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(298, 614);
            button1.Name = "button1";
            button1.Size = new Size(298, 70);
            button1.TabIndex = 3;
            button1.Text = "返回";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 726);
            Controls.Add(button1);
            Controls.Add(txtRecord);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Record";
            StartPosition = FormStartPosition.CenterParent;
            Text = "闯关记录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRecord;
        private Button button1;
    }
}