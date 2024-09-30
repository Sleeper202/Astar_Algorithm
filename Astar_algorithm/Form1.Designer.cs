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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 800);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // btnFindPath
            // 
            btnFindPath.Location = new Point(882, 374);
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
            label1.Location = new Point(871, 74);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(873, 163);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Kết thúc:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(864, 280);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "Kết quả";
            // 
            // cbStart
            // 
            cbStart.FormattingEnabled = true;
            cbStart.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "x", "y" });
            cbStart.Location = new Point(864, 97);
            cbStart.Name = "cbStart";
            cbStart.Size = new Size(151, 28);
            cbStart.TabIndex = 7;
            // 
            // cbEnd
            // 
            cbEnd.FormattingEnabled = true;
            cbEnd.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "x", "y" });
            cbEnd.Location = new Point(864, 186);
            cbEnd.Name = "cbEnd";
            cbEnd.Size = new Size(151, 28);
            cbEnd.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 820);
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
