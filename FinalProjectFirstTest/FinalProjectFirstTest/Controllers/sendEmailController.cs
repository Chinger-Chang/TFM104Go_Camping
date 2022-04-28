using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.AspNetCore.Hosting;
using FinalProjectFirstTest.Models;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace FinalProjectFirstTest.Controllers
{
    public class SendEmailController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly FinalProjectDbContext _db;
        public SendEmailController(IWebHostEnvironment environment, FinalProjectDbContext db)
        {
            _environment = environment;
            _db = db;
        }
        // 忘記密碼 ==> 寄信
        [HttpPost]
        public ActionResult forgetPassword([FromBody] receiveEmailViewModel model)
        {
            // 寄給誰
            var mails = new string[] { model.Email };
            dynamic thisUser;
            // res為(亂數+字元)生成的新密碼
            var randomPassword = new RNGCryptoServiceProvider();
            var bytesarray = new byte[55 / 8];
            randomPassword.GetBytes(bytesarray);
            var res = Convert.ToBase64String(bytesarray);
            Console.WriteLine(res);

            // 新密碼加鹽雜湊存進此user密碼欄位
            if (User.IsInRole("User"))
			{
                thisUser = _db.Users.FirstOrDefault(x => x.Email == model.Email);
            }
            else
			{
                thisUser = _db.Sellers.FirstOrDefault(x => x.Email == model.Email);
            }
            var thisUserSalt = thisUser.Salt;
            byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(res + thisUserSalt);
            byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
            string hashString = Convert.ToBase64String(hashBytes);
            thisUser.Password = hashString;
            _db.SaveChanges();


            var mailhelper = new MailHelper();
            mailhelper.CreateMail(mails, "忘記密碼????", "您的新密碼為 : " + res);
            mailhelper.Send();

            // ????
            return Json(Url.Action("register", "Buyer"));
        }
        private class MailHelper
        {
            private MailMessage mail;
            private readonly SmtpClient client;

            public MailHelper()
            {
                client = new SmtpClient("smtp.gmail.com", 587);
            }
            public MailHelper(MailMessage mail)
            {
                client = new SmtpClient("smtp.gmail.com", 587);
                this.mail = mail;
            }

            public bool Send()
            {
                client.Credentials = new System.Net.NetworkCredential("tfm104Camping@gmail.com", "ejaskltxfifavthk");
                client.EnableSsl = true;
                client.Send(mail);
                return true;
            }

            public void CreateMail(string[] to, string subject, string body)
            {
                var mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("tfm104Camping@gmail.com");
                foreach (var item in to)
                {
                    mail.To.Add(item);
                }
                mail.Subject = subject;
                mail.Body = body;

                this.mail = mail;
            }

        }
        // 註冊 ==> 開通帳號 ==> 寄開通信
        public ActionResult GetEmail(receiveEmailViewModel model)
        {
            // 寄給誰
            var mails = new string[] { model.Email };
            // 對email加密
            var secretcodeMail = Encrypt(model.Email + "&y=true");

            var mailhelper = new MailHelper();
            mailhelper.CreateMail(mails, "驗證信箱", "您好，請點擊以下網址註冊 : " + "https://localhost:5001/sendEmail/get?d=" + secretcodeMail);
            mailhelper.Send();

            return Content("信已寄出");
        }
        // 拿secretcodeMail回來解密 ==> email和帳號相同 ==> 同一人
        [HttpGet()]
        public async Task<IActionResult> Get([FromQuery] string d)
        {
            // 對email解密
            string userMail = Decrypt(d);
            string[] sArray = userMail.Split("&");
            string mailString = sArray[0];
            var mail = mailString;
            dynamic x;

            if (User.IsInRole("User"))
            {
                x = _db.Users.Where(x => x.Email == mail).FirstOrDefault();
            }
            else
            {
                x = _db.Sellers.Where(x => x.Email == mail).FirstOrDefault();
            }
           
            if (x != null)
            {
                x.IsMailConfirm = true;
                await _db.SaveChangesAsync();
            }
            return Content("帳號已開通");
        }
        static string encryptKey = "abcd";
        private string Decrypt(string str) // 解密字符串
        {
            try
            {
                str = str.Replace(' ', '+');
                byte[] key = Encoding.Unicode.GetBytes(encryptKey); // 密鑰
                byte[] data = Convert.FromBase64String(str); // 待解密字符串

                DESCryptoServiceProvider descsp = new DESCryptoServiceProvider(); //加密、解密對象
                MemoryStream MStream = new MemoryStream(); //內存流對象

                // 用內存流實例化解密流對象
                CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);
                CStream.Write(data, 0, data.Length); // 向加密流中寫入數據
                CStream.FlushFinalBlock(); // 將數據壓入基礎流
                byte[] temp = MStream.ToArray(); // 從內存流中獲取字節序列
                CStream.Close(); // 關閉加密流
                MStream.Close(); // 關閉內存流

                return Encoding.Unicode.GetString(temp); // 返回解密後的字符串
		}
				catch
				{
				    return str;
				}
}
		private string Encrypt(string str) // 加密字符串
        {
            try
            {
                byte[] key = Encoding.Unicode.GetBytes(encryptKey); // 密鑰
                byte[] data = Encoding.Unicode.GetBytes(str); // 待加密字符串

                DESCryptoServiceProvider descsp = new DESCryptoServiceProvider(); // 加密、解密對象
                MemoryStream MStream = new MemoryStream(); // 內存流對象

                // 用內存流實例化加密流對象
                CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);
                CStream.Write(data, 0, data.Length); // 向加密流中寫入數據
                CStream.FlushFinalBlock(); // 將數據壓入基礎流
                byte[] temp = MStream.ToArray(); // 從內存流中獲取字節序列
                CStream.Close(); // 關閉加密流
                MStream.Close(); // 關閉內存流

                return Convert.ToBase64String(temp); // 返回加密後的字符串
            }
            catch
            {
                return str;
            }
        }
    }
    public class receiveEmailViewModel
    {
        public string Email { get; set; }
    }
}
