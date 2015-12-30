/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: MatchingData.cs
 * 
 * Description: This file takes the collection of centroids as well as the temporary centroid, iterates
 *              through the collection, trying to match each centroid in the collection with the temp
 *              centroid which is the user's real time EEG data.
 * 
 * Parameters: - List<Centroid> collection
 *             - Centroid temp
 * 
 * Returns: A string - the centroid's name that was matched
 * 
 **********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionOfCentroids;
using CreatingCentroids;
using ReadingData;
using GettingData;

namespace MatchData
{
    class MatchingData
    {
        public string match_data(List<Centroid> collection, Centroid temp)
        {
            double distance = 0.0;
            double currDistance = 900000000;
            string centroidString = "";

            //Can do a second distance check to see how far away the closest one is to resemble the idea of a "no match" for a user
            //Check if the centroid has values > 0 then don't check it, because the user hasn't trained on it yet - not right now
            foreach (Centroid c in collection) //Iterate through each centroid
            {
                distance = 0.0; //Reset distance so it doesn't continue to grow every time we check
                for (int i = 0; i < c.sensors.Length; i++)
                {
                    distance += (Math.Pow((c.sensors[i] - temp.sensors[i]), 2));
                }
                distance = Math.Sqrt(distance);

                if (distance < currDistance) //Setting the 1st centroid to the distance and then comparing it to the rest of them. Ignores ties
                {
                    currDistance = distance;
                    c.currDistance = currDistance;
                    centroidString = c.name;
                }
            }
            clearCentroidDistances(collection);
            playWord(centroidString); //Here is where the audio function gets called. It will play after you press ok on the Matching complete messagebox.
            return centroidString;
        }


        //This is a function that will play the matched word as an audio file, .wav in particular.
        //It takes the name of the matched word as a string, and a switch statement is run on it.
        //System.Media.SoundPlayer is an object that plays sound basically.
        //In the line that says player = new SoundPlayer, the string is the local filepath of the file, with the name of the word.wav
        //I think a good place for these is the resources folder for this project. You have to put the entire filepath, like C:\Users\etc
        //I did a try catch block for good practice, but also so when people after us try to work with Vanscoy on this, they will have
        //know why they are getting an error if the file isn't on their machine. I don't know how to get the error message to pop up though.
        //Don't know what to put as the error message for the default case; it should never reach it, but just in case it somehow happens.
        //Currently, this is called at the line I commented above. You can create a button in Matching.cs that calls m.playWord(this.label4.Text).
        //I didn't want to do that though because I don't know what changes you made to the gui, so I will let you do that.
        //We don't have any audio files, so this won't do anything right now. But if you wanna just record some rough ones to play around with it that will be cool.
        public void playWord(string nameOfMatchedWord)
        {
            System.Media.SoundPlayer player;
            switch (nameOfMatchedWord)
            {
                case "bathroom":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\bathroom.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "food":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\food.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "hello":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\hello.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "help":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\help.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "how":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\how.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "need":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\need.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "no":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\no.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "please":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\please.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "sleep":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\sleep.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "stop":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\stop.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "thanks":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\thanks.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "time":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\time.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "want":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\want.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "water":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\water.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                case "what":
                    {
                        try
                        {
                            player = new System.Media.SoundPlayer(@"C:\Users\Tyler\Documents\Visual Studio 2012\Projects\help\help\Resources\what.wav");
                            player.Play();
                        }
                        catch (FileNotFoundException e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                        break;
                    }
                default:
                    {
                        System.Diagnostics.Debug.WriteLine("Error, in MatchingData function playWord. For some reason, nameOfMatchedWord doesn't match any of the cases for the switch statement.");
                        break;
                    }
            }
        }

        public void clearCentroidDistances(List<Centroid> collection) //Need this to reset the distances for each centroid
        {
            foreach (Centroid c in collection)
            {
                c.currDistance = 0;
            }
        }
    }
}

