using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorkerTest
{
    public partial class Form1 : Form
    {
        BackgroundWorker bg1;
        public Form1()
        {
            InitializeComponent();
            bg1 = new BackgroundWorker();
            bg1.WorkerReportsProgress = true;
            bg1.WorkerSupportsCancellation = true;
            bg1.DoWork += bg1_DoWork;
            bg1.ProgressChanged += bg1_ProgressChanged;
            bg1.RunWorkerCompleted += bg1_RunWorkerCompleted;
        }

        void bg1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbResult.Text = "取消!";
            }
            else if (e.Error != null)
            {
                lbResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
                lbResult.Text = "完成!";
            }
        }

        // This event handler updates the progress. 回報的進度事件
        void bg1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lbResult.Text = (e.ProgressPercentage.ToString() + "%") + ":" + e.UserState.ToString();
        }

        void bg1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 1; i <= 10; i++)
            {
                //若外部要求BackgroundWorker中止正在進行的程序執行CancelAsync方法則BackgroundWorker的CancellationPending屬性變為True
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(3000);
                    //計算一個目前進度值並傳遞給ProgressChanged事件
                    worker.ReportProgress(i * 10, i);//引發ProgressChanged事件並傳入參數
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartAsync_Click(object sender, EventArgs e)
        {
            if (!bg1.IsBusy)
            {
                // Start the asynchronous operation.
                bg1.RunWorkerAsync();
            }
        }

        private void btnCancelAsync_Click(object sender, EventArgs e)
        {
            if (bg1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                bg1.CancelAsync();
            }
        }
    }
}
