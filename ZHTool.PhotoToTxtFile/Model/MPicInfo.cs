using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZHTool.PhotoToTxtFile.Model
{
    /// <summary>
    /// 图片信息
    /// </summary>
    public class MPicInfo
    {
        /// <summary>
        /// 图片名称
        /// </summary>
        public string PicName { get; set; }
        /// <summary>
        /// 图片二进制
        /// </summary>
        public byte[] PicBytes { get; set; }
        /// <summary>
        /// 图片内容加密密钥
        /// </summary>
        public string EncryKey { get; set; }
    }
}
