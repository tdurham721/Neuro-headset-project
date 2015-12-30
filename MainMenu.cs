/**********************************************************************************************************
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: MainMenu.cs
 * 
 * Description: This file begins running the GUI application, calling the Welcome.cs windows form file
 * 
 * Parameters: N/A
 * 
 * Returns: N/A
 * 
 **********************************************************************************************************/


using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Emotiv;
using System.IO;
using System.Threading;
using System.Reflection;
using ReadingData;
using MatchData;
using GettingData;
using CollectionOfCentroids;
using CreatingCentroids;
using speak_your_mind;
     
    public class MainMenu
    {
        static void Main(string[] args)
        {
            Application.Run(new Welcome());
        }
    }

