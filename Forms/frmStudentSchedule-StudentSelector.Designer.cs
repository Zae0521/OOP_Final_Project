namespace OOP_Final_Project_Team3.Forms
{
	partial class frmStudentSchedule_StudentSelector
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentSchedule_StudentSelector));
			btnUpdateSch = new Button();
			dgvStudentSchSelect = new DataGridView();
			userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			userBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvStudentSchSelect).BeginInit();
			((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
			SuspendLayout();
			// 
			// btnUpdateSch
			// 
			btnUpdateSch.Location = new Point(626, 52);
			btnUpdateSch.Name = "btnUpdateSch";
			btnUpdateSch.Size = new Size(110, 23);
			btnUpdateSch.TabIndex = 3;
			btnUpdateSch.Text = "Update Schedule";
			btnUpdateSch.UseVisualStyleBackColor = true;
			btnUpdateSch.Click += btnUpdateSch_Click;
			// 
			// dgvStudentSchSelect
			// 
			dgvStudentSchSelect.AllowUserToAddRows = false;
			dgvStudentSchSelect.AllowUserToDeleteRows = false;
			dgvStudentSchSelect.AutoGenerateColumns = false;
			dgvStudentSchSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudentSchSelect.Columns.AddRange(new DataGridViewColumn[] { userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
			dgvStudentSchSelect.DataSource = userBindingSource;
			dgvStudentSchSelect.Location = new Point(12, 12);
			dgvStudentSchSelect.Name = "dgvStudentSchSelect";
			dgvStudentSchSelect.ReadOnly = true;
			dgvStudentSchSelect.RowTemplate.Height = 25;
			dgvStudentSchSelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStudentSchSelect.ShowEditingIcon = false;
			dgvStudentSchSelect.Size = new Size(609, 410);
			dgvStudentSchSelect.TabIndex = 2;
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
			userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			userNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			passwordDataGridViewTextBoxColumn.HeaderText = "Password";
			passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			passwordDataGridViewTextBoxColumn.ReadOnly = true;
			passwordDataGridViewTextBoxColumn.Visible = false;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
			firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
			lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// roleDataGridViewTextBoxColumn
			// 
			roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
			roleDataGridViewTextBoxColumn.HeaderText = "Role";
			roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
			roleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userBindingSource
			// 
			userBindingSource.DataSource = typeof(User);
			// 
			// frmStudentSchedule_StudentSelector
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(215, 192, 255);
			ClientSize = new Size(741, 451);
			Controls.Add(btnUpdateSch);
			Controls.Add(dgvStudentSchSelect);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmStudentSchedule_StudentSelector";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Student Schedule Selector";
			Load += frmStudentSchedule_StudentSelector_Load;
			((System.ComponentModel.ISupportInitialize)dgvStudentSchSelect).EndInit();
			((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnUpdateSch;
		private DataGridView dgvStudentSchSelect;
		private BindingSource userBindingSource;
		private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
	}
}