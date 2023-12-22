namespace CapstoneProject
{
    partial class AddTaskForm
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
            this.dueDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.selectDateLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addTaskButton3 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dueDateCalendar
            // 
            this.dueDateCalendar.Location = new System.Drawing.Point(93, 133);
            this.dueDateCalendar.MaxSelectionCount = 1;
            this.dueDateCalendar.Name = "dueDateCalendar";
            this.dueDateCalendar.ShowToday = false;
            this.dueDateCalendar.ShowTodayCircle = false;
            this.dueDateCalendar.TabIndex = 0;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(20, 15);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(64, 15);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Task Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 48);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // selectDateLabel
            // 
            this.selectDateLabel.AutoSize = true;
            this.selectDateLabel.Location = new System.Drawing.Point(20, 133);
            this.selectDateLabel.Name = "selectDateLabel";
            this.selectDateLabel.Size = new System.Drawing.Size(55, 30);
            this.selectDateLabel.TabIndex = 3;
            this.selectDateLabel.Text = "Select\r\nDue Date";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(93, 15);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(227, 23);
            this.taskNameTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(93, 48);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(227, 73);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // addTaskButton3
            // 
            this.addTaskButton3.Location = new System.Drawing.Point(245, 300);
            this.addTaskButton3.Name = "addTaskButton3";
            this.addTaskButton3.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton3.TabIndex = 6;
            this.addTaskButton3.Text = "Add";
            this.addTaskButton3.UseVisualStyleBackColor = true;
            this.addTaskButton3.Click += new System.EventHandler(this.addTaskButton3_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(164, 300);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 335);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addTaskButton3);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.selectDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.dueDateCalendar);
            this.Name = "AddTaskForm";
            this.Text = "Add Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar dueDateCalendar;
        private Label taskNameLabel;
        private Label descriptionLabel;
        private Label selectDateLabel;
        private TextBox taskNameTextBox;
        private TextBox descriptionTextBox;
        private Button addTaskButton3;
        private Button cancelButton;
    }
}