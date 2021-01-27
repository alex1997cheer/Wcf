namespace DuplexClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcessReport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcessReport
            // 
            this.btnProcessReport.Location = new System.Drawing.Point(51, 28);
            this.btnProcessReport.Name = "btnProcessReport";
            this.btnProcessReport.Size = new System.Drawing.Size(167, 23);
            this.btnProcessReport.TabIndex = 0;
            this.btnProcessReport.Text = "Process";
            this.btnProcessReport.UseVisualStyleBackColor = true;
            this.btnProcessReport.Click += new System.EventHandler(this.btnProcessReport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 21);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 152);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProcessReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessReport;
        private System.Windows.Forms.TextBox textBox1;
    }
}

