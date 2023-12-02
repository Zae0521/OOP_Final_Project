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
using Dapper;
using Microsoft.Data.Sqlite;


namespace OOP_Final_Project_Team3.Forms
{
	public partial class frmStudentSchedule_StudentSelector : Form
	{
		string db = "OOP_Final_Proj.db";
		User userSelected;

		public frmStudentSchedule_StudentSelector()
		{
			InitializeComponent();
		}

		private async void frmStudentSchedule_StudentSelector_Load(object sender, EventArgs e)
		{
			await using var conn = new SqliteConnection($"Data Source={db}");

			var sql = $"SELECT * FROM Users ORDER BY UserName ASC";

			var res = conn.QueryAsync<User>(sql);
			List<User> uData = res.Result.ToList();

			dgvStudentSchSelect.DataSource = uData;
		}

		private async void btnUpdateSch_Click(object sender, EventArgs e)
		{
			if (dgvStudentSchSelect.SelectedRows.Count > 0)
			{
				var userName = dgvStudentSchSelect.CurrentRow.Cells[0].Value.ToString();
				await using var conn = new SqliteConnection($"Data Source={db}");

				var sql = $"SELECT * FROM Users WHERE UserName = '{userName}' where username != '' and username != ' ' and username is not null";

				var res = await conn.QueryAsync<User>(sql);

				if (res != null)
				{
					//MessageBox.Show($"{res.First().FirstName} { res.First().LastName} {res.First().UserName} {res.First().Password} {res.First().Role}");
					userSelected = res.First();
					frmStudentScheduleEdit SchEdit = new frmStudentScheduleEdit(userSelected);
					SchEdit.Show();
				}

			}
			else
			{
				MessageBox.Show("No Record selected");
			}
		}
	}
}
