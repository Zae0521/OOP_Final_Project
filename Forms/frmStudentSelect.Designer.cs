namespace OOP_Final_Project_Team3.Forms
{
	partial class frmStudentSelect
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
			dgvStudents = new DataGridView();
			userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			userBindingSource = new BindingSource(components);
			btnUpdate = new Button();
			((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
			((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dgvStudents
			// 
			dgvStudents.AutoGenerateColumns = false;
			dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudents.Columns.AddRange(new DataGridViewColumn[] { userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
			dgvStudents.DataSource = userBindingSource;
			dgvStudents.Location = new Point(12, 12);
			dgvStudents.Name = "dgvStudents";
			dgvStudents.RowTemplate.Height = 25;
			dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStudents.Size = new Size(609, 410);
			dgvStudents.TabIndex = 0;
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
			userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			passwordDataGridViewTextBoxColumn.HeaderText = "Password";
			passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
			firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
			lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// roleDataGridViewTextBoxColumn
			// 
			roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
			roleDataGridViewTextBoxColumn.HeaderText = "Role";
			roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
			// 
			// userBindingSource
			// 
			userBindingSource.DataSource = typeof(User);
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(656, 83);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(97, 23);
			btnUpdate.TabIndex = 1;
			btnUpdate.Text = "Update Info";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// frmStudentSelect
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnUpdate);
			Controls.Add(dgvStudents);
			Name = "frmStudentSelect";
			Text = "frmStudentSelect";
			Load += frmStudentSelect_Load;
			((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
			((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvStudents;
		private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
		private BindingSource userBindingSource;
		private Button btnUpdate;
	}
}