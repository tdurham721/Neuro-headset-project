/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: WordChoice.cs
 * 
 * Description: In this page, the user clicks the train button to begin pulling data from the headset
 *              then it does appropriate calculations, showing the user the word they chose on the screen.
 *              Once it's done, the user will be notified with a messagebox that their training is complete.
 * 
 * Parameters: - Centroid Collection
 *             - Chosen Centroid
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
using ReadingData;
using CollectionOfCentroids;
using CreatingCentroids;
using Emotiv;
using GettingData;
using System.Threading;
using System.IO;

namespace speak_your_mind
{
    public partial class Training : Form
    {
        Centroid c;
        List<Centroid> collection;
        string userInfoString;
        string[] userInfoStringParsed;
        bool userClickedClose;

        public Training(Centroid c, List<Centroid> collection, string userInfoString)
        {
            InitializeComponent();
            this.c = c;
            this.collection = collection;
            this.FormClosing += Form1_FormClosing; //For closing the program
            this.userInfoString = userInfoString;
            this.userInfoStringParsed = userInfoString.Split(',');
            this.userClickedClose = true;
        }

        private void Training_Load(object sender, EventArgs e)
        {
            this.label5.Text = this.c.name;
        }

        //Returns an object for reading in the CSV file
        private ReadingCSV read_CSV()
        {
            ReadingCSV r = new ReadingCSV(); //Creating a new object of the reading data class

            return r;
        }

        //Train Button being clicked
        private void trainButton_Click(object sender, EventArgs e)
        {
            do_training(c);
        }

        private void do_training(Centroid c)
        {
            EEG_Logger p = new EEG_Logger(); //Creating a new object of the class and acting upon it

            for (int i = 0; i < 10; i++)
            {
                pBar.PerformStep();
                p.Run();
                Thread.Sleep(1660); //Slow down the process, so the user can see what's happening and also to pull data for a specified amount of time
                //1660 for 15.03 Seconds
            }

            read_CSV().read_training_records(c);
            

            pBar.Value = 0;
            File.Delete("outfile.csv");
            this.userInfoStringParsed[this.c.position + 1] = this.c.currDistance.ToString();
            this.userInfoString = "";
            foreach (string s in this.userInfoStringParsed)
            {
                this.userInfoString += (s + ",");
            }
            this.userInfoString = this.userInfoString.Substring(0, this.userInfoString.Length - 1);

            MessageBox.Show("Training complete.");
        }
        
        //Clicking the Home button
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
