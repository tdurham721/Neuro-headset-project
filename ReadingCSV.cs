/***********************************************************************************************************************
 * 
 * Acknowledgements: Used CsvHelper created by Josh Close
 * 
 * Authors: Kati Baker and Tyler Durham
 * 
 * File name: ReadingCSV.cs
 * 
 * Description: This file takes the outfile.csv created in HeadsetDataToCSV.cs, reading the first 1500 rows for the 
 *              14 sensors on the headset. Next, the sensors values are cast into doubles, because CsvHelper pulls
 *              them as strings. After that, each sensor value is placed in a sensor array variable in a Centroid object 
 *              and then we divide each sensor value by the number of rows that were pulled from the .csv file.
 *             
 * 
 * Parameters: - The outfile.csv file must already be created for these functions to be called
 *             - A specified centroid based on the word the user chose
 *             - Or a temporary centroid to compare the user's trainings against
 * 
 * Returns: - Nothing
 *          - Or the temprorary centroid to show results
 * 
 ************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Threading;
using CreatingCentroids;
using CollectionOfCentroids;

namespace ReadingData
{
    public class ReadingCSV
    {
        //Mapping of the .csv file
        public class DataRecord
        {
            public string COUNTER { get; set; }
            public string INTERPOLATED { get; set; }
            public string RAW_CQ { get; set; }
            public string AF3 { get; set; }
            public string F7 { get; set; }
            public string F3 { get; set; }
            public string FC5 { get; set; }
            public string T7 { get; set; }
            public string P7 { get; set; }
            public string O1 { get; set; }
            public string O2 { get; set; }
            public string P8 { get; set; }
            public string T8 { get; set; }
            public string FC6 { get; set; }
            public string F4 { get; set; }
            public string F8 { get; set; }
            public string AF4 { get; set; }
            public string GYROX { get; set; }
            public string GYROY { get; set; }
            public string TIMESTAMP { get; set; }
            public string ES_TIMESTAMP { get; set; }
            public string FUNC_ID { get; set; }
            public string FUNC_VALUE { get; set; }
            public string MARKER { get; set; }
            public string SYNC_SIGNAL { get; set; }

        }

        //Reading the whole .csv file as one collection
        public void read_training_records(Centroid c)
        {

            using (var sr = new StreamReader(@"outfile.csv")) //Specifies the file location and opens a stream to begin reading
            {
                CsvReader csv_read = new CsvReader(sr); //Reads the .csv file using the CsvHelper extension (see using at top)
                csv_read.Configuration.IgnoreHeaderWhiteSpace = true; //Ignoring white space for header

                IEnumerable<DataRecord> records = csv_read.GetRecords<DataRecord>(); //Creates a collection based off the map above
                foreach (DataRecord record in records.Take(1500)) //Iterates through the whole .csv file taking the first 1500 records of the below specified fields
                {
                    string[] sensors = { record.AF3, record.F7, record.F3, record.FC5, record.T7, record.P7, record.O1, record.O2, record.P8, record.T8, record.FC6, record.F4, record.F8, record.AF4 };
                   
                    for (int i = 0; i < c.sensors.Length; i++)
                    {
                        c.sensors[i] += (Double.Parse(sensors[i]));
                    }
                }
                for (int i = 0; i < c.sensors.Length; i++)
                {
                    c.sensors[i] = c.sensors[i] / 1500;
                }
            }
        }

        public Centroid read_matching_records()
        {
            Centroid temp = new Centroid("temporary", 0);

            using (var sr = new StreamReader(@"outfile.csv")) //Specifies the file location and opens a stream to begin reading
            {
                CsvReader csv_read = new CsvReader(sr); //Reads the .csv file using the CsvHelper extension (see using at top)
                csv_read.Configuration.IgnoreHeaderWhiteSpace = true; //Ignoring white space for header

                IEnumerable<DataRecord> records = csv_read.GetRecords<DataRecord>(); //Creates a collection based off the map above

                foreach (DataRecord record in records.Take(500)) //Iterates through the whole .csv file taking the first 500 records of the below specified fields
                {
                    string[] sensors = { record.AF3, record.F7, record.F3, record.FC5, record.T7, record.P7, record.O1, record.O2, record.P8, record.T8, record.FC6, record.F4, record.F8, record.AF4 };
                    Thread.Sleep(10); //Sleep to see results - won't need this later; Just for debugging
                    for (int i = 0; i < 14; i++)
                    {
                        temp.sensors[i] += (Double.Parse(sensors[i]) / 500); //Gives the avg for the 1st sensor based off of the # of records taken
                    }
                }
            }
            return temp;
        }
    }
}