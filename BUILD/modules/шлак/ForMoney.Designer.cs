using System.ComponentModel;

namespace BUILD.modules
{
    partial class ForMoney
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForMoney));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_name_surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_time_2 = new System.Windows.Forms.TextBox();
            this.textBox_time_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_card_number = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_message = new System.Windows.Forms.Label();
            this.button_send_money = new System.Windows.Forms.Button();
            this.textBox_cccv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BUILD.Properties.Resources.horMan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox_name_surname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_time_2);
            this.panel1.Controls.Add(this.textBox_time_1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_card_number);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 291);
            this.panel1.TabIndex = 0;
            // 
            // textBox_name_surname
            // 
            this.textBox_name_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox_name_surname.Location = new System.Drawing.Point(29, 228);
            this.textBox_name_surname.Name = "textBox_name_surname";
            this.textBox_name_surname.Size = new System.Drawing.Size(359, 30);
            this.textBox_name_surname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя и Фамилия владельца карты";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(69, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // textBox_time_2
            // 
            this.textBox_time_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox_time_2.Location = new System.Drawing.Point(91, 144);
            this.textBox_time_2.MaxLength = 2;
            this.textBox_time_2.Name = "textBox_time_2";
            this.textBox_time_2.Size = new System.Drawing.Size(34, 30);
            this.textBox_time_2.TabIndex = 4;
            // 
            // textBox_time_1
            // 
            this.textBox_time_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox_time_1.Location = new System.Drawing.Point(29, 144);
            this.textBox_time_1.MaxLength = 2;
            this.textBox_time_1.Name = "textBox_time_1";
            this.textBox_time_1.Size = new System.Drawing.Size(34, 30);
            this.textBox_time_1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Срок действия";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер карты";
            // 
            // textBox_card_number
            // 
            this.textBox_card_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_card_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox_card_number.Location = new System.Drawing.Point(29, 65);
            this.textBox_card_number.MaxLength = 19;
            this.textBox_card_number.Name = "textBox_card_number";
            this.textBox_card_number.Size = new System.Drawing.Size(359, 30);
            this.textBox_card_number.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label_message);
            this.panel2.Controls.Add(this.button_send_money);
            this.panel2.Controls.Add(this.textBox_cccv);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(417, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 291);
            this.panel2.TabIndex = 1;
            // 
            // label_message
            // 
            this.label_message.BackColor = System.Drawing.Color.Transparent;
            this.label_message.ForeColor = System.Drawing.Color.Red;
            this.label_message.Location = new System.Drawing.Point(11, 200);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(198, 23);
            this.label_message.TabIndex = 3;
            // 
            // button_send_money
            // 
            this.button_send_money.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_send_money.Location = new System.Drawing.Point(11, 230);
            this.button_send_money.Name = "button_send_money";
            this.button_send_money.Size = new System.Drawing.Size(198, 30);
            this.button_send_money.TabIndex = 2;
            this.button_send_money.Text = "дать деняг";
            this.button_send_money.UseVisualStyleBackColor = false;
            this.button_send_money.Click += new System.EventHandler(this.button_send_money_Click);
            // 
            // textBox_cccv
            // 
            this.textBox_cccv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox_cccv.Location = new System.Drawing.Point(37, 157);
            this.textBox_cccv.MaxLength = 3;
            this.textBox_cccv.Name = "textBox_cccv";
            this.textBox_cccv.Size = new System.Drawing.Size(61, 30);
            this.textBox_cccv.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "CVC/CVV";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(417, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 51);
            this.panel3.TabIndex = 0;
            // 
            // ForMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 291);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТРОЙ! Перевод деньга";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label_message;

        private System.Windows.Forms.Button button_send_money;

        private System.Windows.Forms.TextBox textBox_cccv;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox textBox_name_surname;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBox_time_2;

        private System.Windows.Forms.TextBox textBox_time_1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox_card_number;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}