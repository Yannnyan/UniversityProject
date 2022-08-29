namespace User_Interface
{
    partial class AcceptionDepartmentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceptionDepartmentPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.goHomeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(173, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי סטודנטים שנירשמו";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "לחץ לטעינת פרטי הסטודנטים";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(651, 344);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // goHomeButton
            // 
            this.goHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("goHomeButton.Image")));
            this.goHomeButton.Location = new System.Drawing.Point(12, 12);
            this.goHomeButton.Name = "goHomeButton";
            this.goHomeButton.Size = new System.Drawing.Size(110, 111);
            this.goHomeButton.TabIndex = 1;
            this.goHomeButton.UseVisualStyleBackColor = true;
            this.goHomeButton.Click += new System.EventHandler(this.goHomeButton_Click);
            // 
            // AcceptionDepartmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 544);
            this.Controls.Add(this.goHomeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AcceptionDepartmentPage";
            this.Text = "AcceptionDepartmentPage";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button goHomeButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
    }
}