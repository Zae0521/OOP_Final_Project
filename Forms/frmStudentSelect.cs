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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOP_Final_Project_Team3.Forms
{
	public partial class frmStudentSelect : Form
	{
		string db = "OOP_Final_Proj.db";
		User userSelected;

		public frmStudentSelect()
		{
			InitializeComponent();
		}

		private async void frmStudentSelect_Load(object sender, EventArgs e)
		{
			await using var conn = new SqliteConnection($"Data Source={db}");

			var sql = $"SELECT * FROM Users ORDER BY UserName ASC";

			var res = conn.QueryAsync<User>(sql);
			List<User> uData = res.Result.ToList();

			dgvStudents.DataSource = uData;
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvStudents.SelectedRows.Count > 0)
			{

				var userName = dgvStudents.CurrentRow.Cells[0].Value.ToString();
				await using var conn = new SqliteConnection($"Data Source={db}");

				var sql = $"SELECT * FROM Users WHERE UserName = '{userName}'";

				var res = await conn.QueryAsync<User>(sql);

				if (res != null)
				{
					//MessageBox.Show($"{res.First().FirstName} { res.First().LastName} {res.First().UserName} {res.First().Password} {res.First().Role}");
					userSelected = res.First();
					this.Close();
					frmEditUserInfo editInfo = new frmEditUserInfo(userSelected, "admin");
					editInfo.Show();
				}



			}
			else
			{
				MessageBox.Show("No Record selected");
			}
		}
	}
}
