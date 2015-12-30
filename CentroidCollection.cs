/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: CentroidCollection.cs
 * 
 * Description: This file is where the Centroid that is created is housed. It's stored in a List<T> collection.
 *              The collection is created as soon as the user logs into the system and creates a centroid
 *              for each word with all sensor values set to 0.
 * 
 * Parameters: N/A
 * 
 * Returns: N/A
 * 
 **********************************************************************************************************/

using System;
using System.Collections.Generic;
using Emotiv;
using System.IO;
using System.Threading;
using System.Reflection;
using ReadingData;
using MatchData;
using GettingData;
using CreatingCentroids;


namespace CollectionOfCentroids
{
    public class CentroidCollection
    {
        public List<Centroid> create_collection()
        {
            var centroidsOfWords = new List<Centroid>(); //Creating a collection of Centroid type for placing centroids in

            int i = 0;

            //All the words we're going to try to match with - only 15
            string[] word = {"bathroom", "food", "hello", "help", "how", "need", "no", "please", "sleep", "stop", "thanks", "time", "want", "water", "what"}; //Excluding the possibility of no match for right now
            for (i = 0; i < word.Length; i++)
            {
                centroidsOfWords.Add(new Centroid(word[i], i)); //Creates a centroid with an assigned word and puts it in the collection

            }
            return centroidsOfWords;
        }
    }
}