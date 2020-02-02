using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DATA
{
    public class PhotoDto
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("filename")]
        public string Filename { get; set; }
    }
}
