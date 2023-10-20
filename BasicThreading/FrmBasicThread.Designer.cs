namespace BasicThreading
{
    partial class FrmBasicThread
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
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 107);
            label1.Name = "label1";
            label1.Size = new Size(362, 37);
            label1.TabIndex = 0;
            label1.Text = "-BEFORE STARTING THREAD-";
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Red;
            btnRun.Location = new Point(243, 228);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 1;
            btnRun.Text = "RUN";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(550, 328);
            Controls.Add(btnRun);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "FrmBasicThread";
            Text = "FrmBasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRun;
        public Label label1;
    }
}