namespace OOP_Final_Project_Team3.Forms
{
	partial class frmCourseEdit_Add
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseEdit_Add));
			dgvCourses = new DataGridView();
			courseIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			SectionID = new DataGridViewTextBoxColumn();
			courseTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			professorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			meetingTimesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			coursesBindingSource = new BindingSource(components);
			btnUpdate = new Button();
			txtCourseID = new TextBox();
			label1 = new Label();
			label2 = new Label();
			txtSectionID = new TextBox();
			label3 = new Label();
			txtProfessor = new TextBox();
			label4 = new Label();
			txtMeetingTimes = new TextBox();
			label5 = new Label();
			txtStartDate = new TextBox();
			label6 = new Label();
			txtEndDate = new TextBox();
			label7 = new Label();
			txtTitle = new TextBox();
			btnAddCourse = new Button();
			btnInsertCourse = new Button();
			((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
			((System.ComponentModel.ISupportInitialize)coursesBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dgvCourses
			// 
			dgvCourses.AutoGenerateColumns = false;
			dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCourses.Columns.AddRange(new DataGridViewColumn[] { courseIDDataGridViewTextBoxColumn, SectionID, courseTitleDataGridViewTextBoxColumn, professorDataGridViewTextBoxColumn, meetingTimesDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn });
			dgvCourses.DataSource = coursesBindingSource;
			dgvCourses.Location = new Point(12, 12);
			dgvCourses.MultiSelect = false;
			dgvCourses.Name = "dgvCourses";
			dgvCourses.RowTemplate.Height = 25;
			dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCourses.Size = new Size(920, 355);
			dgvCourses.TabIndex = 0;
			dgvCourses.SelectionChanged += dgvCourses_SelectionChanged;
			// 
			// courseIDDataGridViewTextBoxColumn
			// 
			courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
			courseIDDataGridViewTextBoxColumn.HeaderText = "Course ID";
			courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
			courseIDDataGridViewTextBoxColumn.Width = 83;
			// 
			// SectionID
			// 
			SectionID.DataPropertyName = "SectionID";
			SectionID.HeaderText = "Section ID";
			SectionID.Name = "SectionID";
			SectionID.Width = 85;
			// 
			// courseTitleDataGridViewTextBoxColumn
			// 
			courseTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseTitle";
			courseTitleDataGridViewTextBoxColumn.HeaderText = "Course Title";
			courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
			courseTitleDataGridViewTextBoxColumn.Width = 94;
			// 
			// professorDataGridViewTextBoxColumn
			// 
			professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
			professorDataGridViewTextBoxColumn.HeaderText = "Professor";
			professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
			professorDataGridViewTextBoxColumn.Width = 81;
			// 
			// meetingTimesDataGridViewTextBoxColumn
			// 
			meetingTimesDataGridViewTextBoxColumn.DataPropertyName = "MeetingTimes";
			meetingTimesDataGridViewTextBoxColumn.HeaderText = "Meeting Times";
			meetingTimesDataGridViewTextBoxColumn.Name = "meetingTimesDataGridViewTextBoxColumn";
			meetingTimesDataGridViewTextBoxColumn.Width = 110;
			// 
			// startDateDataGridViewTextBoxColumn
			// 
			startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
			startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
			startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
			startDateDataGridViewTextBoxColumn.Width = 83;
			// 
			// endDateDataGridViewTextBoxColumn
			// 
			endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
			endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
			endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
			endDateDataGridViewTextBoxColumn.Width = 79;
			// 
			// coursesBindingSource
			// 
			coursesBindingSource.DataSource = typeof(Courses);
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(474, 466);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(97, 23);
			btnUpdate.TabIndex = 9;
			btnUpdate.Text = "Update Course";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtCourseID
			// 
			txtCourseID.Location = new Point(210, 385);
			txtCourseID.Name = "txtCourseID";
			txtCourseID.Size = new Size(100, 23);
			txtCourseID.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(143, 388);
			label1.Name = "label1";
			label1.Size = new Size(61, 15);
			label1.TabIndex = 3;
			label1.Text = "Course ID:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(316, 388);
			label2.Name = "label2";
			label2.Size = new Size(63, 15);
			label2.TabIndex = 5;
			label2.Text = "Section ID:";
			// 
			// txtSectionID
			// 
			txtSectionID.Location = new Point(385, 385);
			txtSectionID.Name = "txtSectionID";
			txtSectionID.Size = new Size(100, 23);
			txtSectionID.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(675, 388);
			label3.Name = "label3";
			label3.Size = new Size(59, 15);
			label3.TabIndex = 7;
			label3.Text = "Professor:";
			// 
			// txtProfessor
			// 
			txtProfessor.Location = new Point(740, 385);
			txtProfessor.Name = "txtProfessor";
			txtProfessor.Size = new Size(100, 23);
			txtProfessor.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(207, 428);
			label4.Name = "label4";
			label4.Size = new Size(88, 15);
			label4.TabIndex = 9;
			label4.Text = "Meeting Times:";
			// 
			// txtMeetingTimes
			// 
			txtMeetingTimes.Location = new Point(301, 425);
			txtMeetingTimes.Name = "txtMeetingTimes";
			txtMeetingTimes.Size = new Size(100, 23);
			txtMeetingTimes.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(407, 428);
			label5.Name = "label5";
			label5.Size = new Size(61, 15);
			label5.TabIndex = 11;
			label5.Text = "Start Date:";
			// 
			// txtStartDate
			// 
			txtStartDate.Location = new Point(474, 425);
			txtStartDate.Name = "txtStartDate";
			txtStartDate.Size = new Size(100, 23);
			txtStartDate.TabIndex = 6;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(580, 428);
			label6.Name = "label6";
			label6.Size = new Size(57, 15);
			label6.TabIndex = 13;
			label6.Text = "End Date:";
			// 
			// txtEndDate
			// 
			txtEndDate.Location = new Point(643, 425);
			txtEndDate.Name = "txtEndDate";
			txtEndDate.Size = new Size(100, 23);
			txtEndDate.TabIndex = 7;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(487, 388);
			label7.Name = "label7";
			label7.Size = new Size(32, 15);
			label7.TabIndex = 15;
			label7.Text = "Title:";
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(525, 385);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(144, 23);
			txtTitle.TabIndex = 3;
			// 
			// btnAddCourse
			// 
			btnAddCourse.Location = new Point(371, 466);
			btnAddCourse.Name = "btnAddCourse";
			btnAddCourse.Size = new Size(97, 23);
			btnAddCourse.TabIndex = 8;
			btnAddCourse.Text = "Add Course";
			btnAddCourse.UseVisualStyleBackColor = true;
			btnAddCourse.Click += btnAddCourse_Click;
			// 
			// btnInsertCourse
			// 
			btnInsertCourse.Location = new Point(371, 466);
			btnInsertCourse.Name = "btnInsertCourse";
			btnInsertCourse.Size = new Size(97, 23);
			btnInsertCourse.TabIndex = 8;
			btnInsertCourse.Text = "Insert Course";
			btnInsertCourse.UseVisualStyleBackColor = true;
			btnInsertCourse.Click += btnInsertCourse_Click;
			// 
			// frmCourseEdit_Add
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(215, 192, 255);
			ClientSize = new Size(955, 501);
			Controls.Add(btnAddCourse);
			Controls.Add(btnInsertCourse);
			Controls.Add(label7);
			Controls.Add(txtTitle);
			Controls.Add(label6);
			Controls.Add(txtEndDate);
			Controls.Add(label5);
			Controls.Add(txtStartDate);
			Controls.Add(label4);
			Controls.Add(txtMeetingTimes);
			Controls.Add(label3);
			Controls.Add(txtProfessor);
			Controls.Add(label2);
			Controls.Add(txtSectionID);
			Controls.Add(label1);
			Controls.Add(txtCourseID);
			Controls.Add(btnUpdate);
			Controls.Add(dgvCourses);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmCourseEdit_Add";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registration System Course Edit/Add";
			Load += frmCourseEdit_Add_Load;
			((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
			((System.ComponentModel.ISupportInitialize)coursesBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvCourses;
		private BindingSource coursesBindingSource;
		private DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sectionIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn meetingTimesDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
		private Button btnUpdate;
		private TextBox txtCourseID;
		private Label label1;
		private Label label2;
		private TextBox txtSectionID;
		private Label label3;
		private TextBox txtProfessor;
		private Label label4;
		private TextBox txtMeetingTimes;
		private Label label5;
		private TextBox txtStartDate;
		private Label label6;
		private TextBox txtEndDate;
		private DataGridViewTextBoxColumn SectionID;
		private Label label7;
		private TextBox txtTitle;
		private Button btnAddCourse;
		private Button btnInsertCourse;
	}
}