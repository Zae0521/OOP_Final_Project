namespace OOP_Final_Project_Team3
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			btnLogin = new Button();
			label1 = new Label();
			label2 = new Label();
			txtUser = new TextBox();
			txtPass = new TextBox();
			lblRegister = new Label();
			SuspendLayout();
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(107, 138);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 23);
			btnLogin.TabIndex = 0;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(60, 56);
			label1.Name = "label1";
			label1.Size = new Size(68, 15);
			label1.TabIndex = 1;
			label1.Text = "User Name:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(68, 88);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 2;
			label2.Text = "Password:";
			// 
			// txtUser
			// 
			txtUser.Location = new Point(135, 53);
			txtUser.Name = "txtUser";
			txtUser.Size = new Size(100, 23);
			txtUser.TabIndex = 3;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(134, 85);
			txtPass.Name = "txtPass";
			txtPass.PasswordChar = '*';
			txtPass.Size = new Size(100, 23);
			txtPass.TabIndex = 4;
			// 
			// lblRegister
			// 
			lblRegister.AutoSize = true;
			lblRegister.Cursor = Cursors.Hand;
			lblRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
			lblRegister.ForeColor = SystemColors.Highlight;
			lblRegister.Location = new Point(84, 183);
			lblRegister.Name = "lblRegister";
			lblRegister.Size = new Size(120, 15);
			lblRegister.TabIndex = 5;
			lblRegister.Text = "Click Here to Register";
			lblRegister.Click += lblRegister_Click;
			// 
			// frmLogin
			// 
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(215, 192, 255);
			ClientSize = new Size(303, 257);
			Controls.Add(lblRegister);
			Controls.Add(txtPass);
			Controls.Add(txtUser);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnLogin);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registration Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogin;
		private Label label1;
		private Label label2;
		private TextBox txtUser;
		private TextBox txtPass;
		private Label lblRegister;
	}
}