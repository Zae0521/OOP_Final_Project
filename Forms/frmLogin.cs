using Dapper;
using Microsoft.Data.Sqlite;
using OOP_Final_Project_Team3.Forms;

namespace OOP_Final_Project_Team3
{
	public partial class frmLogin : Form
	{
		string db = "OOP_Final_Proj.db";

		public frmLogin()
		{

			InitializeComponent();
		}

		public static User LoginUsr { get; set; }

		private void lblRegister_Click(object sender, EventArgs e)
		{
			new frmRegister().Show();
			this.Hide();
		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			await using var conn = new SqliteConnection($"Data Source={db}");

			if ((txtPass.Text is not null && txtPass.Text != "") && (txtUser.Text is not null && txtUser.Text != ""))
			{
				var sql = $"SELECT * FROM Users WHERE UserName = '{txtUser.Text}' AND Password = '{txtPass.Text}'";

				var res = await conn.QueryAsync<User>(sql);

				if (res != null)
				{
					//MessageBox.Show($"{res.First().FirstName} { res.First().LastName} {res.First().UserName} {res.First().Password} {res.First().Role}");
					LoginUsr = res.First();
					frmMainScreen main = new frmMainScreen(LoginUsr);
					this.Hide();
					main.Show();
				}
				else { MessageBox.Show("Account Does Not Exist, or Error in UserName/Password", "Error"); }

			}
			else
			{
				MessageBox.Show("Please insert both a UserName and Password!", "Login Error"); 
			}


		}
	}
}