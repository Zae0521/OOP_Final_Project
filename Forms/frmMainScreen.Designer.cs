namespace OOP_Final_Project_Team3
{
	partial class frmMainScreen
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
			btnUpdateUser = new Button();
			btnAddDropCourse = new Button();
			btnEditCourses = new Button();
			SuspendLayout();
			// 
			// btnUpdateUser
			// 
			btnUpdateUser.Location = new Point(124, 107);
			btnUpdateUser.Name = "btnUpdateUser";
			btnUpdateUser.Size = new Size(160, 23);
			btnUpdateUser.TabIndex = 1;
			btnUpdateUser.Text = "Update User Information";
			btnUpdateUser.UseVisualStyleBackColor = true;
			btnUpdateUser.Visible = false;
			// 
			// btnAddDropCourse
			// 
			btnAddDropCourse.Location = new Point(302, 107);
			btnAddDropCourse.Name = "btnAddDropCourse";
			btnAddDropCourse.Size = new Size(148, 23);
			btnAddDropCourse.TabIndex = 2;
			btnAddDropCourse.Text = "Add/Drop Courses";
			btnAddDropCourse.UseVisualStyleBackColor = true;
			btnAddDropCourse.Visible = false;
			// 
			// btnEditCourses
			// 
			btnEditCourses.Location = new Point(205, 149);
			btnEditCourses.Name = "btnEditCourses";
			btnEditCourses.Size = new Size(172, 23);
			btnEditCourses.TabIndex = 3;
			btnEditCourses.Text = "Edit Courses";
			btnEditCourses.UseVisualStyleBackColor = true;
			btnEditCourses.Visible = false;
			// 
			// frmMainScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnEditCourses);
			Controls.Add(btnAddDropCourse);
			Controls.Add(btnUpdateUser);
			Name = "frmMainScreen";
			Text = "Form1";
			Load += frmMainScreen_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnUpdateUser;
		private Button btnAddDropCourse;
		private Button btnEditCourses;
	}
}