using System.ComponentModel;
using System.Windows.Forms;

namespace BUILD.modules.objects
{
    partial class WInsertForm
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_speciality = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_lvl = new System.Windows.Forms.NumericUpDown();
            this.button_change = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown_lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_name.Location = new System.Drawing.Point(12, 96);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(282, 30);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_surname.Location = new System.Drawing.Point(12, 157);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(282, 30);
            this.textBox_surname.TabIndex = 5;
            this.textBox_surname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_surname_Validating);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // textBox_speciality
            // 
            this.textBox_speciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_speciality.Location = new System.Drawing.Point(12, 218);
            this.textBox_speciality.Name = "textBox_speciality";
            this.textBox_speciality.Size = new System.Drawing.Size(282, 30);
            this.textBox_speciality.TabIndex = 7;
            this.textBox_speciality.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_speciality_Validating);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Специальность";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Уровень";
            // 
            // numericUpDown_lvl
            // 
            this.numericUpDown_lvl.Location = new System.Drawing.Point(116, 257);
            this.numericUpDown_lvl.Maximum = new decimal(new int[] {15, 0, 0, 0});
            this.numericUpDown_lvl.Name = "numericUpDown_lvl";
            this.numericUpDown_lvl.Size = new System.Drawing.Size(213, 22);
            this.numericUpDown_lvl.TabIndex = 9;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(12, 311);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(317, 37);
            this.button_change.TabIndex = 10;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id бригады";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // WInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 370);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.numericUpDown_lvl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_speciality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WInsertForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown_lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textBox_speciality;

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;

        private System.Windows.Forms.NumericUpDown numericUpDown_lvl;
        private System.Windows.Forms.Button button_change;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;

        #endregion
    }
}