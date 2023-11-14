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
using OOP_Final_Project_Team3.Forms;

namespace OOP_Final_Project_Team3.Forms
{
	public partial class frmRegister : Form
	{
		string db = "OOP_Final_Proj.db";

		public frmRegister()
		{
			InitializeComponent();
		}

		private async void btnRegister_Click(object sender, EventArgs e)
		{
			await using var conn = new SqliteConnection($"Data Source={db}");

			if ((txtPass.Text is not null && txtPass.Text != "") && (txtUser.Text is not null && txtUser.Text != "") && (txtFrstName.Text is not null && txtFrstName.Text != "") && (txtLastName.Text is not null && txtLastName.Text != ""))
			{
				var sql = $"INSERT INTO Users VALUES( '{txtUser.Text}', '{txtPass.Text}', '{txtFrstName.Text}', '{txtLastName.Text}', 2)";

				var res = conn.Execute(sql);

				if (res != null)
				{
					//MessageBox.Show($"{res.First().FirstName} { res.First().LastName} {res.First().UserName} {res.First().Password} {res.First().Role}");
				}
				else { MessageBox.Show("Account Does Not Exist, or Error in UserName/Password", "Error"); }

			}
			else
			{
				MessageBox.Show("Please insert both a UserName and Password!", "Login Error");
			}

			// all code above this

			new frmLogin().Show();
			this.Close();
		}
	}
}
