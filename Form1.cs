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
    public partial class Form1 : Form
    {
        private IMongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<User> collection;

        public Form1()
        {
            this.dbClient = new MongoClient("mongodb+srv://admin:81Vd0FTfg7iR8YjK@cluster0.5zsx0.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            this.db = this.dbClient.GetDatabase("to-do");
            this.collection = this.db.GetCollection<User>("users");
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e) //Login
        {
            var filter = Builders<User>.Filter.Eq("email", textEmail.Text);
            User user = this.collection.Find(filter).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Email or password are incorrect!");
                return;
            }

            string hashedPassword = PasswordHash.Hash(textPassword.Text);
                
            if (user.Password != hashedPassword)
            {
                MessageBox.Show("Email or password are incorrect!");
                return;
            }

            Properties.Settings.Default.UserId = user.Id.ToString();

            MessageBox.Show("You logged in successfully.");
            this.Hide();
            new Main().Show();
        }

        private void Clear_btn_Click(object sender, EventArgs e) //Clear
        {
            textEmail.Clear();
            textPassword.Clear();
        }

        private void Click_here_btn_Click(object sender, EventArgs e) //Click here
        {
            this.Hide();
            new Registration().Show();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
    }
}
