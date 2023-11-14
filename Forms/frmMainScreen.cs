using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project_Team3
{
	public partial class frmMainScreen : Form
	{
		public string username;
		public string password;
		public string frstname;
		public string lastname;
		public int role;

		public frmMainScreen(User usr)
		{
			InitializeComponent();
			username = usr.UserName;
			password = usr.Password;
			lastname = usr.LastName;
			frstname = usr.FirstName;
			role = usr.Role;
		}

		private void frmMainScreen_Load(object sender, EventArgs e)
		{
			if (role == 2)
			{
				btnAddDropCourse.Visible = true;
				btnUpdateUser.Visible = true;
				btnEditCourses.Visible = false;
			}
			else if (role == 1) {
				btnAddDropCourse.Visible = false;
				btnUpdateUser.Visible = false;
				btnEditCourses.Visible = true;
			}
		}
	}
}
