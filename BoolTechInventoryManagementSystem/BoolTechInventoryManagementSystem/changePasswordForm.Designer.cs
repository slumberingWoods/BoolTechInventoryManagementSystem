namespace BoolTechInventoryManagementSystem
{
    partial class changePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePasswordForm));
            this.changebutton = new System.Windows.Forms.Button();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oldpasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changebutton
            // 
            resources.ApplyResources(this.changebutton, "changebutton");
            this.changebutton.Name = "changebutton";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // passwordtextBox2
            // 
            resources.ApplyResources(this.passwordtextBox2, "passwordtextBox2");
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // passwordtextBox
            // 
            resources.ApplyResources(this.passwordtextBox, "passwordtextBox");
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // oldpasswordtextBox
            // 
            resources.ApplyResources(this.oldpasswordtextBox, "oldpasswordtextBox");
            this.oldpasswordtextBox.Name = "oldpasswordtextBox";
            this.oldpasswordtextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // changePasswordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oldpasswordtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label3);
            this.Name = "changePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldpasswordtextBox;
        private System.Windows.Forms.Label label1;
    }
}