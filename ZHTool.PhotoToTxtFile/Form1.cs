using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using ZHTool.PhotoToTxtFile.Model;
using Newtonsoft.Json;

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
                
                tb_picByteData.Text += JsonConvert.SerializeObject(item) + "\r\n" + "\r\n";
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
        /// 将图片转换为二进制字符串,todo:需要确认二进制是否能转为字符串，
        /// </summary>
        /// <param name="picPaths"></param>
        /// <returns></returns>
        private List<MPicInfo> PicConvertToByte(List<string> picPaths) {
            List<MPicInfo> picInfoList = new List<MPicInfo>();
           
            foreach(var picPath in picPaths) {
                var picBytes =File.ReadAllBytes(picPath);
                var file = new FileInfo(picPath);
                picInfoList.Add(new MPicInfo { PicName = file.Name, PicBytes = picBytes });                
            }
            
            return picInfoList;
        }
    }
}
