using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SAICVolkswagenVehicleManagementUI.Common
{
    
    public class MailVeriCodeClass
    {
        #region 邮箱验证码功能
        /// <summary>
        /// 随机邮箱验证码
        /// </summary>
        /// <param name="CodeLength">共几位数</param>
        /// <returns></returns>
        public static string CreateRandomMailCode(int CodeLength)
        {
            int randNum;
            char code;
            string randomCode = string.Empty;
            for (int i = 0; i < CodeLength; i++)
            {
                //生成字节数组
                byte[] buffer = Guid.NewGuid().ToByteArray();
                //利用BitConvert方法把字节数组转换成整数
                int seed = BitConverter.ToInt32(buffer, 0);
                //生成的整数作为随机种子
                Random random = new Random(seed);
                randNum = random.Next();
                if(randNum % 3 == 1)
                {
                    code = (char)('A' + (char)(randNum % 26));
                }
                else if(randNum % 3 == 2)
                {
                    code = (char)('a' + (char)(randNum % 26));
                }
                else
                {
                    code = (char)('0' + (char)(randNum % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }
        /// <summary>
        /// 发送邮件验证码
        /// </summary>
        /// <param name="MyEmailAddress"></param>
        /// <param name="RecEmailAddress"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <param name="AuthorizationCode"></param>
        /// <returns></returns>
        public static bool SendMailMessage(string MyEmailAddress, string RecEmailAddress, string Subject, string Body, string AuthorizationCode)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(MyEmailAddress);//发件人邮箱地址
            mail.To.Add(new MailAddress(RecEmailAddress));//收件人邮箱地址;
            mail.Subject = Subject;//邮件标题
            mail.Body = Body;//邮件内容
            mail.Priority = MailPriority.High;//优先级
            SmtpClient client = new SmtpClient(); //QQ邮箱：smtp.qq.com;126邮箱：smtp.126.com
            client.Host = "smtp.qq.com";
            client.Port = 587;//smtp端口号465或587;
            client.EnableSsl = true;//使用安全加密SSL连接
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(MyEmailAddress, AuthorizationCode);
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"发送失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
            return true;
        }
        /// <summary>
        /// 验证QQ邮箱
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static bool CheckMail(string mail)
        {
            string str = @"^[1-9][0-9]{4,}@qq.com$";
            Regex mReg = new Regex(str);
            if(mReg.IsMatch(mail))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
