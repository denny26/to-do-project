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
    public partial class Registration : Form
    {
        private IMongoClient dbClient;
        private IMongoDatabase db;
        private IMongoCollection<User> collection;
        public Registration()
        {
            this.dbClient = new MongoClient("mongodb+srv://admin:81Vd0FTfg7iR8YjK@cluster0.5zsx0.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            this.db = this.dbClient.GetDatabase("to-do");
            this.collection = this.db.GetCollection<User>("users");
            InitializeComponent();
        }

        private void Sign_in_btn_Click(object sender, EventArgs e) //Sign in
        {   
            // Check for empty fields
            if (textEmail.Text == "" || textUsername.Text == "" || textPassword.Text == "")
            {    
                MessageBox.Show("You have an empty field either for email, username or password. Please fill all the empthy fields!");
                return;
            }

            // Check for already used email
            var filter = Builders<User>.Filter.Eq("email", textEmail.Text);
            User userWithUsedEmail = this.collection.Find(filter).FirstOrDefault();

            if (userWithUsedEmail != null)
            {
                MessageBox.Show("This email is already used! Please, use another one!");
                return;
            }

            string hashedPassword = PasswordHash.Hash(textPassword.Text);

            User user = new User(textEmail.Text, textUsername.Text, hashedPassword);
            this.collection.InsertOne(user);
            Properties.Settings.Default.UserId = user.Id.ToString();
            MessageBox.Show("Your info was saved successfully.");

            this.Hide();
            new Main().Show();
        }

        private void Registration_Leave(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
    }
}
