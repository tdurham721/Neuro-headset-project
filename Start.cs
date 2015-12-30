/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: Start.cs
 * 
 * Description: Once the user has logged in, they can choose whether to train or match a word. The created
 *              collection from the Welcome.cs page will be carried into this page and passed to either train
 *              or match, depending on which one the user picks
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
    public partial class Start : Form
    {
        List<Centroid> collection;
        string userInfoString;
        bool userClickedClose;
        public Start(List<Centroid> collection, string userInfoString)
        {
            InitializeComponent();
            this.collection = collection;
            this.FormClosing += Form1_FormClosing; //For closing the program
            this.userInfoString = userInfoString;
            this.userClickedClose = true;
        }

        //Matching Button
        private void matchingButton_Click(object sender, EventArgs e)
        {
            this.userClickedClose = false;
            Form match_word = new Matching(collection, this.userInfoString);
            this.Close();
            match_word.Show();
        }

        //Training Button
        private void trainingButton_Click(object sender, EventArgs e)
        {
            this.userClickedClose = false;
            Form word_choice = new WordChoice(collection, this.userInfoString);
            this.Close();
            word_choice.Show();
        }

        //Home button
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.userClickedClose = false;
            Form main_menu = new Start(collection, this.userInfoString);
            this.Close();
            main_menu.Show();
        }

        //Closing the program
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.userClickedClose == true)
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
                        break;
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
