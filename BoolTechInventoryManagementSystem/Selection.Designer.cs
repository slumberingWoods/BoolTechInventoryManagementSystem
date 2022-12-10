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
            this.viewItemButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.viewUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewItemButton
            // 
            this.viewItemButton.Location = new System.Drawing.Point(53, 24);
            this.viewItemButton.Name = "viewItemButton";
            this.viewItemButton.Size = new System.Drawing.Size(125, 75);
            this.viewItemButton.TabIndex = 0;
            this.viewItemButton.Text = "View Items";
            this.viewItemButton.UseVisualStyleBackColor = true;
            this.viewItemButton.Click += new System.EventHandler(this.viewItemButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(196, 24);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(125, 75);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "Sells Log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // financeButton
            // 
            this.financeButton.Location = new System.Drawing.Point(196, 121);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(125, 75);
            this.financeButton.TabIndex = 3;
            this.financeButton.Text = "Financials";
            this.financeButton.UseVisualStyleBackColor = true;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // viewUserButton
            // 
            this.viewUserButton.Location = new System.Drawing.Point(53, 121);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Size = new System.Drawing.Size(125, 75);
            this.viewUserButton.TabIndex = 2;
            this.viewUserButton.Text = "View User";
            this.viewUserButton.UseVisualStyleBackColor = true;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 241);
            this.Controls.Add(this.financeButton);
            this.Controls.Add(this.viewUserButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.viewItemButton);
            this.Name = "Selection";
            this.Text = "User Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewItemButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.Button viewUserButton;
    }
}