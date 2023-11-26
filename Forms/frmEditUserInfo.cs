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
using Dapper;
using Microsoft.Data.Sqlite;
using OOP_Final_Project_Team3.Forms;
using System.Diagnostics.Eventing.Reader;

namespace OOP_Final_Project_Team3.Forms
{
	public partial class frmEditUserInfo : Form
	{
		string db = "OOP_Final_Proj.db";

		public string username;
		public string password;
		public string frstname;
		public string lastname;
		public int role;
		public string usrlevel;

		public frmEditUserInfo(User usr, string level1)
		{
			InitializeComponent();
			username = usr.UserName;
			password = usr.Password;
			lastname = usr.LastName;
			frstname = usr.FirstName;
			role = usr.Role;
			usrlevel = level1.ToString();
		}

		private void frmEditUserInfo_Load(object sender, EventArgs e)
		{
			txtUserID.Text = username;
			txtPassword.Text = password;
			txtFirst.Text = frstname;
			txtLast.Text = lastname;
			if (usrlevel != "admin")
			{
				if (role != 1) { chkIsAdmin.Checked = false; } else { chkIsAdmin.Checked = true; }
				chkIsAdmin.Enabled = false;
				txtUserID.Enabled = false;

			}
			else
			{
				if (role != 1) { chkIsAdmin.Checked = false; } else { chkIsAdmin.Checked = true; }
				chkIsAdmin.Enabled = true;
				txtUserID.Enabled = true;
			}
		}

		private async void btnUpdateInfo_Click(object sender, EventArgs e)
		{
			await using var conn = new SqliteConnection($"Data Source={db}");

			if ((txtPassword.Text is not null && txtPassword.Text != "") && (txtUserID.Text is not null && txtUserID.Text != ""))
			{
				if (txtUserID.Text != username)
				{
					if (txtFirst.Text == frstname && txtLast.Text == lastname && txtPassword.Text == password)
					{
						var sql = $"UPDATE Users set UserName = '{txtUserID.Text}' WHERE Password = '{password}' and FirstName = '{frstname}' and LastName = '{lastname}'";

						var res = conn.Execute(sql);

						if (res != null)
						{
							MessageBox.Show($"Updated Successfully.");

						}
						else { MessageBox.Show("Account Does Not Exist, or Error in UserName/Password", "Error"); }
					}
					else
					{ MessageBox.Show("To Change a UserName: the First Name, Last Name, and The Password cannot be changed at the same time."); }


				}

				else
				{
					if (chkIsAdmin.Checked) { role = 1; } else { role = 2; }

					var sql = $"UPDATE Users set Password = '{txtPassword.Text}', FirstName = '{frstname}', LastName = '{lastname}', role = {role} WHERE UserName = '{username}'";

					var res = conn.Execute(sql);

					if (res != null)
					{
						MessageBox.Show($"Updated Successfully.");

					}
					else { MessageBox.Show("Account Does Not Exist, or Error in UserName/Password", "Error"); }
				}
			}
			else
			{
				MessageBox.Show("Please insert both a UserName and Password!", "Update Error");
			}
		}
	}
}
