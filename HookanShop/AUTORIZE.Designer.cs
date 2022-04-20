
namespace HookanShop
{
    partial class AUTORIZE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.TBPASSWORDA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBLOGINA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HookanShop.Properties.Resources.КНОПКА_ВОЙТИ_АВТОРИЗАЦИЯ;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(399, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 70);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBPASSWORDA
            // 
            this.TBPASSWORDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPASSWORDA.Location = new System.Drawing.Point(398, 259);
            this.TBPASSWORDA.Multiline = true;
            this.TBPASSWORDA.Name = "TBPASSWORDA";
            this.TBPASSWORDA.PasswordChar = '*';
            this.TBPASSWORDA.Size = new System.Drawing.Size(273, 44);
            this.TBPASSWORDA.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(394, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "ПАРОЛЬ";
            // 
            // TBLOGINA
            // 
            this.TBLOGINA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLOGINA.Location = new System.Drawing.Point(397, 161);
            this.TBLOGINA.Multiline = true;
            this.TBLOGINA.Name = "TBLOGINA";
            this.TBLOGINA.Size = new System.Drawing.Size(273, 44);
            this.TBLOGINA.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(393, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "LOGIN";
            // 
            // AUTORIZE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HookanShop.Properties.Resources.AUTHORIZ;
            this.ClientSize = new System.Drawing.Size(1064, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBPASSWORDA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBLOGINA);
            this.Controls.Add(this.label7);
            this.Name = "AUTORIZE";
            this.Text = "AUTORIZE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBPASSWORDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBLOGINA;
        private System.Windows.Forms.Label label7;
    }
}