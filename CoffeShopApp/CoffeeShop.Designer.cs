namespace CoffeShopApp
{
    partial class CoffeeShop
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CustomertextBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(380, 400);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 34);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomertextBox
            // 
            this.CustomertextBox.Location = new System.Drawing.Point(309, 148);
            this.CustomertextBox.Name = "CustomertextBox";
            this.CustomertextBox.Size = new System.Drawing.Size(203, 20);
            this.CustomertextBox.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(126, 94);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(453, 369);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Customer  Infromation";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(620, 52);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(420, 468);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(309, 236);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(203, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(309, 190);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(203, 20);
            this.contactTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(309, 354);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(203, 20);
            this.quantityTextBox.TabIndex = 7;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(164, 156);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 8;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Location = new System.Drawing.Point(164, 197);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(61, 13);
            this.contactNoLabel.TabIndex = 9;
            this.contactNoLabel.Text = "Contact No";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(164, 243);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address";
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(164, 303);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(33, 13);
            this.OrderLabel.TabIndex = 11;
            this.OrderLabel.Text = "Order";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(164, 361);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 12;
            this.QuantityLabel.Text = "Quantity";
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(309, 303);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(203, 21);
            this.orderComboBox.TabIndex = 13;
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 591);
            this.Controls.Add(this.CustomertextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.contactNoLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.groupBox);
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CustomertextBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.ComboBox orderComboBox;
    }
}

