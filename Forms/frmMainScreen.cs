using OOP_Final_Project_Team3.Forms;
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
		public User User { get; set; }

		public frmMainScreen(User usr)
		{
			InitializeComponent();
			username = usr.UserName;
			password = usr.Password;
			lastname = usr.LastName;
			frstname = usr.FirstName;
			role = usr.Role;
			User = usr;
		}

		private void frmMainScreen_Load(object sender, EventArgs e)
		{
			if (role == 2)
			{
				btnAddDropCourse.Visible = true;
				btnUpdateUser.Visible = true;
				btnUpdateStudent.Visible = false;
				btnEditCourses.Visible = false;
				btnEditStudentSchedule.Visible = false;
			}
			else if (role == 1)
			{
				btnAddDropCourse.Visible = false;
				btnUpdateUser.Visible = false;
				btnUpdateStudent.Visible = true;
				btnEditCourses.Visible = true;
				btnEditStudentSchedule.Visible = true;
			}
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			frmEditUserInfo edit = new frmEditUserInfo(User, "student");
			edit.ShowDialog();
			this.Close();
		}

		private void btnUpdateStudent_Click(object sender, EventArgs e)
		{
			frmStudentSelect studentSelect = new frmStudentSelect();
			studentSelect.ShowDialog();
			this.Close();
		}

		private void btnEditCourses_Click(object sender, EventArgs e)
		{
			frmCourseEdit_Add courseEdit_Add = new frmCourseEdit_Add();
			courseEdit_Add.ShowDialog();
			this.Close();
		}
	}
}
