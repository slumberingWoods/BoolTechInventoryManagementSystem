namespace BoolTechInventoryManagementSystem
{
    partial class deleteItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteItemForm));
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idtextBox
            // 
            resources.ApplyResources(this.idtextBox, "idtextBox");
            this.idtextBox.Name = "idtextBox";
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // delButton
            // 
            resources.ApplyResources(this.delButton, "delButton");
            this.delButton.Name = "delButton";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // deleteItemForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idtextBox);
            this.Name = "deleteItemForm";
            this.Load += new System.EventHandler(this.deleteItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button delButton;
    }
}