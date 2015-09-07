namespace ZHTool.PhotoToTxtFile
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
            this.openPicDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_picConvertToByte = new System.Windows.Forms.Button();
            this.tb_picList = new System.Windows.Forms.TextBox();
            this.tb_picByteData = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_PicToByte = new System.Windows.Forms.TabPage();
            this.tab_byteToPic = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_openDialog = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_PicToByte.SuspendLayout();
            this.SuspendLayout();
            // 
            // openPicDialog
            // 
            this.openPicDialog.FileName = "openPicDialog";
            this.openPicDialog.Multiselect = true;
            // 
            // btn_picConvertToByte
            // 
            this.btn_picConvertToByte.Location = new System.Drawing.Point(390, 226);
            this.btn_picConvertToByte.Name = "btn_picConvertToByte";
            this.btn_picConvertToByte.Size = new System.Drawing.Size(75, 23);
            this.btn_picConvertToByte.TabIndex = 0;
            this.btn_picConvertToByte.Text = "转换";
            this.btn_picConvertToByte.UseVisualStyleBackColor = true;
            this.btn_picConvertToByte.Click += new System.EventHandler(this.btn_picConvertToByte_Click);
            // 
            // tb_picList
            // 
            this.tb_picList.Location = new System.Drawing.Point(8, 30);
            this.tb_picList.Multiline = true;
            this.tb_picList.Name = "tb_picList";
            this.tb_picList.Size = new System.Drawing.Size(457, 190);
            this.tb_picList.TabIndex = 1;
            // 
            // tb_picByteData
            // 
            this.tb_picByteData.Location = new System.Drawing.Point(8, 255);
            this.tb_picByteData.Multiline = true;
            this.tb_picByteData.Name = "tb_picByteData";
            this.tb_picByteData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_picByteData.Size = new System.Drawing.Size(457, 246);
            this.tb_picByteData.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_PicToByte);
            this.tabControl1.Controls.Add(this.tab_byteToPic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 535);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Tag = "";
            // 
            // tab_PicToByte
            // 
            this.tab_PicToByte.Controls.Add(this.btn_openDialog);
            this.tab_PicToByte.Controls.Add(this.label1);
            this.tab_PicToByte.Controls.Add(this.tb_picList);
            this.tab_PicToByte.Controls.Add(this.tb_picByteData);
            this.tab_PicToByte.Controls.Add(this.btn_picConvertToByte);
            this.tab_PicToByte.Location = new System.Drawing.Point(4, 22);
            this.tab_PicToByte.Name = "tab_PicToByte";
            this.tab_PicToByte.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PicToByte.Size = new System.Drawing.Size(473, 509);
            this.tab_PicToByte.TabIndex = 0;
            this.tab_PicToByte.Text = "图片转换";
            this.tab_PicToByte.UseVisualStyleBackColor = true;
            // 
            // tab_byteToPic
            // 
            this.tab_byteToPic.Location = new System.Drawing.Point(4, 22);
            this.tab_byteToPic.Name = "tab_byteToPic";
            this.tab_byteToPic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_byteToPic.Size = new System.Drawing.Size(473, 509);
            this.tab_byteToPic.TabIndex = 1;
            this.tab_byteToPic.Text = "图片浏览";
            this.tab_byteToPic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择上转换的图片：";
            // 
            // btn_openDialog
            // 
            this.btn_openDialog.Location = new System.Drawing.Point(390, 3);
            this.btn_openDialog.Name = "btn_openDialog";
            this.btn_openDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_openDialog.TabIndex = 4;
            this.btn_openDialog.Text = "浏览";
            this.btn_openDialog.UseVisualStyleBackColor = true;
            this.btn_openDialog.Click += new System.EventHandler(this.btn_openDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "照片转文档";
            this.tabControl1.ResumeLayout(false);
            this.tab_PicToByte.ResumeLayout(false);
            this.tab_PicToByte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPicDialog;
        private System.Windows.Forms.Button btn_picConvertToByte;
        private System.Windows.Forms.TextBox tb_picList;
        private System.Windows.Forms.TextBox tb_picByteData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_PicToByte;
        private System.Windows.Forms.TabPage tab_byteToPic;
        private System.Windows.Forms.Button btn_openDialog;
        private System.Windows.Forms.Label label1;
    }
}

