
namespace HookanShop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BCREATER = new System.Windows.Forms.Button();
            this.TBLNAMER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBFNAMER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BLOGINR = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TBPASSWORDR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBLOGINR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCREATER
            // 
            this.BCREATER.BackgroundImage = global::HookanShop.Properties.Resources.button_создать;
            this.BCREATER.FlatAppearance.BorderSize = 0;
            this.BCREATER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCREATER.Location = new System.Drawing.Point(397, 365);
            this.BCREATER.Name = "BCREATER";
            this.BCREATER.Size = new System.Drawing.Size(273, 70);
            this.BCREATER.TabIndex = 16;
            this.BCREATER.UseVisualStyleBackColor = true;
            this.BCREATER.Click += new System.EventHandler(this.BCREATER_Click);
            // 
            // TBLNAMER
            // 
            this.TBLNAMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLNAMER.Location = new System.Drawing.Point(398, 278);
            this.TBLNAMER.Multiline = true;
            this.TBLNAMER.Name = "TBLNAMER";
            this.TBLNAMER.Size = new System.Drawing.Size(273, 44);
            this.TBLNAMER.TabIndex = 15;
            this.TBLNAMER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(394, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "ФАМИЛИЯ";
            // 
            // TBFNAMER
            // 
            this.TBFNAMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBFNAMER.Location = new System.Drawing.Point(397, 180);
            this.TBFNAMER.Multiline = true;
            this.TBFNAMER.Name = "TBFNAMER";
            this.TBFNAMER.Size = new System.Drawing.Size(273, 44);
            this.TBFNAMER.TabIndex = 13;
            this.TBFNAMER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(393, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "ИМЯ";
            // 
            // BLOGINR
            // 
            this.BLOGINR.BackgroundImage = global::HookanShop.Properties.Resources.БАТОН_ВОЙТИ;
            this.BLOGINR.FlatAppearance.BorderSize = 0;
            this.BLOGINR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLOGINR.Location = new System.Drawing.Point(780, 365);
            this.BLOGINR.Name = "BLOGINR";
            this.BLOGINR.Size = new System.Drawing.Size(195, 47);
            this.BLOGINR.TabIndex = 22;
            this.BLOGINR.UseVisualStyleBackColor = true;
            this.BLOGINR.Click += new System.EventHandler(this.BLOGINR_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(697, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Если есть\r\nаккаунт\r\n";
            // 
            // TBPASSWORDR
            // 
            this.TBPASSWORDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPASSWORDR.Location = new System.Drawing.Point(703, 278);
            this.TBPASSWORDR.Multiline = true;
            this.TBPASSWORDR.Name = "TBPASSWORDR";
            this.TBPASSWORDR.Size = new System.Drawing.Size(273, 44);
            this.TBPASSWORDR.TabIndex = 20;
            this.TBPASSWORDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(699, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "ПАРОЛЬ";
            // 
            // TBLOGINR
            // 
            this.TBLOGINR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLOGINR.Location = new System.Drawing.Point(702, 180);
            this.TBLOGINR.Multiline = true;
            this.TBLOGINR.Name = "TBLOGINR";
            this.TBLOGINR.Size = new System.Drawing.Size(273, 44);
            this.TBLOGINR.TabIndex = 18;
            this.TBLOGINR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(698, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "LOGIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HookanShop.Properties.Resources.REGISTR;
            this.ClientSize = new System.Drawing.Size(1064, 491);
            this.Controls.Add(this.BLOGINR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBPASSWORDR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBLOGINR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BCREATER);
            this.Controls.Add(this.TBLNAMER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBFNAMER);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCREATER;
        private System.Windows.Forms.TextBox TBLNAMER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBFNAMER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BLOGINR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBPASSWORDR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBLOGINR;
        private System.Windows.Forms.Label label7;
    }
}

