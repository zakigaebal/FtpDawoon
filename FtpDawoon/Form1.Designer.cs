﻿namespace FtpDawoon
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(573, 319);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 21);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Host";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(66, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 21);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "User";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(66, 28);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 21);
			this.textBox2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "Start Dir";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(66, 50);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(336, 21);
			this.textBox3.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(420, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "Port";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(451, 3);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 21);
			this.textBox4.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(230, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "Password";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(302, 28);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 21);
			this.textBox5.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 12);
			this.label6.TabIndex = 1;
			this.label6.Text = "Remote Host";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(12, 89);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(539, 251);
			this.textBox6.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(552, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 20);
			this.button2.TabIndex = 3;
			this.button2.Text = "Login";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(552, 22);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(73, 20);
			this.button3.TabIndex = 3;
			this.button3.Text = "Logout";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(446, 71);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(105, 16);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Passive Mode";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(552, 41);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(73, 27);
			this.button4.TabIndex = 3;
			this.button4.Text = "Open Dir";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(552, 67);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(73, 27);
			this.button5.TabIndex = 3;
			this.button5.Text = "Go Up";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(552, 93);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(73, 27);
			this.button6.TabIndex = 3;
			this.button6.Text = "Download";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(552, 119);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(73, 27);
			this.button7.TabIndex = 3;
			this.button7.Text = "Upload";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 343);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "FtpClient";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
	}
}

