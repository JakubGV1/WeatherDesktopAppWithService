﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAppClient.Models
{
    public class SimpleData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
