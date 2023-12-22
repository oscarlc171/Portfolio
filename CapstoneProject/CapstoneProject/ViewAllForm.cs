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
    public partial class ViewAllForm : Form
    {
        private readonly DatabaseConnectionFactory _connectionFactory;
        public ViewAllForm(DatabaseConnectionFactory Conn) : this()
        {
            _connectionFactory = Conn;
        }
        public ViewAllForm()
        {
            InitializeComponent();
            
        }

        private void addTaskButton2_Click(object sender, EventArgs e)
        {
            new AddTaskForm(_connectionFactory).ShowDialog();
        }

        private void ViewAllForm_Load(object sender, EventArgs e)
        {
            viewAllListBox.DataSource = GetTasks();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveTask((Task)viewAllListBox.SelectedItem);
        }
        public int RemoveTask(Task task)
        {
            var sql = "DELETE FROM Tasks WHERE Name = @Name AND Description = @Description AND DueDate = @DueDate";
            using (var connection = _connectionFactory.GetConnection)
            {
                //connection.Open();
                var result = connection.Execute(sql, task);
                return result;
            }
        }

        public List<Task> GetTasks()
        {
            var sql = "SELECT Name, Description, DueDate FROM Tasks";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Query<Task>(sql);
                return result.ToList();
            }
        }

        private void viewAllListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
