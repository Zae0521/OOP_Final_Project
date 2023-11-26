namespace OOP_Final_Project_Team3.Forms
{
	partial class frmEditUserInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUserInfo));
			txtUserID = new TextBox();
			txtPassword = new TextBox();
			txtFirst = new TextBox();
			txtLast = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			chkIsAdmin = new CheckBox();
			btnUpdateInfo = new Button();
			SuspendLayout();
			// 
			// txtUserID
			// 
			txtUserID.Enabled = false;
			txtUserID.Location = new Point(137, 23);
			txtUserID.Name = "txtUserID";
			txtUserID.Size = new Size(100, 23);
			txtUserID.TabIndex = 0;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(137, 52);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(100, 23);
			txtPassword.TabIndex = 1;
			// 
			// txtFirst
			// 
			txtFirst.Location = new Point(137, 81);
			txtFirst.Name = "txtFirst";
			txtFirst.Size = new Size(100, 23);
			txtFirst.TabIndex = 2;
			// 
			// txtLast
			// 
			txtLast.Location = new Point(137, 110);
			txtLast.Name = "txtLast";
			txtLast.Size = new Size(100, 23);
			txtLast.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(84, 26);
			label1.Name = "label1";
			label1.Size = new Size(47, 15);
			label1.TabIndex = 4;
			label1.Text = "User ID:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(71, 55);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 5;
			label2.Text = "Password:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(64, 84);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 6;
			label3.Text = "First Name:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(65, 113);
			label4.Name = "label4";
			label4.Size = new Size(66, 15);
			label4.TabIndex = 7;
			label4.Text = "Last Name:";
			// 
			// chkIsAdmin
			// 
			chkIsAdmin.AutoSize = true;
			chkIsAdmin.Enabled = false;
			chkIsAdmin.Location = new Point(109, 150);
			chkIsAdmin.Name = "chkIsAdmin";
			chkIsAdmin.Size = new Size(78, 19);
			chkIsAdmin.TabIndex = 9;
			chkIsAdmin.Text = "is Admin?";
			chkIsAdmin.UseVisualStyleBackColor = true;
			// 
			// btnUpdateInfo
			// 
			btnUpdateInfo.Image = Properties.Resources.refresh__1_;
			btnUpdateInfo.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdateInfo.Location = new Point(93, 181);
			btnUpdateInfo.Name = "btnUpdateInfo";
			btnUpdateInfo.Size = new Size(115, 30);
			btnUpdateInfo.TabIndex = 10;
			btnUpdateInfo.Text = "Update Info";
			btnUpdateInfo.UseVisualStyleBackColor = true;
			btnUpdateInfo.Click += btnUpdateInfo_Click;
			// 
			// frmEditUserInfo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(215, 192, 255);
			ClientSize = new Size(298, 266);
			Controls.Add(btnUpdateInfo);
			Controls.Add(chkIsAdmin);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtLast);
			Controls.Add(txtFirst);
			Controls.Add(txtPassword);
			Controls.Add(txtUserID);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmEditUserInfo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registration User Edit";
			Load += frmEditUserInfo_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUserID;
		private TextBox txtPassword;
		private TextBox txtFirst;
		private TextBox txtLast;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private CheckBox chkIsAdmin;
		private Button btnUpdateInfo;
	}
}