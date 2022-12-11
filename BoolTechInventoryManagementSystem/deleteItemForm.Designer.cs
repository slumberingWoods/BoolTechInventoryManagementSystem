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
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(90, 15);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(164, 20);
            this.idtextBox.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(13, 18);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(35, 13);
            this.id.TabIndex = 1;
            this.id.Text = "itemId";
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(90, 70);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(107, 23);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Remove Item";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // deleteItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 120);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idtextBox);
            this.Name = "deleteItemForm";
            this.Text = "deleteItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button delButton;
    }
}