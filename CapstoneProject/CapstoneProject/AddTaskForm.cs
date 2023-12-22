using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class AddTaskForm : Form
    {

        private readonly DatabaseConnectionFactory connectionFactory;
        public AddTaskForm(DatabaseConnectionFactory Conn) : this ()
        {
            connectionFactory = Conn;
        }
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTaskButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskNameTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("One or more text boxes was left blank", "Task Tracker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Task task = new Task();
                task.Name = taskNameTextBox.Text;
                task.Description = descriptionTextBox.Text;
                task.DueDate = dueDateCalendar.SelectionStart;
                AddTask(task);
                string message = "Task added";
                string title = "Task Tracker";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                taskNameTextBox.Clear();
                descriptionTextBox.Clear();
                dueDateCalendar.SetDate(DateTime.Now);
            }
        }

        public int AddTask(Task task)
        {
            var sql = "INSERT INTO Tasks (Name, Description, DueDate, DateCreated) VALUES (@Name, @Description, @DueDate, GETDATE());";
            using (var connection = connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, task);
                return result;
            }
        }
    }
}
