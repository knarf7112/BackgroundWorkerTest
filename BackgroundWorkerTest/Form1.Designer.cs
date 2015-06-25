namespace BackgroundWorkerTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartAsync = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnCancelAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartAsync
            // 
            this.btnStartAsync.Location = new System.Drawing.Point(80, 152);
            this.btnStartAsync.Name = "btnStartAsync";
            this.btnStartAsync.Size = new System.Drawing.Size(75, 23);
            this.btnStartAsync.TabIndex = 0;
            this.btnStartAsync.Text = "Start";
            this.btnStartAsync.UseVisualStyleBackColor = true;
            this.btnStartAsync.Click += new System.EventHandler(this.btnStartAsync_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(92, 49);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(53, 12);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "顯示進度";
            // 
            // btnCancelAsync
            // 
            this.btnCancelAsync.Location = new System.Drawing.Point(261, 152);
            this.btnCancelAsync.Name = "btnCancelAsync";
            this.btnCancelAsync.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAsync.TabIndex = 2;
            this.btnCancelAsync.Text = "Cancel";
            this.btnCancelAsync.UseVisualStyleBackColor = true;
            this.btnCancelAsync.Click += new System.EventHandler(this.btnCancelAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 222);
            this.Controls.Add(this.btnCancelAsync);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnStartAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartAsync;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnCancelAsync;
    }
}

