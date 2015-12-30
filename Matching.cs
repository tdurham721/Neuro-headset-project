/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: Matching.cs
 * 
 * Description: On this page, once the user selects match, the system will match the word the user is
 *              currently thinking against what they've trained on already and will show the result on the
 *              screen after notifying the user that the matching has complete via a messagebox.
 * 
 * Parameters: - Centroid Collection
 *             - Temporary centroid
 * 
 * Returns: - The user's result aka the word they were thinking of
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
using GettingData;
using ReadingData;
using CollectionOfCentroids;
using CreatingCentroids;
using System.Threading;
using System.IO;
using MatchData;

namespace speak_your_mind
{
    public partial class Matching : Form
    {
        List<Centroid> collection;
        string userInfoString;
        string[] userInfoStringParsed;
        bool userClickedClose;

        public Matching(List<Centroid> collection, string userInfoString)
        {
            InitializeComponent();
            this.collection = collection;
            this.FormClosing += Form1_FormClosing; //For closing the program
            this.userInfoString = userInfoString;
            this.userInfoStringParsed = userInfoString.Split(',');
            this.userClickedClose = true;
        }

        //Returns an object for reading in the CSV file
        private ReadingCSV read_CSV()
        {
            ReadingCSV r = new ReadingCSV(); //Creating a new object of the reading data class

            return r;
        }
        
        //Match button clicked
        private void matchButton_Click(object sender, EventArgs e)
        {
            EEG_Logger p = new EEG_Logger(); //Creating a new object of the class and acting upon it

            for (int i = 0; i < 10; i++)
            {
                pBar.PerformStep();
                p.Run();
                Thread.Sleep(1660); //Slow down the process, so the user can see what's happening and also to pull data for a specified amount of time
                //1660 for 15.03 Seconds
            }

            Centroid temp_centroid = new Centroid("temp", 0);
            temp_centroid = read_CSV().read_matching_records(); //Reading the .csv file

            File.Delete("outfile.csv");
            pBar.Value = 0;
            MessageBox.Show("Matching complete.");

            MatchingData m = new MatchingData();
            this.label4.Text = m.match_data(collection, temp_centroid);
            this.label4.Visible = true;
            Thread.Sleep(1500);
            //This is to calculate our error rate to make see how accurate we are at predicting the right word
            DialogResult answer = MessageBox.Show("Did we match the right word?", "Speak Your Mind", MessageBoxButtons.YesNo);
            
            if(answer == DialogResult.Yes)
            {
                int yesCount;
                yesCount = Convert.ToInt32(this.userInfoStringParsed[16]) + 1;
                this.userInfoStringParsed[16] = yesCount.ToString();
                this.userInfoString = "";
                foreach (string s in this.userInfoStringParsed)
                {
                    this.userInfoString += (s + ",");
                }
                this.userInfoString = this.userInfoString.Substring(0, this.userInfoString.Length - 1);
            }
            else if(answer == DialogResult.No)
            {
                int noCount;
                noCount = Convert.ToInt32(this.userInfoStringParsed[17]) + 1;
                this.userInfoStringParsed[17] = noCount.ToString();
                this.userInfoString = "";
                foreach (string s in this.userInfoStringParsed)
                {
                    this.userInfoString += (s + ",");
                }
                this.userInfoString = this.userInfoString.Substring(0, this.userInfoString.Length - 1);
            }
        }

        //Clicking Home
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
