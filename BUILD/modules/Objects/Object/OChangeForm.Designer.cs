using System.ComponentModel;

namespace BUILD.modules.objects
{
    partial class OChangeForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_area = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_id_user = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_id.Location = new System.Drawing.Point(12, 35);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(317, 30);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_title.Location = new System.Drawing.Point(12, 98);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(284, 30);
            this.textBox_title.TabIndex = 3;
            this.textBox_title.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_title_Validating);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id бригады";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id заказчика";
            // 
            // textBox_state
            // 
            this.textBox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_state.Location = new System.Drawing.Point(12, 346);
            this.textBox_state.MaxLength = 20;
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.Size = new System.Drawing.Size(318, 30);
            this.textBox_state.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Состояние";
            // 
            // textBox_area
            // 
            this.textBox_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_area.Location = new System.Drawing.Point(12, 283);
            this.textBox_area.MaxLength = 40;
            this.textBox_area.Name = "textBox_area";
            this.textBox_area.Size = new System.Drawing.Size(318, 30);
            this.textBox_area.TabIndex = 9;
            this.textBox_area.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_area_Validating);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Площадь";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_id_user
            // 
            this.comboBox_id_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_id_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_id_user.FormattingEnabled = true;
            this.comboBox_id_user.Location = new System.Drawing.Point(13, 161);
            this.comboBox_id_user.Name = "comboBox_id_user";
            this.comboBox_id_user.Size = new System.Drawing.Size(317, 33);
            this.comboBox_id_user.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // OChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 457);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox_id_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_state);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_area);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OChangeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ErrorProvider errorProvider2;

        private System.Windows.Forms.ComboBox comboBox_id_user;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;


        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_area;
        private System.Windows.Forms.TextBox textBox_state;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}