namespace WindowsFormsApp6
{
    partial class Form1
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
            this.Registration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_text_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_text_box = new System.Windows.Forms.TextBox();
            this.Registration_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Registration.Location = new System.Drawing.Point(68, 9);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(215, 39);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // name_text_box
            // 
            this.name_text_box.Location = new System.Drawing.Point(12, 103);
            this.name_text_box.Name = "name_text_box";
            this.name_text_box.Size = new System.Drawing.Size(120, 20);
            this.name_text_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lastName_text_box
            // 
            this.lastName_text_box.Location = new System.Drawing.Point(168, 103);
            this.lastName_text_box.Name = "lastName_text_box";
            this.lastName_text_box.Size = new System.Drawing.Size(173, 20);
            this.lastName_text_box.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // password_text_box
            // 
            this.password_text_box.Location = new System.Drawing.Point(91, 179);
            this.password_text_box.Name = "password_text_box";
            this.password_text_box.Size = new System.Drawing.Size(164, 20);
            this.password_text_box.TabIndex = 6;
            // 
            // Registration_button
            // 
            this.Registration_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Registration_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_button.Location = new System.Drawing.Point(104, 245);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(118, 36);
            this.Registration_button.TabIndex = 7;
            this.Registration_button.Text = "Registration";
            this.Registration_button.UseVisualStyleBackColor = false;
            this.Registration_button.Click += new System.EventHandler(this.Resgistration_button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 320);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.password_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_text_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName_text_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_text_box;
        private System.Windows.Forms.Button Registration_button;
    }
}

