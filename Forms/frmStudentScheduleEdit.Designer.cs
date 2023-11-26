namespace OOP_Final_Project_Team3.Forms
{
	partial class frmStudentScheduleEdit
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentScheduleEdit));
			dgvCourses = new DataGridView();
			courseIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sectionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			courseTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			professorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			meetingTimesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			coursesBindingSource = new BindingSource(components);
			dgvStudentSchedule = new DataGridView();
			userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			courseIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			sectionIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			studentScheduleBindingSource = new BindingSource(components);
			userBindingSource = new BindingSource(components);
			btnAddToSchedule = new Button();
			btnDeleteCourseFromSchedule = new Button();
			((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
			((System.ComponentModel.ISupportInitialize)coursesBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvStudentSchedule).BeginInit();
			((System.ComponentModel.ISupportInitialize)studentScheduleBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dgvCourses
			// 
			dgvCourses.AllowUserToAddRows = false;
			dgvCourses.AllowUserToDeleteRows = false;
			dgvCourses.AutoGenerateColumns = false;
			dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCourses.Columns.AddRange(new DataGridViewColumn[] { courseIDDataGridViewTextBoxColumn, sectionIDDataGridViewTextBoxColumn, courseTitleDataGridViewTextBoxColumn, professorDataGridViewTextBoxColumn, meetingTimesDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn });
			dgvCourses.DataSource = coursesBindingSource;
			dgvCourses.Location = new Point(12, 12);
			dgvCourses.Name = "dgvCourses";
			dgvCourses.ReadOnly = true;
			dgvCourses.RowTemplate.Height = 25;
			dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCourses.Size = new Size(746, 195);
			dgvCourses.TabIndex = 0;
			// 
			// courseIDDataGridViewTextBoxColumn
			// 
			courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
			courseIDDataGridViewTextBoxColumn.HeaderText = "Course ID";
			courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
			courseIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sectionIDDataGridViewTextBoxColumn
			// 
			sectionIDDataGridViewTextBoxColumn.DataPropertyName = "SectionID";
			sectionIDDataGridViewTextBoxColumn.HeaderText = "Section ID";
			sectionIDDataGridViewTextBoxColumn.Name = "sectionIDDataGridViewTextBoxColumn";
			sectionIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// courseTitleDataGridViewTextBoxColumn
			// 
			courseTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseTitle";
			courseTitleDataGridViewTextBoxColumn.HeaderText = "Course Title";
			courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
			courseTitleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// professorDataGridViewTextBoxColumn
			// 
			professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
			professorDataGridViewTextBoxColumn.HeaderText = "Professor";
			professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
			professorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// meetingTimesDataGridViewTextBoxColumn
			// 
			meetingTimesDataGridViewTextBoxColumn.DataPropertyName = "MeetingTimes";
			meetingTimesDataGridViewTextBoxColumn.HeaderText = "Meeting Times";
			meetingTimesDataGridViewTextBoxColumn.Name = "meetingTimesDataGridViewTextBoxColumn";
			meetingTimesDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// startDateDataGridViewTextBoxColumn
			// 
			startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
			startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
			startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
			startDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// endDateDataGridViewTextBoxColumn
			// 
			endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
			endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
			endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
			endDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// coursesBindingSource
			// 
			coursesBindingSource.DataSource = typeof(Courses);
			// 
			// dgvStudentSchedule
			// 
			dgvStudentSchedule.AllowUserToAddRows = false;
			dgvStudentSchedule.AllowUserToDeleteRows = false;
			dgvStudentSchedule.AutoGenerateColumns = false;
			dgvStudentSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudentSchedule.Columns.AddRange(new DataGridViewColumn[] { userIDDataGridViewTextBoxColumn, courseIDDataGridViewTextBoxColumn1, sectionIDDataGridViewTextBoxColumn1 });
			dgvStudentSchedule.DataSource = studentScheduleBindingSource;
			dgvStudentSchedule.Location = new Point(50, 238);
			dgvStudentSchedule.Name = "dgvStudentSchedule";
			dgvStudentSchedule.ReadOnly = true;
			dgvStudentSchedule.RowTemplate.Height = 25;
			dgvStudentSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStudentSchedule.Size = new Size(420, 172);
			dgvStudentSchedule.TabIndex = 1;
			// 
			// userIDDataGridViewTextBoxColumn
			// 
			userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
			userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
			userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
			userIDDataGridViewTextBoxColumn.ReadOnly = true;
			userIDDataGridViewTextBoxColumn.Visible = false;
			// 
			// courseIDDataGridViewTextBoxColumn1
			// 
			courseIDDataGridViewTextBoxColumn1.DataPropertyName = "CourseID";
			courseIDDataGridViewTextBoxColumn1.HeaderText = "Course ID";
			courseIDDataGridViewTextBoxColumn1.Name = "courseIDDataGridViewTextBoxColumn1";
			courseIDDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// sectionIDDataGridViewTextBoxColumn1
			// 
			sectionIDDataGridViewTextBoxColumn1.DataPropertyName = "SectionID";
			sectionIDDataGridViewTextBoxColumn1.HeaderText = "Section ID";
			sectionIDDataGridViewTextBoxColumn1.Name = "sectionIDDataGridViewTextBoxColumn1";
			sectionIDDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// studentScheduleBindingSource
			// 
			studentScheduleBindingSource.DataSource = typeof(StudentSchedule);
			// 
			// userBindingSource
			// 
			userBindingSource.DataSource = typeof(User);
			// 
			// btnAddToSchedule
			// 
			btnAddToSchedule.Location = new Point(769, 38);
			btnAddToSchedule.Name = "btnAddToSchedule";
			btnAddToSchedule.Size = new Size(107, 23);
			btnAddToSchedule.TabIndex = 2;
			btnAddToSchedule.Text = "Add To Schedule";
			btnAddToSchedule.UseVisualStyleBackColor = true;
			btnAddToSchedule.Click += btnAddToSchedule_Click;
			// 
			// btnDeleteCourseFromSchedule
			// 
			btnDeleteCourseFromSchedule.Location = new Point(486, 255);
			btnDeleteCourseFromSchedule.Name = "btnDeleteCourseFromSchedule";
			btnDeleteCourseFromSchedule.Size = new Size(141, 23);
			btnDeleteCourseFromSchedule.TabIndex = 3;
			btnDeleteCourseFromSchedule.Text = "Remove From Schedule";
			btnDeleteCourseFromSchedule.UseVisualStyleBackColor = true;
			btnDeleteCourseFromSchedule.Click += btnDeleteCourseFromSchedule_Click;
			// 
			// frmStudentScheduleEdit
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(215, 192, 255);
			ClientSize = new Size(887, 450);
			Controls.Add(btnDeleteCourseFromSchedule);
			Controls.Add(btnAddToSchedule);
			Controls.Add(dgvStudentSchedule);
			Controls.Add(dgvCourses);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmStudentScheduleEdit";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Schedule Edit";
			Load += frmStudentScheduleEdit_Load;
			((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
			((System.ComponentModel.ISupportInitialize)coursesBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvStudentSchedule).EndInit();
			((System.ComponentModel.ISupportInitialize)studentScheduleBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvCourses;
		private BindingSource coursesBindingSource;
		private DataGridView dgvStudentSchedule;
		private BindingSource studentScheduleBindingSource;
		private BindingSource userBindingSource;
		private DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sectionIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn meetingTimesDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn sectionIDDataGridViewTextBoxColumn1;
		private Button btnAddToSchedule;
		private Button btnDeleteCourseFromSchedule;
	}
}