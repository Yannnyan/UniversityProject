namespace UniversityProject.View
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.moneyDepartmentButton = new System.Windows.Forms.Button();
            this.registerDepartmentButton = new System.Windows.Forms.Button();
            this.acceptionDepartmentButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.helpButton);
            this.panel1.Controls.Add(this.moneyDepartmentButton);
            this.panel1.Controls.Add(this.registerDepartmentButton);
            this.panel1.Controls.Add(this.acceptionDepartmentButton);
            this.panel1.Controls.Add(this.studentButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 125);
            this.panel1.TabIndex = 0;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.helpButton.Location = new System.Drawing.Point(866, 32);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(112, 65);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "אפשרויות נוספות וקבלת עזרה";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // moneyDepartmentButton
            // 
            this.moneyDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.moneyDepartmentButton.Location = new System.Drawing.Point(690, 32);
            this.moneyDepartmentButton.Name = "moneyDepartmentButton";
            this.moneyDepartmentButton.Size = new System.Drawing.Size(158, 65);
            this.moneyDepartmentButton.TabIndex = 4;
            this.moneyDepartmentButton.Text = "הזדהות כעובד מחלקת כספים";
            this.moneyDepartmentButton.UseVisualStyleBackColor = false;
            this.moneyDepartmentButton.Click += new System.EventHandler(this.moneyDepartmentButton_Click);
            // 
            // registerDepartmentButton
            // 
            this.registerDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.registerDepartmentButton.Location = new System.Drawing.Point(510, 32);
            this.registerDepartmentButton.Name = "registerDepartmentButton";
            this.registerDepartmentButton.Size = new System.Drawing.Size(158, 65);
            this.registerDepartmentButton.TabIndex = 3;
            this.registerDepartmentButton.Text = "הזדהות כעובד מחלקת רישום";
            this.registerDepartmentButton.UseVisualStyleBackColor = false;
            this.registerDepartmentButton.Click += new System.EventHandler(this.registerDepartmentButton_Click);
            // 
            // acceptionDepartmentButton
            // 
            this.acceptionDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.acceptionDepartmentButton.Location = new System.Drawing.Point(332, 32);
            this.acceptionDepartmentButton.Name = "acceptionDepartmentButton";
            this.acceptionDepartmentButton.Size = new System.Drawing.Size(158, 65);
            this.acceptionDepartmentButton.TabIndex = 2;
            this.acceptionDepartmentButton.Text = "הזדהות כעובד מחלקת קבלה";
            this.acceptionDepartmentButton.UseVisualStyleBackColor = false;
            this.acceptionDepartmentButton.Click += new System.EventHandler(this.acceptionDepartmentButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.studentButton.Location = new System.Drawing.Point(152, 32);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(158, 65);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "הזדהות כסטודנט";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(115, 110);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 434);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 434);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button studentButton;
        private Button registerDepartmentButton;
        private Button acceptionDepartmentButton;
        private Button helpButton;
        private Button moneyDepartmentButton;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}