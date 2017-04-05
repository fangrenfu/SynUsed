namespace CpuUsed
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCpu = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMemory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(91, 13);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(100, 21);
            this.tbIp.TabIndex = 1;
            this.tbIp.Text = "0.0.0.0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 113);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCpu
            // 
            this.lbCpu.AutoSize = true;
            this.lbCpu.Location = new System.Drawing.Point(26, 59);
            this.lbCpu.Name = "lbCpu";
            this.lbCpu.Size = new System.Drawing.Size(59, 12);
            this.lbCpu.TabIndex = 3;
            this.lbCpu.Text = "cpu负载：";
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(92, 49);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(99, 21);
            this.tbCPU.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "内存使用：";
            // 
            // tbMemory
            // 
            this.tbMemory.Location = new System.Drawing.Point(91, 88);
            this.tbMemory.Name = "tbMemory";
            this.tbMemory.Size = new System.Drawing.Size(100, 21);
            this.tbMemory.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 142);
            this.Controls.Add(this.tbMemory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCPU);
            this.Controls.Add(this.lbCpu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "服务器资源监控";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCpu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMemory;
    }
}

