namespace BoolTechInventoryManagementSystem
{
    partial class changeUsernameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeUsernameForm));
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // newNametextBox
            // 
            resources.ApplyResources(this.newNametextBox, "newNametextBox");
            this.newNametextBox.Name = "newNametextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nametextBox
            // 
            resources.ApplyResources(this.nametextBox, "nametextBox");
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // changebutton
            // 
            resources.ApplyResources(this.changebutton, "changebutton");
            this.changebutton.Name = "changebutton";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // changeUsernameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newNametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label1);
            this.Name = "changeUsernameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changebutton;
    }
}