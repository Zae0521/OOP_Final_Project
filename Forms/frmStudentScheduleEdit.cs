using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project_Team3.Forms
{
	public partial class frmStudentScheduleEdit : Form
	{
		string db = "OOP_Final_Proj.db";

		User user;

		int count = 0;

		public frmStudentScheduleEdit(User usr)
		{
			InitializeComponent();
			user = usr;
		}

		private async void frmStudentScheduleEdit_Load(object sender, EventArgs e)
		{
			await using var conn = new SqliteConnection($"Data Source={db}");

			var sql = $"SELECT * FROM Courses";
			var sql2 = $"SELECT * FROM StudentSchedule WHERE UserID = '{user.UserName}'";

			var res = conn.QueryAsync<Courses>(sql);
			var res2 = conn.QueryAsync<StudentSchedule>(sql2);

			count = res2.Result.Count();

			List<Courses> cData = res.Result.ToList<Courses>();
			List<StudentSchedule> ssData = res2.Result.ToList<StudentSchedule>();

			dgvCourses.DataSource = cData;
			dgvStudentSchedule.DataSource = ssData;

		}

		private async void btnAddToSchedule_Click(object sender, EventArgs e)
		{
			if (count < 5)
			{

				string coursee;
				string sectionidd;

				if (dgvCourses.SelectedRows.Count > 0)
				{
					coursee = dgvCourses.CurrentRow.Cells[0].Value.ToString();
					sectionidd = dgvCourses.CurrentRow.Cells[1].Value.ToString();

					await using var conn = new SqliteConnection($"Data Source={db}");
					var sql = $"INSERT INTO StudentSchedule VALUES ('{user.UserName}', '{coursee}', '{sectionidd}')";
					var res = conn.Execute(sql);

					var sql2 = $"SELECT * FROM StudentSchedule WHERE UserID = '{user.UserName}'";
					var res2 = conn.QueryAsync<StudentSchedule>(sql2);
					List<StudentSchedule> ssData = res2.Result.ToList<StudentSchedule>();
					dgvStudentSchedule.DataSource = ssData;

					count++;

				}
			}
			else
			{
				MessageBox.Show("Too Many Registered Courses (Max Number of Registered Courses is '5')", "Course Add Error");
			}

		}

		private async void btnDeleteCourseFromSchedule_Click(object sender, EventArgs e)
		{
			string coursee;
			string sectionidd;

			if (dgvStudentSchedule.SelectedRows.Count > 0)
			{
				coursee = dgvStudentSchedule.CurrentRow.Cells[1].Value.ToString();
				sectionidd = dgvStudentSchedule.CurrentRow.Cells[2].Value.ToString();

				await using var conn = new SqliteConnection($"Data Source={db}");
				
				var sql = $"DELETE FROM StudentSchedule WHERE UserID = '{user.UserName}' AND CourseID = '{coursee}' AND SectionID = '{sectionidd}'";
				var res = conn.Execute(sql);

				var sql2 = $"SELECT * FROM StudentSchedule WHERE UserID = '{user.UserName}'";
				var res2 = conn.QueryAsync<StudentSchedule>(sql2);
				List<StudentSchedule> ssData = res2.Result.ToList<StudentSchedule>();
				dgvStudentSchedule.DataSource = ssData;
			}
		}
	}
}
