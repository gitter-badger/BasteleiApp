﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BasteleiApp
{
    public class DataElement
    {

       
       public float Temperature
        {
            get;
            set;
        }
       public float Airpressure
        {
            get;
            set;
        }
        public float Humidity
        {
            get;
            set;
        }
    public float Altitude
        {
            get;
            set;
        }

       public DateTime Timestamp
       {
            get;
            set;
        }

        
        public DataElement(string jsonstr)
        {
            //dynamic input = JsonConvert.DeserializeObject("{'temperature':17.100000381469728,'humidity':40.70000076293945,'airpressure':99423.0,'altitude':159.31381225585938, 'time':'2015 - 11 - 25 18:05:16'}");
            dynamic input = JsonConvert.DeserializeObject(jsonstr);
            this.Temperature = (float)input.temperature;
            this.Airpressure = (float)input.airpressure;
            this.Humidity = (float)input.humidity;
            this.Altitude = (float)input.altitude;
            this.Timestamp = (DateTime)input.time;
        }
    }
}