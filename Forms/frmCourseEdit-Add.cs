﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;



namespace OOP_Final_Project_Team3.Forms
{
	public partial class frmCourseEdit_Add : Form
	{
		string db = "OOP_Final_Proj.db";
		Courses course;
		string courseidd;
		string section;
		string title;
		string prof;
		string meeting;
		string start;
		string end;

		string oldCourse;
		string oldSection;

		bool fload = true;
		bool fload2 = false;

		public frmCourseEdit_Add()
		{
			InitializeComponent();
		}

		private async void frmCourseEdit_Add_Load(object sender, EventArgs e)
		{
			await using var conn = new SqliteConnection($"Data Source={db}");

			var sql = $"SELECT * FROM Courses ORDER BY CourseID ASC, SectionID ASC";

			var res = conn.QueryAsync<Courses>(sql);
			List<Courses> uData = res.Result.ToList();

			dgvCourses.DataSource = uData;

			var courseid = dgvCourses.CurrentRow.Cells[0].Value.ToString();
			var sectionid = dgvCourses.CurrentRow.Cells[1].Value.ToString();

			await using var conn2 = new SqliteConnection($"Data Source={db}");
			var sql2 = $"SELECT * FROM Courses WHERE CourseID = '{courseid}' AND SectionID = '{sectionid}'";

			var res2 = await conn.QueryAsync<Courses>(sql2);

			txtCourseID.Text = res2.First().CourseID;
			txtSectionID.Text = res2.First().SectionID.ToString();
			txtTitle.Text = res2.First().CourseTitle;
			txtProfessor.Text = res2.First().Professor;
			txtMeetingTimes.Text = res2.First().MeetingTimes;
			txtStartDate.Text = res2.First().StartDate;
			txtEndDate.Text = res2.First().EndDate;

			courseidd = txtCourseID.Text;
			section = txtSectionID.Text;
			title = txtTitle.Text;
			prof = txtProfessor.Text;
			meeting = txtMeetingTimes.Text;
			start = txtStartDate.Text;
			end = txtEndDate.Text;
		}

