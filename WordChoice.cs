/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: WordChoice.cs
 * 
 * Description: Here, the user can select one word and choose to train on it. The user cannot proceed unless
 *              the user has chosen a word. Once the word is selected, that centroid is pulled out from the
 *              collection, and both the collection and that centroid are passed to the next page.
 * 
 * Parameters: N/A
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
using Emotiv;
using System.IO;
using System.Threading;
using System.Reflection;
using ReadingData;
using MatchData;
using GettingData;
using CollectionOfCentroids;
using CreatingCentroids;

namespace speak_your_mind
{
    public partial class WordChoice : Form
    {
        List<Centroid> collection;
        string userInfoString;
        bool userClickedClose;

        public WordChoice(List<Centroid> collection, string userInfoString)
        {
            InitializeComponent();
            this.collection = collection;
            this.FormClosing += Form1_FormClosing; //For closing the program
            this.userInfoString = userInfoString;
            this.userClickedClose = true;
        }

        //Begin Training Button
        private void beginTrainingButton_Click(object sender, EventArgs e)
        {
            string wordChosen = "";

            if (this.bathroomRadioButton.Checked)
            {
                wordChosen = "bathroom";
            }

            else if (this.foodRadioButton.Checked)
            {
                wordChosen = "food";
            }

            else if (this.helloRadioButton.Checked)
            {
                wordChosen = "hello";
            }

            else if (this.helpRadioButton.Checked)
            {
                wordChosen = "help";
            }

            else if (this.howRadioButton.Checked)
            {
                wordChosen = "how";
            }

            else if (this.needRadioButton.Checked)
            {
                wordChosen = "need";
            }

            else if (this.noRadioButton.Checked)
            {
                wordChosen = "no";
            }

            else if (this.pleaseRadioButton.Checked)
            {
                wordChosen = "please";
            }

            else if (this.sleepRadioButton.Checked)
            {
                wordChosen = "sleep";
            }

            else if (this.stopRadioButton.Checked)
            {
                wordChosen = "stop";
            }

            else if (this.thanksRadioButton.Checked)
            {
                wordChosen = "thanks";
            }

            else if (this.timeRadioButton.Checked)
            {
                wordChosen = "time";
            }

            else if (this.wantRadioButton.Checked)
            {
                wordChosen = "want";
            }

            else if (this.waterRadioButton.Checked)
            {
                wordChosen = "water";
            }

            else if (this.whatRadioButton.Checked)
            {
                wordChosen = "what";
            }

            else if (wordChosen == "")
            {
                MessageBox.Show("Please choose a word.");
                return;
            }


            Centroid c = collection.Find(item => item.name == wordChosen);

            userClickedClose = false;
            Form training_page = new Training(c, collection, this.userInfoString);
            training_page.Show();
            this.Close();
        }

        //Home button
        private void homeButton_Click(object sender, EventArgs e)
        {
            userClickedClose = false;
            Form main_menu = new Start(collection, this.userInfoString);
            this.Close();
            main_menu.Show();
        }

        //Closing the program
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userClickedClose)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to quit?", "Speak Your Mind", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    //Here is where we write the user's info to the .txt file
                    string[] all_text = System.IO.File.ReadAllLines(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\info.txt");
                    int i = 0;
                    foreach (string s in all_text)
                    {
                        if (s.Substring(0, s.IndexOf(',')) == this.userInfoString.Substring(0, s.IndexOf(',')))
                        {
                            all_text[i] = this.userInfoString;
                        }
                        i++;
                    }
                    System.IO.File.WriteAllLines(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\info.txt", all_text);
                    Environment.Exit(0);
                }
                else if (answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to logout?", "Speak Your Mind", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                string[] all_text = System.IO.File.ReadAllLines(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\info.txt");
                int i = 0;
                foreach (string s in all_text)
                {
                    if (s.Substring(0, s.IndexOf(',')) == this.userInfoString.Substring(0, s.IndexOf(',')))
                    {
                        all_text[i] = this.userInfoString;
                    }
                    i++;
                }
                System.IO.File.WriteAllLines(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\info.txt", all_text);
                this.userClickedClose = false;
                Form choice = new Welcome();
                choice.Show();
                this.Close();
            }
        }
    }
}
