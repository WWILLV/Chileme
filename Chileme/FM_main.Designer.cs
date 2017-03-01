namespace Chileme
{
    partial class FM_main
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.link_about = new System.Windows.Forms.LinkLabel();
            this.link_openList = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(235, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(78, 73);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 39);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "吃了么？";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // link_about
            // 
            this.link_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.link_about.AutoSize = true;
            this.link_about.Location = new System.Drawing.Point(1, 123);
            this.link_about.Name = "link_about";
            this.link_about.Size = new System.Drawing.Size(29, 12);
            this.link_about.TabIndex = 2;
            this.link_about.TabStop = true;
            this.link_about.Text = "说明";
            this.link_about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_about_LinkClicked);
            // 
            // link_openList
            // 
            this.link_openList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.link_openList.AutoSize = true;
            this.link_openList.Location = new System.Drawing.Point(36, 123);
            this.link_openList.Name = "link_openList";
            this.link_openList.Size = new System.Drawing.Size(53, 12);
            this.link_openList.TabIndex = 3;
            this.link_openList.TabStop = true;
            this.link_openList.Text = "打开list";
            this.link_openList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_openList_LinkClicked);
            // 
            // FM_main
            // 
            this.AcceptButton = this.btn_refresh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 144);
            this.Controls.Add(this.link_openList);
            this.Controls.Add(this.link_about);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.textBox1);
            this.Name = "FM_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "吃了么";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.LinkLabel link_about;
        private System.Windows.Forms.LinkLabel link_openList;
    }
}

