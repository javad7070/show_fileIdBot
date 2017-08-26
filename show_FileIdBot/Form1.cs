using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show_FileIdBot
{
    public partial class Form1 : Form
    {
        int run = 0;
        public Form1()
        {
            InitializeComponent();
            Telegram.bot.token = "393219959:AAFQDuFuHjqCV56_kSjByiUUoyfewm1xDxQ";
            backgroundWorker1.RunWorkerAsync();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void sendmessage(string CHatId, string TXT)
        {
            Telegram.bot.sendMessage.send(CHatId, TXT);
        }

        private void reply(string CHatId, string _TXT, string MId)
        {
            Telegram.bot.sendMessage.reply_to_message(CHatId, _TXT, MId);
        }
        private string msg()
        {
            return Telegram.bot.message_text;
        }
        private string Chat_ID()
        {
            return Telegram.bot.chat_id;
        }
        private string fileId()
        {
            return Telegram.bot.file_id;
        }
        private string msgid()
        {
            return Telegram.bot.message_id;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Telegram.bot.update = "True";
                richTextBox1.Text = Telegram.bot.update;
                if (Telegram.bot.update.Contains("private"))
                {
                    if (msg().ToLower() == "/start")
                    {
                        Telegram.bot.send_inline_keyboard.parse_mode = "html";
                        Telegram.bot.send_inline_keyboard.keyboard_R1_1 = "ورود به ربات♥️";
                        Telegram.bot.send_inline_keyboard.keyboard_R1_1_callback_data = "001";
                        Telegram.bot.send_inline_keyboard.keyboard_R2_1 = "کانال ما🗣";
                        Telegram.bot.send_inline_keyboard.keyboard_R2_1_Url = "https://t.me/SeniorTM";
                        Telegram.bot.send_inline_keyboard.keyboard_R2_2 = "پشتیبانی🌟";
                        Telegram.bot.send_inline_keyboard.keyboard_R2_2_Url = "https://t.me/cpp_cs";
                        Telegram.bot.send_inline_keyboard.send(Chat_ID(), "<b>سلام </b>" + "<b>"+ Telegram.bot.from_first_name+"</b>" + " " + "<b>🤠به ربات نمایش فایل ایدی سنیور خوش اومدی,برای نمایش فهرست دکمه ورود به ربات رو لمس کن💝</b>");
                    }
                    else if (Telegram.bot.data == "001")
                    {
                        Telegram.bot.editMessageInlinekeyboard.parse_mode = "html";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "استیکر🐻";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "002";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R1_2 = "فایل🦊";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R1_2_callback_data = "003";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1 = "آهنگ🐰";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1_callback_data = "004";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_2 = "صدا🐹";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_2_callback_data = "005";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R3_1 = "عکس🐱";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R3_1_callback_data = "006";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R3_2 = "ویدیو🐷";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R3_2_callback_data = "007";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R4_1 = "بازگشت🔙";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R4_1_callback_data = "008";
                        Telegram.bot.editMessageInlinekeyboard.send(Chat_ID(), msgid(), "<b>😜خب دوست عزیزم هر رسانه ای که میخوای فایل ایدیشو ببینی روی دکمش لمس کن و رسانه اونو برام بفرست😬توجه: گیف یک فایل به حساب میاد پس میتونی از دکمه فایل،فایل آیدیشو به دست بیاری‼️</b>");
                    }
                    else if (run == 1)
                    {
                        if (Telegram.bot.update.Contains("sticker"))
                        {
                            string JosonString = Telegram.bot.update.ToString();
                            string wid = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "width").ToString();
                            string hgt = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "height").ToString();
                            string size = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "file_size").ToString();
                            string emoji = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "emoji").ToString();
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>👤شناسه شما: </b>" + "<code>" + Chat_ID() + "</code>" + "\n" + "<b>🏵نوع رسانه: </b>" + "<b>استیکر</b>" + "\n" + "<b>▫️طول و عرض: </b>" + "<b>" + hgt + "</b>" + "<b>X</b>" + "<b>" + wid + "</b>"+"\n"+ "<b>🎈سایز: </b>"+"<b>"+size+"</b>" +"\n"+ "<b>😸ایموجی: </b>" +emoji+ "\n" + "<b>🌈فایل ایدی:</b>" + "<code>" + fileId() + "</code>", msgid());
                            run = 0;
                        }
                        else if (Telegram.bot.update.Contains("callback_query"))
                        {
                            sendmessage(Chat_ID(), "<b>خطا❕لطفا هنگام انجام عملیات روی دکمه های دیگر کلیک نکنید:) عملیات فعلی لغو شد لطفا مجددا امتحان کنید😐</b>");
                            run = 0;
                        }
                        else
                        {
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>رسانه ارسال شده یک استیکر نیست❌</b>", msgid());
                            run = 0;
                        }
                    }
                    else if (run == 2)
                    {
                        if (Telegram.bot.update.Contains("document"))
                        {
                            string JosonString = Telegram.bot.update.ToString();
                            string name = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "file_name").ToString();
                            string size = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "file_size").ToString();
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>👤شناسه شما: </b>" + "<code>" + Chat_ID() + "</code>" + "\n" + "<b>🏵نوع رسانه: </b>" + "<b>فایل</b>" + "\n" + "<b>🎈سایز: </b>" + "<b>" + size + "</b>"+"\n"+"<b>🔅نام فایل: </b> "+"<b>"+name+"</b>"+"\n" + "<b>🌈فایل ایدی:</b>" + "<code>" + fileId() + "</code>", msgid());
                            run = 0;
                        }
                        else if (Telegram.bot.update.Contains("callback_query"))
                        {
                            sendmessage(Chat_ID(), "<b>خطا❕لطفا هنگام انجام عملیات روی دکمه های دیگر کلیک نکنید:) عملیات فعلی لغو شد لطفا مجددا امتحان کنید😐</b>");
                            run = 0;
                        }
                        else
                        {
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>رسانه ارسال شده یک فایل نیست❌</b>", msgid());
                            run = 0;
                        }
                    }
                    else if (run == 3)
                    {
                        if (Telegram.bot.update.Contains("audio"))
                        {
                            string JosonString = Telegram.bot.update.ToString();
                            string fname = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "title").ToString();
                            string size = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "file_size").ToString();
                            string du = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "duration").ToString();
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>👤شناسه شما: </b>" + "<code>" + Chat_ID() + "</code>" + "\n" + "<b>🏵نوع رسانه: </b>" + "<b>آهنگ</b>" + "\n" + "<b>🎈سایز: </b>" + "<b>" + size + "</b>" +"\n"+ "<b>🎧نام آهنگ: </b>"+"<b>"+fname+"</b>"+"\n"+ "<b>🕰زمان:  </b>" + "<b>" + du + "</b>" + "\n"+ "<b>🌈فایل ایدی:</b>" + "<code>" + fileId() + "</code>", msgid());
                            run = 0;
                        }
                        else if (Telegram.bot.update.Contains("callback_query"))
                        {
                            sendmessage(Chat_ID(), "<b>خطا❕لطفا هنگام انجام عملیات روی دکمه های دیگر کلیک نکنید:) عملیات فعلی لغو شد لطفا مجددا امتحان کنید😐</b>");
                            run = 0;
                        }
                        else
                        {
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>رسانه ارسال شده یک آهنگ نیست❌</b>", msgid());
                            run = 0;
                        }
                    }
                    else if (run == 4)
                    {
                        if (Telegram.bot.update.Contains("voice"))
                        {
                            string JosonString = Telegram.bot.update.ToString();
                            string size = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "file_size").ToString();
                            string du = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "duration").ToString();
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>👤شناسه شما: </b>" + "<code>" + Chat_ID() + "</code>" + "\n" + "<b>🏵نوع رسانه: </b>" + "<b>صدا</b>" +"\n"+ "<b>🎈سایز: </b>" + "<b>" + size + "</b>" + "\n"+ "<b>🕰زمان:  </b>" + "<b>" + du + "</b>"+"\n" + "<b>🌈فایل ایدی:</b>" + "<code>" + fileId() + "</code>", msgid());
                            run = 0;
                        }
                        else if (Telegram.bot.update.Contains("callback_query"))
                        {
                            sendmessage(Chat_ID(), "<b>خطا❕لطفا هنگام انجام عملیات روی دکمه های دیگر کلیک نکنید:) عملیات فعلی لغو شد لطفا مجددا امتحان کنید😐</b>");
                            run = 0;
                        }
                        else
                        {
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>رسانه ارسال شده یک صدا نیست❌</b>", msgid());
                            run = 0;
                        }
                    }
                    else if (run == 5)
                    {
                        if (Telegram.bot.update.Contains("photo"))
                        {
                            string JosonString = Telegram.bot.update.ToString();
                            string size = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "file_size").ToString();
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>👤شناسه شما: </b>" + "<code>" + Chat_ID() + "</code>" + "\n" +"<b>🎈سایز: </b>" + "<b>" + size + "</b>"+"\n" + "<b>🏵نوع رسانه: </b>" + "<b>عکس</b>" + "\n" + "<b>🌈فایل ایدی:</b>" + "<code>" + fileId() + "</code>", msgid());
                            run = 0;
                        }
                        else if (Telegram.bot.update.Contains("callback_query"))
                        {
                            sendmessage(Chat_ID(), "<b>خطا❕لطفا هنگام انجام عملیات روی دکمه های دیگر کلیک نکنید:) عملیات فعلی لغو شد لطفا مجددا امتحان کنید😐</b>");
                            run = 0;
                        }
                        else 
                        {
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>رسانه ارسال شده یک عکس نیست❌</b>", msgid());
                            run = 0;
                        }
                    }
                    else if (run == 6)
                    {
                        if (Telegram.bot.update.Contains("video"))
                        {
                            string JosonString = Telegram.bot.update.ToString();
                            string du = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "duration").ToString();
                            string wid = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "width").ToString();
                            string hgt = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "height").ToString();
                            string size = Telegram.JSON.Read.get_JSONRead(JosonString, "result", "file_size").ToString();
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>👤شناسه شما: </b>" + "<code>" + Chat_ID() + "</code>" + "\n" + "<b>🏵نوع رسانه: </b>" + "<b>ویدیو</b>" + "\n" + "<b>▫️طول و عرض: </b>" + "<b>" + hgt + "</b>" + "<b>X</b>" + "<b>" + wid + "</b>" + "\n" + "<b>🎈سایز: </b>" + "<b>" + size + "</b>"+"\n"+ "<b>🕰زمان:  </b>"+"<b>"+du+"</b>"+"\n" + "<b>🌈فایل ایدی:</b>" + "<code>" + fileId() + "</code>", msgid());
                            run = 0;
                        }
                        else if(Telegram.bot.update.Contains("callback_query"))
                        {
                            sendmessage(Chat_ID(), "<b>خطا❕لطفا هنگام انجام عملیات روی دکمه های دیگر کلیک نکنید:) عملیات فعلی لغو شد لطفا مجددا امتحان کنید😐</b>");
                            run = 0;
                        }
                        else
                        {
                            Telegram.bot.sendMessage.parse_mode = "html";
                            reply(Chat_ID(), "<b>رسانه ارسال شده یک ویدیو نیست❌</b>", msgid());
                            run = 0;
                        }
                    }
                    else if (Telegram.bot.data == "002")
                    {
                        Telegram.bot.sendMessage.parse_mode = "html";
                        reply(Chat_ID(), "<b>خب حالا یک استیکر برام ارسال کن😆</b>", msgid());
                        string txt = msg();
                        txt = null;
                        run++;
                    }
                    else if (Telegram.bot.data == "003")
                    {
                        Telegram.bot.sendMessage.parse_mode = "html";
                        reply(Chat_ID(), "<b>خب حالا یک فایل برام ارسال کن😆</b>", msgid());
                        string txt = msg();
                        txt = null;
                        run += 2;
                    }
                    else if (Telegram.bot.data == "004")
                    {
                        Telegram.bot.sendMessage.parse_mode = "html";
                        reply(Chat_ID(), "<b>خب حالا یک آهنگ برام ارسال کن😆</b>", msgid());
                        string txt = msg();
                        txt = null;
                        run += 3;
                    }
                    else if (Telegram.bot.data == "005")
                    {
                        Telegram.bot.sendMessage.parse_mode = "html";
                        reply(Chat_ID(), "<b>خب حالا یک صدا برام ارسال کن😆</b>", msgid());
                        string txt = msg();
                        txt = null;
                        run += 4;
                    }
                    else if (Telegram.bot.data == "006")
                    {
                        Telegram.bot.sendMessage.parse_mode = "html";
                        reply(Chat_ID(), "<b>خب حالا یک عکس برام ارسال کن😆</b>", msgid());
                        string txt = msg();
                        txt = null;
                        run += 5;
                    }
                    else if (Telegram.bot.data == "007")
                    {
                        Telegram.bot.sendMessage.parse_mode = "html";
                        reply(Chat_ID(), "<b>خب حالا یک ویدیو برام ارسال کن😆</b>", msgid());
                        string txt = msg();
                        txt = null;
                        run += 6;
                    }
                    else if (Telegram.bot.data == "008")
                    {
                        Telegram.bot.editMessageInlinekeyboard.parse_mode = "html";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1 = "ورود به ربات♥️";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "001";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1 = "کانال ما🗣";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_1_Url = "https://t.me/SeniorTM";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_2 = "پشتیبانی🌟";
                        Telegram.bot.editMessageInlinekeyboard.keyboard_R2_2_Url = "https://t.me/cpp_cs";
                        Telegram.bot.editMessageInlinekeyboard.send(Chat_ID(),msgid(), "<b>سلام </b>" + "<b>" + Telegram.bot.from_first_name + "</b>" + " " + "<b>🤠به ربات نمایش فایل ایدی سنیور خوش اومدی,برای نمایش فهرست دکمه ورود به ربات رو لمس کن💝</b>");
                    }
                    else
                    {
                        sendmessage(Chat_ID(), Telegram.bot.update);
                    }
                    }
            }
        }

        private void prorammer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":طراح و برنامه نویس" + "\n" + "جوادمحمدی", "درباره", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void call_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/cpp_cs");
        }

        private void ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
