namespace BoolTechInventoryManagementSystem
{
    partial class addUserForm
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
            this.Clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userTypeTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.userType = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(152, 191);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(84, 23);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "Clear Data";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(15, 191);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 28;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(136, 68);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 27;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // userTypeTextBox
            // 
            this.userTypeTextBox.Location = new System.Drawing.Point(136, 142);
            this.userTypeTextBox.Name = "userTypeTextBox";
            this.userTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTypeTextBox.TabIndex = 26;
            this.userTypeTextBox.TextChanged += new System.EventHandler(this.userTypeTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(136, 102);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 25;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(136, 29);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 24;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // userType
            // 
            this.userType.AutoSize = true;
            this.userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userType.Location = new System.Drawing.Point(12, 142);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(71, 16);
            this.userType.TabIndex = 23;
            this.userType.Text = "User Type";
            this.userType.Click += new System.EventHandler(this.userType_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(12, 103);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 22;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(12, 69);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(70, 16);
            this.userName.TabIndex = 21;
            this.userName.Text = "Username";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(12, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 16);
            this.id.TabIndex = 20;
            this.id.Text = "Id";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 245);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userTypeTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.id);
            this.Name = "addUserForm";
            this.Text = "addUserForm";
            this.Load += new System.EventHandler(this.addUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userTypeTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label userType;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label id;
    }
}