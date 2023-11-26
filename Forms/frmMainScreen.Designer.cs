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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
			btnUpdateUser = new Button();
			btnAddDropCourse = new Button();
			btnEditCourses = new Button();
			btnEditStudentSchedule = new Button();
			btnUpdateStudent = new Button();
			SuspendLayout();
			// 
			// btnUpdateUser
			// 
			btnUpdateUser.Image = Properties.Resources.user_interface;
			btnUpdateUser.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdateUser.Location = new Point(8, 43);
			btnUpdateUser.Name = "btnUpdateUser";
			btnUpdateUser.Size = new Size(185, 33);
			btnUpdateUser.TabIndex = 1;
			btnUpdateUser.Text = "Update User Information";
			btnUpdateUser.UseVisualStyleBackColor = true;
			btnUpdateUser.Visible = false;
			btnUpdateUser.Click += btnUpdateUser_Click;
			// 
			// btnAddDropCourse
			// 
			btnAddDropCourse.Image = Properties.Resources.add__1_;
			btnAddDropCourse.ImageAlign = ContentAlignment.MiddleLeft;
			btnAddDropCourse.Location = new Point(199, 4);
			btnAddDropCourse.Name = "btnAddDropCourse";
			btnAddDropCourse.Size = new Size(166, 33);
			btnAddDropCourse.TabIndex = 2;
			btnAddDropCourse.Text = "Add/Drop Courses";
			btnAddDropCourse.UseVisualStyleBackColor = true;
			btnAddDropCourse.Visible = false;
			btnAddDropCourse.Click += btnAddDropCourse_Click;
			// 
			// btnEditCourses
			// 
			btnEditCourses.Image = Properties.Resources.refresh__1_;
			btnEditCourses.ImageAlign = ContentAlignment.MiddleLeft;
			btnEditCourses.Location = new Point(8, 4);
			btnEditCourses.Name = "btnEditCourses";
			btnEditCourses.Size = new Size(185, 33);
			btnEditCourses.TabIndex = 3;
			btnEditCourses.Text = "Edit Courses";
			btnEditCourses.UseVisualStyleBackColor = true;
			btnEditCourses.Visible = false;
			btnEditCourses.Click += btnEditCourses_Click;
			// 
			// btnEditStudentSchedule
			// 
			btnEditStudentSchedule.Image = Properties.Resources.graduated;
			btnEditStudentSchedule.ImageAlign = ContentAlignment.MiddleLeft;
			btnEditStudentSchedule.Location = new Point(199, 43);
			btnEditStudentSchedule.Name = "btnEditStudentSchedule";
			btnEditStudentSchedule.Size = new Size(165, 33);
			btnEditStudentSchedule.TabIndex = 4;
			btnEditStudentSchedule.Text = "Edit Student Schedule";
			btnEditStudentSchedule.UseVisualStyleBackColor = true;
			btnEditStudentSchedule.Visible = false;
			btnEditStudentSchedule.Click += btnEditStudentSchedule_Click;
			// 
			// btnUpdateStudent
			// 
			btnUpdateStudent.Image = Properties.Resources.refresh__1_;
			btnUpdateStudent.ImageAlign = ContentAlignment.MiddleLeft;
			btnUpdateStudent.Location = new Point(8, 4);
			btnUpdateStudent.Name = "btnUpdateStudent";
			btnUpdateStudent.Size = new Size(185, 33);
			btnUpdateStudent.TabIndex = 5;
			btnUpdateStudent.Text = "Update Student Information";
			btnUpdateStudent.TextAlign = ContentAlignment.MiddleRight;
			btnUpdateStudent.UseVisualStyleBackColor = true;
			btnUpdateStudent.Visible = false;
			btnUpdateStudent.Click += btnUpdateStudent_Click;
			// 
			// frmMainScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(215, 192, 255);
			ClientSize = new Size(376, 79);
			Controls.Add(btnEditStudentSchedule);
			Controls.Add(btnEditCourses);
			Controls.Add(btnAddDropCourse);
			Controls.Add(btnUpdateUser);
			Controls.Add(btnUpdateStudent);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmMainScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registration Landing Page";
			Load += frmMainScreen_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnUpdateUser;
		private Button btnAddDropCourse;
		private Button btnEditCourses;
		private Button btnEditStudentSchedule;
		private Button btnUpdateStudent;
	}
}