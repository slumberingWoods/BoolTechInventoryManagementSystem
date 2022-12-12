namespace BoolTechInventoryManagementSystem
{
    partial class deleteSalesLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteSalesLog));
            this.deleteLabel = new System.Windows.Forms.Label();
            this.logId = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.darkButton = new System.Windows.Forms.RadioButton();
            this.lightButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteLabel
            // 
            resources.ApplyResources(this.deleteLabel, "deleteLabel");
            this.deleteLabel.Name = "deleteLabel";
            // 
            // logId
            // 
            resources.ApplyResources(this.logId, "logId");
            this.logId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logId.Name = "logId";
            // 
            // logTextBox
            // 
            resources.ApplyResources(this.logTextBox, "logTextBox");
            this.logTextBox.Name = "logTextBox";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            // 
            // lightButton
            // 
            resources.ApplyResources(this.lightButton, "lightButton");
            this.lightButton.Checked = true;
            this.lightButton.Name = "lightButton";
            this.lightButton.TabStop = true;
            this.lightButton.UseVisualStyleBackColor = true;
            // 
            // deleteSalesLog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.logId);
            this.Controls.Add(this.deleteLabel);
            this.Name = "deleteSalesLog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label logId;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton darkButton;
        private System.Windows.Forms.RadioButton lightButton;
    }
}