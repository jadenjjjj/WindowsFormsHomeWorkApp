namespace WindowsFormsHomeWorkDemo1
{
    partial class UserInfo
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
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.addFirstNameButton = new System.Windows.Forms.Button();
            this.addLastName = new System.Windows.Forms.Button();
            this.greetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(296, 101);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 21);
            this.firstNameText.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(296, 172);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 21);
            this.lastNameText.TabIndex = 1;
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstNameLable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstNameLable.Location = new System.Drawing.Point(173, 101);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(88, 21);
            this.firstNameLable.TabIndex = 2;
            this.firstNameLable.Text = "FirstName";
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lastNameLable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lastNameLable.Location = new System.Drawing.Point(173, 172);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(86, 21);
            this.lastNameLable.TabIndex = 3;
            this.lastNameLable.Text = "LastName";
            // 
            // addFirstNameButton
            // 
            this.addFirstNameButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addFirstNameButton.Location = new System.Drawing.Point(449, 101);
            this.addFirstNameButton.Name = "addFirstNameButton";
            this.addFirstNameButton.Size = new System.Drawing.Size(75, 23);
            this.addFirstNameButton.TabIndex = 4;
            this.addFirstNameButton.Text = "Add";
            this.addFirstNameButton.UseVisualStyleBackColor = true;
            this.addFirstNameButton.Click += new System.EventHandler(this.addFirstNameButton_Click);
            // 
            // addLastName
            // 
            this.addLastName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addLastName.Location = new System.Drawing.Point(449, 169);
            this.addLastName.Name = "addLastName";
            this.addLastName.Size = new System.Drawing.Size(75, 23);
            this.addLastName.TabIndex = 6;
            this.addLastName.Text = "Add";
            this.addLastName.UseVisualStyleBackColor = true;
            this.addLastName.Click += new System.EventHandler(this.addLastName_Click);
            // 
            // greetButton
            // 
            this.greetButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.greetButton.Location = new System.Drawing.Point(279, 241);
            this.greetButton.Name = "greetButton";
            this.greetButton.Size = new System.Drawing.Size(137, 44);
            this.greetButton.TabIndex = 7;
            this.greetButton.Text = "Hi";
            this.greetButton.UseVisualStyleBackColor = true;
            this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 348);
            this.Controls.Add(this.greetButton);
            this.Controls.Add(this.addLastName);
            this.Controls.Add(this.addFirstNameButton);
            this.Controls.Add(this.lastNameLable);
            this.Controls.Add(this.firstNameLable);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.Button addFirstNameButton;
        private System.Windows.Forms.Button addLastName;
        private System.Windows.Forms.Button greetButton;
    }
}