		private void dgvCourses_SelectionChanged(object sender, EventArgs e)
		{

			if (fload != true)
			{
				if (courseidd == txtCourseID.Text && section == txtSectionID.Text && prof == txtProfessor.Text && meeting == txtMeetingTimes.Text && start == txtStartDate.Text && end == txtEndDate.Text)
				{

					fetch();
				}
				else
				{
					if (!fload2)
					{
						if (MessageBox.Show("Data has been changed do you want to save.", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							update();
							fetch();
						}
						else
						{
							fetch();
						}
					}
					fload2 = false;
				}
				courseidd = txtCourseID.Text;
				section = txtSectionID.Text;
				title = txtTitle.Text;
				prof = txtProfessor.Text;
				meeting = txtMeetingTimes.Text;
				start = txtStartDate.Text;
				end = txtEndDate.Text;
				oldCourse = txtCourseID.Text;
				oldSection = txtSectionID.Text;

			}

			fload = false;

		}

		private void fetch()
		{
			var courseid = dgvCourses.CurrentRow.Cells[0].Value.ToString();
			var sectionid = dgvCourses.CurrentRow.Cells[1].Value.ToString();
			using var conn = new SqliteConnection($"Data Source={db}");
			var sql = $"SELECT * FROM Courses WHERE CourseID = '{courseid}' AND SectionID = '{sectionid}'";

			var res = conn.QueryAsync<Courses>(sql);

			try
			{
				txtCourseID.Text = res.Result.First().CourseID;
				txtSectionID.Text = res.Result.First().SectionID.ToString();
				txtTitle.Text = res.Result.First().CourseTitle;
				txtProfessor.Text = res.Result.First().Professor;
				txtMeetingTimes.Text = res.Result.First().MeetingTimes;
				txtStartDate.Text = res.Result.First().StartDate;
				txtEndDate.Text = res.Result.First().EndDate;
			}
			catch (Exception ex) { }
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			update();
		}

		private async void update()
		{
			fload = true;
			await using var conn = new SqliteConnection($"Data Source={db}");

			courseidd = txtCourseID.Text;
			section = txtSectionID.Text;
			title = txtTitle.Text;
			prof = txtProfessor.Text;
			meeting = txtMeetingTimes.Text;
			start = txtStartDate.Text;
			end = txtEndDate.Text;

			if ((courseidd is not null && courseidd != "" && courseidd != " ") && (section is not null && section != "" && section != " "))
			{

				var sql = $"UPDATE Courses set CourseID = '{courseidd}', SectionID = '{section}', CourseTitle = '{title}', Professor='{prof}', MeetingTimes = '{meeting}', StartDate ='{start}', EndDate = '{end}' WHERE CourseID = '{oldCourse}' AND SectionID = '{oldSection}'";

				var res = conn.Execute(sql);

				if (res != null)
				{
					MessageBox.Show($"Updated Successfully.");

				}
				else { MessageBox.Show("Course Doesn't Exist", "Error"); }

			}
			else
			{
				MessageBox.Show("Course Doesn't Exist", "Update Error");
			}

			await using var conn2 = new SqliteConnection($"Data Source={db}");

			var sql2 = $"SELECT * FROM Courses ORDER BY CourseID ASC, SectionID ASC";

			var res2 = conn2.QueryAsync<Courses>(sql2);
			List<Courses> uData = res2.Result.ToList();

			dgvCourses.DataSource = uData;

			var courseid = dgvCourses.CurrentRow.Cells[0].Value.ToString();
			var sectionid = dgvCourses.CurrentRow.Cells[1].Value.ToString();

			await using var conn3 = new SqliteConnection($"Data Source={db}");
			var sql3 = $"SELECT * FROM Courses WHERE CourseID = '{courseid}' AND SectionID = '{sectionid}'";

			var res3 = await conn.QueryAsync<Courses>(sql3);

			txtCourseID.Text = res3.First().CourseID;
			txtSectionID.Text = res3.First().SectionID.ToString();
			txtTitle.Text = res3.First().CourseTitle;
			txtProfessor.Text = res3.First().Professor;
			txtMeetingTimes.Text = res3.First().MeetingTimes;
			txtStartDate.Text = res3.First().StartDate;
			txtEndDate.Text = res3.First().EndDate;

			courseidd = txtCourseID.Text;
			section = txtSectionID.Text;
			title = txtTitle.Text;
			prof = txtProfessor.Text;
			meeting = txtMeetingTimes.Text;
			start = txtStartDate.Text;
			end = txtEndDate.Text;

		}

		private void btnAddCourse_Click(object sender, EventArgs e)
		{
			txtCourseID.Clear();
			txtSectionID.Clear();
			txtTitle.Clear();
			txtProfessor.Clear();
			txtMeetingTimes.Clear();
			txtStartDate.Clear();
			txtEndDate.Clear();

			btnAddCourse.Visible = false;
			btnInsertCourse.Visible = true;
			btnUpdate.Visible = false;
			btnDeleteCourse.Visible = false;

		}

		private async void btnInsertCourse_Click(object sender, EventArgs e)
		{
			fload = true;
			fload2 = true;
			await using var conn = new SqliteConnection($"Data Source={db}");

			if ((courseidd is not null && courseidd != "" && courseidd != " ") && (section is not null && section != "" && section != " "))
			{

				var sql = $"INSERT INTO Courses VALUES ('{txtCourseID.Text}', '{txtSectionID.Text}', '{txtTitle.Text}', '{txtProfessor.Text}', '{txtMeetingTimes.Text}', '{txtStartDate.Text}', '{txtEndDate.Text}')";

				var res = conn.Execute(sql);

				if (res != null)
				{
					MessageBox.Show($"Inserted Successfully.");

				}
				else { MessageBox.Show("Error", "Error"); }

				await using var conn2 = new SqliteConnection($"Data Source={db}");

				var sql2 = $"SELECT * FROM Courses ORDER BY CourseID ASC, SectionID ASC";

				var res2 = conn2.QueryAsync<Courses>(sql2);
				List<Courses> uData = res2.Result.ToList();

				dgvCourses.DataSource = uData;

				var courseid = dgvCourses.CurrentRow.Cells[0].Value.ToString();
				var sectionid = dgvCourses.CurrentRow.Cells[1].Value.ToString();

				await using var conn3 = new SqliteConnection($"Data Source={db}");
				var sql3 = $"SELECT * FROM Courses WHERE CourseID = '{courseid}' AND SectionID = '{sectionid}'";

				var res3 = await conn.QueryAsync<Courses>(sql3);

				txtCourseID.Text = res3.First().CourseID;
				txtSectionID.Text = res3.First().SectionID.ToString();
				txtTitle.Text = res3.First().CourseTitle;
				txtProfessor.Text = res3.First().Professor;
				txtMeetingTimes.Text = res3.First().MeetingTimes;
				txtStartDate.Text = res3.First().StartDate;
				txtEndDate.Text = res3.First().EndDate;

				courseidd = txtCourseID.Text;
				section = txtSectionID.Text;
				title = txtTitle.Text;
				prof = txtProfessor.Text;
				meeting = txtMeetingTimes.Text;
				start = txtStartDate.Text;
				end = txtEndDate.Text;

			}
			else
			{
				MessageBox.Show("Course and Section are required for a new course", "Insert Error");
			}

			btnAddCourse.Visible = true;
			btnInsertCourse.Visible = false;
			btnUpdate.Visible = true;
			btnDeleteCourse.Visible = true;


		}

		private async void btnDeleteCourse_Click(object sender, EventArgs e)
		{
			var courseid = dgvCourses.CurrentRow.Cells[0].Value.ToString();
			var sectionid = dgvCourses.CurrentRow.Cells[1].Value.ToString();

			await using var conn = new SqliteConnection($"Data Source={db}");

			var sql = $"DELETE FROM Courses WHERE CourseID = '{courseid}' AND SectionID = '{sectionid}'";
			var sqlschdel = $"DELETE FROM StudentSchedule WHERE CourseID = '{courseid}' AND SectionID = '{SectionID}'";

			var res = conn.Execute(sql);
			var resschdel = conn.Execute(sqlschdel);

			if (res != null)
			{
				MessageBox.Show("Course Deleted!");
				var sql2 = $"SELECT * FROM Courses ORDER BY CourseID ASC, SectionID ASC";

				var res2 = conn.QueryAsync<Courses>(sql2);
				List<Courses> uData = res2.Result.ToList();

				dgvCourses.DataSource = uData;
			}

		}
	}
}
