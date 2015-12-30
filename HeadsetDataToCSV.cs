/***********************************************************************************************************************
 * 
 * Authors: Emotiv, Kati Baker, and Tyler Durham
 * 
 * File name: HeadsetDataToCSV.cs
 * 
 * Description: Nearly all of this code comes from the tutorials within the Developer's Edition of the Emotiv SDK
 *              It reads the EEG data from the headset and places these values in a .csv file called outfile.csv which
 *              is stored in the same directory as these C# files. We have added more comments to clarify each step of
 *              the process. 
 * 
 * Parameters: N/A
 * 
 * Returns: Nothing - But creates a .csv file which we will later access
 * 
 ************************************************************************************************************************/

using System;
using System.Collections.Generic;
using Emotiv;
using System.IO;
using System.Threading;
using System.Reflection;
using ReadingData;
using MatchData;

namespace GettingData
{
    public class EEG_Logger
    {
        EmoEngine engine;                   // Access to the SDK - via the EmoEngine
        int userID = -1;                    // userID is used to uniquely identify a user's headset
        string filename = "outfile.csv";    //Creates the .csv file where the data will be written to

        //Constructor
        public EEG_Logger()
        {
            //Create the engine
            engine = EmoEngine.Instance;
            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);

            //Connect to Emoengine.            
            engine.Connect();

            //Create a header for our output file
            WriteHeader();
        }

        void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {

            // record the user
            userID = (int)e.userId;

            // enable data aquisition for this user.
            engine.DataAcquisitionEnable((uint)userID, true);

            // ask for up to 15 seconds of buffered data
            engine.EE_DataSetBufferSizeInSec(15);

        }

        public void Run()
        {
            // Handle any waiting events
            engine.ProcessEvents();

            // If the user has not yet connected, do not proceed
            if ((int)userID == -1)
            {
                return; //If there are no users, stop
            }

            //Tied to a user
            Dictionary<EdkDll.EE_DataChannel_t, double[]> data = engine.GetData((uint)userID); //Pulls data from the headset

            //This is a good way to also check if the headset is connected
            if (data == null)
            {
                return; //If there's no data, stop
            }

            int _bufferSize = data[EdkDll.EE_DataChannel_t.TIMESTAMP].Length;

            //Opening up a stream and file
            TextWriter file = new StreamWriter(filename, true);

            for (int i = 0; i < _bufferSize; i++)
            {
                //Nw write the data
                foreach (EdkDll.EE_DataChannel_t channel in data.Keys)
                    file.Write(data[channel][i] + ",");
                file.WriteLine("");

            }
            file.Close(); //Close the file
        }

        //Creating the first row in the .csv file
        public void WriteHeader()
        {
            TextWriter file = new StreamWriter(filename, false);

            //Each column in the .csv file
            string header = "COUNTER,INTERPOLATED,RAW_CQ,AF3,F7,F3,FC5,T7,P7,O1,O2,P8" +
                            ",T8,FC6,F4,F8,AF4,GYROX,GYROY,TIMESTAMP,ES_TIMESTAMP," +
                            "FUNC_ID,FUNC_VALUE,MARKER,SYNC_SIGNAL,";

            file.WriteLine(header);
            file.Close(); //Close the file
        }
    }
}