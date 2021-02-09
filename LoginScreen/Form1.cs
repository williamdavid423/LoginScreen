using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PinLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                String username;
                int pin;

                username = usernameInput.Text;
                pin = Convert.ToInt32(pinInput.Text);

                outputLabel.Text = $"{username} {pin}";
            }
            catch
            {
                 outputLabel.Text = "Please enter numbers only for PIN";
            }

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {

        }
    }
}
