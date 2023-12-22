namespace CapstoneProject
{
    partial class ViewAllForm
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
            this.viewAllListBox = new System.Windows.Forms.ListBox();
            this.addTaskButton2 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // viewAllListBox
            // 
            this.viewAllListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewAllListBox.FormattingEnabled = true;
            this.viewAllListBox.ItemHeight = 15;
            this.viewAllListBox.Location = new System.Drawing.Point(18, 23);
            this.viewAllListBox.Name = "viewAllListBox";
            this.viewAllListBox.ScrollAlwaysVisible = true;
            this.viewAllListBox.Size = new System.Drawing.Size(778, 244);
            this.viewAllListBox.TabIndex = 0;
            this.viewAllListBox.SelectedIndexChanged += new System.EventHandler(this.viewAllListBox_SelectedIndexChanged);
            // 
            // addTaskButton2
            // 
            this.addTaskButton2.Location = new System.Drawing.Point(721, 302);
            this.addTaskButton2.Name = "addTaskButton2";
            this.addTaskButton2.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton2.TabIndex = 1;
            this.addTaskButton2.Text = "Add Task";
            this.addTaskButton2.UseVisualStyleBackColor = true;
            this.addTaskButton2.Click += new System.EventHandler(this.addTaskButton2_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(640, 302);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.Location = new System.Drawing.Point(29, 302);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(97, 23);
            this.completeTaskButton.TabIndex = 3;
            this.completeTaskButton.Text = "Complete Task";
            this.completeTaskButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Tasks";
            // 
            // ViewAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 332);
            this.Controls.Add(this.viewAllListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.completeTaskButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addTaskButton2);
            this.Name = "ViewAllForm";
            this.Text = "View All Tasks";
            this.Load += new System.EventHandler(this.ViewAllForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox viewAllListBox;
        private Button addTaskButton2;
        private Button removeButton;
        private Button completeTaskButton;
        private GroupBox groupBox1;
    }
}