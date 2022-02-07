using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Main : Form
    {
        private IMongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<Todo> collection;

        public Main()
        {
            this.dbClient = new MongoClient("mongodb+srv://admin:81Vd0FTfg7iR8YjK@cluster0.5zsx0.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            this.db = this.dbClient.GetDatabase("to-do");
            this.collection = this.db.GetCollection<Todo>("todos");

            InitializeComponent();
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }

        private void textAddToDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = todoList.Text;
            var filter = Builders<Todo>.Filter.Eq("description", selectedItem);
            Todo selectedTodo = this.collection.Find(filter).FirstOrDefault();

            if (selectedTodo == null)
            {
                return;
            }

            var updatedTodo = Builders<Todo>.Update.Set("isCompleted", !selectedTodo.IsCompleted);
            this.collection.UpdateOne(filter, updatedTodo);

            int index = todoList.SelectedIndex;
            todoList.SetItemChecked(index, !selectedTodo.IsCompleted);
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (textAddToDo.Text == "")
            {
                MessageBox.Show("You should put a name to your to-do!");
                return;
            }
            
            Todo todo = new Todo(textAddToDo.Text, Properties.Settings.Default.UserId, false);
            this.collection.InsertOne(todo);

            todoList.Items.Add(todo.Description);
            textAddToDo.Clear();
        }

        private void Check_All_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < todoList.Items.Count; i++)
            {
                todoList.SetItemChecked(i, true);
                string selectedItem = todoList.Items[i].ToString();

                var filter = Builders<Todo>.Filter.Eq("description", selectedItem);
                Todo selectedTodo = this.collection.Find(filter).FirstOrDefault();

                if (selectedTodo == null)
                {
                    return;
                }

                var updatedTodo = Builders<Todo>.Update.Set("isCompleted", true);
                this.collection.UpdateOne(filter, updatedTodo);
            }
        }

        private void Delete_ToDo_btn_Click(object sender, EventArgs e)
        {
            var deleteFilter = Builders<Todo>.Filter.Eq("description", todoList.Text);
            this.collection.DeleteOne(deleteFilter);
            todoList.Items.Remove(todoList.Text);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Load all todos
            var filter = Builders<Todo>.Filter.Eq("owner", Properties.Settings.Default.UserId);
            List<Todo> todos = this.collection.Find(filter).ToList<Todo>();

            foreach (var todo in todos)
            {
                int index = todoList.Items.Add(todo.Description);

                // If todo is completed
                if (todo.IsCompleted)
                {
                    todoList.SetItemChecked(index, true);
                }
            }
        }
    }
}
