using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace world_resources
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        [Obsolete]
        private void loginButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO users (login, password) VALUES (@login, @password)", db.getConnection());

            command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1) 
            {
                MessageBox.Show("Пользователь успешно добавлен");            
            } else
            {
                MessageBox.Show("Не удалось добавить пользователя");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            loginForm.Visible = true;
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
