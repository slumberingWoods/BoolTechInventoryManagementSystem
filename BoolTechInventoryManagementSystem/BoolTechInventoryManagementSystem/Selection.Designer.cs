namespace BoolTechInventoryManagementSystem
{
    partial class Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection));
            this.viewItemButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.viewUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewItemButton
            // 
            resources.ApplyResources(this.viewItemButton, "viewItemButton");
            this.viewItemButton.Name = "viewItemButton";
            this.viewItemButton.UseVisualStyleBackColor = true;
            this.viewItemButton.Click += new System.EventHandler(this.viewItemButton_Click);
            // 
            // logButton
            // 
            resources.ApplyResources(this.logButton, "logButton");
            this.logButton.Name = "logButton";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // financeButton
            // 
            resources.ApplyResources(this.financeButton, "financeButton");
            this.financeButton.Name = "financeButton";
            this.financeButton.UseVisualStyleBackColor = true;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // viewUserButton
            // 
            resources.ApplyResources(this.viewUserButton, "viewUserButton");
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.UseVisualStyleBackColor = true;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // Selection
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.financeButton);
            this.Controls.Add(this.viewUserButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.viewItemButton);
            this.Name = "Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Selection_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewItemButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.Button viewUserButton;
    }
}