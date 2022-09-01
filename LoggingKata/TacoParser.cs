﻿namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogWarning("less that three items. incomplete data");
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }
           
            
            
           
            var latitude = double.Parse(cells[0]);            
            var longitude = double.Parse(cells[1]);            
            var name = cells[2];

            // Your going to need to parse your string as a `double`
            //double doubleline = double.Parse(line);
            // which is similar to parsing a string as an `int`

            // DoneYou'll need to create a TacoBell class
            // that conforms to ITrackable
            

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;

            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return new TacoBell()
            {
                Name = name,
                Location = new Point { Latitude = latitude, Longitude = longitude }
            };
        }
    }
}