using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm1
{
    public partial class Form1 : Form
    {
        // initialize the connection class
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            // pass the database you want to connect to
            db.Connect("userdata");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            // start register window
            Register register = new Register();
            register.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // query MySQL database for the data passed from textboxes
            db.ExecuteSelect("SELECT * FROM user_info where username='" + username.Text + "' and password ='"+ password.Text+"';");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success You Will Login as " + db.Results(0, "names"));
            }
            else 
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
