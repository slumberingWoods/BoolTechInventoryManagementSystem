namespace BoolTechInventoryManagementSystem
{
    partial class addSalesLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSalesLog));
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.clearData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.darkButton = new System.Windows.Forms.RadioButton();
            this.lightButton = new System.Windows.Forms.RadioButton();
            this.addLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            resources.ApplyResources(this.userIdLabel, "userIdLabel");
            this.userIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userIdLabel.Name = "userIdLabel";
            // 
            // userTextBox
            // 
            resources.ApplyResources(this.userTextBox, "userTextBox");
            this.userTextBox.Name = "userTextBox";
            // 
            // itemIdLabel
            // 
            resources.ApplyResources(this.itemIdLabel, "itemIdLabel");
            this.itemIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemIdLabel.Name = "itemIdLabel";
            // 
            // priceLabel
            // 
            resources.ApplyResources(this.priceLabel, "priceLabel");
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceLabel.Name = "priceLabel";
            // 
            // quantityLabel
            // 
            resources.ApplyResources(this.quantityLabel, "quantityLabel");
            this.quantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quantityLabel.Name = "quantityLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateLabel.Name = "dateLabel";
            // 
            // itemTextBox
            // 
            resources.ApplyResources(this.itemTextBox, "itemTextBox");
            this.itemTextBox.Name = "itemTextBox";
            // 
            // priceTextBox
            // 
            resources.ApplyResources(this.priceTextBox, "priceTextBox");
            this.priceTextBox.Name = "priceTextBox";
            // 
            // quantityTextBox
            // 
            resources.ApplyResources(this.quantityTextBox, "quantityTextBox");
            this.quantityTextBox.Name = "quantityTextBox";
            // 
            // dateTextBox
            // 
            resources.ApplyResources(this.dateTextBox, "dateTextBox");
            this.dateTextBox.Name = "dateTextBox";
            // 
            // addItem
            // 
            resources.ApplyResources(this.addItem, "addItem");
            this.addItem.Name = "addItem";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click_1);
            // 
            // clearData
            // 
            resources.ApplyResources(this.clearData, "clearData");
            this.clearData.Name = "clearData";
            this.clearData.UseVisualStyleBackColor = true;
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
            // addLabel
            // 
            resources.ApplyResources(this.addLabel, "addLabel");
            this.addLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addLabel.Name = "addLabel";
            // 
            // addSalesLog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearData);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.itemIdLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Name = "addSalesLog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button clearData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton darkButton;
        private System.Windows.Forms.RadioButton lightButton;
        private System.Windows.Forms.Label addLabel;
    }
}