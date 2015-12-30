/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: Centroid.cs
 * 
 * Description: This file is called when creating a Centroid object. It has the following attributes:
 *              - name of the centroid aka the word 
 *              - currDistance of the centroid aka it's location in the 14-dimension
 *              - an array of the sensors with each value of each sensor
 *              - a toString() method for printing out each centroid and its distance
 * 
 * Parameters: N/A
 * 
 * Returns: N/A
 * 
 **********************************************************************************************************/

using System;

namespace CreatingCentroids
{
    public class Centroid
    {
        public string name { get; set; }
        public double currDistance { get; set; }
        public double[] sensors { get; set; }
        public int position { get; set; }

        public Centroid() //Would be nice to be able to get rid of this
        {

        }

        //Constructor for setting the object
        public Centroid(string name, int position)
        {
            this.currDistance = currDistance;
            this.name = name;
            this.sensors = new double[14];

            for (int i = 0; i < sensors.Length; i++)
            {
                this.sensors[i] = 0;
            }
            //The order of the sensors is: AF3, F7, F3, FC5, T7, P7, O1, O2, P8, T8, FC6, F4, F8, AF4

        }

        public string toString()
        {
            return "Centroid name: " + this.name + " Centroid distance: " + this.currDistance;
        }
    }
}