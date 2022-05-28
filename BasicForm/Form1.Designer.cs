namespace BasicForm
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Checkbox");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dropdown");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Options", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserDetailsBox = new System.Windows.Forms.GroupBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CityList = new System.Windows.Forms.ListBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.Csharp = new System.Windows.Forms.CheckBox();
            this.java = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.TreeView();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.UserDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDetailsBox
            // 
            this.UserDetailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserDetailsBox.Controls.Add(this.AddressBox);
            this.UserDetailsBox.Controls.Add(this.NameBox);
            this.UserDetailsBox.Controls.Add(this.AddressLabel);
            this.UserDetailsBox.Controls.Add(this.NameLabel);
            this.UserDetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDetailsBox.Location = new System.Drawing.Point(34, 35);
            this.UserDetailsBox.Name = "UserDetailsBox";
            this.UserDetailsBox.Size = new System.Drawing.Size(239, 143);
            this.UserDetailsBox.TabIndex = 0;
            this.UserDetailsBox.TabStop = false;
            this.UserDetailsBox.Text = "User Details";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(116, 82);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 23);
            this.AddressBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(116, 39);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 23);
            this.NameBox.TabIndex = 1;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(17, 82);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // CityList
            // 
            this.CityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityList.FormattingEnabled = true;
            this.CityList.ItemHeight = 16;
            this.CityList.Items.AddRange(new object[] {
            "Mumbai",
            "Chennai",
            "Banglore"});
            this.CityList.Location = new System.Drawing.Point(34, 243);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(120, 84);
            this.CityList.TabIndex = 1;
            this.CityList.SelectedIndexChanged += new System.EventHandler(this.CityList_SelectedIndexChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(293, 60);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(54, 17);
            this.Male.TabIndex = 2;
            this.Male.TabStop = true;
            this.Male.Text = "MALE";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(293, 93);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(67, 17);
            this.female.TabIndex = 3;
            this.female.TabStop = true;
            this.female.Text = "FEMALE";
            this.female.UseVisualStyleBackColor = true;
            // 
            // Csharp
            // 
            this.Csharp.AutoSize = true;
            this.Csharp.Location = new System.Drawing.Point(293, 161);
            this.Csharp.Name = "Csharp";
            this.Csharp.Size = new System.Drawing.Size(40, 17);
            this.Csharp.TabIndex = 4;
            this.Csharp.Text = "C#";
            this.Csharp.UseVisualStyleBackColor = true;
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(293, 208);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(52, 17);
            this.java.TabIndex = 5;
            this.java.Text = "JAVA";
            this.java.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(222, 346);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(99, 36);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "SUBMIT";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Root
            // 
            this.Root.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Root.Location = new System.Drawing.Point(396, 43);
            this.Root.Name = "Root";
            treeNode1.Name = "CB";
            treeNode1.Text = "Checkbox";
            treeNode2.Name = "DD";
            treeNode2.Text = "Dropdown";
            treeNode3.Name = "RootName";
            treeNode3.Text = "Options";
            this.Root.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.Root.Size = new System.Drawing.Size(161, 135);
            this.Root.TabIndex = 7;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(332, 263);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(333, 76);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 405);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.java);
            this.Controls.Add(this.Csharp);
            this.Controls.Add(this.female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.CityList);
            this.Controls.Add(this.UserDetailsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UserDetailsBox.ResumeLayout(false);
            this.UserDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UserDetailsBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListBox CityList;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.CheckBox Csharp;
        private System.Windows.Forms.CheckBox java;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TreeView Root;
        private System.Windows.Forms.PictureBox Logo;
    }
}

