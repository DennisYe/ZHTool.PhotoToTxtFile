using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZHTool.PhotoToTxtFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_picConvertToByte_Click(object sender, EventArgs e)
        {
            string filePaths = tb_picList.Text;
            if (string.IsNullOrEmpty(filePaths)) {
                return;
            }
            string[] splitStr = { "\r\n" };
            List<string> fileList = filePaths.Split(splitStr, StringSplitOptions.RemoveEmptyEntries).ToList();
            var resultList = PicConvertToByte(fileList);
            foreach (var item in resultList) {
                tb_picByteData.Text += item + "\r\n" + "\r\n";
            }
        }

        private void btn_openDialog_Click(object sender, EventArgs e)
        {
            List<string> filePaths = new List<string>();
            if (openPicDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openPicDialog.FileNames.ToList();
                foreach(var item in filePaths)
                {
                    tb_picList.Text += item+"\r\n";
                }
                
            }            
        }
        /// <summary>
        /// 将图片转换为二进制字符串,todo:需要确认二进制是否能转为字符串，同时文件路径只允许图片
        /// </summary>
        /// <param name="picPaths"></param>
        /// <returns></returns>
        private List<string> PicConvertToByte(List<string> picPaths) {
            return null;
        }
    }
}
