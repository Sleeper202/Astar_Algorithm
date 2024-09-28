namespace Astar_algorithm
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
            panel1 = new Panel();
            btnFindPath = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            cbStart = new ComboBox();
            cbEnd = new ComboBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 650);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnFindPath
            // 
            btnFindPath.Location = new Point(709, 382);
            btnFindPath.Name = "btnFindPath";
            btnFindPath.Size = new Size(94, 29);
            btnFindPath.TabIndex = 1;
            btnFindPath.Text = "Tìm";
            btnFindPath.UseVisualStyleBackColor = true;
            btnFindPath.Click += btnFindPath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(698, 82);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(700, 171);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Kết thúc:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(691, 288);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "Kết quả";
            // 
            // cbStart
            // 
            cbStart.FormattingEnabled = true;
            cbStart.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            cbStart.Location = new Point(691, 105);
            cbStart.Name = "cbStart";
            cbStart.Size = new Size(151, 28);
            cbStart.TabIndex = 7;
            // 
            // cbEnd
            // 
            cbEnd.FormattingEnabled = true;
            cbEnd.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            cbEnd.Location = new Point(691, 194);
            cbEnd.Name = "cbEnd";
            cbEnd.Size = new Size(151, 28);
            cbEnd.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 674);
            Controls.Add(cbEnd);
            Controls.Add(cbStart);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFindPath);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnFindPath;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private ComboBox cbStart;
        private ComboBox cbEnd;
    }
}
