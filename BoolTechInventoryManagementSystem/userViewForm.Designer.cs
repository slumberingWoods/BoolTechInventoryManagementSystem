namespace BoolTechInventoryManagementSystem
{
    partial class userViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userViewForm));
            this.currentUserLable = new System.Windows.Forms.Label();
            this.displayUserLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.darkButton = new System.Windows.Forms.RadioButton();
            this.lightButton = new System.Windows.Forms.RadioButton();
            this.changeUser = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentUserLable
            // 
            resources.ApplyResources(this.currentUserLable, "currentUserLable");
            this.currentUserLable.Name = "currentUserLable";
            // 
            // displayUserLabel
            // 
            resources.ApplyResources(this.displayUserLabel, "displayUserLabel");
            this.displayUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayUserLabel.Name = "displayUserLabel";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.darkButton);
            this.groupBox1.Controls.Add(this.lightButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // darkButton
            // 
            resources.ApplyResources(this.darkButton, "darkButton");
            this.darkButton.Name = "darkButton";
            this.darkButton.UseVisualStyleBackColor = true;
            this.darkButton.CheckedChanged += new System.EventHandler(this.darkButton_CheckedChanged);
            // 
            // lightButton
            // 
            resources.ApplyResources(this.lightButton, "lightButton");
            this.lightButton.Checked = true;
            this.lightButton.Name = "lightButton";
            this.lightButton.TabStop = true;
            this.lightButton.UseVisualStyleBackColor = true;
            this.lightButton.CheckedChanged += new System.EventHandler(this.lightButton_CheckedChanged);
            // 
            // changeUser
            // 
            resources.ApplyResources(this.changeUser, "changeUser");
            this.changeUser.Name = "changeUser";
            this.changeUser.UseVisualStyleBackColor = true;
            this.changeUser.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // changePassword
            // 
            resources.ApplyResources(this.changePassword, "changePassword");
            this.changePassword.Name = "changePassword";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // userViewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.changeUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayUserLabel);
            this.Controls.Add(this.currentUserLable);
            this.Name = "userViewForm";
            this.Load += new System.EventHandler(this.userViewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentUserLable;
        private System.Windows.Forms.Label displayUserLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton darkButton;
        private System.Windows.Forms.RadioButton lightButton;
        private System.Windows.Forms.Button changeUser;
        private System.Windows.Forms.Button changePassword;
    }
}