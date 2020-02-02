using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace DATA
{
    public class PhotoCreateDto
    {
        [Required, MaxLength(150)]
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [Required, JsonPropertyName("bytes")]
        public byte[] Bytes { get; set; }
    }
}
