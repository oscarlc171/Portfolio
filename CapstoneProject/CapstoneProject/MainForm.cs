namespace CapstoneProject
{
    public partial class TaskTrackerForm : Form
    {
        private DatabaseConnectionFactory connectionFactory;
        public TaskTrackerForm(DatabaseConnectionFactory conn)
        {
            connectionFactory = conn;
            InitializeComponent();
        }


        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm addtaskform = new AddTaskForm(connectionFactory);
            addtaskform.ShowDialog();
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            ViewAllForm viewallform = new ViewAllForm(connectionFactory);
            viewallform.ShowDialog();
        }
    }
}