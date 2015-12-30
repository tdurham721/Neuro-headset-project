/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: Welcome.cs
 * 
 * Description: The first page of the GUI. It's the welcome screen where users can choose to sign up for
 *              the system or log in with an existing account.
 * 
 * Parameters: 
 * 
 * Returns: N/A
 * 
 **********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollectionOfCentroids;
using CreatingCentroids;
using speak_your_mind;

namespace speak_your_mind
{
    public partial class Welcome : Form
    {
        StringBuilder user_info = new StringBuilder();
        string userInfoString;
        bool userClickedClose;
        static int numWelcomes = 0;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            numWelcomes++;
            this.loginTextBox.Visible = false;
            this.signUpTextBox.Visible = false;
            this.loginSubmitButton.Visible = false;
            this.signUpSubmitButton.Visible = false;
            this.FormClosing += Form1_FormClosing; //For closing the program
            this.userClickedClose = true;
        }

        //Returns a the collection of centroids for each word
        private List<Centroid> get_collection()
        {
            CentroidCollection cc = new CentroidCollection(); //Creating the collection object
            return cc.create_collection(); //Creates the collection of centroids for each word and returns the collection as a list of centroids
        }

        //Login
        private void login_Click(object sender, EventArgs e)
        {
            this.loginTextBox.Text = "Enter username"; //Filling in the textbox
            this.loginTextBox.Visible = true; //Showing the text box after the click
            this.loginSubmitButton.Visible = true; //Showing the submit button
            this.signUpTextBox.Visible = false; //Hiding the the other textbox
            this.signUpSubmitButton.Visible = false; //Hiding the other submit button
        }

        //When Login Username Box is clicked
        private void loginTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginTextBox.Text == "Enter username")
            {
                loginTextBox.Text = "";
            }
        }

        //Sign Up
        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.signUpTextBox.Text = "Enter username";
            this.signUpTextBox.Visible = true;
            this.signUpSubmitButton.Visible = true;
            this.loginTextBox.Visible = false;
            this.loginSubmitButton.Visible = false;
        }

        //When user clicks the textbox for Sign Up
        private void signUpTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (signUpTextBox.Text == "Enter username")
            {
                signUpTextBox.Text = "";
            }
        }

        //Submit button for Login Button
        private void loginSubmitButton_Click(object sender, EventArgs e)
        {

            //Read in .txt for their saved data
            if ((loginTextBox.Text == "Enter username") || (loginTextBox.Text == " "))
            {
                MessageBox.Show("Please enter a valid username.");
            }
            else
            {
                string[] all_text = System.IO.File.ReadAllLines(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\info.txt");
                bool validUsername = false;
                foreach(string s in all_text)
                {
                    if (loginTextBox.Text == s.Substring(0, s.IndexOf(',')))
                    {
                        validUsername = true;
                        MessageBox.Show("Login successful.");

                        this.userInfoString = s;
                        this.userClickedClose = false;
                        Form choice = new Start(get_collection(), this.userInfoString);
                        choice.Show();
                        if (numWelcomes != 1)
                        {
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                        }
                    }
                }
                if (validUsername == false)
                {
                    MessageBox.Show("Username not found.");
                    loginTextBox.Clear();
                }
            }
        }

        //Submit button for Sign Up Button
        private void signUpSubmitButton_Click(object sender, EventArgs e)
        {
            //Add a row for them with values of 0 for everything
            //Check if user is already signed up with that name
            if ((signUpTextBox.Text == "Enter username") || (signUpTextBox.Text == "") || (signUpTextBox.Text.Contains(',')))
            {
                MessageBox.Show("Please enter a valid username.");
            }
            else
            {
                bool validUsername = true;
                string[] all_text = System.IO.File.ReadAllLines(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\info.txt");
                foreach (string s in all_text)
                {
                    if (s.Substring(0, s.IndexOf(',')) == signUpTextBox.Text)
                    {
                        MessageBox.Show("Username already exists in the database.");
                        validUsername = false;
                        break;
                    }
                }
                if (validUsername == true)
                {
                    user_info.AppendLine(signUpTextBox.Text + ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0");
                    this.userInfoString = signUpTextBox.Text + ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\info.txt", true))
                    {
                        file.Write(user_info);
                    }

                    this.userClickedClose = false;
                    Form choice = new Start(get_collection(), this.userInfoString);
                    choice.Show();
                    if (numWelcomes != 1)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                    }
                    signUpTextBox.Clear();
                }
            }
        }

        //Closing the program
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.userClickedClose == true)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to quit?", "Speak Your Mind", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else if (answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
