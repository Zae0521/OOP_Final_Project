﻿namespace OOP_Final_Project_Team3.Forms
{
	partial class frmRegister
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtLastName = new TextBox();
			txtFrstName = new TextBox();
			txtPass = new TextBox();
			txtUser = new TextBox();
			btnRegister = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(393, 73);
			label1.Name = "label1";
			label1.Size = new Size(68, 15);
			label1.TabIndex = 0;
			label1.Text = "User Name:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(401, 113);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 1;
			label2.Text = "Password:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(394, 153);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 2;
			label3.Text = "First Name:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(395, 193);
			label4.Name = "label4";
			label4.Size = new Size(66, 15);
			label4.TabIndex = 3;
			label4.Text = "Last Name:";
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(467, 190);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(100, 23);
			txtLastName.TabIndex = 3;
			// 
			// txtFrstName
			// 
			txtFrstName.Location = new Point(467, 150);
			txtFrstName.Name = "txtFrstName";
			txtFrstName.Size = new Size(100, 23);
			txtFrstName.TabIndex = 2;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(467, 110);
			txtPass.Name = "txtPass";
			txtPass.Size = new Size(100, 23);
			txtPass.TabIndex = 1;
			// 
			// txtUser
			// 
			txtUser.Location = new Point(467, 70);
			txtUser.Name = "txtUser";
			txtUser.Size = new Size(100, 23);
			txtUser.TabIndex = 0;
			// 
			// btnRegister
			// 
			btnRegister.Location = new Point(439, 247);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(75, 23);
			btnRegister.TabIndex = 4;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// frmRegister
			// 
			AcceptButton = btnRegister;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnRegister);
			Controls.Add(txtUser);
			Controls.Add(txtPass);
			Controls.Add(txtFrstName);
			Controls.Add(txtLastName);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmRegister";
			Text = "frmRegister";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtLastName;
		private TextBox txtFrstName;
		private TextBox txtPass;
		private TextBox txtUser;
		private Button btnRegister;
	}
}